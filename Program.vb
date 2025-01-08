Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Windows.Forms
Imports DevExpress.XtraEditors

Friend Class Program

    Private Sub New()

    End Sub

    <STAThread()>
    Shared Sub Main()

        LoadProjectSettings()

        With ApplicationSettings.Instance
            AppData = New DataManager(.GetProviderType, .GetConnectionStringFromRegistry)
        End With

        Try
            If AppData.TryConnect() Then

                AppMainForm = New MainForm

                ''BuildMenu(AppMainForm)

                Application.Run(AppMainForm)
            Else
                Dim DBSettingsForm As New DatabaseConnection
                If DBSettingsForm.ShowDialog = DialogResult.OK Then
                    With ApplicationSettings.Instance
                        AppData = New DataManager(.GetProviderType, .GetConnectionStringFromRegistry)
                    End With
                    'Show Login Form
                    AppMainForm = New MainForm
                    ''BuildMenu(AppMainForm)
                    Application.Run(AppMainForm)
                Else
                    Application.Exit()
                End If
            End If

        Catch ex As Exception

        End Try

    End Sub

    Shared Sub LoadProjectSettings()
        With Project.Instance
            .CompanyName = "ARMART"
            .CompanyAddress = "Mandaluyong City"
        End With
    End Sub

End Class
