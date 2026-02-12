Imports MySql.Data.MySqlClient

Public Class ucMyHistory

    Private Sub ucMyHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblTitle.Text = "My Borrowing History — " & Session.FullName
        LoadHistory()
        tmrRefresh.Start()
    End Sub

    Private Sub LoadHistory()
        Try
            Connect()
            sql = "SELECT b.title, b.author, br.borrow_date, br.due_date, " &
                  "br.return_date, br.status " &
                  "FROM borrow_records br " &
                  "INNER JOIN books b ON br.book_id = b.book_id " &
                  "WHERE br.user_id = @uid " &
                  "ORDER BY br.borrow_date DESC"

            Dim dt As New DataTable
            Dim da As New MySqlDataAdapter(sql, cn)
            da.SelectCommand.Parameters.AddWithValue("@uid", Session.UserID)
            da.Fill(dt)
            dgvHistory.DataSource = dt
            cn.Close()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, "Load Error")
        End Try
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        LoadHistory()
    End Sub

    Private Sub tmrRefresh_Tick(sender As Object, e As EventArgs) Handles tmrRefresh.Tick
        LoadHistory()
    End Sub

End Class