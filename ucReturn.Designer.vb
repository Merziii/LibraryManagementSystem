<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucReturn
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.dgvBorrowedBooks = New System.Windows.Forms.DataGridView()
        Me.lblStudentName = New System.Windows.Forms.Label()
        Me.btnFindStudent = New System.Windows.Forms.Button()
        Me.txtStudentNumber = New System.Windows.Forms.TextBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.grpStudent = New System.Windows.Forms.GroupBox()
        CType(Me.dgvBorrowedBooks, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpStudent.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(56, 371)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(198, 56)
        Me.btnCancel.TabIndex = 16
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnReturn
        '
        Me.btnReturn.Location = New System.Drawing.Point(56, 288)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(198, 56)
        Me.btnReturn.TabIndex = 15
        Me.btnReturn.Text = "Return"
        Me.btnReturn.UseVisualStyleBackColor = True
        '
        'dgvBorrowedBooks
        '
        Me.dgvBorrowedBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBorrowedBooks.Location = New System.Drawing.Point(330, 52)
        Me.dgvBorrowedBooks.Name = "dgvBorrowedBooks"
        Me.dgvBorrowedBooks.ReadOnly = True
        Me.dgvBorrowedBooks.Size = New System.Drawing.Size(496, 355)
        Me.dgvBorrowedBooks.TabIndex = 14
        '
        'lblStudentName
        '
        Me.lblStudentName.AutoSize = True
        Me.lblStudentName.Location = New System.Drawing.Point(26, 93)
        Me.lblStudentName.Name = "lblStudentName"
        Me.lblStudentName.Size = New System.Drawing.Size(75, 13)
        Me.lblStudentName.TabIndex = 13
        Me.lblStudentName.Text = "Student Name"
        '
        'btnFindStudent
        '
        Me.btnFindStudent.Location = New System.Drawing.Point(133, 32)
        Me.btnFindStudent.Name = "btnFindStudent"
        Me.btnFindStudent.Size = New System.Drawing.Size(121, 23)
        Me.btnFindStudent.TabIndex = 12
        Me.btnFindStudent.Text = "Find Student Number"
        Me.btnFindStudent.UseVisualStyleBackColor = True
        '
        'txtStudentNumber
        '
        Me.txtStudentNumber.Location = New System.Drawing.Point(6, 32)
        Me.txtStudentNumber.Name = "txtStudentNumber"
        Me.txtStudentNumber.Size = New System.Drawing.Size(121, 20)
        Me.txtStudentNumber.TabIndex = 11
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Location = New System.Drawing.Point(24, 31)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(76, 13)
        Me.lblTitle.TabIndex = 17
        Me.lblTitle.Text = "Return a Book"
        '
        'grpStudent
        '
        Me.grpStudent.Controls.Add(Me.txtStudentNumber)
        Me.grpStudent.Controls.Add(Me.btnFindStudent)
        Me.grpStudent.Controls.Add(Me.lblStudentName)
        Me.grpStudent.Location = New System.Drawing.Point(27, 72)
        Me.grpStudent.Name = "grpStudent"
        Me.grpStudent.Size = New System.Drawing.Size(270, 148)
        Me.grpStudent.TabIndex = 18
        Me.grpStudent.TabStop = False
        Me.grpStudent.Text = "Student Information"
        '
        'ucReturn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.grpStudent)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnReturn)
        Me.Controls.Add(Me.dgvBorrowedBooks)
        Me.Name = "ucReturn"
        Me.Size = New System.Drawing.Size(872, 466)
        CType(Me.dgvBorrowedBooks, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpStudent.ResumeLayout(False)
        Me.grpStudent.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCancel As Button
    Friend WithEvents btnReturn As Button
    Friend WithEvents dgvBorrowedBooks As DataGridView
    Friend WithEvents lblStudentName As Label
    Friend WithEvents btnFindStudent As Button
    Friend WithEvents txtStudentNumber As TextBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents grpStudent As GroupBox
End Class
