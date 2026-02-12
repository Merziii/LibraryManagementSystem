<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucBorrowLibrarian
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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.grpStudent = New System.Windows.Forms.GroupBox()
        Me.lblStudentName = New System.Windows.Forms.Label()
        Me.btnFindStudent = New System.Windows.Forms.Button()
        Me.txtStudentNumber = New System.Windows.Forms.TextBox()
        Me.grpBook = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSearchBook = New System.Windows.Forms.Button()
        Me.txtSearchBook = New System.Windows.Forms.TextBox()
        Me.dgvBooks = New System.Windows.Forms.DataGridView()
        Me.grpBorrow = New System.Windows.Forms.GroupBox()
        Me.btnBorrow = New System.Windows.Forms.Button()
        Me.dtpDueDate = New System.Windows.Forms.DateTimePicker()
        Me.grpStudent.SuspendLayout()
        Me.grpBook.SuspendLayout()
        CType(Me.dgvBooks, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpBorrow.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Location = New System.Drawing.Point(34, 41)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(77, 13)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Borrow a Book"
        '
        'grpStudent
        '
        Me.grpStudent.Controls.Add(Me.lblStudentName)
        Me.grpStudent.Controls.Add(Me.btnFindStudent)
        Me.grpStudent.Controls.Add(Me.txtStudentNumber)
        Me.grpStudent.Location = New System.Drawing.Point(37, 80)
        Me.grpStudent.Name = "grpStudent"
        Me.grpStudent.Size = New System.Drawing.Size(270, 148)
        Me.grpStudent.TabIndex = 1
        Me.grpStudent.TabStop = False
        Me.grpStudent.Text = "Student Information"
        '
        'lblStudentName
        '
        Me.lblStudentName.AutoSize = True
        Me.lblStudentName.Location = New System.Drawing.Point(24, 86)
        Me.lblStudentName.Name = "lblStudentName"
        Me.lblStudentName.Size = New System.Drawing.Size(35, 13)
        Me.lblStudentName.TabIndex = 2
        Me.lblStudentName.Text = "Name"
        '
        'btnFindStudent
        '
        Me.btnFindStudent.Location = New System.Drawing.Point(175, 34)
        Me.btnFindStudent.Name = "btnFindStudent"
        Me.btnFindStudent.Size = New System.Drawing.Size(81, 22)
        Me.btnFindStudent.TabIndex = 1
        Me.btnFindStudent.Text = "Find Student"
        Me.btnFindStudent.UseVisualStyleBackColor = True
        '
        'txtStudentNumber
        '
        Me.txtStudentNumber.Location = New System.Drawing.Point(27, 34)
        Me.txtStudentNumber.Name = "txtStudentNumber"
        Me.txtStudentNumber.Size = New System.Drawing.Size(142, 20)
        Me.txtStudentNumber.TabIndex = 0
        '
        'grpBook
        '
        Me.grpBook.Controls.Add(Me.Label1)
        Me.grpBook.Controls.Add(Me.btnSearchBook)
        Me.grpBook.Controls.Add(Me.txtSearchBook)
        Me.grpBook.Location = New System.Drawing.Point(361, 80)
        Me.grpBook.Name = "grpBook"
        Me.grpBook.Size = New System.Drawing.Size(270, 148)
        Me.grpBook.TabIndex = 3
        Me.grpBook.TabStop = False
        Me.grpBook.Text = "Book Information"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 86)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Name"
        '
        'btnSearchBook
        '
        Me.btnSearchBook.Location = New System.Drawing.Point(175, 34)
        Me.btnSearchBook.Name = "btnSearchBook"
        Me.btnSearchBook.Size = New System.Drawing.Size(81, 22)
        Me.btnSearchBook.TabIndex = 1
        Me.btnSearchBook.Text = "Search Book"
        Me.btnSearchBook.UseVisualStyleBackColor = True
        '
        'txtSearchBook
        '
        Me.txtSearchBook.Location = New System.Drawing.Point(27, 34)
        Me.txtSearchBook.Name = "txtSearchBook"
        Me.txtSearchBook.Size = New System.Drawing.Size(142, 20)
        Me.txtSearchBook.TabIndex = 0
        '
        'dgvBooks
        '
        Me.dgvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBooks.Location = New System.Drawing.Point(37, 254)
        Me.dgvBooks.Name = "dgvBooks"
        Me.dgvBooks.Size = New System.Drawing.Size(603, 144)
        Me.dgvBooks.TabIndex = 4
        '
        'grpBorrow
        '
        Me.grpBorrow.Controls.Add(Me.btnBorrow)
        Me.grpBorrow.Controls.Add(Me.dtpDueDate)
        Me.grpBorrow.Location = New System.Drawing.Point(108, 422)
        Me.grpBorrow.Name = "grpBorrow"
        Me.grpBorrow.Size = New System.Drawing.Size(433, 99)
        Me.grpBorrow.TabIndex = 4
        Me.grpBorrow.TabStop = False
        Me.grpBorrow.Text = "Borrow Details"
        '
        'btnBorrow
        '
        Me.btnBorrow.Location = New System.Drawing.Point(254, 44)
        Me.btnBorrow.Name = "btnBorrow"
        Me.btnBorrow.Size = New System.Drawing.Size(116, 22)
        Me.btnBorrow.TabIndex = 3
        Me.btnBorrow.Text = "Confirm Borrow"
        Me.btnBorrow.UseVisualStyleBackColor = True
        '
        'dtpDueDate
        '
        Me.dtpDueDate.Location = New System.Drawing.Point(29, 46)
        Me.dtpDueDate.Name = "dtpDueDate"
        Me.dtpDueDate.Size = New System.Drawing.Size(200, 20)
        Me.dtpDueDate.TabIndex = 5
        '
        'ucBorrowLibrarian
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.grpBorrow)
        Me.Controls.Add(Me.dgvBooks)
        Me.Controls.Add(Me.grpBook)
        Me.Controls.Add(Me.grpStudent)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "ucBorrowLibrarian"
        Me.Size = New System.Drawing.Size(685, 564)
        Me.grpStudent.ResumeLayout(False)
        Me.grpStudent.PerformLayout()
        Me.grpBook.ResumeLayout(False)
        Me.grpBook.PerformLayout()
        CType(Me.dgvBooks, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpBorrow.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents grpStudent As GroupBox
    Friend WithEvents lblStudentName As Label
    Friend WithEvents btnFindStudent As Button
    Friend WithEvents txtStudentNumber As TextBox
    Friend WithEvents grpBook As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSearchBook As Button
    Friend WithEvents txtSearchBook As TextBox
    Friend WithEvents dgvBooks As DataGridView
    Friend WithEvents grpBorrow As GroupBox
    Friend WithEvents btnBorrow As Button
    Friend WithEvents dtpDueDate As DateTimePicker
End Class
