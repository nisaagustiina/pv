Public Class FormPendaftaranPasienLama
    Private Sub FormPendaftaranPasienLama_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Label pendaftaran pasien
        lbPendaftaranPasienLama.Text = "PENDAFTARAN PASIEN LAMA"
        lbPendaftaranPasienLama.Font = New Font("Arial", 14, FontStyle.Bold)
        lbPendaftaranPasienLama.TextAlign = ContentAlignment.MiddleCenter

    End Sub

    Private Sub lbPendaftaranPasienLama_Click(sender As Object, e As EventArgs) Handles lbPendaftaranPasienLama.Click

    End Sub

    Private Sub lbNIK_Click(sender As Object, e As EventArgs) Handles lbNIK.Click

    End Sub
End Class