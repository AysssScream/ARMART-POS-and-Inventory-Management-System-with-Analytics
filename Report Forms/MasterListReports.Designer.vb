<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MasterListReports
    Inherits NewTemplate.ReportFormBase

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MasterListReports))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GunaButton1 = New Guna.UI.WinForms.GunaButton()
        Me.GunaButton2 = New Guna.UI.WinForms.GunaButton()
        Me.GunaButton5 = New Guna.UI.WinForms.GunaButton()
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
        Me.lblHeaderTitle.Text = "MASTER LIST REPORTS"
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Appearance.Header.Font = New System.Drawing.Font("Verdana", 8.5!, System.Drawing.FontStyle.Bold)
        Me.XtraTabPage2.Appearance.Header.Options.UseFont = True
        Me.XtraTabPage2.Appearance.PageClient.BackColor = System.Drawing.SystemColors.Control
        Me.XtraTabPage2.Appearance.PageClient.BackColor2 = System.Drawing.SystemColors.Control
        Me.XtraTabPage2.Appearance.PageClient.Options.UseBackColor = True
        Me.XtraTabPage2.Size = New System.Drawing.Size(343, 58)
        '
        'FilterPanel
        '
        Me.FilterPanel.Controls.Add(Me.Label1)
        Me.FilterPanel.Size = New System.Drawing.Size(343, 58)
        Me.FilterPanel.Controls.SetChildIndex(Me.PtDateFilter1, 0)
        Me.FilterPanel.Controls.SetChildIndex(Me.PtLabel1, 0)
        Me.FilterPanel.Controls.SetChildIndex(Me.Label1, 0)
        '
        'XtraTabPage3
        '
        Me.XtraTabPage3.Appearance.Header.Font = New System.Drawing.Font("Verdana", 8.5!, System.Drawing.FontStyle.Bold)
        Me.XtraTabPage3.Appearance.Header.Options.UseFont = True
        Me.XtraTabPage3.Appearance.PageClient.BackColor = System.Drawing.SystemColors.Control
        Me.XtraTabPage3.Appearance.PageClient.BackColor2 = System.Drawing.SystemColors.Control
        Me.XtraTabPage3.Appearance.PageClient.Options.UseBackColor = True
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Appearance.Header.Font = New System.Drawing.Font("Verdana", 8.5!, System.Drawing.FontStyle.Bold)
        Me.XtraTabPage1.Appearance.Header.Options.UseFont = True
        Me.XtraTabPage1.Appearance.PageClient.BackColor = System.Drawing.SystemColors.Control
        Me.XtraTabPage1.Appearance.PageClient.BackColor2 = System.Drawing.SystemColors.Control
        Me.XtraTabPage1.Appearance.PageClient.Options.UseBackColor = True
        Me.XtraTabPage1.Size = New System.Drawing.Size(343, 362)
        '
        'ReportPanel
        '
        Me.ReportPanel.Controls.Add(Me.GunaButton5)
        Me.ReportPanel.Controls.Add(Me.GunaButton2)
        Me.ReportPanel.Controls.Add(Me.GunaButton1)
        Me.ReportPanel.Size = New System.Drawing.Size(343, 362)
        '
        'PtDateFilter1
        '
        Me.PtDateFilter1.EditValue = " Like '%2023-12-03%'"
        Me.PtDateFilter1.Location = New System.Drawing.Point(8, 101)
        Me.PtDateFilter1.Tag = "12/03/2023"
        Me.PtDateFilter1.Visible = False
        '
        'PtLabel1
        '
        Me.PtLabel1.Location = New System.Drawing.Point(8, 84)
        Me.PtLabel1.Visible = False
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
        Me.XtraTabControl2.Size = New System.Drawing.Size(349, 86)
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
        Me.XtraTabControl1.Location = New System.Drawing.Point(3, 86)
        Me.XtraTabControl1.Size = New System.Drawing.Size(349, 390)
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(343, 50)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "No Available Filters"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.GunaButton1.Tag = "rptProducts"
        Me.GunaButton1.Text = "PRODUCTS"
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
        Me.GunaButton2.Tag = "rptSuppliers"
        Me.GunaButton2.Text = "SUPPLIERS"
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
        Me.GunaButton5.Location = New System.Drawing.Point(0, 69)
        Me.GunaButton5.Name = "GunaButton5"
        Me.GunaButton5.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GunaButton5.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButton5.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton5.OnHoverImage = Nothing
        Me.GunaButton5.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton5.Size = New System.Drawing.Size(343, 32)
        Me.GunaButton5.TabIndex = 5
        Me.GunaButton5.Tag = "rptUsers"
        Me.GunaButton5.Text = "USERS"
        '
        'MasterListReports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1215, 510)
        Me.Name = "MasterListReports"
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

    Friend WithEvents Label1 As Label
    Friend WithEvents GunaButton1 As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaButton2 As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaButton5 As Guna.UI.WinForms.GunaButton
End Class
