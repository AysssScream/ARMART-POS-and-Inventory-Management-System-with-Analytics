Imports System.Data.Common
Imports System.Windows
Imports System.Data
Imports MySql.Data
Imports System.IO
Imports MySql.Data.MySqlClient
Imports DevExpress.XtraEditors
Public Class DatabaseConnection

    Private Testing As Boolean
    Private serverType As String
    Private providerType As DataProviderType
    Private tripleDES As ClsTripleDES

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.FormBorderStyle = FormBorderStyle.None

        Guna2ShadowForm1.SetShadowForm(Me)

    End Sub
    Private Function TestConnection(Optional ByVal ShowTestConfirmation As Boolean = True) As Boolean
        Dim connStr As String = ""
        Dim conn As DbConnection
        Try

            conn = New MySqlConnection()
            conn.ConnectionString = String.Format("server={0};database={1};user id={2};password={3};port={4}", txtServerName.Text, txtDatabase.Text, txtUser.Text, txtPassword.Text, txtPort.Text)
            providerType = DataProviderType.Mysql

            conn.Open()
            If ShowTestConfirmation Then
                MsgBox("Successfully Connected to Database...", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Database Settings")
            End If

            Return True
        Catch ex As Exception
            'MsgBox("Invalid Database settings...", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Invalid Settings")
            Return False
        Finally
            conn.Close()
            conn = Nothing
        End Try
    End Function

    Private Sub DatabaseConnection_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            tripleDES = New ClsTripleDES

            serverType = If(IsNothing(GetValueFromRegistry("Database Settings", "Server Type")), "", GetValueFromRegistry("Database Settings", "Server Type").ToString)

            If serverType <> String.Empty Then
                providerType = DataProviderType.Mysql
                txtServerName.Text = tripleDES.Decrypt(GetValueFromRegistry("Database Settings", "Server Name"))
                txtPort.Text = tripleDES.Decrypt(GetValueFromRegistry("Database Settings", "Port"))
                txtUser.Text = tripleDES.Decrypt(GetValueFromRegistry("Database Settings", "User"))
                txtPassword.Text = tripleDES.Decrypt(GetValueFromRegistry("Database Settings", "Password"))
                txtDatabase.Text = tripleDES.Decrypt(GetValueFromRegistry("Database Settings", "Database Name"))

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            Dim myProcess As New Process
            If TestConnection() Then

                WriteValueToRegistry("Database Settings", "Server Type", "Mysql", Microsoft.Win32.RegistryValueKind.String)
                WriteValueToRegistry("Database Settings", "Server Name", tripleDES.Encrypt(txtServerName.Text), Microsoft.Win32.RegistryValueKind.Binary)
                WriteValueToRegistry("Database Settings", "Port", tripleDES.Encrypt(txtPort.Text), Microsoft.Win32.RegistryValueKind.Binary)
                WriteValueToRegistry("Database Settings", "User", tripleDES.Encrypt(txtUser.Text), Microsoft.Win32.RegistryValueKind.Binary)
                WriteValueToRegistry("Database Settings", "Password", tripleDES.Encrypt(txtPassword.Text), Microsoft.Win32.RegistryValueKind.Binary)
                WriteValueToRegistry("Database Settings", "Database Name", tripleDES.Encrypt(txtDatabase.Text), Microsoft.Win32.RegistryValueKind.Binary)

                With ApplicationSettings.Instance
                    AppData = New DataManager(.GetProviderType, .GetConnectionStringFromRegistry)
                End With

                Me.DialogResult = System.Windows.Forms.DialogResult.OK
                Me.Close()



            Else
                MsgBox("Invalid Database Settings," + vbCrLf +
                "Please check settings...", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Invalid Settings")
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class
