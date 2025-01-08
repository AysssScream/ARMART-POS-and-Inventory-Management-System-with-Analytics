<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EnterNumber
    Inherits NewTemplate.BaseForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblHeaderTitle = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnClose = New FontAwesome.Sharp.IconButton()
        Me.btnDone = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2ShadowForm1 = New Guna.UI2.WinForms.Guna2ShadowForm(Me.components)
        Me.txtNumber = New NewTemplate.PTTextInput()
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.txtNumber.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.Panel1.BackgroundImage = Global.NewTemplate.My.Resources.Resources.logo_system
        Me.Panel1.Controls.Add(Me.lblHeaderTitle)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(403, 39)
        Me.Panel1.TabIndex = 1
        '
        'lblHeaderTitle
        '
        Me.lblHeaderTitle.AutoSize = True
        Me.lblHeaderTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblHeaderTitle.Font = New System.Drawing.Font("Verdana", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lblHeaderTitle.ForeColor = System.Drawing.Color.White
        Me.lblHeaderTitle.Location = New System.Drawing.Point(6, 9)
        Me.lblHeaderTitle.Name = "lblHeaderTitle"
        Me.lblHeaderTitle.Size = New System.Drawing.Size(53, 18)
        Me.lblHeaderTitle.TabIndex = 5
        Me.lblHeaderTitle.Text = "Input"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.btnClose)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel4.Location = New System.Drawing.Point(375, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(28, 39)
        Me.Panel4.TabIndex = 1
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.btnClose.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.IconChar = FontAwesome.Sharp.IconChar.WindowClose
        Me.btnClose.IconColor = System.Drawing.Color.White
        Me.btnClose.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnClose.IconSize = 24
        Me.btnClose.Location = New System.Drawing.Point(0, 0)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(28, 39)
        Me.btnClose.TabIndex = 1
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'btnDone
        '
        Me.btnDone.CheckedState.Parent = Me.btnDone
        Me.btnDone.CustomImages.Parent = Me.btnDone
        Me.btnDone.FillColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.btnDone.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnDone.ForeColor = System.Drawing.Color.White
        Me.btnDone.HoverState.Parent = Me.btnDone
        Me.btnDone.Location = New System.Drawing.Point(36, 130)
        Me.btnDone.Name = "btnDone"
        Me.btnDone.ShadowDecoration.Parent = Me.btnDone
        Me.btnDone.Size = New System.Drawing.Size(325, 39)
        Me.btnDone.TabIndex = 7
        Me.btnDone.Text = "DONE"
        '
        'txtNumber
        '
        Me.txtNumber.DisplayFormat = ""
        Me.txtNumber.EditValue = ""
        Me.txtNumber.Location = New System.Drawing.Point(36, 66)
        Me.txtNumber.Name = "txtNumber"
        Me.txtNumber.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtNumber.Properties.Appearance.BackColor2 = System.Drawing.Color.White
        Me.txtNumber.Properties.Appearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.txtNumber.Properties.Appearance.Font = New System.Drawing.Font("Verdana", 24.0!)
        Me.txtNumber.Properties.Appearance.Options.UseBackColor = True
        Me.txtNumber.Properties.Appearance.Options.UseBorderColor = True
        Me.txtNumber.Properties.Appearance.Options.UseFont = True
        Me.txtNumber.Properties.Appearance.Options.UseTextOptions = True
        Me.txtNumber.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtNumber.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.txtNumber.Properties.AppearanceDisabled.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtNumber.Properties.AppearanceDisabled.BackColor2 = System.Drawing.SystemColors.ControlLightLight
        Me.txtNumber.Properties.AppearanceDisabled.BorderColor = System.Drawing.SystemColors.ControlLight
        Me.txtNumber.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.DimGray
        Me.txtNumber.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txtNumber.Properties.AppearanceDisabled.Options.UseBorderColor = True
        Me.txtNumber.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txtNumber.Properties.AppearanceFocused.BackColor = System.Drawing.Color.White
        Me.txtNumber.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.White
        Me.txtNumber.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNumber.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txtNumber.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtNumber.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.txtNumber.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txtNumber.Properties.AppearanceReadOnly.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtNumber.Properties.AppearanceReadOnly.BackColor2 = System.Drawing.SystemColors.ControlLightLight
        Me.txtNumber.Properties.AppearanceReadOnly.BorderColor = System.Drawing.SystemColors.ControlLight
        Me.txtNumber.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.DimGray
        Me.txtNumber.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtNumber.Properties.AppearanceReadOnly.Options.UseBorderColor = True
        Me.txtNumber.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtNumber.Properties.AutoHeight = False
        Me.txtNumber.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txtNumber.Size = New System.Drawing.Size(325, 52)
        Me.txtNumber.TabIndex = 0
        Me.txtNumber.TableField = ""
        Me.txtNumber.TableName = ""
        '
        'EnterNumber
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(403, 215)
        Me.Controls.Add(Me.txtNumber)
        Me.Controls.Add(Me.btnDone)
        Me.Controls.Add(Me.Panel1)
        Me.KeyPreview = True
        Me.Name = "EnterNumber"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        CType(Me.txtNumber.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Protected Friend WithEvents lblHeaderTitle As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents btnClose As FontAwesome.Sharp.IconButton
    Protected Friend WithEvents btnDone As Guna.UI2.WinForms.Guna2Button
    Protected Friend WithEvents Guna2ShadowForm1 As Guna.UI2.WinForms.Guna2ShadowForm
    Friend WithEvents txtNumber As PTTextInput
End Class
