<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PTNumericInputGroup
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
        Me.PtNumericInput1 = New NewTemplate.PTNumericInput()
        CType(Me.PtNumericInput1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.PtLabelGrp1.TableField = ""
        Me.PtLabelGrp1.TableName = ""
        Me.PtLabelGrp1.Text = "PtLabel1"
        Me.PtLabelGrp1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PtNumericInput1
        '
        Me.PtNumericInput1.BackColor = System.Drawing.Color.Transparent
        Me.PtNumericInput1.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.PtNumericInput1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.PtNumericInput1.DecimalPlaces = 2
        Me.PtNumericInput1.DefaultValue = 0R
        Me.PtNumericInput1.DisabledState.BorderColor = System.Drawing.SystemColors.ControlLight
        Me.PtNumericInput1.DisabledState.FillColor = System.Drawing.SystemColors.ControlLightLight
        Me.PtNumericInput1.DisabledState.ForeColor = System.Drawing.Color.DimGray
        Me.PtNumericInput1.DisabledState.Parent = Me.PtNumericInput1
        Me.PtNumericInput1.DisabledState.UpDownButtonFillColor = System.Drawing.SystemColors.ControlLight
        Me.PtNumericInput1.DisabledState.UpDownButtonForeColor = System.Drawing.Color.DimGray
        Me.PtNumericInput1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PtNumericInput1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PtNumericInput1.FocusedState.FillColor = System.Drawing.Color.White
        Me.PtNumericInput1.FocusedState.ForeColor = System.Drawing.Color.Black
        Me.PtNumericInput1.FocusedState.Parent = Me.PtNumericInput1
        Me.PtNumericInput1.Font = New System.Drawing.Font("Verdana", 8.5!)
        Me.PtNumericInput1.ForeColor = System.Drawing.Color.Black
        Me.PtNumericInput1.Location = New System.Drawing.Point(0, 21)
        Me.PtNumericInput1.Maximum = New Decimal(New Integer() {99999999, 0, 0, 0})
        Me.PtNumericInput1.Minimum = New Decimal(New Integer() {999999999, 0, 0, -2147483648})
        Me.PtNumericInput1.Name = "PtNumericInput1"
        Me.PtNumericInput1.ShadowDecoration.Parent = Me.PtNumericInput1
        Me.PtNumericInput1.Size = New System.Drawing.Size(250, 24)
        Me.PtNumericInput1.TabIndex = 1
        Me.PtNumericInput1.TableField = ""
        Me.PtNumericInput1.TableName = ""
        Me.PtNumericInput1.ThousandsSeparator = True
        Me.PtNumericInput1.UpDownButtonFillColor = System.Drawing.Color.White
        Me.PtNumericInput1.UpDownButtonForeColor = System.Drawing.Color.Black
        '
        'PTNumericInputGroup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.PtNumericInput1)
        Me.Controls.Add(Me.PtLabelGrp1)
        Me.MaximumSize = New System.Drawing.Size(500, 45)
        Me.MinimumSize = New System.Drawing.Size(70, 45)
        Me.Name = "PTNumericInputGroup"
        Me.Size = New System.Drawing.Size(250, 45)
        CType(Me.PtNumericInput1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Protected Friend WithEvents PtLabelGrp1 As PTLabel
    Friend WithEvents PtNumericInput1 As PTNumericInput
End Class
