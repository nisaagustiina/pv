Imports MySql.Data.MySqlClient

Public Class FormDataPendaftaran
    ' Koneksi ke database
    Dim conn As MySqlConnection = DBConnection.GetConnection()

    Private Sub FormDataPendaftaran_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub

    Private Sub LoadData()
        ' Buat DataTable baru untuk menyimpan data
        Dim DataPendaftaran As New DataTable

        Try
            conn.Open()

            ' Query Data Pendaftaran
            Dim query As String = "
              SELECT 
                  r.registration_date, 
                  p.name, 
                  p.mr_no, 
                  r.complaint,
                  CASE 
                      WHEN r.payment_type = 0 THEN 'Umum'
                      WHEN r.payment_type = 1 THEN 'BPJS'
                      WHEN r.payment_type = 2 THEN 'Lainnya'
                  END AS payment_type,
                  r.queue_no
              FROM registrations r
              INNER JOIN patients p ON r.patient_id = p.id"

            Dim dataAdapter As New MySqlDataAdapter(query, conn)
            ' Mengisi DataTable dengan hasil query
            dataAdapter.Fill(DataPendaftaran)

            ' Sambungkan DataTable ke DataGridView
            dgvDataPendaftaran.DataSource = DataPendaftaran

            ' Pastikan header tidak menggunakan gaya visual default Windows
            dgvDataPendaftaran.EnableHeadersVisualStyles = False

            ' Atur agar DataGridView rapi
            With dgvDataPendaftaran
                .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill ' Kolom memenuhi lebar DataGridView
                .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells   ' Baris mengikuti ukuran konten
                .RowHeadersVisible = False                                 ' Sembunyikan header baris
                .SelectionMode = DataGridViewSelectionMode.FullRowSelect   ' Pilih seluruh baris
            End With

            ' Atur warna dan teks header DataGridView
            With dgvDataPendaftaran.ColumnHeadersDefaultCellStyle
                .BackColor = ColorTranslator.FromHtml("#19456B")         ' Warna latar belakang header
                .ForeColor = Color.White       ' Warna teks header
                .Font = New Font("Arial", 10, FontStyle.Bold) ' Font teks header (tebal)
                .Alignment = DataGridViewContentAlignment.MiddleCenter ' Pusatkan teks
            End With

        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan: " & ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

End Class
