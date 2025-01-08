<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TopSellingProduct
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TopSellingProduct))
        Me.lblProduct = New System.Windows.Forms.Label()
        Me.lblCategory = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Qty = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblNo = New System.Windows.Forms.Label()
        Me.pbWarning = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.pbWarning, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblProduct
        '
        Me.lblProduct.AutoEllipsis = True
        Me.lblProduct.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProduct.ForeColor = System.Drawing.Color.White
        Me.lblProduct.Location = New System.Drawing.Point(66, 15)
        Me.lblProduct.Name = "lblProduct"
        Me.lblProduct.Size = New System.Drawing.Size(370, 23)
        Me.lblProduct.TabIndex = 1
        Me.lblProduct.Text = "lblProduct"
        Me.lblProduct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCategory
        '
        Me.lblCategory.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.lblCategory.ForeColor = System.Drawing.Color.Silver
        Me.lblCategory.Location = New System.Drawing.Point(67, 38)
        Me.lblCategory.Name = "lblCategory"
        Me.lblCategory.Size = New System.Drawing.Size(161, 23)
        Me.lblCategory.TabIndex = 2
        Me.lblCategory.Text = "lblCategory"
        Me.lblCategory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTotal
        '
        Me.lblTotal.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblTotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.lblTotal.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.Color.White
        Me.lblTotal.Location = New System.Drawing.Point(273, 38)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(99, 27)
        Me.lblTotal.TabIndex = 3
        Me.lblTotal.Text = "lblTotal"
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.Guna2Panel1.BorderColor = System.Drawing.Color.Transparent
        Me.Guna2Panel1.BorderRadius = 20
        Me.Guna2Panel1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash
        Me.Guna2Panel1.BorderThickness = 1
        Me.Guna2Panel1.Controls.Add(Me.pbWarning)
        Me.Guna2Panel1.Controls.Add(Me.lblNo)
        Me.Guna2Panel1.Controls.Add(Me.Label1)
        Me.Guna2Panel1.Controls.Add(Me.Qty)
        Me.Guna2Panel1.Controls.Add(Me.lblTotal)
        Me.Guna2Panel1.Controls.Add(Me.lblCategory)
        Me.Guna2Panel1.Controls.Add(Me.lblProduct)
        Me.Guna2Panel1.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Guna2Panel1.Location = New System.Drawing.Point(13, 4)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(442, 70)
        Me.Guna2Panel1.TabIndex = 0
        '
        'Qty
        '
        Me.Qty.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.Qty.ForeColor = System.Drawing.Color.White
        Me.Qty.Location = New System.Drawing.Point(246, 39)
        Me.Qty.Name = "Qty"
        Me.Qty.Size = New System.Drawing.Size(62, 23)
        Me.Qty.TabIndex = 4
        Me.Qty.Text = "Quantity:"
        Me.Qty.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Qty.Visible = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Verdana", 14.0!)
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(0, -3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 76)
        Me.Label1.TabIndex = 5
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblNo
        '
        Me.lblNo.Font = New System.Drawing.Font("Segoe UI Black", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNo.ForeColor = System.Drawing.SystemColors.Control
        Me.lblNo.Location = New System.Drawing.Point(8, 12)
        Me.lblNo.Name = "lblNo"
        Me.lblNo.Size = New System.Drawing.Size(43, 41)
        Me.lblNo.TabIndex = 6
        Me.lblNo.Text = "1"
        Me.lblNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pbWarning
        '
        Me.pbWarning.Image = CType(resources.GetObject("pbWarning.Image"), System.Drawing.Image)
        Me.pbWarning.Location = New System.Drawing.Point(8, 12)
        Me.pbWarning.Name = "pbWarning"
        Me.pbWarning.ShadowDecoration.Parent = Me.pbWarning
        Me.pbWarning.Size = New System.Drawing.Size(53, 49)
        Me.pbWarning.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbWarning.TabIndex = 7
        Me.pbWarning.TabStop = False
        Me.pbWarning.Visible = False
        '
        'TopSellingProduct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Name = "TopSellingProduct"
        Me.Padding = New System.Windows.Forms.Padding(10, 0, 0, 5)
        Me.Size = New System.Drawing.Size(471, 82)
        Me.Guna2Panel1.ResumeLayout(False)
        CType(Me.pbWarning, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblProduct As Label
    Friend WithEvents lblCategory As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Qty As Label
    Friend WithEvents lblNo As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents pbWarning As Guna.UI2.WinForms.Guna2PictureBox
End Class
