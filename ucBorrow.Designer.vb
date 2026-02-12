<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucBorrow
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
        Me.components = New System.ComponentModel.Container()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnBorrow = New System.Windows.Forms.Button()
        Me.dtpDueDate = New System.Windows.Forms.DateTimePicker()
        Me.dgvBooks = New System.Windows.Forms.DataGridView()
        Me.btnSearchBook = New System.Windows.Forms.Button()
        Me.txtSearchBook = New System.Windows.Forms.TextBox()
        Me.lblStudentName = New System.Windows.Forms.Label()
        Me.tmrRefresh = New System.Windows.Forms.Timer(Me.components)
        CType(Me.dgvBooks, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(388, 334)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(198, 56)
        Me.btnCancel.TabIndex = 17
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnBorrow
        '
        Me.btnBorrow.Location = New System.Drawing.Point(145, 334)
        Me.btnBorrow.Name = "btnBorrow"
        Me.btnBorrow.Size = New System.Drawing.Size(198, 56)
        Me.btnBorrow.TabIndex = 16
        Me.btnBorrow.Text = "Borrow"
        Me.btnBorrow.UseVisualStyleBackColor = True
        '
        'dtpDueDate
        '
        Me.dtpDueDate.Location = New System.Drawing.Point(562, 310)
        Me.dtpDueDate.Name = "dtpDueDate"
        Me.dtpDueDate.Size = New System.Drawing.Size(200, 20)
        Me.dtpDueDate.TabIndex = 15
        '
        'dgvBooks
        '
        Me.dgvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBooks.Location = New System.Drawing.Point(20, 151)
        Me.dgvBooks.Name = "dgvBooks"
        Me.dgvBooks.ReadOnly = True
        Me.dgvBooks.Size = New System.Drawing.Size(742, 139)
        Me.dgvBooks.TabIndex = 14
        '
        'btnSearchBook
        '
        Me.btnSearchBook.Location = New System.Drawing.Point(20, 107)
        Me.btnSearchBook.Name = "btnSearchBook"
        Me.btnSearchBook.Size = New System.Drawing.Size(75, 23)
        Me.btnSearchBook.TabIndex = 13
        Me.btnSearchBook.Text = "Search"
        Me.btnSearchBook.UseVisualStyleBackColor = True
        '
        'txtSearchBook
        '
        Me.txtSearchBook.Location = New System.Drawing.Point(101, 107)
        Me.txtSearchBook.Name = "txtSearchBook"
        Me.txtSearchBook.Size = New System.Drawing.Size(226, 20)
        Me.txtSearchBook.TabIndex = 12
        '
        'lblStudentName
        '
        Me.lblStudentName.AutoSize = True
        Me.lblStudentName.Location = New System.Drawing.Point(28, 51)
        Me.lblStudentName.Name = "lblStudentName"
        Me.lblStudentName.Size = New System.Drawing.Size(75, 13)
        Me.lblStudentName.TabIndex = 11
        Me.lblStudentName.Text = "Student Name"
        '
        'tmrRefresh
        '
        Me.tmrRefresh.Interval = 1000
        '
        'ucBorrow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnBorrow)
        Me.Controls.Add(Me.dtpDueDate)
        Me.Controls.Add(Me.dgvBooks)
        Me.Controls.Add(Me.btnSearchBook)
        Me.Controls.Add(Me.txtSearchBook)
        Me.Controls.Add(Me.lblStudentName)
        Me.Name = "ucBorrow"
        Me.Size = New System.Drawing.Size(808, 483)
        CType(Me.dgvBooks, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCancel As Button
    Friend WithEvents btnBorrow As Button
    Friend WithEvents dtpDueDate As DateTimePicker
    Friend WithEvents dgvBooks As DataGridView
    Friend WithEvents btnSearchBook As Button
    Friend WithEvents txtSearchBook As TextBox
    Friend WithEvents lblStudentName As Label
    Friend WithEvents tmrRefresh As Timer
End Class
