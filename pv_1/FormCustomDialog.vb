Public Class FormCustomDialog

    ' Properti untuk menerima pesan dari form utama
    Public Property Pesan As String

    Private Sub FormCustomDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Tampilkan pesan di Label saat form dimuat
        lblPesan.Text = Pesan
    End Sub

    Private Sub btnYes_Click(sender As Object, e As EventArgs) Handles btnYes.Click
        ' Jika tombol Yes diklik, set hasil Dialog menjadi Yes
        Me.DialogResult = DialogResult.Yes
        Me.Close()
    End Sub

    Private Sub btnNo_Click(sender As Object, e As EventArgs) Handles btnNo.Click
        ' Jika tombol No diklik, set hasil Dialog menjadi No
        Me.DialogResult = DialogResult.No
        Me.Close()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblPesan.Click

    End Sub
End Class
