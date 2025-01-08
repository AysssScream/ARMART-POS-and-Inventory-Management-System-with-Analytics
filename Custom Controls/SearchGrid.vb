Imports DevExpress.XtraGrid
Imports System.ComponentModel
Imports System.ComponentModel.Design
Imports System.Drawing.Design


Imports DevExpress.XtraGrid.Views.Grid
Imports System.Threading



Public Class SearchGrid : Inherits GridControl

    Private _ColumnDefinitionInfo As String
    Private _TableFromInfo As String


    Public Property TableFromInfo() As String
        Get
            Return _TableFromInfo
        End Get
        Set(ByVal value As String)
            _TableFromInfo = value
        End Set
    End Property

    <Editor(GetType(MultilineStringEditor), GetType(UITypeEditor))>
    Public Property ColumnDefinitionInfo() As String
        Get
            Return _ColumnDefinitionInfo
        End Get
        Set(ByVal value As String)
            _ColumnDefinitionInfo = value
        End Set
    End Property
End Class
