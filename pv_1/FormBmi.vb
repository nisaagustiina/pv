Public Class FormBmi

    Const UnderweightLimit As Double = 18.5
    Const NormalLimit As Double = 24.9
    Const OverweightLimit As Double = 29.9

    Dim weight As Double
    Dim height As Double
    Dim name As String
    Dim bmi As Double

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        name = txtName.Text

        If String.IsNullOrWhiteSpace(name) Then
            MessageBox.Show("Masukkan nama Anda.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If Double.TryParse(txtWeight.Text, weight) And Double.TryParse(txtHeight.Text, height) Then
            If weight > 0 And height > 0 Then

                ' Asumsikan nilai tinggi adalah cm, ubah ke meter
                height = height / 100
                bmi = weight / (height * height)

                Dim category As String = GetBMICategory(bmi)

                MessageBox.Show("Nama: " & name & Environment.NewLine &
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
        txtName.Clear()
        txtWeight.Clear()
        txtHeight.Clear()
    End Sub

    Private Sub txtName_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged

    End Sub
End Class
