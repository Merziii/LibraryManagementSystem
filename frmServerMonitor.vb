Imports MySql.Data.MySqlClient

Public Class frmServerMonitor

    Private Sub frmServerMonitor_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.WindowState = FormWindowState.Minimized
        Me.ShowInTaskbar = False
        tmrOverdue.Start()
    End Sub

    Private Sub tmrOverdue_Tick(sender As Object, e As EventArgs) Handles tmrOverdue.Tick
        Try
            Connect()
            ' Mark all borrowed books past due date as Overdue
            sql = "UPDATE borrow_records SET status = 'Overdue' " &
                  "WHERE status = 'Borrowed' AND due_date < CURDATE()"
            cmd = New MySqlCommand(sql, cn)
            cmd.ExecuteNonQuery()
            cn.Close()
        Catch ex As Exception
            ' Silent fail — log to file if needed
        End Try
    End Sub

End Class