Imports System.Drawing.Printing
Imports MySql.Data.MySqlClient

Public Class FormDataPasien

    Dim conn As MySqlConnection = DBConnection.GetConnection()
    Dim dataToPrint As List(Of List(Of String)) = New List(Of List(Of String))()

    'Menampilkan DataTable ke DataGridView
    Private Sub FormDataDaftarPasien_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        Dim DataPasien As New DataTable

        Try
            conn.Open()

            ' Query Data Pendaftaran
            Dim query As String = "
                SELECT 
                        p.name AS 'Nama', 
                        p.mr_no AS 'No Rekam Medis',
                        p.nik AS 'NIK',
                        p.gender AS 'Jenis Kelamin',
                        CONCAT(p.birth_place, ', ' ,DATE_FORMAT(p.birth_date, '%d-%m-%Y')) AS 'Tempat dan Tanggal Lahir',
                        p.age AS 'Usia',
                        p.address AS 'Alamat',
                        p.phone_number AS 'Nomor Telepon'
                        FROM registrations r
                INNER JOIN patients p ON r.patient_id = p.id
                ORDER BY r.registration_date DESC"


            Dim dataAdapter As New MySqlDataAdapter(query, conn)
            ' Mengisi DataTable dengan hasil query
            dataAdapter.Fill(DataPasien)

            ' Sambungkan DataTable dari Form Utama ke DataGridView
            dgvPasien.DataSource = DataPasien


            ' Pastikan header tidak menggunakan gaya visual default Windows
            dgvPasien.EnableHeadersVisualStyles = False

            ' Atur agar DataGridView rapi
            With dgvPasien
                .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill ' Kolom memenuhi lebar DataGridView
                .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells   ' Baris mengikuti ukuran konten
                .RowHeadersVisible = False                                 ' Sembunyikan header baris
                .SelectionMode = DataGridViewSelectionMode.FullRowSelect   ' Pilih seluruh baris
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


            ' Label Data pasien
            lbDataPasien.Text = "DATA PASIEN"
            lbDataPasien.Font = New Font("Arial", 14, FontStyle.Bold)
            lbDataPasien.TextAlign = ContentAlignment.MiddleCenter

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
        For Each column As DataGridViewColumn In dgvPasien.Columns
            header.Add(column.HeaderText)
        Next
        dataToPrint.Add(header)

        ' Menambahkan setiap baris data
        For Each row As DataGridViewRow In dgvPasien.Rows
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
                                           Dim currentY As Integer = startY

                                           ' Calculate column widths dynamically based on text length
                                           columnWidths = New List(Of Integer)()
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

                                           ' Calculate row heights manually based on text length
                                           rowHeights = New List(Of Integer)()
                                           For Each row In dataToPrint
                                               Dim maxHeight As Integer = 0
                                               For col As Integer = 0 To row.Count - 1
                                                   Dim textHeight As Integer = CInt(e.Graphics.MeasureString(row(col), printFont, columnWidths(col)).Height)
                                                   If textHeight > maxHeight Then
                                                       maxHeight = textHeight
                                                   End If
                                               Next
                                               rowHeights.Add(maxHeight + 5) ' Add padding
                                           Next

                                           ' Scale columns if total width exceeds page width
                                           Dim totalWidth As Integer = columnWidths.Sum()
                                           If totalWidth > e.MarginBounds.Width Then
                                               Dim scaleFactor As Double = e.MarginBounds.Width / totalWidth
                                               For i As Integer = 0 To columnWidths.Count - 1
                                                   columnWidths(i) = CInt(columnWidths(i) * scaleFactor)
                                               Next
                                           End If

                                           ' Scale rows if total height exceeds page height
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
                                                   Dim rectHeight As Integer = rowHeights(rowIndex)
                                                   Dim rect As New Rectangle(currentX, currentY, columnWidths(col), rectHeight)
                                                   e.Graphics.DrawRectangle(Pens.Black, rect)
                                                   e.Graphics.DrawString(cellText, printFont, Brushes.Black, New RectangleF(currentX + 2, currentY + 2, columnWidths(col) - 4, rectHeight - 4))
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
