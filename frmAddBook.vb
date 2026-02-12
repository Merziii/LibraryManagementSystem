Imports MySql.Data.MySqlClient

Public Class frmAddBook

    Private Sub frmAddBook_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadCategories()

        ' If Tag = "Add" then new book, else load existing book data
        If Me.Tag.ToString = "Add" Then
            Me.Text = "Add New Book"
        Else
            Me.Text = "Edit Book"
            LoadBookData(CInt(Me.Tag))
        End If
    End Sub

    Private Sub LoadCategories()
        Try
            Connect()
            sql = "SELECT category_id, category_name FROM categories ORDER BY category_name"
            Dim dt As New DataTable
            Dim da As New MySqlDataAdapter(sql, cn)
            da.Fill(dt)
            cmbCategory.DisplayMember = "category_name"
            cmbCategory.ValueMember = "category_id"
            cmbCategory.DataSource = dt
            cn.Close()
        Catch ex As Exception
            MsgBox("Error loading categories: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub LoadBookData(bookID As Integer)
        Try
            Connect()
            sql = "SELECT * FROM books WHERE book_id = @id"
            cmd = New MySqlCommand(sql, cn)
            cmd.Parameters.AddWithValue("@id", bookID)
            dr = cmd.ExecuteReader()

            If dr.Read() Then
                txtISBN.Text = dr("isbn").ToString
                txtTitle.Text = dr("title").ToString
                txtAuthor.Text = dr("author").ToString
                txtTotalQty.Text = dr("total_quantity").ToString
                cmbCategory.SelectedValue = dr("category_id")
            End If
            dr.Close()
            cn.Close()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, "Load Error")
        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtISBN.Text.Trim = "" Or txtTitle.Text.Trim = "" Or
           txtAuthor.Text.Trim = "" Or txtTotalQty.Text.Trim = "" Then
            MsgBox("All fields are required.", MsgBoxStyle.Exclamation, "Validation")
            Exit Sub
        End If

        If Not IsNumeric(txtTotalQty.Text.Trim) OrElse CInt(txtTotalQty.Text.Trim) < 1 Then
            MsgBox("Quantity must be a valid number greater than 0.", MsgBoxStyle.Exclamation, "Validation")
            Exit Sub
        End If

        Try
            Connect()

            If Me.Tag.ToString = "Add" Then
                sql = "INSERT INTO books (isbn, title, author, category_id, total_quantity, available_qty, added_by) " &
                      "VALUES (@isbn, @title, @author, @cat, @qty, @qty, @by)"
                cmd = New MySqlCommand(sql, cn)
                cmd.Parameters.AddWithValue("@by", Session.UserID)
            Else
                sql = "UPDATE books SET isbn = @isbn, title = @title, author = @author, " &
                      "category_id = @cat, total_quantity = @qty WHERE book_id = @id"
                cmd = New MySqlCommand(sql, cn)
                cmd.Parameters.AddWithValue("@id", CInt(Me.Tag))
            End If

            cmd.Parameters.AddWithValue("@isbn", txtISBN.Text.Trim)
            cmd.Parameters.AddWithValue("@title", txtTitle.Text.Trim)
            cmd.Parameters.AddWithValue("@author", txtAuthor.Text.Trim)
            cmd.Parameters.AddWithValue("@cat", cmbCategory.SelectedValue)
            cmd.Parameters.AddWithValue("@qty", CInt(txtTotalQty.Text.Trim))
            cmd.ExecuteNonQuery()
            cn.Close()

            MsgBox("Book saved successfully.", MsgBoxStyle.Information, "Success")
            Me.Close()

        Catch ex As MySqlException When ex.Number = 1062
            MsgBox("ISBN already exists.", MsgBoxStyle.Critical, "Duplicate Entry")
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

        txtAuthor.Clear()
        txtISBN.Clear()
        txtTitle.Clear()
        txtTotalQty.Clear()
        cmbCategory.SelectedIndex = -1
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
        txtAuthor.Clear()
        txtISBN.Clear()
        txtTitle.Clear()
        txtTotalQty.Clear()
        cmbCategory.SelectedIndex = -1
    End Sub

End Class