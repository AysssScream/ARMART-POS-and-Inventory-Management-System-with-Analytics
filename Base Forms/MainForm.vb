Imports DevExpress.XtraTab
Imports FontAwesome.Sharp
Imports Guna.UI.WinForms

Public Class MainForm

    Private _LoginVerified As Boolean
    Private _LoginType As String
    Private currentButton As IconButton
    Private currentPanel As System.Windows.Forms.Panel
    Private leftBorderButton As Panel
    Private currentChildForm As Form
    Public AvailableForms As New Collection
    Public MenuAndForms As New Collection
    Public FormsMenu As New Collection
    Protected SubMenus As Collection
    Public Property DirectlyOpenDashboard As Boolean = False


    Private IsMenuClose As Boolean = False
    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.FormBorderStyle = FormBorderStyle.None
        Me.MenuPanel.FillColor = Color.FromArgb(51, 54, 82)
        Me.MenuPanel.ForeColor = Colors.brand
        Me.MenuPanel.ShadowColor = Colors.brand

        Me.MaximumSize = Screen.PrimaryScreen.WorkingArea.Size

        leftBorderButton = New Panel()
        leftBorderButton.Size = New Size(4, 40)
        'SidePanel.Controls.Add(leftBorderButton)

        If Me.WindowState = FormWindowState.Normal Then
            ButtonMaximized.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize
        Else
            ButtonMaximized.IconChar = FontAwesome.Sharp.IconChar.WindowRestore
        End If

    End Sub
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        'If DateValue(Now).ToString("yyyy-MM-dd") > DateValue("2023-12-15").ToString("yyyy-MM-dd") Then
        '    MsgBox("Expired. Please contact me @ facebook. facebook.com/pos4usoftware")
        '    Application.Exit()
        '    Exit Sub
        'End If
        Dim vUser As User = New User("", Nothing)
        Project.Instance.ActiveUser = vUser

        LoginVerified = False

        Dim LoginFrm As New Login
        If LoginFrm.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Me.Show()
        End If


    End Sub

    Public Property LoginVerified() As Boolean
        Set(ByVal value As Boolean)
            _LoginVerified = value
            Me.SuspendLayout()
            If value Then
                LoadSettings()
                HideMenus(False)
                LoadUserMenu()
                BuildMenu(AppMainForm)
                btnMenu.Visible = True
                'lblUser.Visible = True
                'lblUser.Text = Project.Instance.ActiveUser.Name
            Else
                HideMenus(True)

                'lblUser.Visible = False
                'lblUser.Text = ""

                Dim vUser As User = New User("", Nothing)
                Project.Instance.ActiveUser = vUser

            End If
            Me.ResumeLayout()
        End Set
        Get
            Return _LoginVerified
        End Get
    End Property

    Public Property LoginType() As String
        Set(ByVal value As String)
            _LoginType = value
        End Set
        Get
            Return _LoginType
        End Get
    End Property

    Shared Sub BuildMenu(ByVal mdiForm As MainForm)
        Try
            With mdiForm
                .AddMenu("Dashboard:Dashboard", FontAwesome.Sharp.IconChar.Home)
                .AddMenu("POS:POSv1", FontAwesome.Sharp.IconChar.ShoppingCart)
                .AddMenu("Master Lists:SubMenu0", FontAwesome.Sharp.IconChar.File, New String() {
                         "Product Categories:ProductCategoryListView",
                         "Products:ProductListView",
                         "Suppliers:SupplierListView",
                         "User:UserListView",
                         "-----REPORTS-----",
                         "Master List Reports:MasterListReports"
                        })


                .AddMenu("Stock Entry:StockEntryListView", FontAwesome.Sharp.IconChar.PlusSquare)  ' Icon for adding stock
                .AddMenu("Stock Out:StockOutListView", FontAwesome.Sharp.IconChar.MinusSquare) ' // Icon For removing stock
                .AddMenu("Stock Adjustments:StockAdjustmentListView", FontAwesome.Sharp.IconChar.Wrench) ' // Icon For adjustments

                .AddMenu("Purchase Order (Supplier):PurchaseOrderListView", FontAwesome.Sharp.IconChar.FileInvoiceDollar)
                .AddMenu("Purchase Receiving (Supplier):PurchaseReceivingListView", FontAwesome.Sharp.IconChar.DollyFlatbed)

                .AddMenu("Sales Reports:SalesReports", FontAwesome.Sharp.IconChar.ChartBar)
                .AddMenu("Inventory Reports:InventoryReports", FontAwesome.Sharp.IconChar.ChartLine)  '// Icon For reports
                .AddMenu("Purchasing Reports:PurchasingReports", FontAwesome.Sharp.IconChar.ChartPie)


                ' "Cash Invoice:CashInvoiceListView",
                ' "Charge Invoice:ChargeInvoiceListView",
                ' "Collection:CollectionListView",
                '.AddMenu("Accounting:SubMenu4", FontAwesome.Sharp.IconChar.Calculator, New String() {
                ' "General Journal:GeneralJournalListView",
                '"Vendor Bill:VendorBillListView",
                '"Bill Payment:BillPaymentListView",
                ' "Expense Disbursement:ExpenseDisbursementListView",
                ' "-----REPORTS-----",
                ' "Financial Statements:FinancialStatementReports"
                ' })
            End With
        Catch ex As Exception

        End Try
    End Sub

    Public Sub AddMenu(ByVal menuName As String, ByRef Icon As FontAwesome.Sharp.IconChar, Optional ByVal MnuItems() As String = Nothing)
        Try

            Dim tripleDES = New ClsTripleDES
            Dim host As String = tripleDES.Decrypt(GetValueFromRegistry("Database Settings", "Server Name"))
            Dim visible = True
            If Not menuName.Split(":")(1).Contains("SubMenu") Then
                visible = Project.Instance.ActiveUser.IsFormPermissionGranted(menuName.Split(":")(0))
            End If
            ' Define colors
            Dim primaryColor As Color = Color.FromArgb(10, 25, 74)  ' Dark blue
            Dim secondaryColor As Color = Color.FromArgb(255, 255, 255)  ' White
            Dim hoverColor As Color = Color.FromArgb(35, 35, 168)  ' Lighter blue for hover


            'visible = True
            If visible Then
                Dim Menu = New IconButton
                Menu.Dock = System.Windows.Forms.DockStyle.Top
                Menu.FlatAppearance.BorderSize = 0
                Menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
                Menu.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal
                Menu.Font = New System.Drawing.Font("Segoe UI", 11.0!, FontStyle.Regular)
                Menu.BackColor = Color.Transparent
                Menu.IconChar = Icon
                Menu.ForeColor = Color.White
                Menu.IconColor = Color.White
                Menu.IconFont = FontAwesome.Sharp.IconFont.[Auto]
                Menu.IconSize = 28
                Menu.Height = 50  ' Increased height for better spacing
                Menu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
                Menu.Location = New System.Drawing.Point(0, 450)
                Menu.Padding = New Padding(10, 10, 20, 10)  ' Adjusted padding for better spacing
                Menu.Margin = New Padding(0, 5, 0, 5)  ' Margins to space out items
                Menu.Size = New Size(192, 50)  ' Adjust size if needed to fit padding/margins
                Menu.TabIndex = 8
                Menu.Text = menuName.Split(":")(0)
                Menu.AutoEllipsis = True
                Menu.Tag = menuName.Split(":")(1)
                Menu.TextAlign = ContentAlignment.MiddleLeft
                Menu.TextImageRelation = TextImageRelation.ImageBeforeText
                ' Apply colors
                Menu.BackColor = primaryColor
                Menu.ForeColor = secondaryColor
                Menu.IconColor = secondaryColor
                Menu.FlatAppearance.MouseOverBackColor = hoverColor
                Menu.UseVisualStyleBackColor = True
                Menu.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(20, Byte), Integer))
                'Menu.Visible = visible
                AddHandler Menu.Click, AddressOf Me.MenuClick
                AddHandler Menu.MouseHover, AddressOf Me.ButtonLogout_MouseHover
                AddHandler Menu.MouseLeave, AddressOf Me.ButtonLogout_MouseLeave
                MenuPanel.Controls.Add(Menu)
                MenuPanel.Controls.SetChildIndex(Menu, 0)
                Dim isWithSubMenu = Not IsNothing(MnuItems)
                Dim submenuCount = 0
                Dim submenuLineCount = 0
                If Not IsNothing(MnuItems) Then
                    Dim SubMenu = New System.Windows.Forms.Panel
                    SubMenu.Name = menuName.Split(":")(1)
                    SubMenu.Visible = IIf(menuName.Split(":")(1) = "SubMenu0", True, False)
                    SubMenu.Dock = System.Windows.Forms.DockStyle.Top
                    SubMenu.AutoSizeMode = AutoSizeMode.GrowAndShrink
                    If menuName.Split(":")(1) = "SubMenu0" Then
                        currentPanel = SubMenu
                    End If
                    MenuPanel.Controls.Add(SubMenu)
                    MenuPanel.Controls.SetChildIndex(SubMenu, 0)
                    For Each Item As String In MnuItems

                        visible = Project.Instance.ActiveUser.IsFormPermissionGranted(Item.Split(":")(0))

                        If visible Then
                            If Item.Contains("--") Then
                                submenuLineCount += 1
                                Dim Separator = New Label()
                                Separator.Dock = System.Windows.Forms.DockStyle.Top
                                Separator.Font = New System.Drawing.Font("Verdana", 7.5!, System.Drawing.FontStyle.Bold)
                                Separator.ForeColor = System.Drawing.Color.DimGray
                                Separator.Location = New System.Drawing.Point(0, 39)
                                Separator.Size = New System.Drawing.Size(192, 14)
                                Separator.Text = Item
                                Separator.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
                                SubMenu.Controls.Add(Separator)
                                SubMenu.Controls.SetChildIndex(Separator, 0)
                            Else
                                submenuCount += 1
                                Dim Menu2 = New IconButton()
                                Menu2.UseMnemonic = False
                                Menu2.IconChar = IconChar.ArrowLeft
                                Menu2.Padding = New Padding(30, 0, 10, 0)
                                Menu2.IconSize = 12
                                Menu2.IconColor = Color.White
                                Menu2.TextImageRelation = TextImageRelation.ImageBeforeText
                                Menu2.Dock = System.Windows.Forms.DockStyle.Top
                                Menu2.FlatAppearance.BorderSize = 0
                                Menu2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
                                Menu2.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal
                                Menu2.Font = New System.Drawing.Font("Segoe UI", 11.0!, FontStyle.Regular)
                                Menu2.ForeColor = Color.White
                                Menu2.BackColor = Color.Transparent
                                Menu2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
                                Menu2.Location = New System.Drawing.Point(0, 450)
                                Menu2.Size = New System.Drawing.Size(192, 30)
                                Menu2.Text = Item.Split(":")(0)
                                Menu2.AutoEllipsis = True
                                Menu2.Tag = Item.Split(":")(1)
                                Menu2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
                                Menu2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
                                Menu2.UseVisualStyleBackColor = True
                                AddHandler Menu2.Click, AddressOf Me.MenuClick
                                AddHandler Menu2.MouseHover, AddressOf Me.ButtonLogout_MouseHover
                                AddHandler Menu2.MouseLeave, AddressOf Me.ButtonLogout_MouseLeave
                                SubMenu.Controls.Add(Menu2)
                                SubMenu.Controls.SetChildIndex(Menu2, 0)

                                MenuAndForms.Add(Item.Split(":")(0))
                            End If
                        End If
                    Next
                    SubMenu.Size = New Size(192, (submenuCount * 30) + (submenuLineCount * 14) + 2)

                    SubMenus.Add(SubMenu, SubMenu.Name)
                Else
                    ''AvailableForms.Add(menuName.Split(":")(0))
                    MenuAndForms.Add(menuName.Split(":")(0))
                End If


                If isWithSubMenu And submenuCount = 0 Then
                    Menu.Visible = False
                End If

            End If
        Catch ex As Exception

        End Try
    End Sub

    Public Sub LoadSettings()

    End Sub

    Private Sub HideMenus(Optional ByVal hideMenus As Boolean = True)
        If hideMenus Then
            MenuPanel.Visible = False
        Else
            MenuPanel.Visible = True
        End If
    End Sub

    Private Sub LoadUserMenu()
        Me.MenuPanel.Visible = True
        OpenChildForm("Dashboard", " Dashboard", FontAwesome.Sharp.IconChar.Home)
    End Sub

    Private Sub MenuClick(sender As Object, e As EventArgs) Handles ButtonLogout.Click
        Try
            If sender.Tag.ToString.ToLower = "logout" Then
            Else
                ActivateButton(sender, Color.White) '
                OpenChildForm(sender.Tag, sender.Text)
            End If
        Catch ex As Exception

        End Try
    End Sub


    Public Sub ActivateButton(senderButton As Object, customColor As Color)
        If senderButton IsNot Nothing Then
            DisableButton()
            currentButton = CType(senderButton, IconButton)
            currentButton.BackColor = Colors.secondaryDark
            currentButton.IconColor = Color.White
            currentButton.ForeColor = Color.White

            leftBorderButton.BackColor = Colors.secondaryDark
            leftBorderButton.Location = New Point(0, IIf(currentButton.UseMnemonic, LogoPanel.Height + currentButton.Location.Y, LogoPanel.Height + currentButton.Location.Y + currentButton.Parent.Location.Y))
            leftBorderButton.Visible = True
            leftBorderButton.BringToFront()
        End If
    End Sub

    Private Sub DisableButton()
        If currentButton IsNot Nothing Then
            currentButton.BackColor = Color.Transparent
            currentButton.IconColor = Color.White
            currentButton.ForeColor = Color.White
        End If
    End Sub

    Public Sub OpenChildForm(FormName As String, FormCaption As String, Optional ByVal RecordPK As String = "")
        Try
            Dim FormIdentifier = "()"
            If FormName.Contains("Sub") Then
                currentPanel.Visible = False
                Dim controlPanel As System.Windows.Forms.Panel = CType(Me.Controls("MenuPanel").Controls(FormName), System.Windows.Forms.Panel)

                controlPanel.Visible = Not controlPanel.Visible
                currentPanel = controlPanel
            Else
                Dim childForm As BaseForm
                If FormName.Contains("List") Then
                    FormIdentifier = "(L)"
                    childForm = New ListView
                ElseIf FormName.Contains("Report") Then
                    FormIdentifier = "(R)"
                    childForm = New ReportFormBase
                Else
                    FormCaption = FormCaption.Replace(" (L)", "")
                    FormIdentifier = IIf(FormCaption.Contains("Dashboard"), "", "(F)")
                    childForm = New CRUDBase
                End If
                Dim FormName1 As String
                Dim FullTypeName As String
                Dim FormInstanceType As Type

                Dim st As New StackTrace()
                FormName1 = st.GetFrame(1).GetMethod().DeclaringType.FullName
                FormName1 = String.Format("{0}.{1}", FormName1.Split(".")(0), FormName)

                FullTypeName = FormName1
                FormInstanceType = Type.GetType(FullTypeName, True, True)
                childForm = Activator.CreateInstance(FormInstanceType)
                childForm.Text = FormCaption & " " & FormIdentifier
                childForm.TempRecordSelected = RecordPK

                currentChildForm = childForm
                childForm.TopLevel = False
                childForm.FormBorderStyle = FormBorderStyle.None
                childForm.Dock = DockStyle.Fill

                ''TAB
                Dim tabpage As XtraTabPage = New XtraTabPage()
                tabpage.Controls.Add(childForm)
                tabpage.Tag = childForm
                tabpage.Text = childForm.Text

                Dim tabFound As Boolean = False
                Dim tabFoundIndex = 0
                For i As Integer = 0 To XtraTabControl1.TabPages.Count - 1
                    If XtraTabControl1.TabPages(i).Text = FormName Then 'childForm.Text Then
                        tabFound = True
                        tabFoundIndex = i
                        Exit For
                    End If
                Next

                If tabFound Then
                    XtraTabControl1.SelectedTabPageIndex = tabFoundIndex
                Else
                    XtraTabControl1.TabPages.Add(tabpage)
                    XtraTabControl1.SelectedTabPageIndex = XtraTabControl1.TabPages.Count - 1
                End If

                'TAB

                'childForm.BringToFront()
                childForm.Show()

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ButtonLogout_MouseHover(sender As Object, e As EventArgs) Handles ButtonLogout.MouseHover
        If currentButton IsNot CType(sender, IconButton) Then
            CType(sender, IconButton).BackColor = Colors.secondaryDark
            CType(sender, IconButton).ForeColor = Color.Black
            CType(sender, IconButton).IconColor = Color.Black
        End If
    End Sub

    Private Sub ButtonLogout_MouseLeave(sender As Object, e As EventArgs) Handles ButtonLogout.MouseLeave
        If currentButton IsNot CType(sender, IconButton) Then
            CType(sender, IconButton).BackColor = Color.Transparent
            CType(sender, IconButton).ForeColor = Color.White
            CType(sender, IconButton).IconColor = Color.White
        End If
    End Sub


    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        Application.Exit()
    End Sub

    Private Sub ButtonMaximized_Click(sender As Object, e As EventArgs) Handles ButtonMaximized.Click
        If Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
            ButtonMaximized.IconChar = FontAwesome.Sharp.IconChar.WindowRestore
        Else
            Me.StartPosition = FormStartPosition.CenterScreen
            Me.WindowState = FormWindowState.Normal
            ButtonMaximized.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize
        End If
    End Sub

    Private Sub ButtonMinimized_Click(sender As Object, e As EventArgs) Handles ButtonMinimized.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        IsMenuClose = Not IsMenuClose
        If IsMenuClose Then
            'MenuPanel.Width = 50
            MenuPanel.Hide()
        Else
            'MenuPanel.Width = 200
            MenuPanel.Show()
        End If
    End Sub

    Private Sub XtraTabControl1_CloseButtonClick(sender As Object, e As EventArgs) Handles XtraTabControl1.CloseButtonClick
        Dim close = CType(e, DevExpress.XtraTab.ViewInfo.ClosePageButtonEventArgs)
        XtraTabControl1.TabPages.Remove(close.Page)
    End Sub

    Private Sub LogoPanel_Click(sender As Object, e As EventArgs) Handles LogoPanel.Click
        OpenChildForm("Dashboard", " Dashboard", FontAwesome.Sharp.IconChar.Home)
    End Sub
    Public Sub OpenDashboardDirectly()
        OpenChildForm("Dashboard", "Dashboard", FontAwesome.Sharp.IconChar.Home)
    End Sub



    Private Sub MenuPanel_Paint(sender As Object, e As PaintEventArgs) Handles MenuPanel.Paint

    End Sub
End Class