Imports System.Drawing.Printing
Imports MySql.Data.MySqlClient

Public Class FormDataPendaftaran
    ' Koneksi ke database
    Dim conn As MySqlConnection = DBConnection.GetConnection()

    Private Sub FormDataPendaftaran_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub

    Private WithEvents PrintDoc As New PrintDocument
    Private PrintGridView As DataGridView
    Private PageNo As Integer = 1
    Private TotalWidth As Integer
    Private ColumnWidths As New List(Of Integer)
    Private RowsPerPage As Integer

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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        PrintGridView = dgvDataPendaftaran

        ' Menampilkan PrintDialog
        Dim printDialog As New PrintDialog()
        printDialog.Document = PrintDoc

        If printDialog.ShowDialog() = DialogResult.OK Then
            PrintDoc.DocumentName = "GridView Print"
            PrintDoc.Print()
        End If
    End Sub

    Private Sub PrintDoc_BeginPrint(sender As Object, e As PrintEventArgs) Handles PrintDoc.BeginPrint
        PageNo = 1
        TotalWidth = 0
        ColumnWidths.Clear()

        ' Hitung total lebar tabel dan lebar tiap kolom
        For Each col As DataGridViewColumn In PrintGridView.Columns
            ColumnWidths.Add(col.Width)
            TotalWidth += col.Width
        Next
    End Sub

    Private Sub PrintDoc_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDoc.PrintPage
        Dim leftMargin As Integer = e.MarginBounds.Left
        Dim topMargin As Integer = e.MarginBounds.Top
        Dim cellHeight As Integer = PrintGridView.Rows(0).Height + 5
        Dim startY As Integer = topMargin
        Dim scaleFactor As Single = CSng(e.MarginBounds.Width) / TotalWidth
        Dim currentRow As Integer = 0

        ' Header Tabel
        Dim headerFont As New Font("Arial", 10, FontStyle.Bold)
        Dim dataFont As New Font("Arial", 9, FontStyle.Regular)

        ' Cetak Header
        Dim currentX As Integer = leftMargin
        For i As Integer = 0 To PrintGridView.ColumnCount - 1
            Dim colWidth As Integer = CInt(ColumnWidths(i) * scaleFactor)
            e.Graphics.FillRectangle(Brushes.LightGray, New Rectangle(currentX, startY, colWidth, cellHeight))
            e.Graphics.DrawRectangle(Pens.Black, New Rectangle(currentX, startY, colWidth, cellHeight))
            e.Graphics.DrawString(PrintGridView.Columns(i).HeaderText, headerFont, Brushes.Black, New RectangleF(currentX, startY, colWidth, cellHeight))
            currentX += colWidth
        Next
        startY += cellHeight

        ' Cetak Data Baris
        For Each row As DataGridViewRow In PrintGridView.Rows
            If Not row.IsNewRow Then
                currentX = leftMargin
                For colIndex As Integer = 0 To PrintGridView.ColumnCount - 1
                    Dim colWidth As Integer = CInt(ColumnWidths(colIndex) * scaleFactor)
                    e.Graphics.DrawRectangle(Pens.Black, New Rectangle(currentX, startY, colWidth, cellHeight))
                    e.Graphics.DrawString(row.Cells(colIndex).Value?.ToString(), dataFont, Brushes.Black, New RectangleF(currentX, startY, colWidth, cellHeight))
                    currentX += colWidth
                Next
                startY += cellHeight
                currentRow += 1

                ' Periksa apakah halaman cukup
                If startY + cellHeight > e.MarginBounds.Bottom Then
                    e.HasMorePages = True
                    Exit Sub
                End If
            End If
        Next

        ' Jika selesai, set ke False
        e.HasMorePages = False
    End Sub
End Class
