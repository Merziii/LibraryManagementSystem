Imports MySql.Data.MySqlClient

Public Class ucManageStudents

    Private Sub ucManageStudents_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadStudents()
        tmrRefresh.Start()
    End Sub

    Private Sub LoadStudents()
        Try
            Connect()
            sql = "SELECT u.user_id, u.username, u.full_name, s.student_number, " &
                  "s.course, s.year_level, " &
                  "CASE WHEN u.is_active = 1 THEN 'Active' ELSE 'Deactivated' END AS status " &
                  "FROM users u INNER JOIN students s ON u.user_id = s.user_id " &
                  "WHERE u.role = 'Student' ORDER BY u.full_name"

            Dim dt As New DataTable
            Dim da As New MySqlDataAdapter(sql, cn)
            da.Fill(dt)
            dgvStudents.DataSource = dt
            dgvStudents.Columns("user_id").Visible = False
            cn.Close()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, "Load Error")
        End Try
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Try
            Connect()
            sql = "SELECT u.user_id, u.username, u.full_name, s.student_number, " &
                  "s.course, s.year_level, " &
                  "CASE WHEN u.is_active = 1 THEN 'Active' ELSE 'Deactivated' END AS status " &
                  "FROM users u INNER JOIN students s ON u.user_id = s.user_id " &
                  "WHERE u.role = 'Student' " &
                  "AND (u.full_name LIKE @kw OR s.student_number LIKE @kw) ORDER BY u.full_name"

            Dim dt As New DataTable
            Dim da As New MySqlDataAdapter(sql, cn)
            da.SelectCommand.Parameters.AddWithValue("@kw", "%" & txtSearch.Text.Trim & "%")
            da.Fill(dt)
            dgvStudents.DataSource = dt
            dgvStudents.Columns("user_id").Visible = False
            cn.Close()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, "Search Error")
        End Try
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        frmAddUser.Tag = "Student"
        frmAddUser.ShowDialog()
        LoadStudents()
    End Sub

    Private Sub btnDeactivate_Click(sender As Object, e As EventArgs) Handles btnDeactivate.Click
        If dgvStudents.CurrentRow Is Nothing Then
            MsgBox("Please select a student.", MsgBoxStyle.Exclamation, "Validation")
            Exit Sub
        End If

        Dim userID As Integer = dgvStudents.CurrentRow.Cells("user_id").Value
        Dim confirm As MsgBoxResult = MsgBox("Deactivate this student?", MsgBoxStyle.YesNo, "Confirm")
        If confirm = MsgBoxResult.Yes Then
            Try
                Connect()
                sql = "UPDATE users SET is_active = 0 WHERE user_id = @id"
                cmd = New MySqlCommand(sql, cn)
                cmd.Parameters.AddWithValue("@id", userID)
                cmd.ExecuteNonQuery()
                cn.Close()
                MsgBox("Student deactivated.", MsgBoxStyle.Information, "Done")
                LoadStudents()
            Catch ex As Exception
                MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
        End If
    End Sub

    Private Sub btnActivate_Click(sender As Object, e As EventArgs) Handles btnActivate.Click
        If dgvStudents.CurrentRow Is Nothing Then
            MsgBox("Please select a student.", MsgBoxStyle.Exclamation, "Validation")
            Exit Sub
        End If

        Dim userID As Integer = dgvStudents.CurrentRow.Cells("user_id").Value
        Try
            Connect()
            sql = "UPDATE users SET is_active = 1 WHERE user_id = @id"
            cmd = New MySqlCommand(sql, cn)
            cmd.Parameters.AddWithValue("@id", userID)
            cmd.ExecuteNonQuery()
            cn.Close()
            MsgBox("Student activated.", MsgBoxStyle.Information, "Done")
            LoadStudents()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub tmrRefresh_Tick(sender As Object, e As EventArgs) Handles tmrRefresh.Tick
        LoadStudents()
    End Sub

End Class