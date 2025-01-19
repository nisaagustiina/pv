Imports Google.Protobuf.WellKnownTypes
Imports MySql.Data.MySqlClient
Imports Mysqlx.Expect.Open.Types.Condition.Types
Imports Mysqlx.XDevAPI.Common
Imports ZstdSharp.Unsafe

Public Class FormBMI

    ' Koneksi ke database
    Dim conn As MySqlConnection = DBConnection.GetConnection()

    ' Array untuk kategori BMI dan batas-batasnya
    Dim BMICategories() As String = {"Kekurangan Berat Badan", "Normal", "Kelebihan Berat Badan", "Obesitas"}
    Dim BMILimits() As Double = {18.5, 24.9, 29.9, Double.MaxValue} ' Batas maksimum untuk setiap kategori

    Dim weight As Double
    Shadows height As Double
    Dim MRName As String
    Dim bmi As Double

    Private Function GetPasien(MRName As String) As (Integer, String)
        Dim query As String = "SELECT id, name FROM patients WHERE `mr_no` = @mrCode"

        Using cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@mrCode", MRName)

            Try
                conn.Open()
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        Dim id As Integer = reader("id")
                        Dim name As String = reader("name").ToString()
                        Return (id, name)
                    End If
                End Using
            Catch ex As MySqlException
                MessageBox.Show("Error: " & ex.Message)
            Finally
                conn.Close()
            End Try
        End Using
        Return (0, String.Empty)
    End Function

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        MRName = txtMRName.Text

        If String.IsNullOrWhiteSpace(MRName) Then
            MessageBox.Show("Masukkan no rekam medis Anda.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim result = GetPasien(txtMRName.Text)
        Dim pasienId As Integer = result.Item1
        Dim pasienNama As String = result.Item2

        If pasienId = 0 Then
            MessageBox.Show("Nomor rekam medis tidak ditemukan. Silakan periksa kembali.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If Double.TryParse(txtWeight.Text, weight) AndAlso Double.TryParse(txtHeight.Text, height) Then
            If weight > 0 AndAlso height > 0 Then
                ' Asumsikan tinggi dalam cm, ubah ke meter
                height = height / 100
                bmi = weight / (height * height)

                Dim query As String = "UPDATE medical_records SET height = @height, weight = @weight WHERE patient_id = @pasienId"

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@height", height)
                    cmd.Parameters.AddWithValue("@weight", weight)
                    cmd.Parameters.AddWithValue("@pasienId", pasienId)

                    Try
                        conn.Open()
                        cmd.ExecuteNonQuery()
                    Catch ex As MySqlException
                        MessageBox.Show("Error: " & ex.Message)
                    Finally
                        conn.Close()
                    End Try
                End Using

                Dim category As String = GetBMICategory(bmi)

                MessageBox.Show("Nama: " & pasienNama & Environment.NewLine &
                    "BMI: " & bmi.ToString("F2") & Environment.NewLine &
                    "Kategori: " & category, "Informasi",
                    MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Masukkan nilai berat badan dan tinggi badan yang valid.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Else
            MessageBox.Show("Tolong masukkan angka yang valid untuk berat badan dan tinggi badan.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

        ClearForm()
    End Sub

    Private Function GetBMICategory(ByVal bmi As Double) As String
        ' Looping untuk menentukan kategori berdasarkan batas-batas
        For i As Integer = 0 To BMILimits.Length - 1
            If bmi <= BMILimits(i) Then
                Return BMICategories(i)
            End If
        Next
        Return "Tidak Diketahui"
    End Function

    Private Sub ClearForm()
        txtMRName.Clear()
        txtWeight.Clear()
        txtHeight.Clear()
    End Sub

    Private Sub FormBMI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Label Hitung BMI
        lblPerhitunganBMI.Text = "PERHITUNGAN BMI"
        lblPerhitunganBMI.Font = New Font("Arial", 14, FontStyle.Bold)
        lblPerhitunganBMI.TextAlign = ContentAlignment.MiddleCenter
    End Sub


    'Hapus inputan data BMI
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        'Custom dialog untuk konfirmasi
        Dim dialog As New FormCustomDialog()
        dialog.Pesan = "Apakah Anda yakin ingin menghapus data inputan?"
        Dim result As DialogResult = dialog.ShowDialog()

        If result = DialogResult.Yes Then
            ' Reset semua inputan
            txtMRName.Text = String.Empty
            txtWeight.Text = String.Empty
            txtHeight.Text = String.Empty

            ' Tampilkan pesan bahwa inputan telah dihapus
            MessageBox.Show("Data inputan berhasil dihapus.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            ' Jika tidak jadi menghapus
            MessageBox.Show("Data inputan tidak jadi dihapus.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class
