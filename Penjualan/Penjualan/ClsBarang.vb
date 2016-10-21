Imports System.Data.Sql
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
