Public Class FormPendaftaranPasienLama
    Private Sub FormPendaftaranPasienLama_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Label pendaftaran pasien
        lbPendaftaranPasienLama.Text = "PENDAFTARAN PASIEN LAMA"
        lbPendaftaranPasienLama.Font = New Font("Arial", 14, FontStyle.Bold)
        lbPendaftaranPasienLama.TextAlign = ContentAlignment.MiddleCenter







    End Sub



    ' Custom dialog 
    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click

        'Custom dialog untuk konfirmasi
        Dim dialog As New FormCustomDialog()
        dialog.Pesan = "Apakah Anda yakin ingin menghapus data inputan?"
        Dim result As DialogResult = dialog.ShowDialog()

        If result = DialogResult.Yes Then
            ' Reset semua inputan
            txtKeluhan.Text = String.Empty
            cbTipePembayaran.SelectedIndex = -1 ' Reset ComboBox ke kondisi kosong


            ' Tampilkan pesan bahwa inputan telah dihapus
            MessageBox.Show("Data inputan berhasil dihapus.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            ' Jika tidak jadi menghapus
            MessageBox.Show("Data inputan tidak jadi dihapus.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub





End Class