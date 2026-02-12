Imports MySql.Data.MySqlClient

Public Class ucReports

    Private Sub ucReports_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadReport()
        tmrRefresh.Start()
    End Sub

    Private Sub LoadReport()
        Try
            Connect()
            Dim dt As New DataTable
            Dim da As New MySqlDataAdapter

            Select Case Me.Tag.ToString

                Case "Inventory"
                    lblReportTitle.Text = "Inventory Report — Available vs Borrowed"
                    sql = "SELECT b.isbn, b.title, b.author, c.category_name AS category, " &
                          "b.total_quantity, b.available_qty, " &
                          "(b.total_quantity - b.available_qty) AS borrowed_qty, " &
                          "CASE WHEN b.available_qty > 0 THEN 'Available' " &
                          "ELSE 'Unavailable' END AS status " &
                          "FROM books b " &
                          "INNER JOIN categories c ON b.category_id = c.category_id " &
                          "WHERE b.is_deleted = 0 ORDER BY b.title"

                Case "Borrowed"
                    lblReportTitle.Text = "All Currently Borrowed Books"
                    sql = "SELECT u.full_name AS student, s.student_number, " &
                          "b.title AS book, b.author, " &
                          "br.borrow_date, br.due_date, " &
                          "DATEDIFF(br.due_date, CURDATE()) AS days_remaining " &
                          "FROM borrow_records br " &
                          "INNER JOIN users u ON br.user_id = u.user_id " &
                          "INNER JOIN students s ON u.user_id = s.user_id " &
                          "INNER JOIN books b ON br.book_id = b.book_id " &
                          "WHERE br.status = 'Borrowed' " &
                          "ORDER BY br.borrow_date DESC"

                Case "Overdue"
                    lblReportTitle.Text = "Overdue Books"
                    sql = "SELECT u.full_name AS student, s.student_number, " &
                          "b.title AS book, br.borrow_date, br.due_date, " &
                          "DATEDIFF(CURDATE(), br.due_date) AS days_overdue " &
                          "FROM borrow_records br " &
                          "INNER JOIN users u ON br.user_id = u.user_id " &
                          "INNER JOIN students s ON u.user_id = s.user_id " &
                          "INNER JOIN books b ON br.book_id = b.book_id " &
                          "WHERE br.status IN ('Borrowed','Overdue') " &
                          "AND br.due_date < CURDATE() " &
                          "ORDER BY br.due_date ASC"

                Case Else
                    cn.Close()
                    Exit Sub
            End Select

            da = New MySqlDataAdapter(sql, cn)
            da.Fill(dt)
            dgvReport.DataSource = dt
            cn.Close()

        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, "Report Error")
        End Try
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        LoadReport()
    End Sub

    Private Sub tmrRefresh_Tick(sender As Object, e As EventArgs) Handles tmrRefresh.Tick
        LoadReport()
    End Sub



End Class