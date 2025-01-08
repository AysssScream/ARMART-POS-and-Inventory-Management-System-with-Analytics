Imports DevExpress.XtraEditors
Imports tem.ComponentModel
Imports DevExpress.XtraGrid.Views.Grid
Imports tem.Data.Common


Public Class GenerateAccountingEntries
    Private Const MeModuleKey As String = "GENENTRY"
    Private Const MeModuleField As String = "Module_LdgrEntries"
    Private Const MePKField As String = "PK_LdgrEntries"
    Private Const MeCOAField As String = "FK_COA_LdgrEntries"
    Private Const MeFKUMField As String = "FK_UM_LdgrEntries"
    Private Const MeDebitField As String = "DRAmount_LdgrEntries"
    Private Const MeCreditField As String = "CRAmount_LdgrEntries"
    Private Const MeModuleTransField As String = "ModuleTrans_LdgrEntries"
    Private Const MeStatusField As String = "Status_LdgrEntries"
    Private Const MeDateDueField As String = "DateDue_LdgrEntries"
    Private Const MeDateField As String = "Date_LdgrEntries"
    Private Const MeBalanceField As String = "Balance_LdgrEntries"
    Private Const MeFKTransHField As String = "FK_TransH_LdgrEntries"
    Private Const MeFKTransHSLField As String = "FK_TransHSL_LdgrEntries"
    Private Const MeFKEntriesSLField As String = "FK_LdgrEntriesSL_LdgrEntries"
    Private Const MeAmountPayEntries As String = "AmountPayClr_LdgrEntries"
    Private Const MePkEntries As String = "PK_LdgrEntries"
    Private Const MeCheckDateField As String = "CheckDate_LdgrEntries"
    Private Const MeCheckNoField As String = "CheckNo_LdgrEntries"
    Private Const MeRefNoField As String = "RefNo_LdgrEntries"

    'Variables
    Private MeCheckDateValue As Date = Date.MinValue
    Private MeCheckNOValue As String
    Private MeRefNoValue As String
    Private MeCOAValue As String
    Private MeFKUM As String = Guid.Empty.ToString
    Private MeFKTransH As String = Guid.Empty.ToString
    Private MeFKTransHSL As String = Guid.Empty.ToString
    Private MeFKEntriesSL As String = Guid.Empty.ToString
    Private MeDebitAmount As Double
    Private MeCreditAmount As Double
    Private MeModuleTrans As String
    Private MeModule As String = ""
    Private MeStatus As String = ""
    Private MeDateDue As Date = Date.MinValue
    Private MeDate As Date = Date.MinValue
    Private MeTotalDue As Double


    '------------------- Used for Simple AR/AP  Accounting Generation --------------
    Private TableName As String = "Transaction_Ledger_Entries"
    Private MeAmount As Double = 0
    'Private MeFK_COA As Double = ""
    'Private MeFK_UM As Double = ""
    Private MePostSide As Integer = 0 'DebitSide and 1 for credit side

    'Add Cost Center and Project Name
    Private MeProjectName As String = ""
    Private MeCostCenter As String = ""

    Private _EntriesGrid As DetailGrid

    Public Sub New(ByVal EntriesGrid As DetailGrid)
        _EntriesGrid = EntriesGrid
    End Sub

    Public WriteOnly Property AttachCheckDateValue() As Date
        Set(ByVal value As Date)
            If IsDate(value) Then
                MeCheckDateValue = value
            Else
                MeCheckDateValue = Now.Date
            End If
        End Set
    End Property

    Public WriteOnly Property AttachCheckNoValue() As String
        Set(ByVal value As String)
            If value <> String.Empty Then
                MeCheckNOValue = value
            Else
                MeCheckNOValue = ""
            End If
        End Set
    End Property

    Public WriteOnly Property AttachRefNoValue() As String
        Set(ByVal value As String)
            If value <> String.Empty Then
                MeRefNoValue = value
            Else
                MeRefNoValue = ""
            End If
        End Set
    End Property

    Public WriteOnly Property AttachCOAValue() As String
        Set(ByVal value As String)
            If value <> String.Empty Then
                MeCOAValue = value
            Else
                MeCOAValue = ""
            End If
        End Set
    End Property

    Public WriteOnly Property AttachMeFKEntriesSLValue() As String
        Set(ByVal value As String)
            If value <> String.Empty Then
                MeFKEntriesSL = value
            Else
                MeFKEntriesSL = ""
            End If
        End Set
    End Property

    Public WriteOnly Property AttachMeFKTransHValue() As String
        Set(ByVal value As String)
            If value <> String.Empty Then
                MeFKTransH = value
            Else
                MeFKTransH = ""
            End If
        End Set
    End Property

    Public WriteOnly Property AttachMeFKTransHSLValue() As String
        Set(ByVal value As String)
            If value <> String.Empty Then
                MeFKTransHSL = value
            Else
                MeFKTransHSL = ""
            End If
        End Set
    End Property

    Public WriteOnly Property AttachMeFKUMValue() As String
        Set(ByVal value As String)
            If value <> String.Empty Then
                MeFKUM = value
            Else
                MeFKUM = ""
            End If
        End Set
    End Property

    Public WriteOnly Property AttachMeDebitAmountValue() As Double
        Set(ByVal value As Double)
            If value <> 0 Then
                MeDebitAmount = value
            Else
                MeDebitAmount = 0
            End If
        End Set
    End Property

    Public WriteOnly Property AttachMeTotalDueValue() As Double
        Set(ByVal value As Double)
            If value <> 0 Then
                MeTotalDue = value
            Else
                MeTotalDue = 0
            End If
        End Set
    End Property


    Public WriteOnly Property AttachMeCreditAmountValue() As Double
        Set(ByVal value As Double)
            If value <> 0 Then
                MeCreditAmount = value
            Else
                MeCreditAmount = 0
            End If
        End Set
    End Property

    Public WriteOnly Property AttachMeModuleTransValue() As String
        Set(ByVal value As String)
            If value <> "" Then
                MeModuleTrans = value
            Else
                MeModuleTrans = ""
            End If
        End Set
    End Property

    Public WriteOnly Property AttachMeModule() As String
        Set(ByVal value As String)
            If value <> "" Then
                MeModule = value
            Else
                MeModule = ""
            End If
        End Set
    End Property

    Public WriteOnly Property AttachMeStatusValue() As String
        Set(ByVal value As String)
            If value <> "" Then
                MeStatus = value
            Else
                MeStatus = ""
            End If
        End Set
    End Property

    Public WriteOnly Property AttachMeDateDueValue() As Date
        Set(ByVal value As Date)
            If IsDate(value) Then
                MeDateDue = value
            Else
                MeDateDue = Now.Date
            End If
        End Set
    End Property

    Public WriteOnly Property AttachMeDateValue() As Date
        Set(ByVal value As Date)
            If IsDate(value) Then
                MeDate = value
            Else
                MeDate = Now.Date
            End If
        End Set
    End Property

    Public WriteOnly Property AttachMeAmountValue() As Double
        Set(ByVal value As Double)
            If value <> 0 Then
                MeAmount = value
            Else
                MeAmount = 0
            End If
        End Set
    End Property

    Public WriteOnly Property AttachMePostSide() As Double
        Set(ByVal value As Double)
            If value <> 0 Then
                MePostSide = value
            Else
                MePostSide = 0
            End If
        End Set
    End Property


    Public WriteOnly Property AttachFKProject() As String
        Set(ByVal value As String)
            MeProjectName = value
        End Set
    End Property

    Public WriteOnly Property AttachCostCenter() As String
        Set(ByVal value As String)
            MeCostCenter = value
        End Set
    End Property
    Private Sub LookupEntry(ByVal memodule As String, ByVal mecoavalue As String)

    End Sub
    Public Sub GenerateEntry(Optional ByVal pkvalue As String = "")
        Try
            If MeCOAValue = "" OrElse MeFKTransH = "" Then

                MeCOAValue = Guid.Empty.ToString
                MeFKTransH = Guid.Empty.ToString
                MeFKTransHSL = Guid.Empty.ToString
                MeFKEntriesSL = Guid.Empty.ToString
                MeFKUM = Guid.Empty.ToString
                MeDebitAmount = 0
                MeCreditAmount = 0
                MeModuleTrans = ""
                MeStatus = ""
                MeCostCenter = ""
                MeCheckNOValue = ""
                MeRefNoValue = ""
                MeDateDue = Date.MinValue
                MeCheckDateValue = Date.MinValue
                MeTotalDue = 0
                Exit Sub
            End If

            Try

                With Me._EntriesGrid

                    .AddNewRow()
                    Dim coaInfo As DataTable = AppData.GetDataTable("SELECT Type_COA, UserPK_COA, Title_COA FROM chart_of_accounts  WHERE PK_COA = " & AddQuote9(MeCOAValue))
                    If Not IsNothing(coaInfo) AndAlso coaInfo.Rows.Count > 0 Then
                        .Field("Type_COA") = coaInfo.Rows(0).Item("Type_COA")
                        .Field("UserPK_COA") = coaInfo.Rows(0).Item("UserPK_COA")
                        .Field("Title_COA") = coaInfo.Rows(0).Item("Title_COA")
                    End If

                    If Not pkvalue = "" Then
                        .Field(MePKField.ToLower) = pkvalue
                    End If

                    .Field(MeCheckDateField.ToLower) = MeCheckDateValue
                    .Field(MeCheckNoField.ToLower) = MeCheckNOValue
                    .Field(MeRefNoField.ToLower) = MeRefNoValue

                    .Field(MeCOAField.ToLower) = MeCOAValue
                    .Field(MeFKUMField.ToLower) = MeFKUM
                    .Field(MeDebitField.ToLower) = MeDebitAmount

                    .Field(MeCreditField.ToLower) = MeCreditAmount
                    .Field(MeModuleTransField.ToLower) = MeModuleTrans
                    .Field(MeStatusField.ToLower) = MeStatus


                    .Field(MeModuleField.ToLower) = IIf(MeModule <> "", MeModule, MeModuleKey)

                    .Field(MeFKTransHField.ToLower) = MeFKTransH

                    .Field(MeFKTransHSLField.ToLower) = IIf(MeFKTransHSL <> Guid.Empty.ToString, MeFKTransHSL, MeFKTransH)


                    .Field(MeFKEntriesSLField.ToLower) = IIf(MeFKEntriesSL <> Guid.Empty.ToString, MeFKEntriesSL, Nothing)

                    If MeDateDue <> Date.MinValue Then
                        .Field(MeDateDueField.ToLower) = DateValue(MeDateDue).ToString("yyyy-MM-dd")
                    End If

                    If MeDate <> Date.MinValue Then
                        .Field(MeDateField.ToLower) = DateValue(MeDate).ToString("yyyy-MM-dd")
                    End If

                    If MeModuleTrans <> "" Then
                        If MeModuleTrans.ToUpper = "DUE" Then
                            Select Case True
                                Case StrVal9(MeDebitAmount) <> 0
                                    .Field(MeBalanceField.ToLower) = MeDebitAmount
                                Case StrVal9(MeCreditAmount) <> 0
                                    .Field(MeBalanceField.ToLower) = MeCreditAmount
                                Case Else
                                    .Field(MeBalanceField.ToLower) = 0
                            End Select
                        End If
                    ElseIf MeModuleTrans = "GENENTRY-S" Then
                        If MeModuleTrans.ToUpper = "DUE" Then
                            Select Case True
                                Case StrVal9(MeDebitAmount) <> 0
                                    .Field(MeBalanceField.ToLower) = MeDebitAmount
                                Case StrVal9(MeCreditAmount) <> 0
                                    .Field(MeBalanceField.ToLower) = MeCreditAmount
                                Case Else
                                    .Field(MeBalanceField.ToLower) = 0
                            End Select
                        End If

                    End If
                    .Field(MeFKTransHField.ToLower) = MeFKTransH
                    .UpdateCurrentRow()
                End With


            Catch ex As Exception

            End Try
            MeCOAValue = Guid.Empty.ToString
            MeFKTransH = Guid.Empty.ToString
            MeFKTransHSL = Guid.Empty.ToString
            MeFKEntriesSL = Guid.Empty.ToString
            MeFKUM = Guid.Empty.ToString
            MeDebitAmount = 0
            MeCreditAmount = 0
            MeTotalDue = 0
            MeModuleTrans = ""
            MeStatus = ""
            MeCheckNOValue = ""
            MeRefNoValue = ""
            MeCheckDateValue = Date.MinValue
            MeCostCenter = ""
            MeDateDue = Date.MinValue
            MeDate = Date.MinValue
        Catch ex As Exception

        End Try


    End Sub
End Class
