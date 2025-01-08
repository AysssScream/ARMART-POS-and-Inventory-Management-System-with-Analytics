<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class InventoryReports
    Inherits NewTemplate.ReportFormBase

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InventoryReports))
        Me.GunaButton1 = New Guna.UI.WinForms.GunaButton()
        Me.GunaButton2 = New Guna.UI.WinForms.GunaButton()
        Me.GunaButton3 = New Guna.UI.WinForms.GunaButton()
        Me.GunaButton4 = New Guna.UI.WinForms.GunaButton()
        Me.PtGridLookupEditGroup1 = New NewTemplate.PTGridLookupEditGroup()
        Me.Guna2GradientPanel1.SuspendLayout()
        Me.XtraTabPage2.SuspendLayout()
        Me.FilterPanel.SuspendLayout()
        Me.XtraTabPage3.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        Me.ReportPanel.SuspendLayout()
        CType(Me.XtraTabControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl2.SuspendLayout()
        CType(Me.XtraTabControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl3.SuspendLayout()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2GradientPanel1
        '
        Me.Guna2GradientPanel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.Guna2GradientPanel1.ShadowDecoration.Parent = Me.Guna2GradientPanel1
        '
        'lblHeaderTitle
        '
        Me.lblHeaderTitle.Text = "SALES REPORTS"
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Appearance.Header.Font = New System.Drawing.Font("Verdana", 8.5!, System.Drawing.FontStyle.Bold)
        Me.XtraTabPage2.Appearance.Header.Options.UseFont = True
        Me.XtraTabPage2.Appearance.PageClient.BackColor = System.Drawing.SystemColors.Control
        Me.XtraTabPage2.Appearance.PageClient.BackColor2 = System.Drawing.SystemColors.Control
        Me.XtraTabPage2.Appearance.PageClient.Options.UseBackColor = True
        Me.XtraTabPage2.Size = New System.Drawing.Size(343, 125)
        '
        'FilterPanel
        '
        Me.FilterPanel.Controls.Add(Me.PtGridLookupEditGroup1)
        Me.FilterPanel.Size = New System.Drawing.Size(343, 125)
        Me.FilterPanel.Controls.SetChildIndex(Me.PtDateFilter1, 0)
        Me.FilterPanel.Controls.SetChildIndex(Me.PtLabel1, 0)
        Me.FilterPanel.Controls.SetChildIndex(Me.PtGridLookupEditGroup1, 0)
        '
        'XtraTabPage3
        '
        Me.XtraTabPage3.Appearance.Header.Font = New System.Drawing.Font("Verdana", 8.5!, System.Drawing.FontStyle.Bold)
        Me.XtraTabPage3.Appearance.Header.Options.UseFont = True
        Me.XtraTabPage3.Appearance.PageClient.BackColor = System.Drawing.SystemColors.Control
        Me.XtraTabPage3.Appearance.PageClient.BackColor2 = System.Drawing.SystemColors.Control
        Me.XtraTabPage3.Appearance.PageClient.Options.UseBackColor = True
        Me.XtraTabPage3.Size = New System.Drawing.Size(843, 564)
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Appearance.Header.Font = New System.Drawing.Font("Verdana", 8.5!, System.Drawing.FontStyle.Bold)
        Me.XtraTabPage1.Appearance.Header.Options.UseFont = True
        Me.XtraTabPage1.Appearance.PageClient.BackColor = System.Drawing.SystemColors.Control
        Me.XtraTabPage1.Appearance.PageClient.BackColor2 = System.Drawing.SystemColors.Control
        Me.XtraTabPage1.Appearance.PageClient.Options.UseBackColor = True
        Me.XtraTabPage1.Size = New System.Drawing.Size(343, 411)
        '
        'ReportPanel
        '
        Me.ReportPanel.Controls.Add(Me.GunaButton4)
        Me.ReportPanel.Controls.Add(Me.GunaButton3)
        Me.ReportPanel.Controls.Add(Me.GunaButton2)
        Me.ReportPanel.Controls.Add(Me.GunaButton1)
        Me.ReportPanel.Size = New System.Drawing.Size(343, 411)
        '
        'PreviewPanel
        '
        Me.PreviewPanel.Size = New System.Drawing.Size(843, 511)
        '
        'PtDateFilter1
        '
        Me.PtDateFilter1.EditValue = " Like '%2023-11-06%'"
        Me.PtDateFilter1.TableField = "date_transh"
        Me.PtDateFilter1.TableName = "transaction_headers"
        Me.PtDateFilter1.Tag = "04/11/2023"
        '
        'XtraTabControl2
        '
        Me.XtraTabControl2.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.XtraTabControl2.Appearance.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.XtraTabControl2.Appearance.Options.UseBackColor = True
        Me.XtraTabControl2.Appearance.Options.UseFont = True
        Me.XtraTabControl2.AppearancePage.Header.Font = New System.Drawing.Font("Verdana", 8.5!)
        Me.XtraTabControl2.AppearancePage.Header.Options.UseFont = True
        Me.XtraTabControl2.AppearancePage.Header.Options.UseTextOptions = True
        Me.XtraTabControl2.AppearancePage.Header.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.XtraTabControl2.AppearancePage.Header.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.XtraTabControl2.Size = New System.Drawing.Size(349, 153)
        '
        'XtraTabControl3
        '
        Me.XtraTabControl3.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.XtraTabControl3.Appearance.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.XtraTabControl3.Appearance.Options.UseBackColor = True
        Me.XtraTabControl3.Appearance.Options.UseFont = True
        Me.XtraTabControl3.AppearancePage.Header.Font = New System.Drawing.Font("Verdana", 8.5!)
        Me.XtraTabControl3.AppearancePage.Header.Options.UseFont = True
        Me.XtraTabControl3.AppearancePage.Header.Options.UseTextOptions = True
        Me.XtraTabControl3.AppearancePage.Header.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.XtraTabControl3.AppearancePage.Header.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.XtraTabControl3.Size = New System.Drawing.Size(849, 592)
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.XtraTabControl1.Appearance.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.XtraTabControl1.Appearance.Options.UseBackColor = True
        Me.XtraTabControl1.Appearance.Options.UseFont = True
        Me.XtraTabControl1.AppearancePage.Header.Font = New System.Drawing.Font("Verdana", 8.5!)
        Me.XtraTabControl1.AppearancePage.Header.Options.UseFont = True
        Me.XtraTabControl1.AppearancePage.Header.Options.UseTextOptions = True
        Me.XtraTabControl1.AppearancePage.Header.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.XtraTabControl1.AppearancePage.Header.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.XtraTabControl1.Location = New System.Drawing.Point(3, 153)
        Me.XtraTabControl1.Size = New System.Drawing.Size(349, 439)
        '
        'GunaButton1
        '
        Me.GunaButton1.AnimationHoverSpeed = 0.07!
        Me.GunaButton1.AnimationSpeed = 0.03!
        Me.GunaButton1.BaseColor = System.Drawing.Color.Transparent
        Me.GunaButton1.BorderColor = System.Drawing.Color.Black
        Me.GunaButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GunaButton1.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton1.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GunaButton1.ForeColor = System.Drawing.Color.Black
        Me.GunaButton1.Image = Nothing
        Me.GunaButton1.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaButton1.Location = New System.Drawing.Point(0, 5)
        Me.GunaButton1.Name = "GunaButton1"
        Me.GunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GunaButton1.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButton1.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton1.OnHoverImage = Nothing
        Me.GunaButton1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton1.Size = New System.Drawing.Size(343, 32)
        Me.GunaButton1.TabIndex = 1
        Me.GunaButton1.Tag = "rptInventories"
        Me.GunaButton1.Text = "INVENTORY LIST"
        '
        'GunaButton2
        '
        Me.GunaButton2.AnimationHoverSpeed = 0.07!
        Me.GunaButton2.AnimationSpeed = 0.03!
        Me.GunaButton2.BaseColor = System.Drawing.Color.Transparent
        Me.GunaButton2.BorderColor = System.Drawing.Color.Black
        Me.GunaButton2.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GunaButton2.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton2.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GunaButton2.ForeColor = System.Drawing.Color.Black
        Me.GunaButton2.Image = Nothing
        Me.GunaButton2.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaButton2.Location = New System.Drawing.Point(0, 37)
        Me.GunaButton2.Name = "GunaButton2"
        Me.GunaButton2.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GunaButton2.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButton2.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton2.OnHoverImage = Nothing
        Me.GunaButton2.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton2.Size = New System.Drawing.Size(343, 32)
        Me.GunaButton2.TabIndex = 2
        Me.GunaButton2.Tag = "rptStockCard"
        Me.GunaButton2.Text = "STOCK CARD"
        '
        'GunaButton3
        '
        Me.GunaButton3.AnimationHoverSpeed = 0.07!
        Me.GunaButton3.AnimationSpeed = 0.03!
        Me.GunaButton3.BaseColor = System.Drawing.Color.Transparent
        Me.GunaButton3.BorderColor = System.Drawing.Color.Black
        Me.GunaButton3.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton3.Dock = System.Windows.Forms.DockStyle.Top
        Me.GunaButton3.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton3.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GunaButton3.ForeColor = System.Drawing.Color.Black
        Me.GunaButton3.Image = Nothing
        Me.GunaButton3.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaButton3.Location = New System.Drawing.Point(0, 69)
        Me.GunaButton3.Name = "GunaButton3"
        Me.GunaButton3.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GunaButton3.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButton3.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton3.OnHoverImage = Nothing
        Me.GunaButton3.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton3.Size = New System.Drawing.Size(343, 32)
        Me.GunaButton3.TabIndex = 3
        Me.GunaButton3.Tag = "rptCriticalStocks"
        Me.GunaButton3.Text = "CRITICAL STOCKS"
        '
        'GunaButton4
        '
        Me.GunaButton4.AnimationHoverSpeed = 0.07!
        Me.GunaButton4.AnimationSpeed = 0.03!
        Me.GunaButton4.BaseColor = System.Drawing.Color.Transparent
        Me.GunaButton4.BorderColor = System.Drawing.Color.Black
        Me.GunaButton4.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton4.Dock = System.Windows.Forms.DockStyle.Top
        Me.GunaButton4.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton4.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GunaButton4.ForeColor = System.Drawing.Color.Black
        Me.GunaButton4.Image = Nothing
        Me.GunaButton4.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaButton4.Location = New System.Drawing.Point(0, 101)
        Me.GunaButton4.Name = "GunaButton4"
        Me.GunaButton4.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GunaButton4.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButton4.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton4.OnHoverImage = Nothing
        Me.GunaButton4.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton4.Size = New System.Drawing.Size(343, 32)
        Me.GunaButton4.TabIndex = 4
        Me.GunaButton4.Tag = "rptStockOuts"
        Me.GunaButton4.Text = "STOCK OUTS"
        '
        'PtGridLookupEditGroup1
        '
        Me.PtGridLookupEditGroup1.EditValue = Nothing
        Me.PtGridLookupEditGroup1.Location = New System.Drawing.Point(14, 70)
        Me.PtGridLookupEditGroup1.MaximumSize = New System.Drawing.Size(500, 45)
        Me.PtGridLookupEditGroup1.MinimumSize = New System.Drawing.Size(200, 45)
        Me.PtGridLookupEditGroup1.Name = "PtGridLookupEditGroup1"
        Me.PtGridLookupEditGroup1.Size = New System.Drawing.Size(200, 45)
        Me.PtGridLookupEditGroup1.TabIndex = 5
        Me.PtGridLookupEditGroup1.TableColumnDefinitionString = "|key" & Global.Microsoft.VisualBasic.ChrW(9) & "|caption" & Global.Microsoft.VisualBasic.ChrW(9) & "|fieldname" & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & "|width" & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & "|return textbox" & Global.Microsoft.VisualBasic.ChrW(9) & "|dataformat" & Global.Microsoft.VisualBasic.ChrW(9) & "|input source" & Global.Microsoft.VisualBasic.ChrW(9) & "|outp" &
    "ut field" & Global.Microsoft.VisualBasic.ChrW(9) & "|default value" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "@" & Global.Microsoft.VisualBasic.ChrW(9) & "|pk" & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & "|pk_invty" & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & "|0" & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & "|" & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & "|" & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & "|" & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & "|" & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & "|" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "@" & Global.Microsoft.VisualBasic.ChrW(9) & "|description" & Global.Microsoft.VisualBasic.ChrW(9) & "|de" &
    "scription_invty" & Global.Microsoft.VisualBasic.ChrW(9) & "|250-" & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & "|" & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & "|" & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & "|" & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & "|" & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & "|"
        Me.PtGridLookupEditGroup1.TableDisplayField = "description_invty"
        Me.PtGridLookupEditGroup1.TableField = "pk_invty"
        Me.PtGridLookupEditGroup1.TableFromString = "|from inventories |order by description_invty"
        Me.PtGridLookupEditGroup1.TableLabel = "Product"
        Me.PtGridLookupEditGroup1.TableName = "inventories"
        Me.PtGridLookupEditGroup1.TableValueMember = "pk_invty"
        '
        'InventoryReports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1215, 626)
        Me.Name = "InventoryReports"
        Me.Guna2GradientPanel1.ResumeLayout(False)
        Me.XtraTabPage2.ResumeLayout(False)
        Me.FilterPanel.ResumeLayout(False)
        Me.FilterPanel.PerformLayout()
        Me.XtraTabPage3.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        Me.ReportPanel.ResumeLayout(False)
        CType(Me.XtraTabControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl2.ResumeLayout(False)
        CType(Me.XtraTabControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl3.ResumeLayout(False)
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GunaButton1 As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaButton2 As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaButton3 As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaButton4 As Guna.UI.WinForms.GunaButton
    Friend WithEvents PtGridLookupEditGroup1 As PTGridLookupEditGroup
End Class
