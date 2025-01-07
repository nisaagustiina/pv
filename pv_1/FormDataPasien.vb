Public Class FormDataPasien

    'Menampilkan DataTable ke DataGridView
    Private Sub FormDataDaftarPasien_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Sambungkan DataTable dari Form Utama ke DataGridView
        dgvPasien.DataSource = FormUtama.DataPasien

        ' Pastikan header tidak menggunakan gaya visual default Windows
        dgvPasien.EnableHeadersVisualStyles = False

        ' Atur agar DataGridView rapi
        With dgvPasien
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill ' Kolom memenuhi lebar DataGridView
            .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells   ' Baris mengikuti ukuran konten
            .RowHeadersVisible = False                                 ' Sembunyikan header baris
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect   ' Pilih seluruh baris
        End With

        ' Ukuran kolom tabel usia dan alamat
        With dgvPasien

            .Columns(5).Width = 35
            .Columns(6).Width = 150

        End With

        ' Atur warna dan teks header DataGridView
        With dgvPasien.ColumnHeadersDefaultCellStyle
            .BackColor = ColorTranslator.FromHtml("#19456B")         ' Warna latar belakang header
            .ForeColor = Color.White       ' Warna teks header
            .Font = New Font("Arial", 10, FontStyle.Bold) ' Font teks header (tebal)
            .Alignment = DataGridViewContentAlignment.MiddleCenter ' Pusatkan teks
        End With

        ' Contoh untuk menyembunyikan header baris
        dgvPasien.RowHeadersVisible = False

    End Sub

End Class