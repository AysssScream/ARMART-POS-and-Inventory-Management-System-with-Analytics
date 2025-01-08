<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ListView
    Inherits BaseForm

    'Form overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ListView))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SearchBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnPrint = New Guna.UI2.WinForms.Guna2Button()
        Me.btnExcel = New Guna.UI2.WinForms.Guna2Button()
        Me.btnAddNew = New Guna.UI2.WinForms.Guna2Button()
        Me.lblHeaderTitle = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.sg_records = New NewTemplate.DetailGrid()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.sg_records, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.Controls.Add(Me.SearchBox)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.lblHeaderTitle)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1215, 72)
        Me.Panel1.TabIndex = 1
        '
        'SearchBox
        '
        Me.SearchBox.BackColor = System.Drawing.Color.Transparent
        Me.SearchBox.BorderColor = System.Drawing.Color.DimGray
        Me.SearchBox.BorderRadius = 13
        Me.SearchBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.SearchBox.DefaultText = ""
        Me.SearchBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.SearchBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.SearchBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.SearchBox.DisabledState.Parent = Me.SearchBox
        Me.SearchBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.SearchBox.FillColor = System.Drawing.SystemColors.Control
        Me.SearchBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SearchBox.FocusedState.Parent = Me.SearchBox
        Me.SearchBox.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.SearchBox.ForeColor = System.Drawing.Color.Black
        Me.SearchBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SearchBox.HoverState.Parent = Me.SearchBox
        Me.SearchBox.IconLeftCursor = System.Windows.Forms.Cursors.Hand
        Me.SearchBox.IconRight = Global.NewTemplate.My.Resources.Resources.search2
        Me.SearchBox.IconRightCursor = System.Windows.Forms.Cursors.Hand
        Me.SearchBox.Location = New System.Drawing.Point(10, 35)
        Me.SearchBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.SearchBox.Name = "SearchBox"
        Me.SearchBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.SearchBox.PlaceholderText = "Search"
        Me.SearchBox.SelectedText = ""
        Me.SearchBox.ShadowDecoration.Parent = Me.SearchBox
        Me.SearchBox.Size = New System.Drawing.Size(375, 30)
        Me.SearchBox.TabIndex = 6
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnPrint)
        Me.Panel2.Controls.Add(Me.btnExcel)
        Me.Panel2.Controls.Add(Me.btnAddNew)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(913, 30)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(302, 42)
        Me.Panel2.TabIndex = 5
        '
        'btnPrint
        '
        Me.btnPrint.BorderRadius = 14
        Me.btnPrint.CheckedState.Parent = Me.btnPrint
        Me.btnPrint.CustomImages.Parent = Me.btnPrint
        Me.btnPrint.FillColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.btnPrint.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnPrint.ForeColor = System.Drawing.Color.White
        Me.btnPrint.HoverState.Parent = Me.btnPrint
        Me.btnPrint.Location = New System.Drawing.Point(11, 5)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.ShadowDecoration.Parent = Me.btnPrint
        Me.btnPrint.Size = New System.Drawing.Size(90, 30)
        Me.btnPrint.TabIndex = 8
        Me.btnPrint.Text = "PRINT"
        '
        'btnExcel
        '
        Me.btnExcel.BorderRadius = 14
        Me.btnExcel.CheckedState.Parent = Me.btnExcel
        Me.btnExcel.CustomImages.Parent = Me.btnExcel
        Me.btnExcel.FillColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.btnExcel.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnExcel.ForeColor = System.Drawing.Color.White
        Me.btnExcel.HoverState.Parent = Me.btnExcel
        Me.btnExcel.Location = New System.Drawing.Point(107, 5)
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.ShadowDecoration.Parent = Me.btnExcel
        Me.btnExcel.Size = New System.Drawing.Size(90, 30)
        Me.btnExcel.TabIndex = 7
        Me.btnExcel.Text = "TO EXCEL"
        '
        'btnAddNew
        '
        Me.btnAddNew.BorderRadius = 14
        Me.btnAddNew.CheckedState.Parent = Me.btnAddNew
        Me.btnAddNew.CustomImages.Parent = Me.btnAddNew
        Me.btnAddNew.FillColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.btnAddNew.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnAddNew.ForeColor = System.Drawing.Color.White
        Me.btnAddNew.HoverState.Parent = Me.btnAddNew
        Me.btnAddNew.Location = New System.Drawing.Point(203, 5)
        Me.btnAddNew.Name = "btnAddNew"
        Me.btnAddNew.ShadowDecoration.Parent = Me.btnAddNew
        Me.btnAddNew.Size = New System.Drawing.Size(90, 30)
        Me.btnAddNew.TabIndex = 6
        Me.btnAddNew.Text = "ADD NEW"
        '
        'lblHeaderTitle
        '
        Me.lblHeaderTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.lblHeaderTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblHeaderTitle.Font = New System.Drawing.Font("Verdana", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lblHeaderTitle.ForeColor = System.Drawing.Color.White
        Me.lblHeaderTitle.Location = New System.Drawing.Point(0, 0)
        Me.lblHeaderTitle.Name = "lblHeaderTitle"
        Me.lblHeaderTitle.Size = New System.Drawing.Size(1215, 30)
        Me.lblHeaderTitle.TabIndex = 4
        Me.lblHeaderTitle.Text = "List View"
        Me.lblHeaderTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BackgroundWorker1
        '
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.sg_records)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 72)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Padding = New System.Windows.Forms.Padding(10)
        Me.Panel3.Size = New System.Drawing.Size(1215, 417)
        Me.Panel3.TabIndex = 2
        '
        'sg_records
        '
        Me.sg_records.ColumnDefinitionInfo = Nothing
        Me.sg_records.Dock = System.Windows.Forms.DockStyle.Fill
        Me.sg_records.Location = New System.Drawing.Point(10, 10)
        Me.sg_records.MainView = Me.GridView3
        Me.sg_records.Name = "sg_records"
        Me.sg_records.RowPosition = -2147483648
        Me.sg_records.Size = New System.Drawing.Size(1195, 397)
        Me.sg_records.TabIndex = 3
        Me.sg_records.TableFromInfo = Nothing
        Me.sg_records.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView3})
        '
        'GridView3
        '
        Me.GridView3.GridControl = Me.sg_records
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView3.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView3.OptionsCustomization.AllowColumnMoving = False
        Me.GridView3.OptionsFilter.AllowAutoFilterConditionChange = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView3.OptionsFind.AllowFindPanel = False
        Me.GridView3.OptionsFind.ShowClearButton = False
        Me.GridView3.OptionsFind.ShowFindButton = False
        Me.GridView3.OptionsMenu.EnableFooterMenu = False
        Me.GridView3.OptionsMenu.EnableGroupPanelMenu = False
        Me.GridView3.OptionsMenu.ShowAddNewSummaryItem = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView3.OptionsNavigation.AutoFocusNewRow = True
        Me.GridView3.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.SmartTag
        Me.GridView3.OptionsView.ShowAutoFilterRow = True
        Me.GridView3.OptionsView.ShowGroupPanel = False
        '
        'ListView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1215, 489)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "ListView"
        Me.Text = "ListView"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.sg_records, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Protected Friend WithEvents Panel1 As Panel
    Protected Friend WithEvents Panel2 As Panel
    Protected Friend WithEvents btnPrint As Guna.UI2.WinForms.Guna2Button
    Protected Friend WithEvents btnExcel As Guna.UI2.WinForms.Guna2Button
    Protected Friend WithEvents btnAddNew As Guna.UI2.WinForms.Guna2Button
    Protected Friend WithEvents lblHeaderTitle As Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Protected Friend WithEvents SearchBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Panel3 As Panel
    Protected Friend WithEvents sg_records As DetailGrid
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
End Class
