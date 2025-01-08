Imports System.Data.Common
Imports System.Data
Imports DevExpress.XtraEditors
Imports MySql.Data.MySqlClient

Public NotInheritable Class DataManager
    Private strConnectionString As [String]
    Private dataProviderType As DataProviderType

    Public Sub New(ByVal providerType As DataProviderType, ByVal connectionString As String)
        Me.strConnectionString = connectionString
        Me.dataProviderType = providerType
    End Sub

    Public Function TryConnect() As Boolean
        Dim cur As Cursor = Cursor.Current
        Cursor.Current = Cursors.WaitCursor
        Using conn As DbConnection = New MySqlConnection()

            Try
                conn.ConnectionString = Me.strConnectionString
                conn.Open()
                Return True
            Catch
                Return False
            Finally
                conn.Close()
            End Try
        End Using
    End Function


    Public ReadOnly Property ConnectionString() As [String]
        Get
            Return strConnectionString
        End Get
    End Property

    Public ReadOnly Property DBProvider() As DataProviderType
        Get
            Return dataProviderType
        End Get
    End Property

    Public Function GetDataSet(ByVal query As String) As DataSet
        Return GetDataSet(query, CommandType.Text)
    End Function

    Public Function GetDataSet(ByVal query As String, ByVal CommandType As CommandType) As DataSet
        Return GetDataSet(query, CommandType, Nothing)
    End Function

    Public Function GetDataSet(ByVal sqlString As [String], ByVal CommandType As CommandType, ByVal ParamArray Parameters() As DbParameter) As DataSet
        Using dbConn As DbConnection = New MySqlConnection()
            dbConn.ConnectionString = Me.ConnectionString
            Using dbDataAdapter As DbDataAdapter = New MySqlDataAdapter()
                Try
                    With dbDataAdapter
                        .SelectCommand = New MySqlCommand()
                        .SelectCommand.CommandType = CommandType
                        .SelectCommand.CommandText = sqlString
                        If Not IsNothing(Parameters) Then _
                           .SelectCommand.Parameters.AddRange(Parameters)
                        .SelectCommand.Connection = dbConn
                    End With
                    dbConn.Open()

                    Dim dataSet As New DataSet()
                    Dim dataTable As New DataTable()
                    dataTable.BeginLoadData()
                    dbDataAdapter.Fill(dataTable)
                    dataTable.EndLoadData()
                    dataSet.EnforceConstraints = False
                    dataSet.Tables.Add(dataTable)
                    Return dataSet

                Catch ex As Exception
                    Return Nothing
                Finally
                    dbConn.Close()
                End Try
            End Using
        End Using

    End Function

    Public Function ExecuteReader(ByVal query As String) As DbDataReader
        Return ExecuteReader(query, CommandType.Text)
    End Function

    Public Function ExecuteReader(ByVal query As String, ByVal CommandType As CommandType) As DbDataReader
        Return ExecuteReader(query, CommandType.Text, Nothing)
    End Function

    Public Function ExecuteReader(ByVal sqlString As [String], ByVal CommandType As CommandType, ByVal ParamArray Parameters() As DbParameter) As DbDataReader
        Dim DataReader As DbDataReader
        Using dbConn As DbConnection = New MySqlConnection()
            dbConn.ConnectionString = Me.ConnectionString
            Using DbCommand As DbCommand = New MySqlCommand()
                Try
                    With DbCommand
                        .CommandType = CommandType
                        .CommandText = sqlString
                        If Not IsNothing(Parameters) Then _
                           .Parameters.AddRange(Parameters)
                        .Connection = dbConn
                    End With
                    dbConn.Open()
                    DataReader = DbCommand.ExecuteReader
                    Return DataReader

                Catch ex As Exception
                    Return Nothing
                Finally
                    dbConn.Close()
                End Try
            End Using
        End Using


    End Function

    Public Function ExecuteScalar(ByVal query As String) As Object
        Return ExecuteScalar(query, CommandType.Text)
    End Function

    Public Function ExecuteScalar(ByVal query As String, ByVal CommandType As CommandType) As Object
        Return ExecuteScalar(query, CommandType.Text, Nothing)
    End Function

    Public Function ExecuteScalar(ByVal sqlString As [String], ByVal CommandType As CommandType, ByVal ParamArray Parameters() As DbParameter) As Object
        Dim Result As Object
        Using dbConn As DbConnection = New MySqlConnection()
            dbConn.ConnectionString = Me.ConnectionString
            Using DbCmd As DbCommand = New MySqlCommand()
                Try
                    With DbCmd
                        .CommandType = CommandType
                        .CommandText = sqlString
                        If Not IsNothing(Parameters) Then _
                           .Parameters.AddRange(Parameters)
                        .Connection = dbConn
                    End With
                    dbConn.Open()

                    Result = DbCmd.ExecuteScalar
                    Return Result

                Catch ex As Exception
                    Return Nothing
                Finally
                    dbConn.Close()
                End Try
            End Using
        End Using


    End Function

    Public Function ExecuteNonQuery(ByVal query As String) As Long
        Return ExecuteNonQuery(query, CommandType.Text)
    End Function

    Public Function ExecuteNonQuery(ByVal query As String, ByVal CommandType As CommandType) As Long
        Return ExecuteNonQuery(query, CommandType.Text, Nothing)
    End Function

    Public Function ExecuteNonQuery(ByVal sqlString As [String], ByVal CommandType As CommandType, ByVal ParamArray Parameters() As DbParameter) As Long
        Dim Result As Long = -1
        Using dbConn As DbConnection = New MySqlConnection()
            dbConn.ConnectionString = Me.ConnectionString
            Using DbCommand As DbCommand = New MySqlCommand()

                Try
                    Dim conn As DbConnection = New MySqlConnection()
                    conn.ConnectionString = Me.ConnectionString
                    If conn.State <> System.Data.ConnectionState.Open Then
                        conn.Open()
                    End If
                    With DbCommand
                        .CommandType = CommandType
                        .CommandText = sqlString
                        If Not IsNothing(Parameters) Then _
                           .Parameters.AddRange(Parameters)
                        .Connection = dbConn
                    End With
                    dbConn.Open()
                    Result = DbCommand.ExecuteNonQuery
                    Return Result

                Catch ex As Exception

                Finally
                    dbConn.Close()

                End Try
            End Using
        End Using


    End Function

    Public Function GetDataTable(ByVal query As String) As DataTable
        Return GetDataTable(query, CommandType.Text)
    End Function

    Public Function GetDataTable(ByVal query As String, ByVal CommandType As CommandType) As DataTable
        Return GetDataTable(query, CommandType.Text, Nothing)
    End Function

    Public Function GetDataTable(ByVal sqlString As [String], ByVal CommandType As CommandType, ByVal ParamArray Parameters() As DbParameter) As DataTable
        Using dbConn As DbConnection = New MySqlConnection()
            dbConn.ConnectionString = Me.ConnectionString
            Using dbDataAdapter As DbDataAdapter = New MySqlDataAdapter()
                Try
                    With dbDataAdapter
                        .SelectCommand = New MySqlCommand()
                        .SelectCommand.CommandType = CommandType
                        .SelectCommand.CommandText = sqlString
                        If Not IsNothing(Parameters) Then _
                            .SelectCommand.Parameters.AddRange(Parameters)
                        .SelectCommand.Connection = dbConn
                    End With
                    dbConn.Open()
                    Dim dataTable As New DataTable()
                    dataTable.BeginLoadData()
                    dbDataAdapter.Fill(dataTable)
                    dataTable.EndLoadData()
                    Return dataTable

                Catch ex As Exception
                    Return Nothing
                Finally
                    dbConn.Close()
                End Try
            End Using
        End Using

    End Function

    Public Function GetPKCOA(ByVal TitleCOA As String) As String
        Try
            Dim SQL As String = String.Format("SELECT PK_COA FROM chart_of_accounts WHERE Title_COA = '{0}'", TitleCOA)
            Dim MeData As DataTable = AppData.GetDataTable(SQL)
            If Not IsNothing(MeData) AndAlso MeData.Rows.Count > 0 Then
                Return MeData.Rows(0)("PK_COA").ToString
            Else
                XtraMessageBox.Show(TitleCOA & " is Not Found in Chart of Accounts", TitleCOA & " Not Found !", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return ""
            End If

        Catch ex As Exception
            Return ""
        End Try

    End Function

    Public Function GetUserPKCOA(ByVal PKCoa As String) As String
        Try
            Dim SQL As String = String.Format("SELECT UserPK_COA FROM chart_of_accounts WHERE PK_COA = '{0}'", PKCoa)
            Dim MeData As DataTable = AppData.GetDataTable(SQL)
            If Not IsNothing(MeData) AndAlso MeData.Rows.Count > 0 Then
                Return MeData.Rows(0)("UserPK_COA").ToString
            Else
                XtraMessageBox.Show(PKCoa & "is Not Found in Chart of Accounts", PKCoa & " Not Found !", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return ""
            End If

        Catch ex As Exception
            Return ""
        End Try

    End Function

    Public Function GetTitleCOA(ByVal PKCoa As String) As String
        Try
            Dim SQL As String = String.Format("SELECT Title_COA FROM chart_of_accounts WHERE PK_COA = '{0}'", PKCoa)
            Dim MeData As DataTable = AppData.GetDataTable(SQL)
            If Not IsNothing(MeData) AndAlso MeData.Rows.Count > 0 Then
                Return MeData.Rows(0)("Title_COA").ToString
            Else
                XtraMessageBox.Show(PKCoa & "is Not Found in Chart of Accounts", PKCoa & " Not Found !", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return 0
            End If

        Catch ex As Exception
            Return ""
        End Try

    End Function

End Class

