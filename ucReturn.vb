Imports MySql.Data.MySqlClient

Public Class ucReturn

    Private selectedStudentID As Integer = 0
    Private selectedRecordID As Integer = 0

    Private Sub ucReturn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblStudentName.Text = "Student: —"
    End Sub

    Private Sub btnFindStudent_Click(sender As Object, e As EventArgs) Handles btnFindStudent.Click
        If txtStudentNumber.Text.Trim = "" Then
            MsgBox("Enter a student number.", MsgBoxStyle.Exclamation, "Validation")
            Exit Sub
        End If

        Try
            Connect()
            sql = "SELECT u.user_id, u.full_name FROM users u " &
                  "INNER JOIN students s ON u.user_id = s.user_id " &
                  "WHERE s.student_number = @snum AND u.is_active = 1"
            cmd = New MySqlCommand(sql, cn)
            cmd.Parameters.AddWithValue("@snum", txtStudentNumber.Text.Trim)
            dr = cmd.ExecuteReader()

            If dr.Read() Then
                selectedStudentID = dr("user_id")
                lblStudentName.Text = "Student: " & dr("full_name").ToString
                dr.Close()
                cn.Close()
                LoadBorrowedBooks()
            Else
                dr.Close()
                cn.Close()
                MsgBox("Student not found or deactivated.", MsgBoxStyle.Exclamation, "Not Found")
                selectedStudentID = 0
                lblStudentName.Text = "Student: —"
            End If
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub LoadBorrowedBooks()
        Try
            Connect()
            sql = "SELECT br.record_id, b.title, b.author, " &
                  "br.borrow_date, br.due_date, br.status " &
                  "FROM borrow_records br " &
                  "INNER JOIN books b ON br.book_id = b.book_id " &
                  "WHERE br.user_id = @uid AND br.status IN ('Borrowed','Overdue')"
            Dim dt As New DataTable
            Dim da As New MySqlDataAdapter(sql, cn)
            da.SelectCommand.Parameters.AddWithValue("@uid", selectedStudentID)
            da.Fill(dt)
            dgvBorrowedBooks.DataSource = dt
            dgvBorrowedBooks.Columns("record_id").Visible = False
            cn.Close()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        If dgvBorrowedBooks.CurrentRow Is Nothing Then
            MsgBox("Please select a book to return.", MsgBoxStyle.Exclamation, "Validation")
            Exit Sub
        End If

        selectedRecordID = dgvBorrowedBooks.CurrentRow.Cells("record_id").Value

        Dim confirm As MsgBoxResult = MsgBox("Confirm return of this book?", MsgBoxStyle.YesNo, "Confirm")
        If confirm = MsgBoxResult.Yes Then
            Try
                Connect()

                ' Get book_id from the record first
                sql = "SELECT book_id FROM borrow_records WHERE record_id = @rid"
                cmd = New MySqlCommand(sql, cn)
                cmd.Parameters.AddWithValue("@rid", selectedRecordID)
                Dim bookID As Integer = cmd.ExecuteScalar()

                ' Update borrow record
                sql = "UPDATE borrow_records SET return_date = CURDATE(), " &
                      "status = 'Returned', processed_by = @by " &
                      "WHERE record_id = @rid"
                cmd = New MySqlCommand(sql, cn)
                cmd.Parameters.AddWithValue("@by", Session.UserID)
                cmd.Parameters.AddWithValue("@rid", selectedRecordID)
                cmd.ExecuteNonQuery()

                ' Restore available quantity
                sql = "UPDATE books SET available_qty = available_qty + 1 WHERE book_id = @bid"
                cmd = New MySqlCommand(sql, cn)
                cmd.Parameters.AddWithValue("@bid", bookID)
                cmd.ExecuteNonQuery()

                cn.Close()
                MsgBox("Book returned successfully.", MsgBoxStyle.Information, "Success")
                LoadBorrowedBooks()

            Catch ex As Exception
                MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
        End If
    End Sub

End Class