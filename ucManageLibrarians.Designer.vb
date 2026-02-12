<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucManageLibrarians
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
        Me.btnActivate = New System.Windows.Forms.Button()
        Me.btnDeactivate = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.dgvLibrarians = New System.Windows.Forms.DataGridView()
        Me.tmrRefresh = New System.Windows.Forms.Timer(Me.components)
        CType(Me.dgvLibrarians, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnActivate
        '
        Me.btnActivate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnActivate.Location = New System.Drawing.Point(47, 364)
        Me.btnActivate.Name = "btnActivate"
        Me.btnActivate.Size = New System.Drawing.Size(207, 41)
        Me.btnActivate.TabIndex = 16
        Me.btnActivate.Text = "Activate"
        Me.btnActivate.UseVisualStyleBackColor = True
        '
        'btnDeactivate
        '
        Me.btnDeactivate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeactivate.Location = New System.Drawing.Point(47, 411)
        Me.btnDeactivate.Name = "btnDeactivate"
        Me.btnDeactivate.Size = New System.Drawing.Size(207, 41)
        Me.btnDeactivate.TabIndex = 15
        Me.btnDeactivate.Text = "Deactivate"
        Me.btnDeactivate.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(47, 317)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(207, 41)
        Me.btnAdd.TabIndex = 14
        Me.btnAdd.Text = "Add Librarian"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(396, 317)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(249, 26)
        Me.txtSearch.TabIndex = 13
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(651, 317)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(127, 29)
        Me.btnSearch.TabIndex = 12
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'dgvLibrarians
        '
        Me.dgvLibrarians.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLibrarians.Location = New System.Drawing.Point(23, 43)
        Me.dgvLibrarians.Name = "dgvLibrarians"
        Me.dgvLibrarians.ReadOnly = True
        Me.dgvLibrarians.Size = New System.Drawing.Size(776, 250)
        Me.dgvLibrarians.TabIndex = 11
        '
        'tmrRefresh
        '
        Me.tmrRefresh.Interval = 10000
        '
        'ucManageLibrarians
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btnActivate)
        Me.Controls.Add(Me.btnDeactivate)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.dgvLibrarians)
        Me.Name = "ucManageLibrarians"
        Me.Size = New System.Drawing.Size(823, 495)
        CType(Me.dgvLibrarians, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnActivate As Button
    Friend WithEvents btnDeactivate As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents dgvLibrarians As DataGridView
    Friend WithEvents tmrRefresh As Timer
End Class
