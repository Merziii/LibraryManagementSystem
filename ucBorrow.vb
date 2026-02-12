Imports MySql.Data.MySqlClient

Public Class ucBorrow

    Private selectedBookID As Integer = 0

    Private Sub ucBorrow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpDueDate.Value = DateTime.Now.AddDays(7)
        lblStudentName.Text = "Student: " & Session.FullName
    End Sub

    Private Sub btnSearchBook_Click(sender As Object, e As EventArgs) Handles btnSearchBook.Click
        Try
            Connect()
            sql = "SELECT b.book_id, b.title, b.author, c.category_name AS category, " &
                  "b.available_qty FROM books b " &
                  "INNER JOIN categories c ON b.category_id = c.category_id " &
                  "WHERE b.is_deleted = 0 AND b.available_qty > 0 " &
                  "AND (b.title LIKE @kw OR b.author LIKE @kw OR c.category_name LIKE @kw)"

            Dim dt As New DataTable
            Dim da As New MySqlDataAdapter(sql, cn)
            da.SelectCommand.Parameters.AddWithValue("@kw", "%" & txtSearchBook.Text.Trim & "%")
            da.Fill(dt)
            dgvBooks.DataSource = dt
            dgvBooks.Columns("book_id").Visible = False
            cn.Close()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, "Search Error")
        End Try
    End Sub

    Private Sub btnBorrow_Click(sender As Object, e As EventArgs) Handles btnBorrow.Click
        If dgvBooks.CurrentRow Is Nothing Then
            MsgBox("Please select a book.", MsgBoxStyle.Exclamation, "Validation")
            Exit Sub
        End If

        selectedBookID = dgvBooks.CurrentRow.Cells("book_id").Value

        If dtpDueDate.Value.Date <= DateTime.Now.Date Then
            MsgBox("Due date must be after today.", MsgBoxStyle.Exclamation, "Validation")
            Exit Sub
        End If

        Dim confirm As MsgBoxResult = MsgBox("Confirm borrowing this book?", MsgBoxStyle.YesNo, "Confirm")
        If confirm = MsgBoxResult.Yes Then
            Try
                Connect()

                ' Insert borrow record
                sql = "INSERT INTO borrow_records (user_id, book_id, borrow_date, due_date, status) " &
                      "VALUES (@uid, @bid, CURDATE(), @due, 'Borrowed')"
                cmd = New MySqlCommand(sql, cn)
                cmd.Parameters.AddWithValue("@uid", Session.UserID)
                cmd.Parameters.AddWithValue("@bid", selectedBookID)
                cmd.Parameters.AddWithValue("@due", dtpDueDate.Value.Date.ToString("yyyy-MM-dd"))
                cmd.ExecuteNonQuery()

                ' Reduce available quantity
                sql = "UPDATE books SET available_qty = available_qty - 1 WHERE book_id = @bid"
                cmd = New MySqlCommand(sql, cn)
                cmd.Parameters.AddWithValue("@bid", selectedBookID)
                cmd.ExecuteNonQuery()

                cn.Close()
                MsgBox("Book borrowed successfully.", MsgBoxStyle.Information, "Success")

                ' Clear search results
                dgvBooks.DataSource = Nothing
                txtSearchBook.Clear()
                dtpDueDate.Value = DateTime.Now.AddDays(7)

            Catch ex As Exception
                MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
        End If
    End Sub

    Private Sub txtStudentNumber_TextChanged(sender As Object, e As EventArgs)

    End Sub
End Class