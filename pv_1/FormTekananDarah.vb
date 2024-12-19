Public Class FormTekananDarah
    Enum KategoriTekananDarah
        Normal
        Tinggi
        Rendah
        TidakTahu
    End Enum

    Const TekananNormalMaxSistolik As Integer = 120
    Const TekananNormalMaxDiastolik As Integer = 80
    Const TekananTinggiSistolik As Integer = 140
    Const TekananTinggiDiastolik As Integer = 90

    Dim sistolik As Integer
    Dim diastolik As Integer
    Dim kategori As KategoriTekananDarah

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        If Integer.TryParse(txtSistolik.Text, sistolik) AndAlso Integer.TryParse(txtDiastolik.Text, diastolik) Then
            kategori = TentukanKategoriTekananDarah(sistolik, diastolik)
            MessageBox.Show("Kategori Tekanan Darah: " & kategori.ToString(), "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Input nilai sistolik dan diastolik dengan benar.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

        ClearForm()
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

    Private Sub ClearForm()
        txtDiastolik.Clear()
        txtSistolik.Clear()
    End Sub
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        ClearForm()
    End Sub
End Class
