Imports System.Data.Common
Imports System.IO
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors
Imports DevExpress.XtraReports.UI
Imports MySql.Data.MySqlClient

Imports Bunifu.UI.WinForms

Public Module ModUtils
    Public SearchGridData As DataSet ''hansel
    Public UserName As String

    Public dbconn As New MySqlConnection

    Public dbcomm As MySqlCommand

    Public Sub AdditionalWhere9(ByVal ControlCriteria As PTTextInput, ByRef Criteria As String)

        With ControlCriteria
            If Not IsEmptyString(.TableField) AndAlso Not IsEmptyString(.TableName) _
                AndAlso Not IsEmptyString(.Text) Then
                If Not IsEmptyString(Criteria) Then
                    Criteria = String.Format("{0} AND {1}={2}", Criteria, .TableField, AddQuote9(.Text))
                Else
                    Criteria = String.Format("{0}={1}", .TableField, AddQuote9(.Text))
                End If
            End If
        End With

    End Sub

    Public Sub AdditionalWhere9(ByVal AdditionaCriteria As String, ByRef Criteria As String)

        If Not String.IsNullOrEmpty(AdditionaCriteria) Then
            If Not IsEmptyString(Criteria) Then
                Criteria = String.Format("{0} AND {1}", Criteria, AdditionaCriteria)
            Else
                Criteria = AdditionaCriteria
            End If
        End If

    End Sub

    Public Function AddQuote9(ByVal StrValue As String) As String
        If IsDate(StrValue) Then
            If AppData.DBProvider = DataProviderType.Mysql Then
                StrValue = DateValue(StrValue).ToString("yyyy-MM-dd")
                StrValue = String.Format("'{0}'", StrValue)
            Else
                String.Format("#{0}#", StrValue)
            End If
        Else
            StrValue = String.Format("'{0}'", StrValue)
        End If
        Return StrValue
    End Function

    Public Function AddDoubleQuote(ByVal StrValue As String) As String
        Return String.Format("{0}{1}{0}", ControlChars.Quote, StrValue)
    End Function

    Public Function ForceRoundUpTo1Dec(ByVal value As Object) As Double
        Try
            Dim res As Double
            Dim decPart As String
            Dim GivenValue As String = value.ToString.Replace("$", "").Replace(",", "").Trim
            Dim tens, ones As Integer
            Dim numPart As Double
            Select Case True
                Case InStr(value, "%") <> 0
                    res = Val(GivenValue.Replace("%", "")) / 100
                Case Else
                    res = Val(GivenValue)
            End Select


            If res.ToString.Contains(".") Then
                decPart = res.ToString.Split(".")(1)
                numPart = Val(res.ToString.Split(".")(0))
                tens = CInt(decPart.Substring(0, 1))
                ones = CInt(decPart.Substring(1, 1))
                If ones > 0 Then
                    tens += 1
                    ones = 0
                End If

                If tens > 9 Then
                    numPart += 1
                    tens = 0
                End If

                res = numPart
                res += (tens * 10) / 100

            End If

            Return res
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Public Function StrVal9(ByVal ValueExpression As Object, Optional ByVal CustomNumberFormat As Boolean = False) As Decimal
        Try
            Dim GivenValue As String = ValueExpression.ToString.Replace("$", "").Replace(",", "").Trim
            Select Case True
                Case InStr(ValueExpression, "%") <> 0
                    GivenValue = CDec(GivenValue.Replace("%", "")) / 100
                Case Else
                    GivenValue = CDec(GivenValue)
            End Select


            Return Convert.ToDecimal(GivenValue)
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Public Function IsEmptyString(ByVal Str As String) As Boolean
        Return String.IsNullOrEmpty(Trim(Str))
    End Function

    Public Function ProperCase(ByVal Str As String) As String
        Dim tmpStrArr() As String = Str.Split(" ")
        Dim res As String = ""
        If Not IsNothing(tmpStrArr) Then
            For i As Integer = 0 To UBound(tmpStrArr)
                Dim tmp As String = tmpStrArr(i)
                If Not IsEmptyString(tmp) Then
                    tmp = Left(tmp, 1).ToUpper + Right(tmp, Len(tmp) - 1).ToLower
                    res &= tmp + " "
                End If
            Next
            res.TrimEnd(" ")
        End If

        Return res
    End Function

    Public Function GetColumnInfo(ByVal ColumnDefinitionString As String) As Collection
        Dim Columns As Collection
        Dim ColStr() As String
        Try
            If Not IsEmptyString(ColumnDefinitionString) Then
                Columns = New Collection
                ColStr = ColumnDefinitionString.Split("@")

                For i As Integer = 1 To UBound(ColStr)
                    Dim column As New ColumnInfo
                    Dim colInfoString() As String = ColStr(i).Split("|")

                    With column
                        .Caption = colInfoString(1).TrimEnd(ChrW(Keys.Tab))
                        .FieldName = colInfoString(2).TrimEnd(ChrW(Keys.Tab)).ToLower
                        If colInfoString(3).TrimEnd(ChrW(Keys.Tab)).Contains("*") Then
                            .Fixed = True
                        Else
                            .Fixed = False
                        End If
                        If colInfoString(3).TrimEnd(ChrW(Keys.Tab)).Contains("-") Then
                            .Locked = True
                        Else
                            .Locked = False
                        End If
                        .Width = colInfoString(3).TrimEnd(ChrW(Keys.Tab)).Replace("*", "").Replace("-", "")
                        .OutputCtrl = colInfoString(4).TrimEnd(ChrW(Keys.Tab))
                        .Format = colInfoString(5).TrimEnd(ChrW(Keys.Tab))
                        Select Case .Format.ToLower
                            Case "currency"
                                .Format = "n2"
                            Case "int", "integer"
                                .Format = "n0"
                            Case "date"
                                .Format = "d"
                            Case "time"
                                .Format = "t"
                            Case "percent", "p"
                                .Format = "p"
                            Case "bool"
                                .Format = "bool"
                            Case "memo"
                                .Format = "memo"
                            Case "datetime"
                                .Format = "datetime"
                            Case Else
                                .Format = .Format.ToLower
                        End Select
                        .CustProperty = colInfoString(6).TrimEnd(ChrW(Keys.Tab))
                        .OutputField = colInfoString(7).TrimEnd(ChrW(Keys.Tab))
                        .DefaultValue = colInfoString(8).TrimEnd(ChrW(Keys.Tab)).Trim
                    End With

                    Columns.Add(column, column.FieldName)
                Next
            End If
        Catch ex As Exception

        End Try


        Return Columns

    End Function

    Public Function GenerateSystemPK() As Integer
        Return System.Guid.NewGuid.GetHashCode()
    End Function

    Public Function GetPK() As String
        Return SequentialGUID.Create(IIf(AppData.DBProvider = DataProviderType.Mysql, SequentialGuidType.SequentialAsString, SequentialGuidType.SequentialAtEnd)).ToString
    End Function

    Public Function CreateObject(ByVal ObjectName As String, ByVal ParamArray Params() As Object) As Object
        Try
            'Dim FormName1 As String
            Dim FullTypeName As String
            Dim FormInstanceType As Type

            Dim st As New StackTrace()
            FullTypeName = st.GetFrame(1).GetMethod().DeclaringType.FullName
            FullTypeName = String.Format("{0}.{1}", FullTypeName.Split(".")(0), ObjectName)

            'FullTypeName = FormName1
            FormInstanceType = Type.GetType(FullTypeName, True, True)
            If Params.Length = 0 Then
                Return Activator.CreateInstance(FormInstanceType)
            Else
                Return Activator.CreateInstance(FormInstanceType, Params)
            End If


        Catch ex As Exception
            Return Nothing
        End Try

    End Function


    Public Function getPickListData(ByVal FromString As String, ByVal ColumnDefString As String) As DataSet
        Dim pickdata As DataSet
        Try

            If Not IsNothing(ColumnDefString) AndAlso Not IsEmptyString(ColumnDefString) Then
                Dim sqlQry As String
                Dim sqlSelect As String = "", sqlFrom As String = "", sqlWhere As String = "", sqlOrderBy As String = "", sqlAdditionalCriteria As String = ""
                Dim pColumns As Collection = GetColumnInfo(ColumnDefString)
                If Not IsNothing(pColumns) Then
                    For Each col As ColumnInfo In pColumns
                        sqlSelect &= col.FieldName + ","
                    Next

                    sqlSelect = "SELECT " + sqlSelect.TrimEnd(",")
                    '''''''''''''''''BUILD QUERY'''''''''''''''''
                    'Build FROM SQL
                    Dim tmp() As String = FromString.Split("|")

                    For i As Integer = 0 To UBound(tmp)
                        If tmp(i) <> "" Then
                            With tmp(i).ToUpper
                                Select Case True
                                    Case .Contains("FROM")
                                        sqlFrom = tmp(i).Trim
                                    Case .Contains("WHERE")
                                        sqlWhere = tmp(i).Trim
                                    Case .Contains("ORDER BY")
                                        sqlOrderBy = tmp(i).Trim
                                End Select
                            End With
                        End If
                    Next

                    'BUILD SQL QUERY STRING
                    sqlQry = String.Format("{0} {1} {2} {3}", sqlSelect, sqlFrom, sqlWhere, sqlOrderBy)

                    Dim tmpCommand As DbCommand
                    Dim tmpConnection As DbConnection
                    Dim tmpDataAdapter As DbDataAdapter


                    tmpConnection = Data.GetConnection
                    tmpConnection.ConnectionString = Data.GetConnectionString

                    tmpCommand = Data.GetCommand
                    tmpCommand.CommandText = sqlQry 'IIf(ApplyFilter, String.Format("{0} WHERE {1}", pQueryString, FilterString), pQueryString)
                    tmpCommand.Connection = tmpConnection

                    tmpDataAdapter = Data.GetDataAdapter
                    tmpDataAdapter.SelectCommand = tmpCommand

                    pickdata = New DataSet
                    pickdata.Tables.Add("lookupsource")
                    pickdata.EnforceConstraints = False

                    pickdata.Tables("lookupsource").BeginLoadData()
                    tmpDataAdapter.Fill(pickdata.Tables("lookupsource"))
                    pickdata.Tables("lookupsource").EndLoadData()

                    Application.DoEvents()
                    Return pickdata
                End If

            End If

        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function GetApplicationPath() As String
        Try
            Dim _AppPath As String, _ExeName As String
            _AppPath = System.Reflection.Assembly.GetExecutingAssembly.Location
            _ExeName = Dir(_AppPath)
            _AppPath = Path.GetFullPath((Left(_AppPath, (Len(_AppPath) - Len(_ExeName)))))

            Return _AppPath
        Catch ex As Exception
            Return ""
        End Try
    End Function

    Public Function ShowSaveFileDialog(ByVal title As String, ByVal DefaultFilename As String, ByVal filter As String) As String
        Dim dlg As SaveFileDialog = New SaveFileDialog()
        Dim name As String = DefaultFilename
        Dim n As Integer = name.LastIndexOf(".") + 1
        If n > 0 Then
            name = name.Substring(n, name.Length - n)
        End If
        dlg.Title = title
        dlg.FileName = name
        dlg.Filter = filter
        If dlg.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Return dlg.FileName
        End If
        Return ""
    End Function

    Public Function ShowOpenFileDialog(ByVal title As String, ByVal DefaultFilename As String, ByVal filter As String) As String
        Try
            Dim dlg As OpenFileDialog = New OpenFileDialog()
            Dim name As String = DefaultFilename
            Dim n As Integer = name.LastIndexOf(".") + 1
            If n > 0 Then
                name = name.Substring(n, name.Length - n)
            End If
            dlg.Title = title
            dlg.FileName = name
            dlg.Filter = filter
            If dlg.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                Return dlg.FileName
            End If
            Return ""
        Catch ex As Exception

        End Try

    End Function

    Public Sub AutosizeImage(ByVal Img As Bitmap, ByVal picBox As DevExpress.XtraEditors.PictureEdit, Optional ByVal pSizeMode As PictureBoxSizeMode = PictureBoxSizeMode.CenterImage)
        Try
            picBox.Image = Nothing
            Dim imgOrg As Bitmap
            Dim imgShow As Bitmap
            Dim g As Graphics
            Dim divideBy, divideByH, divideByW As Double
            imgOrg = Img

            divideByW = imgOrg.Width / picBox.Width
            divideByH = imgOrg.Height / picBox.Height
            If divideByW > 1 Or divideByH > 1 Then
                If divideByW > divideByH Then
                    divideBy = divideByW
                Else
                    divideBy = divideByH
                End If

                imgShow = New Bitmap(CInt(CDbl(imgOrg.Width) / divideBy), CInt(CDbl(imgOrg.Height) / divideBy))
                imgShow.SetResolution(imgOrg.HorizontalResolution, imgOrg.VerticalResolution)
                g = Graphics.FromImage(imgShow)
                g.InterpolationMode = Drawing2D.InterpolationMode.HighQualityBicubic
                g.DrawImage(imgOrg, New Rectangle(0, 0, CInt(CDbl(imgOrg.Width) / divideBy), CInt(CDbl(imgOrg.Height) / divideBy)), 0, 0, imgOrg.Width, imgOrg.Height, GraphicsUnit.Pixel)
                g.Dispose()
            Else
                imgShow = New Bitmap(imgOrg.Width, imgOrg.Height)
                imgShow.SetResolution(imgOrg.HorizontalResolution, imgOrg.VerticalResolution)
                g = Graphics.FromImage(imgShow)
                g.InterpolationMode = Drawing2D.InterpolationMode.HighQualityBicubic
                g.DrawImage(imgOrg, New Rectangle(0, 0, imgOrg.Width, imgOrg.Height), 0, 0, imgOrg.Width, imgOrg.Height, GraphicsUnit.Pixel)
                g.Dispose()
            End If
            imgOrg.Dispose()

            picBox.Image = imgShow


        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Public Sub AutosizeImage(ByVal ImagePath As String, ByVal picBox As DevExpress.XtraEditors.PictureEdit, Optional ByVal pSizeMode As PictureBoxSizeMode = PictureBoxSizeMode.CenterImage)
        Try
            picBox.Image = Nothing
            If System.IO.File.Exists(ImagePath) Then
                Dim imgOrg As Bitmap
                Dim imgShow As Bitmap
                Dim g As Graphics
                Dim divideBy, divideByH, divideByW As Double
                imgOrg = DirectCast(Bitmap.FromFile(ImagePath), Bitmap)

                divideByW = imgOrg.Width / picBox.Width
                divideByH = imgOrg.Height / picBox.Height
                If divideByW > 1 Or divideByH > 1 Then
                    If divideByW > divideByH Then
                        divideBy = divideByW
                    Else
                        divideBy = divideByH
                    End If

                    imgShow = New Bitmap(CInt(CDbl(imgOrg.Width) / divideBy), CInt(CDbl(imgOrg.Height) / divideBy))
                    imgShow.SetResolution(imgOrg.HorizontalResolution, imgOrg.VerticalResolution)
                    g = Graphics.FromImage(imgShow)
                    g.InterpolationMode = Drawing2D.InterpolationMode.HighQualityBicubic
                    g.DrawImage(imgOrg, New Rectangle(0, 0, CInt(CDbl(imgOrg.Width) / divideBy), CInt(CDbl(imgOrg.Height) / divideBy)), 0, 0, imgOrg.Width, imgOrg.Height, GraphicsUnit.Pixel)
                    g.Dispose()
                Else
                    imgShow = New Bitmap(imgOrg.Width, imgOrg.Height)
                    imgShow.SetResolution(imgOrg.HorizontalResolution, imgOrg.VerticalResolution)
                    g = Graphics.FromImage(imgShow)
                    g.InterpolationMode = Drawing2D.InterpolationMode.HighQualityBicubic
                    g.DrawImage(imgOrg, New Rectangle(0, 0, imgOrg.Width, imgOrg.Height), 0, 0, imgOrg.Width, imgOrg.Height, GraphicsUnit.Pixel)
                    g.Dispose()
                End If
                imgOrg.Dispose()

                picBox.Image = imgShow
            Else
                picBox.Image = Nothing
            End If


        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Public Function ImageToByte(ByVal img As Bitmap) As Byte()
        Try
            Dim imgStream As MemoryStream = New MemoryStream()

            img.Save(imgStream, System.Drawing.Imaging.ImageFormat.Png)
            imgStream.Close()

            Dim byteArray As Byte() = imgStream.ToArray()

            imgStream.Dispose()

            Return byteArray

        Catch ex As Exception
            Return Nothing
        End Try

    End Function

    Public Function ImageToByte(ByVal imgPath As String) As Byte()
        Try
            Dim imgStream As MemoryStream = New MemoryStream()

            Dim img As Bitmap
            img = DirectCast(Bitmap.FromFile(imgPath), Bitmap)

            img.Save(imgStream, System.Drawing.Imaging.ImageFormat.Png)
            imgStream.Close()

            Dim byteArray As Byte() = imgStream.ToArray()

            imgStream.Dispose()

            Return byteArray

        Catch ex As Exception
            Return Nothing
        End Try

    End Function

    Public Function GetLowerCaseString(ByVal str As String)
        Dim res = ""
        Try
            If Not (IsNothing(str) OrElse String.IsNullOrEmpty(str)) Then
                res = str.ToLower
            End If

        Catch ex As Exception
        End Try
        Return res
    End Function

    Public Sub AutosizeImage(ByVal image As MemoryStream, ByVal picBox As DevExpress.XtraEditors.PictureEdit, Optional ByVal pSizeMode As PictureBoxSizeMode = PictureBoxSizeMode.CenterImage)
        Try
            picBox.Image = Nothing
            If Not IsNothing(image) Then
                Dim imgOrg As Bitmap
                Dim imgShow As Bitmap
                Dim g As Graphics
                Dim divideBy, divideByH, divideByW As Double
                imgOrg = DirectCast(Bitmap.FromStream(image), Bitmap)

                divideByW = imgOrg.Width / picBox.Width
                divideByH = imgOrg.Height / picBox.Height
                If divideByW > 1 Or divideByH > 1 Then
                    If divideByW > divideByH Then
                        divideBy = divideByW
                    Else
                        divideBy = divideByH
                    End If

                    imgShow = New Bitmap(CInt(CDbl(imgOrg.Width) / divideBy), CInt(CDbl(imgOrg.Height) / divideBy))
                    imgShow.SetResolution(imgOrg.HorizontalResolution, imgOrg.VerticalResolution)
                    g = Graphics.FromImage(imgShow)
                    g.InterpolationMode = Drawing2D.InterpolationMode.HighQualityBicubic
                    g.DrawImage(imgOrg, New Rectangle(0, 0, CInt(CDbl(imgOrg.Width) / divideBy), CInt(CDbl(imgOrg.Height) / divideBy)), 0, 0, imgOrg.Width, imgOrg.Height, GraphicsUnit.Pixel)
                    g.Dispose()
                Else
                    imgShow = New Bitmap(imgOrg.Width, imgOrg.Height)
                    imgShow.SetResolution(imgOrg.HorizontalResolution, imgOrg.VerticalResolution)
                    g = Graphics.FromImage(imgShow)
                    g.InterpolationMode = Drawing2D.InterpolationMode.HighQualityBicubic
                    g.DrawImage(imgOrg, New Rectangle(0, 0, imgOrg.Width, imgOrg.Height), 0, 0, imgOrg.Width, imgOrg.Height, GraphicsUnit.Pixel)
                    g.Dispose()
                End If
                imgOrg.Dispose()

                picBox.Image = imgShow
            Else
                picBox.Image = Nothing
            End If


        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Public Sub AutosizeImage(ByVal image As MemoryStream, ByVal picBox As XRPictureBox, Optional ByVal pSizeMode As PictureBoxSizeMode = PictureBoxSizeMode.CenterImage)
        Try
            picBox.Image = Nothing
            If Not IsNothing(image) Then
                Dim imgOrg As Bitmap
                Dim imgShow As Bitmap
                Dim g As Graphics
                Dim divideBy, divideByH, divideByW As Double
                imgOrg = DirectCast(Bitmap.FromStream(image), Bitmap)

                divideByW = imgOrg.Width / picBox.Width
                divideByH = imgOrg.Height / picBox.Height
                If divideByW > 1 Or divideByH > 1 Then
                    If divideByW > divideByH Then
                        divideBy = divideByW
                    Else
                        divideBy = divideByH
                    End If

                    imgShow = New Bitmap(CInt(CDbl(imgOrg.Width) / divideBy), CInt(CDbl(imgOrg.Height) / divideBy))
                    imgShow.SetResolution(imgOrg.HorizontalResolution, imgOrg.VerticalResolution)
                    g = Graphics.FromImage(imgShow)
                    g.InterpolationMode = Drawing2D.InterpolationMode.HighQualityBicubic
                    g.DrawImage(imgOrg, New Rectangle(0, 0, CInt(CDbl(imgOrg.Width) / divideBy), CInt(CDbl(imgOrg.Height) / divideBy)), 0, 0, imgOrg.Width, imgOrg.Height, GraphicsUnit.Pixel)
                    g.Dispose()
                Else
                    imgShow = New Bitmap(imgOrg.Width, imgOrg.Height)
                    imgShow.SetResolution(imgOrg.HorizontalResolution, imgOrg.VerticalResolution)
                    g = Graphics.FromImage(imgShow)
                    g.InterpolationMode = Drawing2D.InterpolationMode.HighQualityBicubic
                    g.DrawImage(imgOrg, New Rectangle(0, 0, imgOrg.Width, imgOrg.Height), 0, 0, imgOrg.Width, imgOrg.Height, GraphicsUnit.Pixel)
                    g.Dispose()
                End If
                imgOrg.Dispose()

                picBox.Image = imgShow
            Else
                picBox.Image = Nothing
            End If


        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Public Sub CreateDetailGridColumns(ByVal Grid As Control, ByVal ColumnsCollection As Collection, Optional ByVal ContainerForm As Form = Nothing)

        Dim OwnerForm As Form
        If IsNothing(ContainerForm) Then
            OwnerForm = Grid.FindForm
        Else
            OwnerForm = ContainerForm
        End If
        Try
            If OwnerForm.InvokeRequired Then
                OwnerForm.Invoke(New CreateGridColumnsCrossThreadDelegate(AddressOf CreateDetailGridColumns), Grid, ColumnsCollection)
            Else
                Dim myGrid As GridControl = CType(Grid, GridControl)
                Dim columnView As GridView = DirectCast(myGrid.MainView, GridView)
                With columnView
                    .Columns.Clear()

                    If Not IsNothing(ColumnsCollection) Then
                        For Each col As ColumnInfo In ColumnsCollection
                            Dim tempFieldName As String = col.FieldName
                            If tempFieldName.ToLower.Contains(" as ") Then
                                tempFieldName = tempFieldName.ToLower.Replace(" as ", "|").Split("|")(1)
                            ElseIf tempFieldName.ToLower.Contains(" ") Then
                                If OwnerForm.Name = "PickListBase4" Then
                                    tempFieldName = tempFieldName.Split(" ")(tempFieldName.Split(" ").Length - 1)
                                End If

                            End If
                            .Columns.AddField(tempFieldName)
                            With .Columns(tempFieldName)
                                .AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                                .OptionsColumn.FixedWidth = False
                                If col.Caption.ToUpper.Contains("\") Then
                                    .Caption = col.Caption.ToUpper.Split("\")(0) & Global.Microsoft.VisualBasic.ChrW(10) & col.Caption.ToUpper.Split("\")(1)
                                Else
                                    .Caption = col.Caption.ToUpper
                                End If

                                .Width = col.Width

                                If Not IsEmptyString(col.Format) Then

                                    Select Case col.Format.ToLower
                                        Case "p", "p2"

                                            Dim repEdit As New RepositoryItemTextEdit
                                            repEdit.ReadOnly = False
                                            myGrid.RepositoryItems.Add(repEdit)

                                            repEdit.Mask.EditMask = "p"
                                            repEdit.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
                                            repEdit.Mask.UseMaskAsDisplayFormat = True

                                            .ColumnEdit = repEdit
                                        Case "image"
                                            Dim repEdit As New RepositoryItemPictureEdit
                                            myGrid.RepositoryItems.Add(repEdit)
                                            repEdit.SizeMode = Controls.PictureSizeMode.Zoom
                                            repEdit.NullText = " "
                                            .ColumnEdit = repEdit
                                        Case "button"
                                            Dim repEdit As New RepositoryItemButtonEdit
                                            myGrid.RepositoryItems.Add(repEdit)
                                            repEdit.TextEditStyle = Controls.TextEditStyles.HideTextEditor

                                            .ColumnEdit = repEdit
                                        Case "memo"
                                            Dim repEdit As New RepositoryItemMemoEdit
                                            myGrid.RepositoryItems.Add(repEdit)
                                            repEdit.AutoHeight = True
                                            repEdit.WordWrap = True
                                            .ColumnEdit = repEdit

                                            columnView.OptionsView.RowAutoHeight = True

                                        Case "n0"

                                            Dim repEdit As New RepositoryItemTextEdit
                                            repEdit.ReadOnly = False
                                            myGrid.RepositoryItems.Add(repEdit)

                                            repEdit.Mask.EditMask = "n0"
                                            repEdit.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
                                            repEdit.Mask.UseMaskAsDisplayFormat = True

                                            .ColumnEdit = repEdit

                                        Case "n1", "n2", "n3", "n4"

                                            Dim repEdit As New RepositoryItemTextEdit
                                            repEdit.ReadOnly = False
                                            myGrid.RepositoryItems.Add(repEdit)

                                            repEdit.Mask.EditMask = col.Format
                                            repEdit.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
                                            repEdit.Mask.UseMaskAsDisplayFormat = True

                                            .ColumnEdit = repEdit

                                        Case "d"
                                            Dim repEdit As New RepositoryItemDateEdit
                                            myGrid.RepositoryItems.Add(repEdit)
                                            repEdit.Mask.EditMask = "d"
                                            repEdit.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime
                                            repEdit.Mask.UseMaskAsDisplayFormat = True
                                            .ColumnEdit = repEdit
                                        Case "t"
                                            Dim repEdit As New RepositoryItemTimeEdit
                                            myGrid.RepositoryItems.Add(repEdit)
                                            repEdit.Mask.EditMask = "t"
                                            repEdit.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime
                                            repEdit.Mask.UseMaskAsDisplayFormat = True
                                            .ColumnEdit = repEdit

                                        Case "datetime"
                                            Dim repEdit As New RepositoryItemTimeEdit
                                            myGrid.RepositoryItems.Add(repEdit)
                                            repEdit.Mask.EditMask = "yyyy-MM-dd HH:mm"
                                            repEdit.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime
                                            repEdit.Mask.UseMaskAsDisplayFormat = True
                                            .ColumnEdit = repEdit

                                        Case "mm/yyyy"
                                            Dim repEdit As New RepositoryItemTimeEdit
                                            myGrid.RepositoryItems.Add(repEdit)
                                            repEdit.Mask.EditMask = "MM/yyyy"
                                            repEdit.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime
                                            repEdit.Mask.UseMaskAsDisplayFormat = True
                                            .ColumnEdit = repEdit

                                        Case "MMMM yyyy"
                                            Dim repEdit As New RepositoryItemTimeEdit
                                            myGrid.RepositoryItems.Add(repEdit)
                                            repEdit.Mask.EditMask = "MMMM yyyy"
                                            repEdit.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime
                                            repEdit.Mask.UseMaskAsDisplayFormat = True
                                            .ColumnEdit = repEdit
                                        Case "bool"
                                            Dim repEdit As New RepositoryItemCheckEdit
                                            myGrid.RepositoryItems.Add(repEdit)
                                            With repEdit
                                                repEdit.ValueChecked = 1
                                                repEdit.ValueUnchecked = 0
                                                repEdit.AllowGrayed = False

                                                repEdit.DisplayValueChecked = CBool(1)
                                                repEdit.DisplayValueGrayed = CBool(0)
                                                repEdit.DisplayValueUnchecked = CBool(0)
                                                repEdit.NullStyle = Controls.StyleIndeterminate.Unchecked
                                            End With
                                            .ColumnEdit = repEdit


                                        Case Else
                                            Dim repEdit As New RepositoryItemTextEdit()
                                            myGrid.RepositoryItems.Add(repEdit)

                                            repEdit.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Custom
                                            repEdit.Mask.EditMask = col.Format
                                            repEdit.Mask.UseMaskAsDisplayFormat = True

                                            .ColumnEdit = repEdit
                                    End Select

                                End If
                                .Fixed = col.Fixed
                                .OptionsColumn.AllowEdit = Not col.Locked
                                .Visible = IIf(col.Width > 0, True, False)
                                Dim valueSource As String = col.CustProperty.ToLower.Split(":")(0)
                                If valueSource = "total" Then
                                    columnView.OptionsView.ShowFooter = True
                                    .SummaryItem.FieldName = col.FieldName
                                    .SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                                    .SummaryItem.DisplayFormat = "{0:n2}"
                                ElseIf valueSource = "combo" Then
                                    Try
                                        Application.DoEvents()
                                        Dim cbEdit As New RepositoryItemComboBox
                                        If col.CustProperty.ToLower.Split(":")(1).Contains(",") Then
                                            Dim strcombo As String() = col.CustProperty.Split(":")(1).Split(",")
                                            For i As Integer = 0 To strcombo.Length - 1
                                                cbEdit.Items.Add(strcombo(i))
                                            Next
                                        Else
                                            'Dim srcCombo As ComboBoxInput = CType(CType(Grid.FindForm, EditorBase).GetControl(col.CustProperty.ToLower.Split(":")(1)), ComboBoxEdit)

                                            'With srcCombo.Properties
                                            '    For i As Integer = 0 To .Items.Count - 1
                                            '        cbEdit.Items.Add(.Items(i))
                                            '    Next
                                            'End With
                                        End If

                                        .ColumnEdit = cbEdit
                                    Catch ex As Exception

                                    End Try
                                    '.ColumnEdit = CType(CType(myGrid.FindForm, EditorBase).GetControl(col.CustProperty), RepositoryItemComboBox)
                                    'If Me.GridMode <> GridModeEnum.Navigation Then .ColumnEdit = CType(pComboEdit(col.FieldName), RepositoryItemComboBox)
                                ElseIf valueSource = "picklist" Then
                                    .Tag = "picklist"
                                    .OptionsColumn.AllowEdit = False
                                ElseIf valueSource = "gridlookup" Then
                                    'Dim GridLookUpInfo As GridPickListInfo = DirectCast(CType(OwnerForm, EditorBase).GetControl(col.CustProperty.ToLower.Split(":")(1)), GridPickListInfo)
                                    'Dim repEdit As New RepositoryItemGridLookUpEdit
                                    'With repEdit
                                    '    '.ValueMember = col.FieldName
                                    '    '.DisplayMember = col.FieldName
                                    '    .NullText = ""
                                    '    .PopupFilterMode = PopupFilterMode.Contains
                                    '    .TextEditStyle = Controls.TextEditStyles.Standard
                                    '    .AutoComplete = True
                                    '    .ImmediatePopup = True
                                    '    .PopupSizeable = True
                                    '    .View.OptionsView.ShowAutoFilterRow = True

                                    '    ''''''GO HERE

                                    '    PrepareGridLookUpEdit(repEdit, GridLookUpInfo, OwnerForm)

                                    'End With
                                    '.ColumnEdit = repEdit
                                End If

                                .OptionsFilter.AutoFilterCondition = IIf(col.Format <> "", AutoFilterCondition.Default, AutoFilterCondition.Contains)

                            End With


                        Next

                    End If

                End With
            End If

        Catch ex As Exception

        End Try
    End Sub
    Public Sub CreateLookUpEditColumns(ByVal Grid As RepositoryItemGridLookUpEdit, ByVal ColumnsCollection As Collection, ByVal ownerForm As Form)

        Try
            If ownerForm.InvokeRequired Then
                ownerForm.Invoke(New CreateGridColumnsCrossThreadDelegate(AddressOf CreateDetailGridColumns), Grid, ColumnsCollection)
            Else
                Dim columnView As GridView = DirectCast(Grid.View, GridView)
                With columnView
                    .Columns.Clear()

                    If Not IsNothing(ColumnsCollection) Then
                        For Each col As ColumnInfo In ColumnsCollection
                            'Dim ncol As GridColumn = New GridColumn
                            .Columns.AddField(col.FieldName)

                            With .Columns(col.FieldName)
                                '.FieldName = col.FieldName

                                .OptionsColumn.FixedWidth = False
                                .Caption = ProperCase(col.Caption)
                                .Width = col.Width

                                If Not IsEmptyString(col.Format) Then

                                    Select Case col.Format
                                        Case "p"
                                            .DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                                            .DisplayFormat.FormatString = col.Format

                                        Case "n0"
                                            .DisplayFormat.FormatString = col.Format
                                            .DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric

                                        Case "n2"
                                            .DisplayFormat.FormatString = col.Format
                                            .DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric

                                        Case "d", "date"
                                            .DisplayFormat.FormatString = col.Format
                                            .DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime

                                        Case Else
                                            .DisplayFormat.FormatString = col.Format
                                            .DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
                                    End Select

                                    '.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
                                End If
                                .Fixed = col.Fixed
                                .Visible = IIf(col.Width > 0, True, False)
                                .OptionsFilter.AutoFilterCondition = IIf(col.Format <> "", AutoFilterCondition.Default, AutoFilterCondition.Contains)

                            End With


                        Next

                    End If

                End With
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Function BuildGridLookUpData(ByVal LookUpInfo As GridPickListInfo) As DataTable
        Try
            Dim dsResult As DataSet
            Dim displaySelectString As String = ""
            Dim DisplayFromString As String = ""
            Dim DisplayWhereString As String = ""
            Dim DisplayOrderByString As String = ""
            Dim DetailDataConnection As DbConnection

            'BUILD QUERY INFO
            Dim DetailColumns As Collection
            DetailColumns = GetColumnInfo(LookUpInfo._PickColumnsInfo)

            If Not DetailColumns Is Nothing Then

                Dim FieldNames = From Column As ColumnInfo In DetailColumns
                                 Select Column.FieldName

                For Each FieldName As Object In FieldNames
                    Dim Field As String = DirectCast(FieldName, String)
                    displaySelectString &= Field + ","
                Next

                displaySelectString = "SELECT " + displaySelectString.TrimEnd(",")
                '''''NEXT HERE
                Dim tmp() As String = LookUpInfo._PickTableFromInfo.Split("|")

                For i As Integer = 0 To UBound(tmp)
                    If tmp(i) <> "" Then
                        With tmp(i).ToUpper
                            Select Case True
                                Case .Contains("FROM")
                                    DisplayFromString = tmp(i).Trim
                                Case .Contains("WHERE")
                                    DisplayWhereString = tmp(i).Trim
                                Case .Contains("ORDER BY")
                                    DisplayOrderByString = tmp(i).Trim
                            End Select
                        End With
                    End If
                Next

                displaySelectString &= " " & DisplayFromString
                If DisplayWhereString <> "" Then displaySelectString &= " " & DisplayWhereString
                If DisplayOrderByString <> "" Then displaySelectString &= " " & DisplayOrderByString

            End If
            'END OF BUILD QUERY INFO


            'BUILD LOOKUP DATA
            dsResult = New DataSet

            If DetailDataConnection Is Nothing Then
                DetailDataConnection = New MySqlConnection() ''DBFactory.GetConnection(AppData.DBProvider)
                DetailDataConnection.ConnectionString = AppData.ConnectionString
            End If

            Dim tmpDataAdapter = New MySqlDataAdapter() ''DBFactory.GetDataAdapter(AppData.DBProvider)
            With tmpDataAdapter
                .SelectCommand = New MySqlCommand() ''DBFactory.GetCommand(AppData.DBProvider)
                .SelectCommand.CommandType = CommandType.Text
                .SelectCommand.CommandText = displaySelectString
                .SelectCommand.Connection = DetailDataConnection
            End With

            If DetailDataConnection.State <> System.Data.ConnectionState.Open Then _
                DetailDataConnection.Open()
            tmpDataAdapter.Fill(dsResult, "TableData")

            Return dsResult.Tables("TableData")
            'END OF BUILD LOOKUP DATA


        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Private Sub PrepareGridLookUpEdit(ByVal LookUpEditor As RepositoryItemGridLookUpEdit, ByVal GridLookUpInfo As GridPickListInfo, ByVal ownerForm As Form)
        Try
            CreateLookUpEditColumns(LookUpEditor, GetColumnInfo(GridLookUpInfo._PickColumnsInfo), ownerForm)
            LookUpEditor.DataSource = BuildGridLookUpData(GridLookUpInfo)

            LookUpEditor.ValueMember = GridLookUpInfo.ValueMember.ToLower
            LookUpEditor.DisplayMember = GridLookUpInfo.ValueMember.ToLower
            LookUpEditor.Tag = GridLookUpInfo.Name
            LookUpEditor.PopupFormSize = New Size(650, LookUpEditor.PopupFormMinSize.Height)

        Catch ex As Exception

        End Try
    End Sub

    Public Sub WriteValueToRegistry(ByVal Section As String, ByVal Key As String, ByVal data As Object, ByVal ValueType As Microsoft.Win32.RegistryValueKind)
        Try
            Dim regHive As String = "HKEY_CURRENT_USER\SOFTWARE\KENTNOBLE"
            My.Computer.Registry.SetValue(String.Format("{0}\{1}\{2}", regHive, Project.Instance.ExeName, Section), Key, data, ValueType)
        Catch ex As Exception

        End Try

    End Sub

    Public Function GetValueFromRegistry(ByVal Section As String, ByVal Key As String) As Object
        Try

            Dim regHive As String = "HKEY_CURRENT_USER\SOFTWARE\KENTNOBLE"
            'MsgBox(Project.Instance.ExeName)
            Return My.Computer.Registry.GetValue(String.Format("{0}\{1}\{2}", regHive, Project.Instance.ExeName, Section), Key, Nothing)
        Catch ex As Exception

        End Try
    End Function

    Public Sub ShowControl(ByVal ctrl As Control)
        Try
            If ctrl.FindForm.InvokeRequired Then
                ctrl.FindForm.Invoke(New CrossThreadMethodInvokerDelegate(AddressOf HideControl), ctrl)
            Else
                ctrl.Visible = True
            End If
        Catch ex As Exception

        End Try
    End Sub

    Public Sub HideControl(ByVal ctrl As Control)
        Try
            If ctrl.FindForm.InvokeRequired Then
                ctrl.FindForm.Invoke(New CrossThreadMethodInvokerDelegate(AddressOf HideControl), ctrl)
            Else
                ctrl.Visible = False
            End If
        Catch ex As Exception

        End Try
    End Sub

    Public Sub UpdateInventory(ByVal FK_Invty As String)
        If FK_Invty = "" Then Exit Sub 'dont continue if no FK_Invy

        Try

            Dim sql_qtyi As String = String.Format("SELECT IFNULL(SUM(QtyIn_LdgrInvty/UnitConversion_LdgrInvty),0) as qty FROM Transaction_Ledger_Inventories WHERE Module_LdgrInvty = 'IN' AND FK_Invty_LdgrInvty='{0}'", FK_Invty)
            Dim dti As DataTable = AppData.GetDataTable(sql_qtyi)

            Dim sql_qtyo As String = String.Format("SELECT  IFNULL(SUM(QtyOut_LdgrInvty/UnitConversion_LdgrInvty),0) as qty FROM Transaction_Ledger_Inventories WHERE Module_LdgrInvty = 'OUT' AND FK_Invty_LdgrInvty='{0}'", FK_Invty)
            Dim dto As DataTable = AppData.GetDataTable(sql_qtyo)

            Dim sql_upd = String.Format("UPDATE inventories SET Quantity_Invty = '{0}' where PK_Invty = '{1}'", dti.Rows(0)("qty") - dto.Rows(0)("qty"), FK_Invty)
            AppData.ExecuteNonQuery(sql_upd)


            'End If
        Catch ex As Exception

        End Try

    End Sub

    Public Sub UpdateCOABalance(ByVal PK_COA As String)
        Try
            Dim sql As String = String.Format("Select NormalBalance_CoaTM from chart_of_accounts left join chart_of_account_types on FK_CoaTM_COA = PK_CoaTM where PK_COA = '{0}'", PK_COA)
            Dim dt As DataTable = AppData.GetDataTable(sql)

            Dim normalBalance As String = dt.Rows(0)("NormalBalance_CoaTM").ToString.ToLower

            Dim sqlTotal As String = String.Format("Select IFNULL(SUM(DRAmount_LdgrEntries),0) as dramount, IFNULL(SUM(CRAmount_LdgrEntries),0) as cramount from transaction_ledger_entries where IsVoid_LdgrEntries <> 1 AND FK_COA_Ldgrentries = '{0}' and Module_LdgrEntries LIKE '%GENENTRY%'", PK_COA)
            Dim dtTotal As DataTable = AppData.GetDataTable(sqlTotal)
            Dim balance = 0
            If normalBalance = "debit" Then
                balance = StrVal9(dtTotal.Rows(0)("dramount")) - StrVal9(dtTotal.Rows(0)("cramount"))
            Else
                balance = StrVal9(dtTotal.Rows(0)("cramount")) - StrVal9(dtTotal.Rows(0)("dramount"))
            End If
            Dim sqlUpdate As String = String.Format("Update chart_of_accounts set Balance_COA = '{0}' where PK_COA = '{1}'", balance, PK_COA)
            AppData.ExecuteNonQuery(sqlUpdate)
        Catch ex As Exception

        End Try
    End Sub

    Public Sub PostPayment(ByVal EntriesSL As String, ByVal TitleCOA As String)
        Try
            Dim dtPayments As DataTable
            Dim tmpSQL, status As String

            Dim balance, payments As Double

            If EntriesSL <> "00000000-0000-0000-0000-000000000000" And TitleCOA <> "" Then

                tmpSQL = "SELECT SUM(DRAmount_LdgrEntries) as TotalDebit, SUM(CRAmount_LdgrEntries) as TotalCredit " &
                            "FROM transaction_header INNER JOIN Transaction_Ledger_Entries ON PK_TransH=FK_TransH_LdgrEntries " &
                            "WHERE (ModuleTrans_LdgrEntries='DUE' or ModuleTrans_LdgrEntries='PAY' or ModuleTrans_LdgrEntries='ADJ') AND FK_LdgrEntriesSL_LdgrEntries=" & AddQuote9(EntriesSL)

                dtPayments = AppData.GetDataTable(tmpSQL)

                If Not IsNothing(dtPayments) AndAlso dtPayments.Rows.Count > 0 Then
                    Select Case True
                        Case TitleCOA.ToLower.Contains("receivable") OrElse TitleCOA.Contains("AR ") OrElse TitleCOA.ToLower.Contains("security ") OrElse TitleCOA.ToLower.Contains("advance ")
                            If Not IsDBNull(dtPayments.Rows(0)("TotalCredit")) Then
                                payments = FormatNumber(StrVal9(dtPayments.Rows(0)("TotalCredit")), 2)
                            End If
                            If Not IsDBNull(dtPayments.Rows(0)("TotalDebit")) Then
                                balance = FormatNumber(StrVal9(dtPayments.Rows(0)("TotalDebit")) - payments, 2)
                            End If

                        Case TitleCOA.ToLower.Contains("payable") OrElse TitleCOA.ToLower.Contains("AP ")
                            If Not IsDBNull(dtPayments.Rows(0)("TotalDebit")) Then
                                payments = FormatNumber(StrVal9(dtPayments.Rows(0)("TotalDebit")), 2)
                            End If
                            If Not IsDBNull(dtPayments.Rows(0)("TotalCredit")) Then
                                balance = FormatNumber(StrVal9(dtPayments.Rows(0)("TotalCredit")) - payments, 2)
                            End If
                        Case Else
                            If Not IsDBNull(dtPayments.Rows(0)("TotalCredit")) Then
                                payments = FormatNumber(StrVal9(dtPayments.Rows(0)("TotalCredit")), 2)
                            End If
                            If Not IsDBNull(dtPayments.Rows(0)("TotalDebit")) Then
                                balance = FormatNumber(StrVal9(dtPayments.Rows(0)("TotalDebit")) - payments, 2)
                            End If
                    End Select
                End If

                Select Case True
                    Case FormatNumber(balance, 2) > 0 And FormatNumber(payments, 2) = 0
                        status = "'UnPaid'"
                    Case FormatNumber(balance, 2) > 0 And FormatNumber(payments, 2) > 0
                        status = "'Part Pd'"
                    Case FormatNumber(balance, 2) = 0 And FormatNumber(payments, 2) > 0
                        status = "'Fully Pd'"
                    Case FormatNumber(balance, 2) < 0 And FormatNumber(payments, 2) > 0
                        status = "'Over Pd'"
                End Select

                Dim updateSQL As String
                Try
                    updateSQL = "UPDATE Transaction_Ledger_Entries " &
                               "SET AmountPayClr_LdgrEntries = " & payments & "," &
                                   "Balance_LdgrEntries = " & balance & "," &
                                   "Status_LdgrEntries = " & status & " " &
                               "WHERE PK_LdgrEntries=" & AddQuote9(EntriesSL)

                    AppData.ExecuteNonQuery(updateSQL)
                Catch ex As Exception

                End Try
            Else
                Exit Sub
            End If
        Catch ex As Exception

        End Try
    End Sub
End Module
