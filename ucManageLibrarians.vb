Imports MySql.Data.MySqlClient

Public Class ucManageLibrarians

    Private Sub ucManageLibrarians_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadLibrarians()
        tmrRefresh.Start()
    End Sub

    Private Sub LoadLibrarians()
        Try
            Connect()
            sql = "SELECT user_id, username, full_name, " &
                  "CASE WHEN is_active = 1 THEN 'Active' ELSE 'Deactivated' END AS status " &
                  "FROM users WHERE role = 'Librarian' ORDER BY full_name"

            Dim dt As New DataTable
            Dim da As New MySqlDataAdapter(sql, cn)
            da.Fill(dt)
            dgvLibrarians.DataSource = dt
            dgvLibrarians.Columns("user_id").Visible = False
            cn.Close()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, "Load Error")
        End Try
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Try
            Connect()
            sql = "SELECT user_id, username, full_name, " &
                  "CASE WHEN is_active = 1 THEN 'Active' ELSE 'Deactivated' END AS status " &
                  "FROM users WHERE role = 'Librarian' " &
                  "AND (username LIKE @kw OR full_name LIKE @kw) ORDER BY full_name"

            Dim dt As New DataTable
            Dim da As New MySqlDataAdapter(sql, cn)
            da.SelectCommand.Parameters.AddWithValue("@kw", "%" & txtSearch.Text.Trim & "%")
            da.Fill(dt)
            dgvLibrarians.DataSource = dt
            dgvLibrarians.Columns("user_id").Visible = False
            cn.Close()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, "Search Error")
        End Try
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        frmAddUser.Tag = "Librarian"
        frmAddUser.ShowDialog()
        LoadLibrarians()
    End Sub

    Private Sub btnDeactivate_Click(sender As Object, e As EventArgs) Handles btnDeactivate.Click
        If dgvLibrarians.CurrentRow Is Nothing Then
            MsgBox("Please select a librarian.", MsgBoxStyle.Exclamation, "Validation")
            Exit Sub
        End If

        Dim userID As Integer = dgvLibrarians.CurrentRow.Cells("user_id").Value
        Dim confirm As MsgBoxResult = MsgBox("Deactivate this librarian?", MsgBoxStyle.YesNo, "Confirm")
        If confirm = MsgBoxResult.Yes Then
            Try
                Connect()
                sql = "UPDATE users SET is_active = 0 WHERE user_id = @id"
                cmd = New MySqlCommand(sql, cn)
                cmd.Parameters.AddWithValue("@id", userID)
                cmd.ExecuteNonQuery()
                cn.Close()
                MsgBox("Librarian deactivated.", MsgBoxStyle.Information, "Done")
                LoadLibrarians()
            Catch ex As Exception
                MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
        End If
    End Sub

    Private Sub btnActivate_Click(sender As Object, e As EventArgs) Handles btnActivate.Click
        If dgvLibrarians.CurrentRow Is Nothing Then
            MsgBox("Please select a librarian.", MsgBoxStyle.Exclamation, "Validation")
            Exit Sub
        End If

        Dim userID As Integer = dgvLibrarians.CurrentRow.Cells("user_id").Value
        Try
            Connect()
            sql = "UPDATE users SET is_active = 1 WHERE user_id = @id"
            cmd = New MySqlCommand(sql, cn)
            cmd.Parameters.AddWithValue("@id", userID)
            cmd.ExecuteNonQuery()
            cn.Close()
            MsgBox("Librarian activated.", MsgBoxStyle.Information, "Done")
            LoadLibrarians()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub tmrRefresh_Tick(sender As Object, e As EventArgs) Handles tmrRefresh.Tick
        LoadLibrarians()
    End Sub

End Class