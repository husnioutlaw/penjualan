Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            koneksi()
            MsgBox("Koneksi Berhasil", MsgBoxStyle.Information, "Peringatan")
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Information, "Peringatan")
        End Try
    End Sub
End Class
