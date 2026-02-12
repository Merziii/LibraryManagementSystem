Imports MySql.Data.MySqlClient

Public Class ucBorrowRecords

    Private Sub ucBorrowRecords_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbFilter.Items.AddRange({"All", "Borrowed", "Returned", "Overdue"})
        cmbFilter.SelectedIndex = 0
        LoadRecords()
        tmrRefresh.Start()
    End Sub

    Private Sub LoadRecords()
        Try
            Connect()
            sql = "SELECT br.record_id, u.full_name AS student, s.student_number, " &
                  "b.title AS book, br.borrow_date, br.due_date, " &
                  "br.return_date, br.status " &
                  "FROM borrow_records br " &
                  "INNER JOIN users u ON br.user_id = u.user_id " &
                  "INNER JOIN students s ON u.user_id = s.user_id " &
                  "INNER JOIN books b ON br.book_id = b.book_id " &
                  "ORDER BY br.borrow_date DESC"

            Dim dt As New DataTable
            Dim da As New MySqlDataAdapter(sql, cn)
            da.Fill(dt)
            dgvRecords.DataSource = dt
            dgvRecords.Columns("record_id").Visible = False
            cn.Close()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, "Load Error")
        End Try
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Try
            Connect()
            Dim statusFilter As String = cmbFilter.SelectedItem.ToString

            sql = "SELECT br.record_id, u.full_name AS student, s.student_number, " &
                  "b.title AS book, br.borrow_date, br.due_date, " &
                  "br.return_date, br.status " &
                  "FROM borrow_records br " &
                  "INNER JOIN users u ON br.user_id = u.user_id " &
                  "INNER JOIN students s ON u.user_id = s.user_id " &
                  "INNER JOIN books b ON br.book_id = b.book_id " &
                  "WHERE (u.full_name LIKE @kw OR s.student_number LIKE @kw OR b.title LIKE @kw)"

            If statusFilter <> "All" Then
                sql &= " AND br.status = @status"
            End If

            sql &= " ORDER BY br.borrow_date DESC"

            Dim dt As New DataTable
            Dim da As New MySqlDataAdapter(sql, cn)
            da.SelectCommand.Parameters.AddWithValue("@kw", "%" & txtSearch.Text.Trim & "%")
            If statusFilter <> "All" Then
                da.SelectCommand.Parameters.AddWithValue("@status", statusFilter)
            End If
            da.Fill(dt)
            dgvRecords.DataSource = dt
            dgvRecords.Columns("record_id").Visible = False
            cn.Close()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, "Search Error")
        End Try
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        txtSearch.Clear()
        cmbFilter.SelectedIndex = 0
        LoadRecords()
    End Sub

    Private Sub tmrRefresh_Tick(sender As Object, e As EventArgs) Handles tmrRefresh.Tick
        LoadRecords()
    End Sub

End Class