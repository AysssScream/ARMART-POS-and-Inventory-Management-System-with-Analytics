<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PTComboBoxInputGroup
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
        Me.PtLabelGrp1 = New NewTemplate.PTLabel()
        Me.PtComboBoxInput1 = New NewTemplate.PTComboBoxInput()
        CType(Me.PtComboBoxInput1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PtLabelGrp1
        '
        Me.PtLabelGrp1.AutoSize = True
        Me.PtLabelGrp1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PtLabelGrp1.Font = New System.Drawing.Font("Verdana", 8.5!)
        Me.PtLabelGrp1.Location = New System.Drawing.Point(0, 0)
        Me.PtLabelGrp1.Margin = New System.Windows.Forms.Padding(0)
        Me.PtLabelGrp1.Name = "PtLabelGrp1"
        Me.PtLabelGrp1.Size = New System.Drawing.Size(62, 14)
        Me.PtLabelGrp1.TabIndex = 0
        Me.PtLabelGrp1.Text = "PtLabel1"
        Me.PtLabelGrp1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PtComboBoxInput1
        '
        Me.PtComboBoxInput1.AdditionalWhere = ""
        Me.PtComboBoxInput1.DataSourceCustom = Nothing
        Me.PtComboBoxInput1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PtComboBoxInput1.Location = New System.Drawing.Point(0, 21)
        Me.PtComboBoxInput1.Name = "PtComboBoxInput1"
        Me.PtComboBoxInput1.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.PtComboBoxInput1.Properties.Appearance.BackColor2 = System.Drawing.Color.White
        Me.PtComboBoxInput1.Properties.Appearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.PtComboBoxInput1.Properties.Appearance.Font = New System.Drawing.Font("Verdana", 8.5!)
        Me.PtComboBoxInput1.Properties.Appearance.Options.UseBackColor = True
        Me.PtComboBoxInput1.Properties.Appearance.Options.UseBorderColor = True
        Me.PtComboBoxInput1.Properties.Appearance.Options.UseFont = True
        Me.PtComboBoxInput1.Properties.AppearanceDisabled.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.PtComboBoxInput1.Properties.AppearanceDisabled.BackColor2 = System.Drawing.SystemColors.ControlLightLight
        Me.PtComboBoxInput1.Properties.AppearanceDisabled.BorderColor = System.Drawing.SystemColors.ControlLight
        Me.PtComboBoxInput1.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.DimGray
        Me.PtComboBoxInput1.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.PtComboBoxInput1.Properties.AppearanceDisabled.Options.UseBorderColor = True
        Me.PtComboBoxInput1.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.PtComboBoxInput1.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Verdana", 8.5!)
        Me.PtComboBoxInput1.Properties.AppearanceDropDown.Options.UseFont = True
        Me.PtComboBoxInput1.Properties.AppearanceFocused.BackColor = System.Drawing.Color.White
        Me.PtComboBoxInput1.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.White
        Me.PtComboBoxInput1.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PtComboBoxInput1.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.PtComboBoxInput1.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.PtComboBoxInput1.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.PtComboBoxInput1.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.PtComboBoxInput1.Properties.AppearanceReadOnly.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.PtComboBoxInput1.Properties.AppearanceReadOnly.BackColor2 = System.Drawing.SystemColors.ControlLightLight
        Me.PtComboBoxInput1.Properties.AppearanceReadOnly.BorderColor = System.Drawing.SystemColors.ControlLight
        Me.PtComboBoxInput1.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.DimGray
        Me.PtComboBoxInput1.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.PtComboBoxInput1.Properties.AppearanceReadOnly.Options.UseBorderColor = True
        Me.PtComboBoxInput1.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.PtComboBoxInput1.Properties.AutoHeight = False
        Me.PtComboBoxInput1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.PtComboBoxInput1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.PtComboBoxInput1.Size = New System.Drawing.Size(250, 24)
        Me.PtComboBoxInput1.TabIndex = 1
        Me.PtComboBoxInput1.TableField = ""
        Me.PtComboBoxInput1.TableName = ""
        '
        'PTComboBoxInputGroup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.PtComboBoxInput1)
        Me.Controls.Add(Me.PtLabelGrp1)
        Me.MaximumSize = New System.Drawing.Size(500, 45)
        Me.MinimumSize = New System.Drawing.Size(200, 45)
        Me.Name = "PTComboBoxInputGroup"
        Me.Size = New System.Drawing.Size(250, 45)
        CType(Me.PtComboBoxInput1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Protected Friend WithEvents PtLabelGrp1 As PTLabel
    Friend WithEvents PtComboBoxInput1 As PTComboBoxInput
End Class
