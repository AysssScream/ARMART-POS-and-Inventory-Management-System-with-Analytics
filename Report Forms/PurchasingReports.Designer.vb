<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PurchasingReports
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PurchasingReports))
        Me.GunaButton1 = New Guna.UI.WinForms.GunaButton()
        Me.GunaButton2 = New Guna.UI.WinForms.GunaButton()
        Me.GunaButton3 = New Guna.UI.WinForms.GunaButton()
        Me.PtGridLookupEditGroup1 = New NewTemplate.PTGridLookupEditGroup()
        Me.LineSeparator = New Guna.UI.WinForms.GunaButton()
        Me.GunaButton4 = New Guna.UI.WinForms.GunaButton()
        Me.GunaButton5 = New Guna.UI.WinForms.GunaButton()
        Me.GunaButton6 = New Guna.UI.WinForms.GunaButton()
        Me.GunaButton7 = New Guna.UI.WinForms.GunaButton()
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
        Me.lblHeaderTitle.Text = "PURCHASING REPORTS"
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Appearance.Header.Font = New System.Drawing.Font("Verdana", 8.5!, System.Drawing.FontStyle.Bold)
        Me.XtraTabPage2.Appearance.Header.Options.UseFont = True
        Me.XtraTabPage2.Appearance.PageClient.BackColor = System.Drawing.SystemColors.Control
        Me.XtraTabPage2.Appearance.PageClient.BackColor2 = System.Drawing.SystemColors.Control
        Me.XtraTabPage2.Appearance.PageClient.Options.UseBackColor = True
        Me.XtraTabPage2.Size = New System.Drawing.Size(343, 132)
        '
        'FilterPanel
        '
        Me.FilterPanel.Controls.Add(Me.PtGridLookupEditGroup1)
        Me.FilterPanel.Size = New System.Drawing.Size(343, 132)
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
        Me.XtraTabPage3.Size = New System.Drawing.Size(843, 487)
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Appearance.Header.Font = New System.Drawing.Font("Verdana", 8.5!, System.Drawing.FontStyle.Bold)
        Me.XtraTabPage1.Appearance.Header.Options.UseFont = True
        Me.XtraTabPage1.Appearance.PageClient.BackColor = System.Drawing.SystemColors.Control
        Me.XtraTabPage1.Appearance.PageClient.BackColor2 = System.Drawing.SystemColors.Control
        Me.XtraTabPage1.Appearance.PageClient.Options.UseBackColor = True
        Me.XtraTabPage1.Size = New System.Drawing.Size(343, 327)
        '
        'ReportPanel
        '
        Me.ReportPanel.Controls.Add(Me.GunaButton7)
        Me.ReportPanel.Controls.Add(Me.GunaButton6)
        Me.ReportPanel.Controls.Add(Me.GunaButton5)
        Me.ReportPanel.Controls.Add(Me.GunaButton4)
        Me.ReportPanel.Controls.Add(Me.LineSeparator)
        Me.ReportPanel.Controls.Add(Me.GunaButton3)
        Me.ReportPanel.Controls.Add(Me.GunaButton2)
        Me.ReportPanel.Controls.Add(Me.GunaButton1)
        Me.ReportPanel.Size = New System.Drawing.Size(343, 327)
        '
        'PreviewPanel
        '
        Me.PreviewPanel.Size = New System.Drawing.Size(843, 434)
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
        Me.XtraTabControl2.Size = New System.Drawing.Size(349, 160)
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
        Me.XtraTabControl3.Size = New System.Drawing.Size(849, 515)
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
        Me.XtraTabControl1.Location = New System.Drawing.Point(3, 160)
        Me.XtraTabControl1.Size = New System.Drawing.Size(349, 355)
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
        Me.GunaButton1.Tag = "rptDailyPurchaseOrders"
        Me.GunaButton1.Text = "DAILY PURCHASE ORDERS"
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
        Me.GunaButton2.Tag = "rptDailyPurchaseOrdersSummaryByTransactions"
        Me.GunaButton2.Text = "DAILY PURCHASE ORDERS SUMMARY BY TRANSACTIONS"
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
        Me.GunaButton3.Tag = "rptDailyPurchaseOrdersSummaryByItems"
        Me.GunaButton3.Text = "DAILY PURCHASE ORDERS SUMMARY BY ITEMS"
        '
        'PtGridLookupEditGroup1
        '
        Me.PtGridLookupEditGroup1.EditValue = Nothing
        Me.PtGridLookupEditGroup1.Location = New System.Drawing.Point(14, 70)
        Me.PtGridLookupEditGroup1.MaximumSize = New System.Drawing.Size(500, 45)
        Me.PtGridLookupEditGroup1.MinimumSize = New System.Drawing.Size(200, 45)
        Me.PtGridLookupEditGroup1.Name = "PtGridLookupEditGroup1"
        Me.PtGridLookupEditGroup1.Size = New System.Drawing.Size(200, 45)
        Me.PtGridLookupEditGroup1.TabIndex = 4
        Me.PtGridLookupEditGroup1.TableColumnDefinitionString = resources.GetString("PtGridLookupEditGroup1.TableColumnDefinitionString")
        Me.PtGridLookupEditGroup1.TableDisplayField = "name_um"
        Me.PtGridLookupEditGroup1.TableField = "fk_um_transh"
        Me.PtGridLookupEditGroup1.TableFromString = "|from universal_masters |where module_um = 'supplier' |order by name_um"
        Me.PtGridLookupEditGroup1.TableLabel = "Supplier"
        Me.PtGridLookupEditGroup1.TableName = "transaction_headers"
        Me.PtGridLookupEditGroup1.TableValueMember = "pk_um"
        '
        'LineSeparator
        '
        Me.LineSeparator.AnimationHoverSpeed = 0.07!
        Me.LineSeparator.AnimationSpeed = 0.03!
        Me.LineSeparator.BackColor = System.Drawing.Color.Gainsboro
        Me.LineSeparator.BaseColor = System.Drawing.Color.Transparent
        Me.LineSeparator.BorderColor = System.Drawing.Color.Black
        Me.LineSeparator.DialogResult = System.Windows.Forms.DialogResult.None
        Me.LineSeparator.Dock = System.Windows.Forms.DockStyle.Top
        Me.LineSeparator.Enabled = False
        Me.LineSeparator.FocusedColor = System.Drawing.Color.Empty
        Me.LineSeparator.Font = New System.Drawing.Font("Verdana", 8.5!)
        Me.LineSeparator.ForeColor = System.Drawing.Color.Black
        Me.LineSeparator.Image = Nothing
        Me.LineSeparator.ImageSize = New System.Drawing.Size(20, 20)
        Me.LineSeparator.Location = New System.Drawing.Point(0, 101)
        Me.LineSeparator.Name = "LineSeparator"
        Me.LineSeparator.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.LineSeparator.OnHoverBorderColor = System.Drawing.Color.Black
        Me.LineSeparator.OnHoverForeColor = System.Drawing.Color.White
        Me.LineSeparator.OnHoverImage = Nothing
        Me.LineSeparator.OnPressedColor = System.Drawing.Color.Black
        Me.LineSeparator.Size = New System.Drawing.Size(343, 2)
        Me.LineSeparator.TabIndex = 4
        Me.LineSeparator.Tag = ""
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
        Me.GunaButton4.Location = New System.Drawing.Point(0, 103)
        Me.GunaButton4.Name = "GunaButton4"
        Me.GunaButton4.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GunaButton4.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButton4.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton4.OnHoverImage = Nothing
        Me.GunaButton4.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton4.Size = New System.Drawing.Size(343, 32)
        Me.GunaButton4.TabIndex = 5
        Me.GunaButton4.Tag = "rptDailyPurchaseReceivings"
        Me.GunaButton4.Text = "DAILY PURCHASE RECEIVINGS"
        '
        'GunaButton5
        '
        Me.GunaButton5.AnimationHoverSpeed = 0.07!
        Me.GunaButton5.AnimationSpeed = 0.03!
        Me.GunaButton5.BaseColor = System.Drawing.Color.Transparent
        Me.GunaButton5.BorderColor = System.Drawing.Color.Black
        Me.GunaButton5.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton5.Dock = System.Windows.Forms.DockStyle.Top
        Me.GunaButton5.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton5.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GunaButton5.ForeColor = System.Drawing.Color.Black
        Me.GunaButton5.Image = Nothing
        Me.GunaButton5.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaButton5.Location = New System.Drawing.Point(0, 135)
        Me.GunaButton5.Name = "GunaButton5"
        Me.GunaButton5.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GunaButton5.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButton5.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton5.OnHoverImage = Nothing
        Me.GunaButton5.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton5.Size = New System.Drawing.Size(343, 32)
        Me.GunaButton5.TabIndex = 6
        Me.GunaButton5.Tag = "rptDailyPurchaseReceivingsSummaryByTransactions"
        Me.GunaButton5.Text = "DAILY PURCHASE RECEIVINGS SUMMARY BY TRANSACTIONS"
        '
        'GunaButton6
        '
        Me.GunaButton6.AnimationHoverSpeed = 0.07!
        Me.GunaButton6.AnimationSpeed = 0.03!
        Me.GunaButton6.BaseColor = System.Drawing.Color.Transparent
        Me.GunaButton6.BorderColor = System.Drawing.Color.Black
        Me.GunaButton6.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton6.Dock = System.Windows.Forms.DockStyle.Top
        Me.GunaButton6.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton6.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GunaButton6.ForeColor = System.Drawing.Color.Black
        Me.GunaButton6.Image = Nothing
        Me.GunaButton6.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaButton6.Location = New System.Drawing.Point(0, 167)
        Me.GunaButton6.Name = "GunaButton6"
        Me.GunaButton6.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GunaButton6.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButton6.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton6.OnHoverImage = Nothing
        Me.GunaButton6.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton6.Size = New System.Drawing.Size(343, 32)
        Me.GunaButton6.TabIndex = 7
        Me.GunaButton6.Tag = "rptDailyPurchaseReceivingsSummaryByItems"
        Me.GunaButton6.Text = "DAILY PURCHASE RECEIVINGS SUMMARY BY ITEMS"
        '
        'GunaButton7
        '
        Me.GunaButton7.AnimationHoverSpeed = 0.07!
        Me.GunaButton7.AnimationSpeed = 0.03!
        Me.GunaButton7.BackColor = System.Drawing.Color.Gainsboro
        Me.GunaButton7.BaseColor = System.Drawing.Color.Transparent
        Me.GunaButton7.BorderColor = System.Drawing.Color.Black
        Me.GunaButton7.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton7.Dock = System.Windows.Forms.DockStyle.Top
        Me.GunaButton7.Enabled = False
        Me.GunaButton7.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton7.Font = New System.Drawing.Font("Verdana", 8.5!)
        Me.GunaButton7.ForeColor = System.Drawing.Color.Black
        Me.GunaButton7.Image = Nothing
        Me.GunaButton7.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaButton7.Location = New System.Drawing.Point(0, 199)
        Me.GunaButton7.Name = "GunaButton7"
        Me.GunaButton7.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GunaButton7.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButton7.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton7.OnHoverImage = Nothing
        Me.GunaButton7.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton7.Size = New System.Drawing.Size(343, 2)
        Me.GunaButton7.TabIndex = 8
        Me.GunaButton7.Tag = ""
        '
        'PurchasingReports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1215, 549)
        Me.Name = "PurchasingReports"
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
    Friend WithEvents PtGridLookupEditGroup1 As PTGridLookupEditGroup
    Friend WithEvents LineSeparator As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaButton4 As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaButton5 As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaButton6 As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaButton7 As Guna.UI.WinForms.GunaButton
End Class
