Imports System.Data.Sql
Imports System.Data.SqlClient

Module ModuleKoneksi
    Public cnn As New SqlConnection
    Public cmmd As SqlCommand
    Public dr As SqlDataReader
    Public sql As String
    Public strcon As String = "data source=.\SQLEXPRESS; initial catalog=penjualan; User ID=husni; PWD=220394"

    Public Sub koneksi()
        cnn = New SqlConnection(strcon)
        If cnn.State = ConnectionState.Closed Then
            cnn.Open()
        Else
            cnn.Close()
        End If
    End Sub
End Module
