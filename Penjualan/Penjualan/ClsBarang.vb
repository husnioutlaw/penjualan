Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class ClsBarang
    Private fkdbrg As String
    Private fnmbrg As String
    Private fsatuan As String
    Private fstok As Integer

    Public Property pkdbrg As String
        Get
            Return fkdbrg
        End Get
        Set(ByVal value As String)
            fkdbrg = value
        End Set
    End Property

    Public Property pnmbrg As String
        Get
            Return fnmbrg
        End Get
        Set(ByVal value As String)
            fnmbrg = value
        End Set
    End Property

    Public Property psatuan As String
        Get
            Return fsatuan
        End Get
        Set(ByVal value As String)
            fsatuan = value
        End Set
    End Property

    Public Property pstok As Integer
        Get
            Return fstok
        End Get
        Set(ByVal value As Integer)
            fstok = value
        End Set
    End Property

    Public Function simpan() As Integer
        sql = "insert into barang(kdbrg,nmbrg,satuan,stok) values(@1,@2,@3,@4)"
        cmmd = New SqlCommand(sql, cnn)
        cmmd.Parameters.AddWithValue("@1", fkdbrg)
        cmmd.Parameters.AddWithValue("@2", fnmbrg)
        cmmd.Parameters.AddWithValue("@3", fsatuan)
        cmmd.Parameters.AddWithValue("@4", fstok)
        Return cmmd.ExecuteNonQuery
    End Function

    Public Function ubah() As Integer

    End Function

    Public Function hapus() As Integer

    End Function

    Public Function cari() As Boolean

    End Function

    Public Function autonumber() As String

    End Function

End Class
