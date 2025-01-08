Imports System.Data.Common
Imports MySql.Data.MySqlClient

Public Enum DataProviderType
    Mysql
End Enum

Friend Class DBFactory
    Private Shared objFactory As DbProviderFactory = Nothing

    Public Shared Function GetDataProvider(ByVal provider As DataProviderType) As DbProviderFactory
        Return MySqlClientFactory.Instance
    End Function

    Public Shared Function GetConnection(Optional ByVal providerType__1 As DataProviderType = DataProviderType.Mysql) As DbConnection
        Return New MySqlConnection()
    End Function

    Public Shared Function GetParameter(Optional ByVal providerType__1 As DataProviderType = DataProviderType.Mysql) As DbParameter
        Return New MySqlParameter()
    End Function

    Public Shared Function GetCommand(Optional ByVal providerType As DataProviderType = DataProviderType.Mysql) As DbCommand
        Return New MySqlCommand()
    End Function

    Public Shared Function GetCommandBuilder(Optional ByVal providerType As DataProviderType = DataProviderType.Mysql) As DbCommandBuilder
        Return New MySqlCommandBuilder()
    End Function

    Public Shared Function GetDataAdapter(Optional ByVal providerType As DataProviderType = DataProviderType.Mysql) As DbDataAdapter
        Return New MySqlDataAdapter()
    End Function
End Class
