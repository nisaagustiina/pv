Imports System.Drawing.Printing
Imports MySql.Data.MySqlClient

Public Class FormDataPendaftaran
    ' Koneksi ke database
    Dim conn As MySqlConnection = DBConnection.GetConnection()
    Dim dataToPrint As New List(Of List(Of String))() ' Ubah menjadi List of List(Of String)

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
            Using conn
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

            End Using
        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan: " & ex.Message)
        End Try
    End Sub

    Private Sub PrepareDataForPrinting()
        dataToPrint.Clear()

        Dim header As New List(Of String) From {
        "Tanggal Daftar",
        "Nama Pasien",
        "Nomor Rekam Medis",
        "Keluhan",
        "Jenis Pembayaran",
        "Nomor Antrian"
    }
        dataToPrint.Add(header)

        ' Menambahkan setiap baris data
        For Each row As DataGridViewRow In dgvDataPendaftaran.Rows
            If Not row.IsNewRow Then
                Dim line As New List(Of String)
                For Each cell As DataGridViewCell In row.Cells
                    line.Add(If(cell.Value IsNot Nothing, cell.Value.ToString(), ""))
                Next
                dataToPrint.Add(line) ' Menambahkan baris data
            End If
        Next
    End Sub

    Private Sub PrintToPDF(filePath As String)
        Dim printDoc As New PrintDocument()
        Dim printFont As New Font("Arial", 10)
        Dim currentLine As Integer = 0
        Dim columnWidths As List(Of Integer) = Nothing

        AddHandler printDoc.PrintPage, Sub(sender, e)
                                           Dim startX As Integer = e.MarginBounds.Left
                                           Dim startY As Integer = e.MarginBounds.Top
                                           Dim cellHeight As Integer = CInt(printFont.GetHeight(e.Graphics)) + 10
                                           Dim currentY As Integer = startY

                                           ' Hitung lebar kolom jika belum dilakukan
                                           If columnWidths Is Nothing Then
                                               columnWidths = New List(Of Integer)()
                                               ' Tentukan lebar kolom berdasarkan panjang teks terpanjang
                                               For i As Integer = 0 To dataToPrint(0).Count - 1
                                                   Dim maxTextWidth As Integer = 0
                                                   For Each row As List(Of String) In dataToPrint
                                                       maxTextWidth = Math.Max(maxTextWidth, TextRenderer.MeasureText(row(i), printFont).Width)
                                                   Next
                                                   ' Tambahkan padding
                                                   columnWidths.Add(maxTextWidth + 10)
                                               Next
                                           End If

                                           ' Gambar data dalam tabel
                                           Dim linesPerPage As Integer = CInt(e.MarginBounds.Height / cellHeight)
                                           While currentLine < dataToPrint.Count AndAlso linesPerPage > 0
                                               Dim row As List(Of String) = dataToPrint(currentLine)
                                               Dim currentX As Integer = startX

                                               ' Gambar setiap kolom dalam baris
                                               For col As Integer = 0 To row.Count - 1
                                                   Dim cellText As String = row(col)
                                                   Dim rect As New Rectangle(currentX, currentY, columnWidths(col), cellHeight)

                                                   e.Graphics.DrawRectangle(Pens.Black, rect)
                                                   e.Graphics.DrawString(cellText, printFont, Brushes.Black, New RectangleF(currentX + 4, currentY + 4, columnWidths(col) - 8, cellHeight - 8))
                                                   currentX += columnWidths(col)
                                               Next

                                               currentY += cellHeight
                                               currentLine += 1
                                               linesPerPage -= 1
                                           End While

                                           e.HasMorePages = currentLine < dataToPrint.Count
                                       End Sub

        ' Mengarahkan output ke file PDF
        Dim printDialog As New PrintDialog()
        printDialog.Document = printDoc
        printDoc.PrinterSettings.PrinterName = "Microsoft Print to PDF"
        printDoc.PrinterSettings.PrintToFile = True
        printDoc.PrinterSettings.PrintFileName = filePath

        Try
            printDoc.Print()
            MessageBox.Show("Data berhasil disimpan ke " & filePath, "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim saveFileDialog As New SaveFileDialog()
        saveFileDialog.Filter = "PDF Files (*.pdf)|*.pdf"
        saveFileDialog.Title = "Simpan File PDF"

        If saveFileDialog.ShowDialog() = DialogResult.OK Then
            PrepareDataForPrinting()
            PrintToPDF(saveFileDialog.FileName)
        End If
    End Sub

End Class