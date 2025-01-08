<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EnterDiscountOrTax
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
        Me.Guna2ShadowForm1 = New Guna.UI2.WinForms.Guna2ShadowForm(Me.components)
        Me.txtNumber = New NewTemplate.PTTextInput()
        Me.btnDone = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblHeaderTitle = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnClose = New FontAwesome.Sharp.IconButton()
        Me.rdPercent = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.rdAmount = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rdTransaction = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.rdPerItem = New Guna.UI2.WinForms.Guna2RadioButton()
        CType(Me.txtNumber.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtNumber
        '
        Me.txtNumber.DisplayFormat = ""
        Me.txtNumber.EditValue = ""
        Me.txtNumber.Location = New System.Drawing.Point(27, 83)
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
        Me.txtNumber.Size = New System.Drawing.Size(370, 52)
        Me.txtNumber.TabIndex = 0
        Me.txtNumber.TableField = ""
        Me.txtNumber.TableName = ""
        '
        'btnDone
        '
        Me.btnDone.CheckedState.Parent = Me.btnDone
        Me.btnDone.CustomImages.Parent = Me.btnDone
        Me.btnDone.FillColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.btnDone.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnDone.ForeColor = System.Drawing.Color.White
        Me.btnDone.HoverState.Parent = Me.btnDone
        Me.btnDone.Location = New System.Drawing.Point(27, 209)
        Me.btnDone.Name = "btnDone"
        Me.btnDone.ShadowDecoration.Parent = Me.btnDone
        Me.btnDone.Size = New System.Drawing.Size(370, 39)
        Me.btnDone.TabIndex = 7
        Me.btnDone.Text = "DONE"
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
        Me.Panel1.Size = New System.Drawing.Size(427, 59)
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
        Me.Panel4.Location = New System.Drawing.Point(399, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(28, 59)
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
        Me.btnClose.Size = New System.Drawing.Size(28, 59)
        Me.btnClose.TabIndex = 1
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'rdPercent
        '
        Me.rdPercent.AutoSize = True
        Me.rdPercent.Checked = True
        Me.rdPercent.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rdPercent.CheckedState.BorderThickness = 0
        Me.rdPercent.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rdPercent.CheckedState.InnerColor = System.Drawing.Color.White
        Me.rdPercent.CheckedState.InnerOffset = -4
        Me.rdPercent.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold)
        Me.rdPercent.Location = New System.Drawing.Point(19, 13)
        Me.rdPercent.Name = "rdPercent"
        Me.rdPercent.Size = New System.Drawing.Size(82, 17)
        Me.rdPercent.TabIndex = 9
        Me.rdPercent.TabStop = True
        Me.rdPercent.Text = "PERCENT"
        Me.rdPercent.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.rdPercent.UncheckedState.BorderThickness = 2
        Me.rdPercent.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.rdPercent.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        Me.rdPercent.UseVisualStyleBackColor = True
        '
        'rdAmount
        '
        Me.rdAmount.AutoSize = True
        Me.rdAmount.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rdAmount.CheckedState.BorderThickness = 0
        Me.rdAmount.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rdAmount.CheckedState.InnerColor = System.Drawing.Color.White
        Me.rdAmount.CheckedState.InnerOffset = -4
        Me.rdAmount.Enabled = False
        Me.rdAmount.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold)
        Me.rdAmount.Location = New System.Drawing.Point(19, 36)
        Me.rdAmount.Name = "rdAmount"
        Me.rdAmount.Size = New System.Drawing.Size(79, 17)
        Me.rdAmount.TabIndex = 10
        Me.rdAmount.Text = "AMOUNT"
        Me.rdAmount.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.rdAmount.UncheckedState.BorderThickness = 2
        Me.rdAmount.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.rdAmount.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        Me.rdAmount.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdPercent)
        Me.GroupBox1.Controls.Add(Me.rdAmount)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Location = New System.Drawing.Point(27, 141)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(182, 62)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rdTransaction)
        Me.GroupBox2.Controls.Add(Me.rdPerItem)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox2.Location = New System.Drawing.Point(210, 141)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(187, 62)
        Me.GroupBox2.TabIndex = 15
        Me.GroupBox2.TabStop = False
        '
        'rdTransaction
        '
        Me.rdTransaction.AutoSize = True
        Me.rdTransaction.Checked = True
        Me.rdTransaction.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rdTransaction.CheckedState.BorderThickness = 0
        Me.rdTransaction.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rdTransaction.CheckedState.InnerColor = System.Drawing.Color.White
        Me.rdTransaction.CheckedState.InnerOffset = -4
        Me.rdTransaction.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold)
        Me.rdTransaction.Location = New System.Drawing.Point(19, 13)
        Me.rdTransaction.Name = "rdTransaction"
        Me.rdTransaction.Size = New System.Drawing.Size(116, 17)
        Me.rdTransaction.TabIndex = 9
        Me.rdTransaction.TabStop = True
        Me.rdTransaction.Text = "TRANSACTION"
        Me.rdTransaction.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.rdTransaction.UncheckedState.BorderThickness = 2
        Me.rdTransaction.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.rdTransaction.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        Me.rdTransaction.UseVisualStyleBackColor = True
        '
        'rdPerItem
        '
        Me.rdPerItem.AutoSize = True
        Me.rdPerItem.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rdPerItem.CheckedState.BorderThickness = 0
        Me.rdPerItem.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rdPerItem.CheckedState.InnerColor = System.Drawing.Color.White
        Me.rdPerItem.CheckedState.InnerOffset = -4
        Me.rdPerItem.Enabled = False
        Me.rdPerItem.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold)
        Me.rdPerItem.Location = New System.Drawing.Point(19, 36)
        Me.rdPerItem.Name = "rdPerItem"
        Me.rdPerItem.Size = New System.Drawing.Size(85, 17)
        Me.rdPerItem.TabIndex = 10
        Me.rdPerItem.Text = "PER ITEM"
        Me.rdPerItem.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.rdPerItem.UncheckedState.BorderThickness = 2
        Me.rdPerItem.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.rdPerItem.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        Me.rdPerItem.UseVisualStyleBackColor = True
        '
        'EnterDiscountOrTax
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(427, 283)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtNumber)
        Me.Controls.Add(Me.btnDone)
        Me.Controls.Add(Me.Panel1)
        Me.KeyPreview = True
        Me.Name = "EnterDiscountOrTax"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        CType(Me.txtNumber.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Protected Friend WithEvents lblHeaderTitle As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents btnClose As FontAwesome.Sharp.IconButton
    Protected Friend WithEvents btnDone As Guna.UI2.WinForms.Guna2Button
    Protected Friend WithEvents Guna2ShadowForm1 As Guna.UI2.WinForms.Guna2ShadowForm
    Friend WithEvents txtNumber As PTTextInput
    Friend WithEvents rdPercent As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents rdAmount As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents rdTransaction As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents rdPerItem As Guna.UI2.WinForms.Guna2RadioButton
End Class
