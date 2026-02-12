Public Class frmLibrarianDashboard

    Private Sub frmLibrarianDashboard_Load(sender As Object, e As EventArgs) Handles Me.Load
        lblWelcome.Text = "  Welcome, " & Session.FullName & "  |  Role: Librarian"
        ' Load default view
        LoadControl(pnlContainer, New ucBookList())
    End Sub

    Private Sub AddBook_Click(sender As Object, e As EventArgs) Handles mnuAddBook.Click
        frmAddBook.Tag = "Add"
        frmAddBook.ShowDialog()
        ' Refresh book list if it's currently loaded
        If pnlContainer.Controls.Count > 0 AndAlso TypeOf pnlContainer.Controls(0) Is ucBookList Then
            LoadControl(pnlContainer, New ucBookList())
        End If
    End Sub

    Private Sub ViewBooks_Click(sender As Object, e As EventArgs) Handles mnuViewBooks.Click
        LoadControl(pnlContainer, New ucBookList())
    End Sub

    Private Sub BorrowBook_Click(sender As Object, e As EventArgs) Handles mnuBorrowBook.Click
        LoadControl(pnlContainer, New ucBorrowLibrarian())
    End Sub

    Private Sub ReturnBook_Click(sender As Object, e As EventArgs) Handles mnuReturnBook.Click
        LoadControl(pnlContainer, New ucReturn())
    End Sub

    Private Sub BorrowingRecords_Click(sender As Object, e As EventArgs) Handles mnuBorrowingRecords.Click
        LoadControl(pnlContainer, New ucBorrowRecords())
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