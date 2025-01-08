Imports DevExpress.XtraEditors
Public Class PTDateFilter
    Private _FieldName As String
    Private _TableName As String
    Private _EditValue As String
    Private useTable As Boolean = False
    Private FirstLoad As Boolean = True
    Private pBlankDate As Boolean
    Private pReplaceDateField As String = Nothing

    Public Property TableField() As String
        Get
            Return _FieldName
        End Get
        Set(ByVal value As String)
            _FieldName = value
        End Set
    End Property

    Public Property TableName() As String
        Get
            Return _TableName
        End Get
        Set(ByVal value As String)
            _TableName = value
        End Set
    End Property

    Public Property EditValue() As String
        Get
            Return _EditValue
        End Get
        Set(ByVal value As String)
            _EditValue = value
        End Set
    End Property

    Public Property UseTableName() As Boolean
        Get
            Return useTable
        End Get
        Set(ByVal value As Boolean)
            useTable = value

        End Set
    End Property
    <System.ComponentModel.DefaultValue(False)>
    Public Property IsBlankDate() As Boolean
        Get
            Return pBlankDate
        End Get
        Set(ByVal value As Boolean)
            pBlankDate = value
        End Set
    End Property

    Public Property ReplaceDateField() As String
        Get
            Return pReplaceDateField
        End Get
        Set(ByVal value As String)
            pReplaceDateField = value
        End Set
    End Property

    Private Sub ComboBoxInput1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboFilterType.TextChanged
        Dim txtFilterType As String = cboFilterType.Text.Trim
        'If cboFilterType.Properties.Items.Count = 0 Then cboFilterType.LoadData()
        If txtFilterType <> "" Then
            Select Case txtFilterType.ToLower
                Case "as of", "today", "equals", "this week", "this month", "this year"
                    DateStart.Visible = True
                    DateEnd.Visible = False
                    DateStart.EditValue = Now
                Case "period from"
                    DateStart.Visible = True
                    DateEnd.Visible = True
                    DateStart.EditValue = Now
                    DateEnd.EditValue = Now
                Case Else
                    Me.DateEnd.EditValue = ""
                    Me.DateStart.EditValue = ""
            End Select

            ChangeDateFilterValue()
        Else
            If Not FirstLoad Then XtraMessageBox.Show("Invalid Date Filter type, please select one from the dropdown...", "Invalid Filter Type", MessageBoxButtons.OK, MessageBoxIcon.Information)
            FirstLoad = False
        End If

    End Sub

    Private Sub ChangeDateFilterValue()
        'If pBlankDate Then
        '    _EditValue = ""
        '    Exit Sub
        'End If

        Try
            'Dim SenderCtrl As DateEdit = DirectCast(sender, DateEdit)
            _EditValue = ""
            'DateStart.EditValue = Now

            If useTable Then
                Select Case cboFilterType.SelectedItem.ToLower
                    Case "today", "equals"
                        _EditValue = String.Format("{2}.{0} Like '%{1:yyyy-MM-dd}%'", Me.TableField, DateValue(DateStart.EditValue), Me.TableName)
                        '_EditValue = String.Format("{0} >= '{1:yyyy-MM-dd}' AND {0} < '{2:yyyy-MM-dd}'", Me.TableField, DateValue(Now),Now.AddDays(1))
                        ' Me.Tag = Now.ToString("d")
                        Me.Tag = DateValue(DateStart.EditValue).ToString("d")
                    Case "as of"
                        _EditValue = String.Format("{2}.{0} < '{1:yyyy-MM-dd}'", Me.TableField, DateValue(DateStart.EditValue).AddDays(1), Me.TableName)
                        Me.Tag = "As Of " & DateValue(DateStart.EditValue).ToString("d")
                        'Case "equals"
                        '    _EditValue = String.Format("{0} >= '{1:yyyy-MM-dd}' AND {0} < '{2:yyyy-MM-dd}'", Me.TableField, DateValue(DateStart.EditValue),DateValue(DateStart.EditValue).AddDays(1)) 'String.Format("{0} = '{1:yyyy-MM-dd}'", Me.TableField, DateValue(DateStart.EditValue))
                        '    Me.Tag = DateValue(DateStart.EditValue).ToString("d")
                    Case "period from"
                        _EditValue = String.Format("{3}.{0} >= '{1:yyyy-MM-dd}' AND {3}.{0} < '{2:yyyy-MM-dd}'", Me.TableField, DateValue(Me.DateStart.EditValue), DateValue(Me.DateEnd.EditValue).AddDays(1), TableName)
                        Me.Tag = String.Format("{0} To {1}", DateValue(DateStart.EditValue).ToString("d"), DateValue(Me.DateEnd.EditValue).ToString("d"))

                    Case "this week"
                        Dim currentDate As DateTime = DateValue(Me.DateStart.EditValue)
                        Dim targetDay As DayOfWeek = DayOfWeek.Sunday ' Change this to the desired target day
                        Dim difference As Integer = (7 + currentDate.DayOfWeek - targetDay) Mod 7
                        Dim firstDayOfWeek As DateTime = currentDate.AddDays(-difference)
                        Dim lastDayOfWeek As DateTime = currentDate.AddDays(-difference).AddDays(6)
                        _EditValue = String.Format("{3}.{0} >= '{1:yyyy-MM-dd}' AND {3}.{0} <= '{2:yyyy-MM-dd}'", Me.TableField, firstDayOfWeek, lastDayOfWeek, TableName)
                        Me.Tag = String.Format("{0} To {1}", firstDayOfWeek.ToString("d"), lastDayOfWeek.ToString("d"))

                    Case "this week"
                        Dim currentDate As DateTime = DateValue(Me.DateStart.EditValue)
                        Dim firstDayOfMonth As DateTime = New DateTime(currentDate.Year, currentDate.Month, 1)
                        Dim lastDayOfMonth As DateTime = New DateTime(currentDate.Year, currentDate.Month, DateTime.DaysInMonth(currentDate.Year, currentDate.Month))
                        _EditValue = String.Format("{3}.{0} >= '{1:yyyy-MM-dd}' AND {3}.{0} <= '{2:yyyy-MM-dd}'", Me.TableField, firstDayOfMonth, lastDayOfMonth, TableName)
                        Me.Tag = String.Format("{0} To {1}", firstDayOfMonth.ToString("d"), lastDayOfMonth.ToString("d"))

                    Case "this year"
                        Dim currentDate As DateTime = DateValue(Me.DateStart.EditValue)
                        Dim firstDayOfYear As DateTime = New DateTime(currentDate.Year, 1, 1)
                        Dim lastDayOfYear As DateTime = New DateTime(currentDate.Year, 12, 31)
                        _EditValue = String.Format("{3}.{0} >= '{1:yyyy-MM-dd}' AND {3}.{0} <= '{2:yyyy-MM-dd}'", Me.TableField, firstDayOfYear, lastDayOfYear, TableName)
                        Me.Tag = String.Format("{0} To {1}", firstDayOfYear.ToString("d"), lastDayOfYear.ToString("d"))
                End Select
            Else
                Select Case cboFilterType.SelectedItem.ToLower
                    Case "today", "equals"
                        _EditValue = String.Format("{0} Like '%{1:yyyy-MM-dd}%'", Me.TableField, DateValue(DateStart.EditValue))
                        '_EditValue = String.Format("{0} >= '{1:yyyy-MM-dd}' AND {0} < '{2:yyyy-MM-dd}'", Me.TableField, DateValue(Now),Now.AddDays(1))
                        ' Me.Tag = Now.ToString("d")
                        Me.Tag = DateValue(DateStart.EditValue).ToString("d")
                    Case "as of"
                        _EditValue = String.Format("{0} < '{1:yyyy-MM-dd}'", Me.TableField, DateValue(DateStart.EditValue).AddDays(1))
                        Me.Tag = "As Of " & DateValue(DateStart.EditValue).ToString("d")
                        'Case "equals"
                        '    _EditValue = String.Format("{0} >= '{1:yyyy-MM-dd}' AND {0} < '{2:yyyy-MM-dd}'", Me.TableField, DateValue(DateStart.EditValue),DateValue(DateStart.EditValue).AddDays(1)) 'String.Format("{0} = '{1:yyyy-MM-dd}'", Me.TableField, DateValue(DateStart.EditValue))
                        '    Me.Tag = DateValue(DateStart.EditValue).ToString("d")
                    Case "period from"
                        _EditValue = String.Format("{0} >= '{1:yyyy-MM-dd}' AND {0} < '{2:yyyy-MM-dd}'", Me.TableField, DateValue(Me.DateStart.EditValue), DateValue(Me.DateEnd.EditValue).AddDays(1))
                        Me.Tag = String.Format("{0} To {1}", DateValue(DateStart.EditValue).ToString("d"), DateValue(Me.DateEnd.EditValue).ToString("d"))

                    Case "this week"
                        Dim currentDate As DateTime = DateValue(Me.DateStart.EditValue)
                        Dim targetDay As DayOfWeek = DayOfWeek.Monday ' Change this to the desired target day
                        Dim difference As Integer = (7 + currentDate.DayOfWeek - targetDay) Mod 7
                        Dim firstDayOfWeek As DateTime = currentDate.AddDays(-difference)
                        Dim lastDayOfWeek As DateTime = currentDate.AddDays(-difference).AddDays(6)
                        _EditValue = String.Format("{0} >= '{1:yyyy-MM-dd}' AND {0} <= '{2:yyyy-MM-dd}'", Me.TableField, firstDayOfWeek, lastDayOfWeek)
                        Me.Tag = String.Format("{0} To {1}", firstDayOfWeek.ToString("d"), lastDayOfWeek.ToString("d"))

                    Case "this month"
                        Dim currentDate As DateTime = DateValue(Me.DateStart.EditValue)
                        Dim firstDayOfMonth As DateTime = New DateTime(currentDate.Year, currentDate.Month, 1)
                        Dim lastDayOfMonth As DateTime = New DateTime(currentDate.Year, currentDate.Month, DateTime.DaysInMonth(currentDate.Year, currentDate.Month))
                        _EditValue = String.Format("{0} >= '{1:yyyy-MM-dd}' AND {0} <= '{2:yyyy-MM-dd}'", Me.TableField, firstDayOfMonth, lastDayOfMonth)
                        Me.Tag = String.Format("{0} To {1}", firstDayOfMonth.ToString("d"), lastDayOfMonth.ToString("d"))

                    Case "this year"
                        Dim currentDate As DateTime = DateValue(Me.DateStart.EditValue)
                        Dim firstDayOfYear As DateTime = New DateTime(currentDate.Year, 1, 1)
                        Dim lastDayOfYear As DateTime = New DateTime(currentDate.Year, 12, 31)
                        _EditValue = String.Format("{0} >= '{1:yyyy-MM-dd}' AND {0} <= '{2:yyyy-MM-dd}'", Me.TableField, firstDayOfYear, lastDayOfYear)
                        Me.Tag = String.Format("{0} To {1}", firstDayOfYear.ToString("d"), lastDayOfYear.ToString("d"))
                End Select
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub DateEnd_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateStart.EditValueChanged, DateEnd.EditValueChanged
        ChangeDateFilterValue()
    End Sub

    Private Sub DateFilter_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Me.cboFilterType.LoadData()
        System.Threading.Thread.Sleep(100)
        DateStart.EditValue = Now
        DateEnd.EditValue = Now
        cboFilterType.Text = "Today"
        If pBlankDate Then
            Me.DateEnd.EditValue = ""
            Me.DateStart.EditValue = ""
        End If

    End Sub

    Private Sub DateFilter_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.LostFocus
        ChangeDateFilterValue()
    End Sub

    Private DateCaption As String
End Class
