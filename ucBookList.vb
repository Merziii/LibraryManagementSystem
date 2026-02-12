Imports MySql.Data.MySqlClient

Public Class ucBookList

    Private Sub ucBookList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbSearchBy.Items.AddRange({"Title", "Author", "Category"})
        cmbSearchBy.SelectedIndex = 0
        LoadBooks()
        tmrRefresh.Start()
    End Sub

    Private Sub LoadBooks()
        Try
            Connect()
            sql = "SELECT b.book_id, b.isbn, b.title, b.author, " &
                  "c.category_name AS category, b.total_quantity, b.available_qty " &
                  "FROM books b INNER JOIN categories c ON b.category_id = c.category_id " &
                  "WHERE b.is_deleted = 0 ORDER BY b.title"

            Dim dt As New DataTable
            Dim da As New MySqlDataAdapter(sql, cn)
            da.Fill(dt)
            dgvBooks.DataSource = dt
            dgvBooks.Columns("book_id").Visible = False
            cn.Close()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, "Load Error")
        End Try
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Try
            Connect()
            Dim filterCol As String = ""
            Select Case cmbSearchBy.SelectedItem.ToString
                Case "Title" : filterCol = "b.title"
                Case "Author" : filterCol = "b.author"
                Case "Category" : filterCol = "c.category_name"
            End Select

            sql = "SELECT b.book_id, b.isbn, b.title, b.author, " &
                  "c.category_name AS category, b.total_quantity, b.available_qty " &
                  "FROM books b INNER JOIN categories c ON b.category_id = c.category_id " &
                  "WHERE b.is_deleted = 0 AND " & filterCol & " LIKE @kw ORDER BY b.title"

            Dim dt As New DataTable
            Dim da As New MySqlDataAdapter(sql, cn)
            da.SelectCommand.Parameters.AddWithValue("@kw", "%" & txtSearch.Text.Trim & "%")
            da.Fill(dt)
            dgvBooks.DataSource = dt
            dgvBooks.Columns("book_id").Visible = False
            cn.Close()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, "Search Error")
        End Try
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If dgvBooks.CurrentRow Is Nothing Then
            MsgBox("Please select a book to edit.", MsgBoxStyle.Exclamation, "Validation")
            Exit Sub
        End If

        frmAddBook.Tag = dgvBooks.CurrentRow.Cells("book_id").Value.ToString
        frmAddBook.ShowDialog()
        LoadBooks()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If dgvBooks.CurrentRow Is Nothing Then
            MsgBox("Please select a book to delete.", MsgBoxStyle.Exclamation, "Validation")
            Exit Sub
        End If

        Dim bookID As Integer = dgvBooks.CurrentRow.Cells("book_id").Value
        Dim confirm As MsgBoxResult = MsgBox("Delete this book?", MsgBoxStyle.YesNo, "Confirm")
        If confirm = MsgBoxResult.Yes Then
            Try
                Connect()
                ' Soft delete — keeps borrow history intact
                sql = "UPDATE books SET is_deleted = 1 WHERE book_id = @id"
                cmd = New MySqlCommand(sql, cn)
                cmd.Parameters.AddWithValue("@id", bookID)
                cmd.ExecuteNonQuery()
                cn.Close()
                MsgBox("Book deleted.", MsgBoxStyle.Information, "Done")
                LoadBooks()
            Catch ex As Exception
                MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
        End If
    End Sub

    Private Sub tmrRefresh_Tick(sender As Object, e As EventArgs) Handles tmrRefresh.Tick
        LoadBooks()
    End Sub


End Class