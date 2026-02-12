Public Class frmStudentDashboard

    Private Sub frmStudentDashboard_Load(sender As Object, e As EventArgs) Handles Me.Load
        lblWelcome.Text = "  Welcome, " & Session.FullName & "  |  Role: Student"
        ' Load default view
        LoadControl(pnlContainer, New ucBookSearch())
    End Sub

    Private Sub SearchBooks_Click(sender As Object, e As EventArgs) Handles mnuSearchBooks.Click
        LoadControl(pnlContainer, New ucBookSearch())
    End Sub

    Private Sub BorrowBook_Click(sender As Object, e As EventArgs) Handles mnuBorrowBook.Click
        LoadControl(pnlContainer, New ucBorrow())
    End Sub

    Private Sub MyHistory_Click(sender As Object, e As EventArgs) Handles mnuMyHistory.Click
        LoadControl(pnlContainer, New ucMyHistory())
    End Sub

    Private Sub Logout_Click(sender As Object, e As EventArgs) Handles mnuLogout.Click
        Dim confirm As MsgBoxResult = MsgBox("Are you sure you want to logout?", MsgBoxStyle.YesNo, "Logout")
        If confirm = MsgBoxResult.Yes Then
            Session.UserID = 0
            Session.FullName = ""
            Session.Role = ""
            frmLogin.Show()
            Me.Close()
        End If
    End Sub

End Class