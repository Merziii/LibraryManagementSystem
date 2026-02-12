Imports MySql.Data.MySqlClient

Public Class ucBookSearch

    Private Sub ucBookSearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbSearchBy.Items.AddRange({"Title", "Author", "Category"})
        cmbSearchBy.SelectedIndex = 0
        LoadAllBooks()
        tmrRefresh.Start()
    End Sub

    Private Sub LoadAllBooks()
        Try
            Connect()
            sql = "SELECT b.isbn, b.title, b.author, c.category_name AS category, " &
                  "b.total_quantity, b.available_qty, " &
                  "CASE WHEN b.available_qty > 0 THEN 'Available' " &
                  "ELSE 'Unavailable' END AS availability " &
                  "FROM books b " &
                  "INNER JOIN categories c ON b.category_id = c.category_id " &
                  "WHERE b.is_deleted = 0 ORDER BY b.title"

            Dim dt As New DataTable
            Dim da As New MySqlDataAdapter(sql, cn)
            da.Fill(dt)
            dgvBooks.DataSource = dt
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

            sql = "SELECT b.isbn, b.title, b.author, c.category_name AS category, " &
                  "b.total_quantity, b.available_qty, " &
                  "CASE WHEN b.available_qty > 0 THEN 'Available' " &
                  "ELSE 'Unavailable' END AS availability " &
                  "FROM books b " &
                  "INNER JOIN categories c ON b.category_id = c.category_id " &
                  "WHERE b.is_deleted = 0 AND " & filterCol & " LIKE @kw ORDER BY b.title"

            Dim dt As New DataTable
            Dim da As New MySqlDataAdapter(sql, cn)
            da.SelectCommand.Parameters.AddWithValue("@kw", "%" & txtSearch.Text.Trim & "%")
            da.Fill(dt)
            dgvBooks.DataSource = dt
            cn.Close()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, "Search Error")
        End Try
    End Sub

    Private Sub tmrRefresh_Tick(sender As Object, e As EventArgs) Handles tmrRefresh.Tick
        LoadAllBooks()
    End Sub

End Class