Public Class Form1

    Private Sub btnBMI_Click(sender As Object, e As EventArgs) Handles btnBMI.Click
        Dim formBMI As New FormBmi()
        formBMI.Show()
        Me.Hide()
    End Sub

    Private Sub btnTekananDarah_Click(sender As Object, e As EventArgs) Handles btnTekananDarah.Click
        Dim formTekanan As New FormTekananDarah()
        formTekanan.Show()
        Me.Hide()
    End Sub
    Private Sub menuExit_Click_1(sender As Object, e As EventArgs) Handles menuExit.Click
        Application.Exit()
    End Sub

    Private Sub menuAbout_Click(sender As Object, e As EventArgs) Handles menuAbout.Click
        MessageBox.Show("Aplikasi Pengukur Tekanan Darah", "Tentang", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class