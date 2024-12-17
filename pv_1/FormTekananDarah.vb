Imports System.Windows.Forms

Public Class FormTekananDarah

    Const TekananNormalMaxSistolik As Integer = 120
    Const TekananNormalMaxDiastolik As Integer = 80
    Const TekananTinggiSistolik As Integer = 140
    Const TekananTinggiDiastolik As Integer = 90

    Enum KategoriTekananDarah
        Normal
        Tinggi
        Rendah
        TidakTahu
    End Enum

    Dim sistolik As Integer
    Dim diastolik As Integer
    Dim kategori As KategoriTekananDarah

    Private Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
        If Integer.TryParse(txtSistolik.Text, sistolik) AndAlso Integer.TryParse(txtDiastolik.Text, diastolik) Then
            kategori = TentukanKategoriTekananDarah(sistolik, diastolik)
            lblHasil.Text = "Kategori Tekanan Darah: " & kategori.ToString
        Else
            MessageBox.Show("Input nilai sistolik dan diastolik dengan benar.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
    Private Function TentukanKategoriTekananDarah(sistolik As Integer, diastolik As Integer) As KategoriTekananDarah
        If sistolik <= TekananNormalMaxSistolik And diastolik <= TekananNormalMaxDiastolik Then
            Return KategoriTekananDarah.Normal
        ElseIf sistolik >= TekananTinggiSistolik Or diastolik >= TekananTinggiDiastolik Then
            Return KategoriTekananDarah.Tinggi
        Else
            Return KategoriTekananDarah.Rendah
        End If
    End Function

    Private Sub btnReturn_Click(sender As Object, e As EventArgs)
        Dim form1 As New Form1
        form1.Show
        Close
    End Sub

End Class
