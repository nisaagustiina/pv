Imports System.Windows.Forms

Public Class FormBmi
    Enum BMICategory
        Underweight
        Normal
        Overweight
        Obese
    End Enum

    Const UnderweightLimit As Double = 18.5
    Const NormalLimit As Double = 24.9
    Const OverweightLimit As Double = 29.9

    Dim weight As Double
    Dim height As Double
    Dim name As String
    Dim bmi As Double

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        name = txtName.Text
        If Double.TryParse(TxtWeight.Text, weight) And Double.TryParse(TxtHeight.Text, height) Then
            If weight > 0 And height > 0 Then
                bmi = weight / (height * height)

                Dim category As BMICategory = GetBMICategory(bmi)

                lblResult.Text = "BMI Anda: " & bmi.ToString("F2")

                Select Case category
                    Case BMICategory.Underweight
                        MessageBox.Show(name & ", berat badan Anda kurang.", "BMI Category")
                    Case BMICategory.Normal
                        MessageBox.Show(name & ", berat badan Anda normal.", "BMI Category")
                    Case BMICategory.Overweight
                        MessageBox.Show(name & ", Anda memiliki kelebihan berat badan.", "BMI Category")
                    Case BMICategory.Obese
                        MessageBox.Show(name & ", Anda obesitas.", "BMI Category")
                End Select
            Else
                MessageBox.Show("Masukkan nilai berat badan dan tinggi badan yang valid.", "Error")
            End If
        Else
            MessageBox.Show("Tolong masukkan angka yang valid untuk berat badan dan tinggi badan.", "Error")
        End If
    End Sub

    Private Function GetBMICategory(ByVal bmi As Double) As BMICategory
        If bmi < UnderweightLimit Then
            Return BMICategory.Underweight
        ElseIf bmi <= NormalLimit Then
            Return BMICategory.Normal
        ElseIf bmi <= OverweightLimit Then
            Return BMICategory.Overweight
        Else
            Return BMICategory.Obese
        End If
    End Function

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Dim form1 As New Form1()
        form1.Show()
        Me.Close()
    End Sub
End Class
