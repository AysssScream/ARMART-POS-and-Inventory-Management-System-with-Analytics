<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ProductListView
    Inherits NewTemplate.ListView

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ProductListView))
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Location = New System.Drawing.Point(877, 30)
        Me.Panel2.Size = New System.Drawing.Size(338, 42)
        '
        'btnPrint
        '
        Me.btnPrint.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.DefaultButton
        Me.btnPrint.CheckedState.Parent = Me.btnPrint
        Me.btnPrint.CustomImages.Parent = Me.btnPrint
        Me.btnPrint.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnPrint.FillColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.btnPrint.HoverState.Parent = Me.btnPrint
        Me.btnPrint.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btnPrint.ShadowDecoration.Parent = Me.btnPrint
        Me.btnPrint.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btnPrint.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit
        Me.btnPrint.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.None
        '
        'btnExcel
        '
        Me.btnExcel.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.DefaultButton
        Me.btnExcel.CheckedState.Parent = Me.btnExcel
        Me.btnExcel.CustomImages.Parent = Me.btnExcel
        Me.btnExcel.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnExcel.FillColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.btnExcel.HoverState.Parent = Me.btnExcel
        Me.btnExcel.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btnExcel.Location = New System.Drawing.Point(124, 5)
        Me.btnExcel.ShadowDecoration.Parent = Me.btnExcel
        Me.btnExcel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btnExcel.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit
        Me.btnExcel.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.None
        '
        'btnAddNew
        '
        Me.btnAddNew.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.DefaultButton
        Me.btnAddNew.CheckedState.Parent = Me.btnAddNew
        Me.btnAddNew.CustomImages.Parent = Me.btnAddNew
        Me.btnAddNew.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnAddNew.FillColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.btnAddNew.HoverState.Parent = Me.btnAddNew
        Me.btnAddNew.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btnAddNew.Location = New System.Drawing.Point(236, 5)
        Me.btnAddNew.ShadowDecoration.Parent = Me.btnAddNew
        Me.btnAddNew.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btnAddNew.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit
        Me.btnAddNew.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.None
        '
        'lblHeaderTitle
        '
        Me.lblHeaderTitle.Text = "PRODUCTS"
        '
        'SearchBox
        '
        Me.SearchBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.SearchBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.SearchBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.SearchBox.DisabledState.Parent = Me.SearchBox
        Me.SearchBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.SearchBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SearchBox.FocusedState.Parent = Me.SearchBox
        Me.SearchBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SearchBox.HoverState.Parent = Me.SearchBox
        Me.SearchBox.ShadowDecoration.Parent = Me.SearchBox
        '
        'ProductListView
        '
        Me.AddNewForm = "Product"
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(1215, 489)
        Me.Name = "ProductListView"
        Me.RecordPKCell = "pk_invty"
        Me.SearchFormColumnDefinitionInfo = resources.GetString("$this.SearchFormColumnDefinitionInfo")
        Me.SearchFormTableFromInfo = "|from inventories left join categories on fk_cat_invty = pk_cat |order by descrip" &
    "tion_invty"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
End Class
