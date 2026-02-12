Imports MySql.Data.MySqlClient

Public Class frmLogin

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        If txtUsername.Text.Trim = "" Or txtPassword.Text.Trim = "" Then
            MsgBox("Please enter username and password.", MsgBoxStyle.Exclamation, "Login")
            Exit Sub
        End If

        Try
            Connect()
            sql = "SELECT user_id, full_name, role FROM users " &
                  "WHERE username = @user AND password = @pass AND is_active = 1"

            cmd = New MySqlCommand(sql, cn)
            cmd.Parameters.AddWithValue("@user", txtUsername.Text.Trim)
            cmd.Parameters.AddWithValue("@pass", txtPassword.Text.Trim)

            dr = cmd.ExecuteReader()

            If dr.Read() Then
                Dim userID As Integer = dr("user_id")
                Dim fullName As String = dr("full_name")
                Dim role As String = dr("role")
                dr.Close()
                cn.Close()

                ' Store session info globally
                Session.UserID = userID
                Session.FullName = fullName
                Session.Role = role

                ' Route to correct dashboard based on role
                Select Case role
                    Case "Admin"
                        frmAdminDashboard.Show()
                    Case "Librarian"
                        frmLibrarianDashboard.Show()
                    Case "Student"
                        frmStudentDashboard.Show()
                End Select

                Me.Hide()
            Else
                dr.Close()
                cn.Close()
                MsgBox("Invalid username or password, or account is deactivated.", MsgBoxStyle.Critical, "Login Failed")
            End If

        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, "Login Error")
        End Try
        txtUsername.Clear()
        txtPassword.Clear()

    End Sub

    Private Sub frmLogin_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then btnLogin_Click(sender, e)
    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If System.Net.Dns.GetHostName().ToUpper = "HOST" Then
            frmServerMonitor.Show()
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class