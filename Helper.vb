Imports System.Windows.Forms

Module Helper

    Public Sub LoadControl(panel As Panel, control As UserControl)
        ' Clear existing controls
        panel.Controls.Clear()

        ' Set control to fill panel
        control.Dock = DockStyle.Fill

        ' Add to panel
        panel.Controls.Add(control)
    End Sub

End Module