Imports System.Drawing.Printing
Imports MySql.Data.MySqlClient

Public Class FormDataPendaftaran
    ' Koneksi ke database
    Dim conn As MySqlConnection = DBConnection.GetConnection()
    Dim dataToPrint As List(Of List(Of String)) = New List(Of List(Of String))()
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
                    r.registration_date AS 'Tanggal Registrasi', 
                    p.name AS 'Nama Pasien', 
                    p.mr_no AS 'No Rekam Medis', 
                    r.complaint AS 'Keluhan',
                    CASE 
                        WHEN r.payment_type = 0 THEN 'Umum'
                        WHEN r.payment_type = 1 THEN 'BPJS'
                        WHEN r.payment_type = 2 THEN 'Lainnya'
                    END AS 'Tipe Pembayaran' ,
                    r.queue_no AS 'Nomor Antrian'
                FROM registrations r
                INNER JOIN patients p ON r.patient_id = p.id
                ORDER BY r.registration_date DESC"

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
    Private Sub PrepareDataForPrinting()
        dataToPrint.Clear()

        ' Menambahkan header kolom
        Dim header As New List(Of String)
        For Each column As DataGridViewColumn In dgvDataPendaftaran.Columns
            header.Add(column.HeaderText)
        Next
        dataToPrint.Add(header)

        ' Menambahkan setiap baris data
        For Each row As DataGridViewRow In dgvDataPendaftaran.Rows
            If Not row.IsNewRow Then
                Dim line As New List(Of String)
                For Each cell As DataGridViewCell In row.Cells
                    line.Add(If(cell.Value IsNot Nothing, cell.Value.ToString(), ""))
                Next
                dataToPrint.Add(line)
            End If
        Next
    End Sub

    Private Sub PrintToPDF(filePath As String)
        Dim printDoc As New PrintDocument()
        Dim printFont As New Font("Arial", 10)
        Dim columnWidths As List(Of Integer) = Nothing
        Dim rowHeights As List(Of Integer) = Nothing

        ' Set landscape orientation
        printDoc.DefaultPageSettings.Landscape = True

        AddHandler printDoc.PrintPage, Sub(sender, e)
                                           Dim startX As Integer = e.MarginBounds.Left
                                           Dim startY As Integer = e.MarginBounds.Top
                                           Dim cellHeight As Integer = CInt(printFont.GetHeight(e.Graphics)) + 5
                                           Dim currentY As Integer = startY
                                           'Calculate column widths and row heights to fit all text
                                           columnWidths = New List(Of Integer)()
                                           rowHeights = New List(Of Integer)()

                                           For i As Integer = 0 To dataToPrint(0).Count - 1
                                               Dim maxWidth As Integer = 0
                                               For Each row In dataToPrint
                                                   Dim textWidth As Integer = CInt(e.Graphics.MeasureString(row(i), printFont).Width)
                                                   If textWidth > maxWidth Then
                                                       maxWidth = textWidth
                                                   End If
                                               Next
                                               columnWidths.Add(maxWidth + 10) ' Add padding
                                           Next

                                           For Each row In dataToPrint
                                               Dim maxHeight As Integer = cellHeight
                                               For Each cellText In row
                                                   Dim textHeight As Integer = CInt(e.Graphics.MeasureString(cellText, printFont, columnWidths(row.IndexOf(cellText))).Height)
                                                   If textHeight > maxHeight Then
                                                       maxHeight = textHeight + 5
                                                   End If
                                               Next
                                               rowHeights.Add(maxHeight)
                                           Next

                                           ' Scale columns and rows if total dimensions exceed page size
                                           Dim totalWidth As Integer = columnWidths.Sum()
                                           If totalWidth > e.MarginBounds.Width Then
                                               Dim scaleFactor As Double = e.MarginBounds.Width / totalWidth
                                               For i As Integer = 0 To columnWidths.Count - 1
                                                   columnWidths(i) = CInt(columnWidths(i) * scaleFactor)
                                               Next
                                           End If

                                           Dim totalHeight As Integer = rowHeights.Sum()
                                           If totalHeight > e.MarginBounds.Height Then
                                               Dim scaleFactor As Double = e.MarginBounds.Height / totalHeight
                                               For i As Integer = 0 To rowHeights.Count - 1
                                                   rowHeights(i) = CInt(rowHeights(i) * scaleFactor)
                                               Next
                                           End If

                                           ' Draw data in table
                                           For rowIndex As Integer = 0 To dataToPrint.Count - 1
                                               Dim row As List(Of String) = dataToPrint(rowIndex)
                                               Dim currentX As Integer = startX

                                               ' Draw each column in the row
                                               For col As Integer = 0 To row.Count - 1
                                                   Dim cellText As String = row(col)
                                                   Dim rect As New Rectangle(currentX, currentY, columnWidths(col), rowHeights(rowIndex))
                                                   e.Graphics.DrawRectangle(Pens.Black, rect)
                                                   e.Graphics.DrawString(cellText, printFont, Brushes.Black, New RectangleF(currentX + 2, currentY + 2, columnWidths(col) - 4, rowHeights(rowIndex) - 4))
                                                   currentX += columnWidths(col)
                                               Next

                                               currentY += rowHeights(rowIndex)
                                           Next

                                           e.HasMorePages = False ' Ensure all content fits on one page
                                       End Sub



        ' Direct output to PDF file
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


    Private Sub btnDowlondFile_Click(sender As Object, e As EventArgs) Handles btnDowlondFile.Click

        Dim saveFileDialog As New SaveFileDialog()
        saveFileDialog.Filter = "PDF Files (*.pdf)|*.pdf"
        saveFileDialog.Title = "Simpan File PDF"

        If saveFileDialog.ShowDialog() = DialogResult.OK Then
            PrepareDataForPrinting()
            PrintToPDF(saveFileDialog.FileName)
        End If
    End Sub

End Class
