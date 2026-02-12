Public Class frmAdminDashboard

    Private Sub frmAdminDashboard_Load(sender As Object, e As EventArgs) Handles Me.Load
        lblWelcome.Text = "  Welcome, " & Session.FullName & "  |  Role: Admin"
        ' Load default view
        LoadControl(pnlContainer, New ucManageLibrarians())
    End Sub

    Private Sub ManageLibrarians_Click(sender As Object, e As EventArgs) Handles mnuManageLibrarians.Click
        LoadControl(pnlContainer, New ucManageLibrarians())
    End Sub

    Private Sub ManageStudents_Click(sender As Object, e As EventArgs) Handles mnuManageStudents.Click
        LoadControl(pnlContainer, New ucManageStudents())
    End Sub

    Private Sub InventoryReport_Click(sender As Object, e As EventArgs) Handles mnuInventoryReport.Click
        Dim uc As New ucReports()
        uc.Tag = "Inventory"
        LoadControl(pnlContainer, uc)
    End Sub

    Private Sub BorrowedBooks_Click(sender As Object, e As EventArgs) Handles mnuBorrowedBooks.Click
        Dim uc As New ucReports()
        uc.Tag = "Borrowed"
        LoadControl(pnlContainer, uc)
    End Sub

    Private Sub OverdueBooks_Click(sender As Object, e As EventArgs) Handles mnuOverdueBooks.Click
        Dim uc As New ucReports()
        uc.Tag = "Overdue"
        LoadControl(pnlContainer, uc)
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