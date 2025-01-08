<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class OrderItem
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
        Me.MainPanel = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ItemTaxAmount = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.AddDescription = New System.Windows.Forms.Label()
        Me.ItemDiscountAmount = New System.Windows.Forms.Label()
        Me.ItemPanel = New System.Windows.Forms.Panel()
        Me.ItemName = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ItemQty = New System.Windows.Forms.Label()
        Me.ItemTotalPrice = New System.Windows.Forms.Label()
        Me.ItemUnit = New System.Windows.Forms.Label()
        Me.ItemUnitPrice = New System.Windows.Forms.Label()
        Me.MainPanel.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.ItemPanel.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MainPanel
        '
        Me.MainPanel.AutoSize = True
        Me.MainPanel.BackColor = System.Drawing.SystemColors.ControlLight
        Me.MainPanel.BorderRadius = 10
        Me.MainPanel.Controls.Add(Me.Panel3)
        Me.MainPanel.Controls.Add(Me.Panel2)
        Me.MainPanel.Controls.Add(Me.ItemPanel)
        Me.MainPanel.Location = New System.Drawing.Point(0, 0)
        Me.MainPanel.Name = "MainPanel"
        Me.MainPanel.Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.MainPanel.ShadowDecoration.Parent = Me.MainPanel
        Me.MainPanel.Size = New System.Drawing.Size(340, 60)
        Me.MainPanel.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.ItemTaxAmount)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(5, 41)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.Panel3.Size = New System.Drawing.Size(330, 16)
        Me.Panel3.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Verdana", 7.5!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.Gray
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(15, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(225, 16)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Tax"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ItemTaxAmount
        '
        Me.ItemTaxAmount.Dock = System.Windows.Forms.DockStyle.Right
        Me.ItemTaxAmount.Font = New System.Drawing.Font("Verdana", 7.5!, System.Drawing.FontStyle.Bold)
        Me.ItemTaxAmount.ForeColor = System.Drawing.Color.Gray
        Me.ItemTaxAmount.Location = New System.Drawing.Point(240, 0)
        Me.ItemTaxAmount.Name = "ItemTaxAmount"
        Me.ItemTaxAmount.Size = New System.Drawing.Size(90, 16)
        Me.ItemTaxAmount.TabIndex = 3
        Me.ItemTaxAmount.Text = "0.00"
        Me.ItemTaxAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.AddDescription)
        Me.Panel2.Controls.Add(Me.ItemDiscountAmount)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(5, 25)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.Panel2.Size = New System.Drawing.Size(330, 16)
        Me.Panel2.TabIndex = 2
        '
        'AddDescription
        '
        Me.AddDescription.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AddDescription.Font = New System.Drawing.Font("Verdana", 7.5!, System.Drawing.FontStyle.Bold)
        Me.AddDescription.ForeColor = System.Drawing.Color.Gray
        Me.AddDescription.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.AddDescription.Location = New System.Drawing.Point(15, 0)
        Me.AddDescription.Name = "AddDescription"
        Me.AddDescription.Size = New System.Drawing.Size(225, 16)
        Me.AddDescription.TabIndex = 7
        Me.AddDescription.Text = "Discount"
        Me.AddDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ItemDiscountAmount
        '
        Me.ItemDiscountAmount.Dock = System.Windows.Forms.DockStyle.Right
        Me.ItemDiscountAmount.Font = New System.Drawing.Font("Verdana", 7.5!, System.Drawing.FontStyle.Bold)
        Me.ItemDiscountAmount.ForeColor = System.Drawing.Color.Gray
        Me.ItemDiscountAmount.Location = New System.Drawing.Point(240, 0)
        Me.ItemDiscountAmount.Name = "ItemDiscountAmount"
        Me.ItemDiscountAmount.Size = New System.Drawing.Size(90, 16)
        Me.ItemDiscountAmount.TabIndex = 3
        Me.ItemDiscountAmount.Text = "0.00"
        Me.ItemDiscountAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ItemPanel
        '
        Me.ItemPanel.Controls.Add(Me.ItemName)
        Me.ItemPanel.Controls.Add(Me.Panel1)
        Me.ItemPanel.Controls.Add(Me.ItemTotalPrice)
        Me.ItemPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.ItemPanel.Location = New System.Drawing.Point(5, 0)
        Me.ItemPanel.Name = "ItemPanel"
        Me.ItemPanel.Size = New System.Drawing.Size(330, 25)
        Me.ItemPanel.TabIndex = 1
        '
        'ItemName
        '
        Me.ItemName.AutoEllipsis = True
        Me.ItemName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ItemName.Font = New System.Drawing.Font("Verdana", 7.5!, System.Drawing.FontStyle.Bold)
        Me.ItemName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ItemName.Location = New System.Drawing.Point(0, 0)
        Me.ItemName.Name = "ItemName"
        Me.ItemName.Size = New System.Drawing.Size(131, 25)
        Me.ItemName.TabIndex = 5
        Me.ItemName.Text = "Item"
        Me.ItemName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.ItemUnitPrice)
        Me.Panel1.Controls.Add(Me.ItemUnit)
        Me.Panel1.Controls.Add(Me.ItemQty)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(131, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(125, 25)
        Me.Panel1.TabIndex = 4
        '
        'ItemQty
        '
        Me.ItemQty.AutoEllipsis = True
        Me.ItemQty.Dock = System.Windows.Forms.DockStyle.Left
        Me.ItemQty.Font = New System.Drawing.Font("Verdana", 7.5!, System.Drawing.FontStyle.Bold)
        Me.ItemQty.Location = New System.Drawing.Point(0, 0)
        Me.ItemQty.Name = "ItemQty"
        Me.ItemQty.Size = New System.Drawing.Size(38, 25)
        Me.ItemQty.TabIndex = 5
        Me.ItemQty.Text = "0"
        Me.ItemQty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ItemTotalPrice
        '
        Me.ItemTotalPrice.Dock = System.Windows.Forms.DockStyle.Right
        Me.ItemTotalPrice.Font = New System.Drawing.Font("Verdana", 7.5!, System.Drawing.FontStyle.Bold)
        Me.ItemTotalPrice.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ItemTotalPrice.Location = New System.Drawing.Point(256, 0)
        Me.ItemTotalPrice.Name = "ItemTotalPrice"
        Me.ItemTotalPrice.Size = New System.Drawing.Size(74, 25)
        Me.ItemTotalPrice.TabIndex = 1
        Me.ItemTotalPrice.Text = "0.00"
        Me.ItemTotalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ItemUnit
        '
        Me.ItemUnit.AutoEllipsis = True
        Me.ItemUnit.Dock = System.Windows.Forms.DockStyle.Left
        Me.ItemUnit.Font = New System.Drawing.Font("Verdana", 7.5!, System.Drawing.FontStyle.Bold)
        Me.ItemUnit.Location = New System.Drawing.Point(38, 0)
        Me.ItemUnit.Name = "ItemUnit"
        Me.ItemUnit.Size = New System.Drawing.Size(25, 25)
        Me.ItemUnit.TabIndex = 6
        Me.ItemUnit.Text = "Unit"
        Me.ItemUnit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ItemUnitPrice
        '
        Me.ItemUnitPrice.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ItemUnitPrice.Font = New System.Drawing.Font("Verdana", 7.5!, System.Drawing.FontStyle.Bold)
        Me.ItemUnitPrice.Location = New System.Drawing.Point(63, 0)
        Me.ItemUnitPrice.Name = "ItemUnitPrice"
        Me.ItemUnitPrice.Size = New System.Drawing.Size(62, 25)
        Me.ItemUnitPrice.TabIndex = 7
        Me.ItemUnitPrice.Text = "@"
        Me.ItemUnitPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'OrderItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.MainPanel)
        Me.Name = "OrderItem"
        Me.Padding = New System.Windows.Forms.Padding(0, 0, 0, 5)
        Me.Size = New System.Drawing.Size(343, 68)
        Me.MainPanel.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ItemPanel.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ItemPanel As Panel
    Friend WithEvents ItemName As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ItemTotalPrice As Label
    Friend WithEvents MainPanel As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents ItemQty As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ItemDiscountAmount As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents ItemTaxAmount As Label
    Friend WithEvents AddDescription As Label
    Friend WithEvents ItemUnitPrice As Label
    Friend WithEvents ItemUnit As Label
End Class
