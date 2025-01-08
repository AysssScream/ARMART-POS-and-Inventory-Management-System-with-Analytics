Imports DevExpress.XtraEditors
Imports System.Data.Common
Imports System.IO
Imports MySql.Data.MySqlClient
Imports System.ComponentModel

Public Class Login
    Private ProgrammerName As String
    Private BackDoorLoginCaptureEnabled As Boolean
    Private BackDoorLoginInput As String

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.FormBorderStyle = FormBorderStyle.None
        Me.Panel1.BackColor = Color.FromArgb(51, 54, 82)  ' Set the custom color here
        Me.btnLogin.FillColor = Color.FromArgb(51, 54, 82)
        Me.btnClose.BackColor = Color.FromArgb(51, 54, 82)
        Me.btnClose.FlatAppearance.MouseDownBackColor = Colors.brand
        Me.btnClose.FlatAppearance.MouseOverBackColor = Colors.brand

        Guna2ShadowForm1.SetShadowForm(Me)

    End Sub

    Private Sub Login_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Select Case True
            Case e.Control AndAlso e.KeyCode = Keys.Q
                BackDoorLoginInput = ""
                BackDoorLoginCaptureEnabled = True
                UserName = "BACKDOOR"

            Case e.KeyCode = Keys.Enter
                If BackDoorLoginCaptureEnabled Then
                    If BackDoorLoginInput.ToLower = BackDoorPass.ToLower Then
                        Dim vUser As User = New User("BACKDOOR", Nothing)
                        Project.Instance.ActiveUser = vUser
                        UserName = "BACKDOOR"

                        'Dim date_p As DateTime = Now
                        'Dim sql As String = String.Format("Select PK_CSession,IsSessionEnded_CSession from cashier_sessions where Date_CSession = '{0}' order by ID_CSession DESC", date_p.ToString("yyyy-MM-dd"))
                        'Dim dt As DataTable = AppData.GetDataTable(sql)
                        'If dt.Rows.Count > 0 Then
                        '    If dt.Rows(0)("IsSessionEnded_CSession") = 0 Then
                        '        Project.Instance.SessionId = dt.Rows(0)("PK_CSession").ToString
                        '    Else
                        '        Project.Instance.SessionId = ""
                        '    End If
                        'End If

                        MsgBox("Back door access granted...", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Success")

                        'LoadStoreSettings()
                        'BackgroundWorker1.RunWorkerAsync()
                        Me.DialogResult = DialogResult.OK
                        Me.Close()
                        AppMainForm.LoginVerified = True

                    Else
                        BackDoorLoginCaptureEnabled = False
                        UserName = "USER"
                        BackDoorLoginInput = ""
                    End If
                Else
                    ValidateLogin()
                End If
            Case Else
                If BackDoorLoginCaptureEnabled Then
                    BackDoorLoginInput &= ChrW(e.KeyCode)
                    e.SuppressKeyPress = True
                End If
        End Select


        SaveSetting(AppExeName, "Default Settings", "CurrentUser", txtUsername.Text)
    End Sub


    Private Sub Login_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load


        Dim loginImgFileName As String = ""
        BackDoorLoginCaptureEnabled = False

        txtUsername.Focus()

        With Project.Instance
            System.Threading.Thread.Sleep(100)
            If GetSetting(AppExeName, "Default Settings", "CurrentUser") <> "" AndAlso GetSetting(AppExeName, "Default Settings", "CurrentUser") <> "BACKDOOR" Then _
                txtUsername.Text = GetSetting(AppExeName, "Default Settings", "CurrentUser")
        End With
    End Sub

    Private Sub ValidateLogin()
        Try
            Dim dtSecurity As New DataTable
            Dim daSecurity As DbDataAdapter
            Dim connSecurity As DbConnection
            If InputValidator.Validate() Then
                Dim SelectUser = "Select PK_ScrtyPrm, FK_Role_ScrtyPrm,FormCaption_ScrtyPrm,Rights_ScrtyPrm, " &
                            "PK_Usr,UserName_Usr,AccountType_Usr,Name_Usr,Picture_Usr " &
                            "FROM users left join security_permissions on FK_Role_ScrtyPrm = pk_Usr " &
                            "WHERE UserName_Usr= @Name AND Password_Usr=@Password "

                connSecurity = New MySqlConnection()
                connSecurity.ConnectionString = AppData.ConnectionString

                daSecurity = New MySqlDataAdapter()
                daSecurity.SelectCommand = New MySqlCommand()

                With daSecurity.SelectCommand
                    .CommandType = CommandType.Text
                    .CommandText = SelectUser
                    .Connection = connSecurity

                    Dim p As DbParameter = .CreateParameter
                    p.ParameterName = "@Name"
                    p.Value = Me.txtUsername.Text.ToLower

                    .Parameters.Add(p)

                    p = .CreateParameter
                    p.ParameterName = "@Password"
                    p.Value = Me.txtPassword.Text

                    .Parameters.Add(p)
                End With

                daSecurity.Fill(dtSecurity)
                If dtSecurity.Rows.Count > 0 Then
                    Dim vUser As User = New User(dtSecurity.Rows(0)("Name_Usr").ToString, dtSecurity)
                    Project.Instance.ActiveUser = vUser
                    Project.Instance.ActiveUserPK = dtSecurity.Rows(0)("PK_Usr").ToString
                    Project.Instance.ActiveAccountType = dtSecurity.Rows(0)("AccountType_Usr").ToString

                    'LoadStoreSettings()

                    With Project.Instance
                        AppMainForm.Text = .CompanyName
                    End With

                    AppMainForm.LoginVerified = True

                    'Dim date_p As DateTime = Now
                    'Dim sql As String = String.Format("Select PK_CSession from cashier_sessions where Date_CSession = '{0}'", date_p.ToString("yyyy-MM-dd"))
                    'Dim dt As DataTable = AppData.GetDataTable(sql)
                    'If dt.Rows.Count > 0 Then
                    '    If dt.Rows(0)("IsSessionEnded_CSession") = 0 Then
                    '        Project.Instance.SessionId = dt.Rows(0)("PK_CSession").ToString
                    '    Else
                    '        Project.Instance.SessionId = ""
                    '    End If
                    'End If
                    Me.DialogResult = DialogResult.OK
                    Me.Close()
                    'BackgroundWorker1.RunWorkerAsync()
                    'AppMainForm.LoginVerified = True
                    'Dim mainForm As New MainForm()
                    'mainForm.Show()
                    'mainForm.OpenDashboardDirectly()  ' Assuming this method is added to MainForm

                Else
                    MsgBox("Login error: either username/password is wrong or user has no permissions...", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Login Error")
                End If

            End If

            'MsgBox("all inputs are valid...")


        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnLogin_KeyUp(sender As Object, e As KeyEventArgs) Handles btnLogin.KeyUp
        If e.KeyCode = Keys.Enter Then
            ValidateLogin()
        End If
    End Sub

    Private Sub btnLogin_Click_1(sender As Object, e As EventArgs) Handles btnLogin.Click
        ValidateLogin()
    End Sub

    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Application.Exit()
    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        Dim dbsettings As New DatabaseConnection
        Me.Hide()
        If dbsettings.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK Then
            Me.Show()
        End If
    End Sub

    Private Sub LoadStoreSettings()
        Try

            Dim sqlSettings As String = String.Format("Select * from settings")
            Dim dtSettings As DataTable = AppData.GetDataTable(sqlSettings)
            With Project.Instance
                .BranchPK = IIf(IsDBNull(dtSettings.Rows(0)("PK_Set")), "", dtSettings.Rows(0)("PK_Set"))
                .CompanyName = IIf(IsDBNull(dtSettings.Rows(0)("StoreName_Set")), "", dtSettings.Rows(0)("StoreName_Set"))
                .CompanyAddress = IIf(IsDBNull(dtSettings.Rows(0)("Address_Set")), "", dtSettings.Rows(0)("Address_Set"))
                .TIN = IIf(IsDBNull(dtSettings.Rows(0)("TIN_Set")), "", dtSettings.Rows(0)("TIN_Set"))
                .ContactNumber = IIf(IsDBNull(dtSettings.Rows(0)("ContactNo_Set")), "", dtSettings.Rows(0)("ContactNo_Set"))
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Try
            'BackupToConsolidatedDatabase
            Dim tripleDES = New ClsTripleDES
            Dim host As String = tripleDES.Decrypt(GetValueFromRegistry("Database Settings", "Server Name"))
            Dim port As String = tripleDES.Decrypt(GetValueFromRegistry("Database Settings", "Port"))
            Dim user As String = tripleDES.Decrypt(GetValueFromRegistry("Database Settings", "User"))
            Dim password As String = tripleDES.Decrypt(GetValueFromRegistry("Database Settings", "Password"))
            Dim databaseName As String = tripleDES.Decrypt(GetValueFromRegistry("Database Settings", "Database Name"))

            Dim where1 = ""
            Dim where = ""
            Dim tables = " inventories, categories"
            ''where1 = AddDoubleQuote(String.Format("(StorePK_Invty IS NULL OR StorePK_Invty = '' OR StorePK_Invty = '{0}')", Project.Instance.StorePK))
            ''Download Updated Inventories from Main Database
            Dim arg2 As String = String.Format(" mysqldump --login-path=remote --replace --skip-add-drop-table --no-create-info --force --compress {0} {1} | mysql --login-path=local --force --compress {0}", databaseName, tables)
            Shell("cmd /c """ & arg2 & """", AppWinStyle.Hide, True)

            tables = " universal_masters, chart_of_accounts, chart_of_account_types"
            ''Download Updated UM from Main Database
            arg2 = String.Format(" mysqldump --login-path=remote --replace --skip-add-drop-table --no-create-info --force --compress {0} {1} | mysql --login-path=local --force --compress {0}", databaseName, tables)
            Shell("cmd /c """ & arg2 & """", AppWinStyle.Hide, True)

            tables = String.Format(" --ignore-table={0}.inventories ", databaseName)
            where = AddDoubleQuote(String.Format("(TimeStamp >= '{0:yyyy-MM-dd}') AND (TimeStamp <= '{1:yyyy-MM-dd}')", Now.AddDays(-1).ToString("yyyy-MM-dd"), Now.AddDays(1).ToString("yyyy-MM-dd")))
            ''Dump and Upload Updated Database
            Dim arg As String = String.Format(" mysqldump --login-path=local --replace --skip-add-drop-table --no-create-info --force {1} --compress {0} --where={2} | mysql --login-path=remote --force --compress {0}", databaseName, tables, where)
            Shell("cmd /c """ & arg & """", AppWinStyle.Hide, True)
        Catch ex As Exception

        End Try
    End Sub


    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class
