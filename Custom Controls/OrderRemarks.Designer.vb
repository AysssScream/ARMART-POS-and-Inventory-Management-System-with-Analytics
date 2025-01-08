<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class OrderRemarks
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.MainPanel = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Remarks = New System.Windows.Forms.Label()
        Me.MainPanel.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'MainPanel
        '
        Me.MainPanel.AutoSize = True
        Me.MainPanel.Controls.Add(Me.Panel2)
        Me.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainPanel.Location = New System.Drawing.Point(0, 0)
        Me.MainPanel.Name = "MainPanel"
        Me.MainPanel.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.MainPanel.Size = New System.Drawing.Size(382, 14)
        Me.MainPanel.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Remarks)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(15, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(367, 14)
        Me.Panel2.TabIndex = 2
        '
        'Remarks
        '
        Me.Remarks.AutoSize = True
        Me.Remarks.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Remarks.Font = New System.Drawing.Font("Verdana", 7.5!, System.Drawing.FontStyle.Bold)
        Me.Remarks.ForeColor = System.Drawing.Color.Gray
        Me.Remarks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Remarks.Location = New System.Drawing.Point(0, 0)
        Me.Remarks.Name = "Remarks"
        Me.Remarks.Size = New System.Drawing.Size(56, 12)
        Me.Remarks.TabIndex = 6
        Me.Remarks.Text = "Remarks"
        Me.Remarks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'OrderRemarks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.MainPanel)
        Me.Name = "OrderRemarks"
        Me.Size = New System.Drawing.Size(382, 14)
        Me.MainPanel.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MainPanel As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Remarks As Label
End Class
