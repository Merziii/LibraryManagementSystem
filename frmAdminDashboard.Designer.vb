<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAdminDashboard
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
        Me.ssAdmin = New System.Windows.Forms.StatusStrip()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.UserManagementToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuManageLibrarians = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuManageStudents = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuInventoryReport = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuBorrowedBooks = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuOverdueBooks = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuLogout = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.pnlContainer = New System.Windows.Forms.Panel()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ssAdmin
        '
        Me.ssAdmin.Location = New System.Drawing.Point(0, 560)
        Me.ssAdmin.Name = "ssAdmin"
        Me.ssAdmin.Size = New System.Drawing.Size(1084, 22)
        Me.ssAdmin.TabIndex = 2
        Me.ssAdmin.Text = "StatusStrip1"
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
        Me.MenuStrip1.Size = New System.Drawing.Size(1084, 29)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'UserManagementToolStripMenuItem
        '
        Me.UserManagementToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuManageLibrarians, Me.mnuManageStudents})
        Me.UserManagementToolStripMenuItem.Name = "UserManagementToolStripMenuItem"
        Me.UserManagementToolStripMenuItem.Size = New System.Drawing.Size(150, 25)
        Me.UserManagementToolStripMenuItem.Text = "User Management"
        '
        'mnuManageLibrarians
        '
        Me.mnuManageLibrarians.Name = "mnuManageLibrarians"
        Me.mnuManageLibrarians.Size = New System.Drawing.Size(209, 26)
        Me.mnuManageLibrarians.Text = "Manage Librarians"
        '
        'mnuManageStudents
        '
        Me.mnuManageStudents.Name = "mnuManageStudents"
        Me.mnuManageStudents.Size = New System.Drawing.Size(209, 26)
        Me.mnuManageStudents.Text = "Manage Students"
        '
        'ReportsToolStripMenuItem
        '
        Me.ReportsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuInventoryReport, Me.mnuBorrowedBooks, Me.mnuOverdueBooks})
        Me.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem"
        Me.ReportsToolStripMenuItem.Size = New System.Drawing.Size(76, 25)
        Me.ReportsToolStripMenuItem.Text = "Reports"
        '
        'mnuInventoryReport
        '
        Me.mnuInventoryReport.Name = "mnuInventoryReport"
        Me.mnuInventoryReport.Size = New System.Drawing.Size(197, 26)
        Me.mnuInventoryReport.Text = "Inventory Report"
        '
        'mnuBorrowedBooks
        '
        Me.mnuBorrowedBooks.Name = "mnuBorrowedBooks"
        Me.mnuBorrowedBooks.Size = New System.Drawing.Size(197, 26)
        Me.mnuBorrowedBooks.Text = "Borrowed Books"
        '
        'mnuOverdueBooks
        '
        Me.mnuOverdueBooks.Name = "mnuOverdueBooks"
        Me.mnuOverdueBooks.Size = New System.Drawing.Size(197, 26)
        Me.mnuOverdueBooks.Text = "Overdue Books"
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
        Me.lblWelcome.Location = New System.Drawing.Point(320, 6)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(75, 20)
        Me.lblWelcome.TabIndex = 5
        Me.lblWelcome.Text = "Welcome"
        '
        'pnlContainer
        '
        Me.pnlContainer.AutoScroll = True
        Me.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlContainer.Location = New System.Drawing.Point(0, 29)
        Me.pnlContainer.Name = "pnlContainer"
        Me.pnlContainer.Size = New System.Drawing.Size(1084, 531)
        Me.pnlContainer.TabIndex = 6
        '
        'frmAdminDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1084, 582)
        Me.Controls.Add(Me.pnlContainer)
        Me.Controls.Add(Me.lblWelcome)
        Me.Controls.Add(Me.ssAdmin)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "frmAdminDashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmAdminDashboard"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ssAdmin As StatusStrip
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents UserManagementToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuManageLibrarians As ToolStripMenuItem
    Friend WithEvents mnuManageStudents As ToolStripMenuItem
    Friend WithEvents ReportsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuInventoryReport As ToolStripMenuItem
    Friend WithEvents mnuBorrowedBooks As ToolStripMenuItem
    Friend WithEvents mnuOverdueBooks As ToolStripMenuItem
    Friend WithEvents mnuLogout As ToolStripMenuItem
    Friend WithEvents lblWelcome As Label
    Friend WithEvents pnlContainer As Panel
End Class
