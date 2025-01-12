Imports Google.Protobuf.WellKnownTypes
Imports MySql.Data.MySqlClient
Imports Mysqlx.Expect.Open.Types.Condition.Types
Imports Mysqlx.XDevAPI.Common
Imports ZstdSharp.Unsafe


Public Class FormBMI

    Dim conn As MySqlConnection = DBConnection.GetConnection()

    Const UnderweightLimit As Double = 18.5
    Const NormalLimit As Double = 24.9
    Const OverweightLimit As Double = 29.9

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
        Name = txtMRName.Text

        If String.IsNullOrWhiteSpace(Name) Then
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

        If Double.TryParse(txtWeight.Text, weight) And Double.TryParse(txtHeight.Text, height) Then
            If weight > 0 And height > 0 Then

                ' Asumsikan nilai tinggi adalah cm, ubah ke meter
                height = height / 100
                bmi = weight / (height * height)

                Dim query As String = "UPDATE medical_records SET height = @height, weight = @height WHERE patient_id = @pasienId"


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
        If bmi < UnderweightLimit Then
            Return "Kekurangan Berat Badan"
        ElseIf bmi <= NormalLimit Then
            Return "Normal"
        ElseIf bmi <= OverweightLimit Then
            Return "Kelebihan Berat Badan"
        Else
            Return "Obesitas"
        End If
    End Function

    Private Sub ClearForm()
        txtMRName.Clear()
        txtWeight.Clear()
        txtHeight.Clear()
    End Sub

End Class
