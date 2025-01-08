<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PTMemoInputGroup
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
        Me.PtLabel1 = New NewTemplate.PTLabel()
        Me.PtMemoInput1 = New NewTemplate.PTMemoInput()
        CType(Me.PtMemoInput1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PtLabel1
        '
        Me.PtLabel1.AutoSize = True
        Me.PtLabel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PtLabel1.Font = New System.Drawing.Font("Verdana", 8.5!)
        Me.PtLabel1.Location = New System.Drawing.Point(0, 0)
        Me.PtLabel1.Name = "PtLabel1"
        Me.PtLabel1.Size = New System.Drawing.Size(62, 14)
        Me.PtLabel1.TabIndex = 0
        Me.PtLabel1.Text = "PtLabel1"
        Me.PtLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PtMemoInput1
        '
        Me.PtMemoInput1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PtMemoInput1.Location = New System.Drawing.Point(0, 21)
        Me.PtMemoInput1.Name = "PtMemoInput1"
        Me.PtMemoInput1.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.PtMemoInput1.Properties.Appearance.BackColor2 = System.Drawing.Color.White
        Me.PtMemoInput1.Properties.Appearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.PtMemoInput1.Properties.Appearance.Font = New System.Drawing.Font("Verdana", 8.5!)
        Me.PtMemoInput1.Properties.Appearance.Options.UseBackColor = True
        Me.PtMemoInput1.Properties.Appearance.Options.UseBorderColor = True
        Me.PtMemoInput1.Properties.Appearance.Options.UseFont = True
        Me.PtMemoInput1.Properties.AppearanceDisabled.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.PtMemoInput1.Properties.AppearanceDisabled.BackColor2 = System.Drawing.SystemColors.ControlLightLight
        Me.PtMemoInput1.Properties.AppearanceDisabled.BorderColor = System.Drawing.SystemColors.ControlLight
        Me.PtMemoInput1.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.DimGray
        Me.PtMemoInput1.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.PtMemoInput1.Properties.AppearanceDisabled.Options.UseBorderColor = True
        Me.PtMemoInput1.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.PtMemoInput1.Properties.AppearanceFocused.BackColor = System.Drawing.Color.White
        Me.PtMemoInput1.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.White
        Me.PtMemoInput1.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PtMemoInput1.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.PtMemoInput1.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.PtMemoInput1.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.PtMemoInput1.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.PtMemoInput1.Properties.AppearanceReadOnly.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.PtMemoInput1.Properties.AppearanceReadOnly.BackColor2 = System.Drawing.SystemColors.ControlLightLight
        Me.PtMemoInput1.Properties.AppearanceReadOnly.BorderColor = System.Drawing.SystemColors.ControlLight
        Me.PtMemoInput1.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.DimGray
        Me.PtMemoInput1.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.PtMemoInput1.Properties.AppearanceReadOnly.Options.UseBorderColor = True
        Me.PtMemoInput1.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.PtMemoInput1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.PtMemoInput1.Properties.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.PtMemoInput1.Size = New System.Drawing.Size(250, 75)
        Me.PtMemoInput1.TabIndex = 1
        Me.PtMemoInput1.TableField = ""
        Me.PtMemoInput1.TableName = ""
        '
        'PTMemoInputGroup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.PtMemoInput1)
        Me.Controls.Add(Me.PtLabel1)
        Me.MaximumSize = New System.Drawing.Size(500, 96)
        Me.MinimumSize = New System.Drawing.Size(200, 96)
        Me.Name = "PTMemoInputGroup"
        Me.Size = New System.Drawing.Size(250, 96)
        CType(Me.PtMemoInput1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PtLabel1 As PTLabel
    Friend WithEvents PtMemoInput1 As PTMemoInput
End Class
