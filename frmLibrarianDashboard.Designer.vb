<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLibrarianDashboard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.UserManagementToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAddBook = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuViewBooks = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuBorrowBook = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuReturnBook = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuBorrowingRecords = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuLogout = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.pnlContainer = New System.Windows.Forms.Panel()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UserManagementToolStripMenuItem, Me.ReportsToolStripMenuItem, Me.mnuLogout})
        Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(938, 29)
        Me.MenuStrip1.TabIndex = 5
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'UserManagementToolStripMenuItem
        '
        Me.UserManagementToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuAddBook, Me.mnuViewBooks})
        Me.UserManagementToolStripMenuItem.Name = "UserManagementToolStripMenuItem"
        Me.UserManagementToolStripMenuItem.Size = New System.Drawing.Size(64, 25)
        Me.UserManagementToolStripMenuItem.Text = "Books"
        '
        'mnuAddBook
        '
        Me.mnuAddBook.Name = "mnuAddBook"
        Me.mnuAddBook.Size = New System.Drawing.Size(200, 26)
        Me.mnuAddBook.Text = "Add Book"
        '
        'mnuViewBooks
        '
        Me.mnuViewBooks.Name = "mnuViewBooks"
        Me.mnuViewBooks.Size = New System.Drawing.Size(200, 26)
        Me.mnuViewBooks.Text = "View / Edit Books"
        '
        'ReportsToolStripMenuItem
        '
        Me.ReportsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuBorrowBook, Me.mnuReturnBook, Me.mnuBorrowingRecords})
        Me.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem"
        Me.ReportsToolStripMenuItem.Size = New System.Drawing.Size(108, 25)
        Me.ReportsToolStripMenuItem.Text = "Transactions"
        '
        'mnuBorrowBook
        '
        Me.mnuBorrowBook.Name = "mnuBorrowBook"
        Me.mnuBorrowBook.Size = New System.Drawing.Size(213, 26)
        Me.mnuBorrowBook.Text = "Borrow a Book"
        '
        'mnuReturnBook
        '
        Me.mnuReturnBook.Name = "mnuReturnBook"
        Me.mnuReturnBook.Size = New System.Drawing.Size(213, 26)
        Me.mnuReturnBook.Text = "Return a Book"
        '
        'mnuBorrowingRecords
        '
        Me.mnuBorrowingRecords.Name = "mnuBorrowingRecords"
        Me.mnuBorrowingRecords.Size = New System.Drawing.Size(213, 26)
        Me.mnuBorrowingRecords.Text = "Borrowing Records"
        '
        'mnuLogout
        '
        Me.mnuLogout.Name = "mnuLogout"
        Me.mnuLogout.Size = New System.Drawing.Size(83, 25)
        Me.mnuLogout.Text = "LOGOUT"
        '
        'lblWelcome
        '
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblWelcome.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome.Location = New System.Drawing.Point(270, 6)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(75, 20)
        Me.lblWelcome.TabIndex = 6
        Me.lblWelcome.Text = "Welcome"
        '
        'pnlContainer
        '
        Me.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlContainer.Location = New System.Drawing.Point(0, 29)
        Me.pnlContainer.Name = "pnlContainer"
        Me.pnlContainer.Size = New System.Drawing.Size(938, 462)
        Me.pnlContainer.TabIndex = 7
        '
        'frmLibrarianDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(938, 491)
        Me.Controls.Add(Me.pnlContainer)
        Me.Controls.Add(Me.lblWelcome)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "frmLibrarianDashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmLibrarianDashboard"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents UserManagementToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuAddBook As ToolStripMenuItem
    Friend WithEvents mnuViewBooks As ToolStripMenuItem
    Friend WithEvents ReportsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuBorrowBook As ToolStripMenuItem
    Friend WithEvents mnuReturnBook As ToolStripMenuItem
    Friend WithEvents mnuBorrowingRecords As ToolStripMenuItem
    Friend WithEvents mnuLogout As ToolStripMenuItem
    Friend WithEvents lblWelcome As Label
    Friend WithEvents pnlContainer As Panel
End Class
