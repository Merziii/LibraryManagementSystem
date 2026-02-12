Imports MySql.Data.MySqlClient

Public Class frmAddUser

    Private Sub frmAddUser_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' Show/hide student fields based on who called this form
        Dim isStudent As Boolean = (Me.Tag.ToString = "Student")
        txtStudentNumber.Visible = isStudent
        txtCourse.Visible = isStudent
        txtYearLevel.Visible = isStudent
        lblStudentNumber.Visible = isStudent
        lblCourse.Visible = isStudent
        lblYearLevel.Visible = isStudent

        Me.Text = "Add " & Me.Tag.ToString
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtFullName.Text.Trim = "" Or txtUsername.Text.Trim = "" Or txtPassword.Text.Trim = "" Then
            MsgBox("Full name, username, and password are required.", MsgBoxStyle.Exclamation, "Validation")
            Exit Sub
        End If

        Try
            Connect()

            ' Insert into users table
            sql = "INSERT INTO users (username, password, full_name, role, is_active) " &
                  "VALUES (@user, @pass, @name, @role, 1)"
            cmd = New MySqlCommand(sql, cn)
            cmd.Parameters.AddWithValue("@user", txtUsername.Text.Trim)
            cmd.Parameters.AddWithValue("@pass", txtPassword.Text.Trim)
            cmd.Parameters.AddWithValue("@name", txtFullName.Text.Trim)
            cmd.Parameters.AddWithValue("@role", Me.Tag.ToString)
            cmd.ExecuteNonQuery()

            ' If Student, also insert into students table
            If Me.Tag.ToString = "Student" Then
                If txtStudentNumber.Text.Trim = "" Then
                    MsgBox("Student number is required.", MsgBoxStyle.Exclamation, "Validation")
                    cn.Close()
                    Exit Sub
                End If

                Dim newID As Integer = cmd.LastInsertedId

                sql = "INSERT INTO students (user_id, student_number, course, year_level) " &
                      "VALUES (@uid, @snum, @course, @yr)"
                cmd = New MySqlCommand(sql, cn)
                cmd.Parameters.AddWithValue("@uid", newID)
                cmd.Parameters.AddWithValue("@snum", txtStudentNumber.Text.Trim)
                cmd.Parameters.AddWithValue("@course", txtCourse.Text.Trim)
                cmd.Parameters.AddWithValue("@yr", If(txtYearLevel.Text.Trim = "", DBNull.Value, CInt(txtYearLevel.Text.Trim)))
                cmd.ExecuteNonQuery()
            End If

            cn.Close()
            MsgBox(Me.Tag.ToString & " account created successfully.", MsgBoxStyle.Information, "Success")
            Me.Close()

        Catch ex As MySqlException When ex.Number = 1062
            MsgBox("Username or Student Number already exists.", MsgBoxStyle.Critical, "Duplicate Entry")
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

        txtFullName.Clear()
        txtUsername.Clear()
        txtPassword.Clear()
        txtStudentNumber.Clear()
        txtCourse.Clear()
        txtYearLevel.Clear()

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
        txtFullName.Clear()
        txtUsername.Clear()
        txtPassword.Clear()
        txtStudentNumber.Clear()
        txtCourse.Clear()
        txtYearLevel.Clear()
    End Sub

End Class