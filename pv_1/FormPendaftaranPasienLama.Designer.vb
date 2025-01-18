<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPendaftaranPasienLama
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        lbPendaftaranPasienLama = New Label()
        pnlKontenDaftarPasien = New Panel()
        lbTempatLahir = New Label()
        txtNamaPasien = New TextBox()
        lbNamaPasien = New Label()
        btnCariNomerRekamMedis = New Button()
        txtbNomerRekamMedis = New TextBox()
        btnHapus = New Button()
        btnSimpan = New Button()
        cbTipePembayaran = New ComboBox()
        lbTipeBayar = New Label()
        txtKeluhan = New TextBox()
        lbKeluhan = New Label()
        lbNomerTelepon = New Label()
        txtNoTelepon = New TextBox()
        txtAlamat = New TextBox()
        lbAlamat = New Label()
        lbUsia = New Label()
        txtUsia = New TextBox()
        rbPerempuan = New RadioButton()
        rbLakiLaki = New RadioButton()
        lbJenisKelamin = New Label()
        dtpTanggalLahir = New DateTimePicker()
        lbTglLahir = New Label()
        txtNIK = New TextBox()
        lbNIK = New Label()
        txtTempatLahir = New TextBox()
        txtTanggalDaftar = New TextBox()
        lbTanggalRegister = New Label()
        pnlKontenDaftarPasien.SuspendLayout()
        SuspendLayout()
        ' 
        ' lbPendaftaranPasienLama
        ' 
        lbPendaftaranPasienLama.Anchor = AnchorStyles.None
        lbPendaftaranPasienLama.AutoSize = True
        lbPendaftaranPasienLama.Font = New Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbPendaftaranPasienLama.ForeColor = Color.FromArgb(CByte(25), CByte(69), CByte(107))
        lbPendaftaranPasienLama.Location = New Point(376, 26)
        lbPendaftaranPasienLama.Margin = New Padding(10)
        lbPendaftaranPasienLama.Name = "lbPendaftaranPasienLama"
        lbPendaftaranPasienLama.Size = New Size(349, 27)
        lbPendaftaranPasienLama.TabIndex = 0
        lbPendaftaranPasienLama.Text = "PENDAFTARAN PASIEN LAMA"
        lbPendaftaranPasienLama.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' pnlKontenDaftarPasien
        ' 
        pnlKontenDaftarPasien.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        pnlKontenDaftarPasien.AutoSize = True
        pnlKontenDaftarPasien.BackColor = Color.FromArgb(CByte(25), CByte(69), CByte(107))
        pnlKontenDaftarPasien.Controls.Add(lbTempatLahir)
        pnlKontenDaftarPasien.Controls.Add(txtNamaPasien)
        pnlKontenDaftarPasien.Controls.Add(lbNamaPasien)
        pnlKontenDaftarPasien.Controls.Add(btnCariNomerRekamMedis)
        pnlKontenDaftarPasien.Controls.Add(txtbNomerRekamMedis)
        pnlKontenDaftarPasien.Controls.Add(btnHapus)
        pnlKontenDaftarPasien.Controls.Add(btnSimpan)
        pnlKontenDaftarPasien.Controls.Add(cbTipePembayaran)
        pnlKontenDaftarPasien.Controls.Add(lbTipeBayar)
        pnlKontenDaftarPasien.Controls.Add(txtKeluhan)
        pnlKontenDaftarPasien.Controls.Add(lbKeluhan)
        pnlKontenDaftarPasien.Controls.Add(lbNomerTelepon)
        pnlKontenDaftarPasien.Controls.Add(txtNoTelepon)
        pnlKontenDaftarPasien.Controls.Add(txtAlamat)
        pnlKontenDaftarPasien.Controls.Add(lbAlamat)
        pnlKontenDaftarPasien.Controls.Add(lbUsia)
        pnlKontenDaftarPasien.Controls.Add(txtUsia)
        pnlKontenDaftarPasien.Controls.Add(rbPerempuan)
        pnlKontenDaftarPasien.Controls.Add(rbLakiLaki)
        pnlKontenDaftarPasien.Controls.Add(lbJenisKelamin)
        pnlKontenDaftarPasien.Controls.Add(dtpTanggalLahir)
        pnlKontenDaftarPasien.Controls.Add(lbTglLahir)
        pnlKontenDaftarPasien.Controls.Add(txtNIK)
        pnlKontenDaftarPasien.Controls.Add(lbNIK)
        pnlKontenDaftarPasien.Controls.Add(txtTempatLahir)
        pnlKontenDaftarPasien.Controls.Add(txtTanggalDaftar)
        pnlKontenDaftarPasien.Controls.Add(lbTanggalRegister)
        pnlKontenDaftarPasien.Font = New Font("Sans Serif Collection", 9F)
        pnlKontenDaftarPasien.ForeColor = SystemColors.Control
        pnlKontenDaftarPasien.Location = New Point(62, 64)
        pnlKontenDaftarPasien.Margin = New Padding(50)
        pnlKontenDaftarPasien.Name = "pnlKontenDaftarPasien"
        pnlKontenDaftarPasien.Size = New Size(926, 979)
        pnlKontenDaftarPasien.TabIndex = 0
        ' 
        ' lbTempatLahir
        ' 
        lbTempatLahir.Anchor = AnchorStyles.None
        lbTempatLahir.AutoSize = True
        lbTempatLahir.Location = New Point(69, 259)
        lbTempatLahir.Name = "lbTempatLahir"
        lbTempatLahir.Size = New Size(106, 51)
        lbTempatLahir.TabIndex = 136
        lbTempatLahir.Text = "Tempat lahir"
        ' 
        ' txtNamaPasien
        ' 
        txtNamaPasien.Anchor = AnchorStyles.None
        txtNamaPasien.Enabled = False
        txtNamaPasien.Font = New Font("Arial", 10.2F)
        txtNamaPasien.Location = New Point(291, 151)
        txtNamaPasien.Multiline = True
        txtNamaPasien.Name = "txtNamaPasien"
        txtNamaPasien.Size = New Size(544, 35)
        txtNamaPasien.TabIndex = 135
        ' 
        ' lbNamaPasien
        ' 
        lbNamaPasien.Anchor = AnchorStyles.None
        lbNamaPasien.AutoSize = True
        lbNamaPasien.Font = New Font("Sans Serif Collection", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lbNamaPasien.Location = New Point(69, 154)
        lbNamaPasien.Name = "lbNamaPasien"
        lbNamaPasien.Size = New Size(110, 51)
        lbNamaPasien.TabIndex = 134
        lbNamaPasien.Text = "Nama Pasien"
        ' 
        ' btnCariNomerRekamMedis
        ' 
        btnCariNomerRekamMedis.Anchor = AnchorStyles.None
        btnCariNomerRekamMedis.BackColor = Color.FromArgb(CByte(13), CByte(146), CByte(118))
        btnCariNomerRekamMedis.FlatAppearance.BorderColor = Color.FromArgb(CByte(255), CByte(246), CByte(233))
        btnCariNomerRekamMedis.Font = New Font("Arial", 10.2F, FontStyle.Bold)
        btnCariNomerRekamMedis.ForeColor = Color.FromArgb(CByte(255), CByte(246), CByte(233))
        btnCariNomerRekamMedis.Location = New Point(736, 27)
        btnCariNomerRekamMedis.Name = "btnCariNomerRekamMedis"
        btnCariNomerRekamMedis.Size = New Size(95, 42)
        btnCariNomerRekamMedis.TabIndex = 133
        btnCariNomerRekamMedis.Text = "CARI"
        btnCariNomerRekamMedis.UseVisualStyleBackColor = False
        ' 
        ' txtbNomerRekamMedis
        ' 
        txtbNomerRekamMedis.Anchor = AnchorStyles.None
        txtbNomerRekamMedis.Font = New Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtbNomerRekamMedis.Location = New Point(73, 25)
        txtbNomerRekamMedis.Multiline = True
        txtbNomerRekamMedis.Name = "txtbNomerRekamMedis"
        txtbNomerRekamMedis.Size = New Size(646, 45)
        txtbNomerRekamMedis.TabIndex = 132
        ' 
        ' btnHapus
        ' 
        btnHapus.Anchor = AnchorStyles.None
        btnHapus.BackColor = Color.FromArgb(CByte(13), CByte(146), CByte(118))
        btnHapus.Font = New Font("Arial", 10.2F, FontStyle.Bold)
        btnHapus.ForeColor = Color.FromArgb(CByte(255), CByte(246), CByte(233))
        btnHapus.Location = New Point(582, 868)
        btnHapus.Margin = New Padding(3, 3, 3, 20)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(137, 52)
        btnHapus.TabIndex = 104
        btnHapus.Text = "HAPUS"
        btnHapus.UseVisualStyleBackColor = False
        ' 
        ' btnSimpan
        ' 
        btnSimpan.Anchor = AnchorStyles.None
        btnSimpan.BackColor = Color.FromArgb(CByte(13), CByte(146), CByte(118))
        btnSimpan.BackgroundImageLayout = ImageLayout.None
        btnSimpan.Font = New Font("Arial", 10.2F, FontStyle.Bold)
        btnSimpan.ForeColor = Color.FromArgb(CByte(255), CByte(246), CByte(233))
        btnSimpan.Location = New Point(394, 868)
        btnSimpan.Margin = New Padding(3, 3, 3, 20)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(137, 52)
        btnSimpan.TabIndex = 103
        btnSimpan.Text = "SIMPAN"
        btnSimpan.UseVisualStyleBackColor = False
        ' 
        ' cbTipePembayaran
        ' 
        cbTipePembayaran.Anchor = AnchorStyles.None
        cbTipePembayaran.Font = New Font("Sans Serif Collection", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cbTipePembayaran.FormattingEnabled = True
        cbTipePembayaran.Location = New Point(291, 757)
        cbTipePembayaran.Name = "cbTipePembayaran"
        cbTipePembayaran.Size = New Size(544, 59)
        cbTipePembayaran.TabIndex = 129
        ' 
        ' lbTipeBayar
        ' 
        lbTipeBayar.Anchor = AnchorStyles.None
        lbTipeBayar.AutoSize = True
        lbTipeBayar.Location = New Point(73, 757)
        lbTipeBayar.Name = "lbTipeBayar"
        lbTipeBayar.Size = New Size(140, 51)
        lbTipeBayar.TabIndex = 128
        lbTipeBayar.Text = "Tipe Pembayaran"
        ' 
        ' txtKeluhan
        ' 
        txtKeluhan.Anchor = AnchorStyles.None
        txtKeluhan.Font = New Font("Arial", 10.2F)
        txtKeluhan.Location = New Point(291, 649)
        txtKeluhan.Multiline = True
        txtKeluhan.Name = "txtKeluhan"
        txtKeluhan.Size = New Size(544, 80)
        txtKeluhan.TabIndex = 127
        ' 
        ' lbKeluhan
        ' 
        lbKeluhan.Anchor = AnchorStyles.None
        lbKeluhan.AutoSize = True
        lbKeluhan.Location = New Point(69, 649)
        lbKeluhan.Name = "lbKeluhan"
        lbKeluhan.Size = New Size(78, 51)
        lbKeluhan.TabIndex = 126
        lbKeluhan.Text = "Keluhan"
        ' 
        ' lbNomerTelepon
        ' 
        lbNomerTelepon.Anchor = AnchorStyles.None
        lbNomerTelepon.AutoSize = True
        lbNomerTelepon.Location = New Point(73, 578)
        lbNomerTelepon.Name = "lbNomerTelepon"
        lbNomerTelepon.Size = New Size(126, 51)
        lbNomerTelepon.TabIndex = 125
        lbNomerTelepon.Text = "Nomer Telepon"
        ' 
        ' txtNoTelepon
        ' 
        txtNoTelepon.Anchor = AnchorStyles.None
        txtNoTelepon.Enabled = False
        txtNoTelepon.Font = New Font("Arial", 10.2F)
        txtNoTelepon.Location = New Point(291, 587)
        txtNoTelepon.Multiline = True
        txtNoTelepon.Name = "txtNoTelepon"
        txtNoTelepon.ReadOnly = True
        txtNoTelepon.Size = New Size(544, 35)
        txtNoTelepon.TabIndex = 124
        ' 
        ' txtAlamat
        ' 
        txtAlamat.Anchor = AnchorStyles.None
        txtAlamat.Enabled = False
        txtAlamat.Font = New Font("Arial", 10.2F)
        txtAlamat.Location = New Point(291, 496)
        txtAlamat.Multiline = True
        txtAlamat.Name = "txtAlamat"
        txtAlamat.ReadOnly = True
        txtAlamat.Size = New Size(544, 67)
        txtAlamat.TabIndex = 123
        ' 
        ' lbAlamat
        ' 
        lbAlamat.Anchor = AnchorStyles.None
        lbAlamat.AutoSize = True
        lbAlamat.Location = New Point(69, 496)
        lbAlamat.Name = "lbAlamat"
        lbAlamat.Size = New Size(71, 51)
        lbAlamat.TabIndex = 122
        lbAlamat.Text = "Alamat"
        ' 
        ' lbUsia
        ' 
        lbUsia.Anchor = AnchorStyles.None
        lbUsia.AutoSize = True
        lbUsia.Location = New Point(73, 431)
        lbUsia.Name = "lbUsia"
        lbUsia.Size = New Size(52, 51)
        lbUsia.TabIndex = 121
        lbUsia.Text = "Usia"
        ' 
        ' txtUsia
        ' 
        txtUsia.Anchor = AnchorStyles.None
        txtUsia.Enabled = False
        txtUsia.Font = New Font("Arial", 10.2F)
        txtUsia.Location = New Point(291, 440)
        txtUsia.Multiline = True
        txtUsia.Name = "txtUsia"
        txtUsia.ReadOnly = True
        txtUsia.Size = New Size(544, 35)
        txtUsia.TabIndex = 120
        ' 
        ' rbPerempuan
        ' 
        rbPerempuan.Anchor = AnchorStyles.None
        rbPerempuan.AutoSize = True
        rbPerempuan.Enabled = False
        rbPerempuan.Font = New Font("Arial", 10.2F)
        rbPerempuan.Location = New Point(441, 389)
        rbPerempuan.Name = "rbPerempuan"
        rbPerempuan.Size = New Size(114, 23)
        rbPerempuan.TabIndex = 119
        rbPerempuan.TabStop = True
        rbPerempuan.Text = "Perempuan"
        rbPerempuan.UseVisualStyleBackColor = True
        ' 
        ' rbLakiLaki
        ' 
        rbLakiLaki.Anchor = AnchorStyles.None
        rbLakiLaki.AutoSize = True
        rbLakiLaki.Enabled = False
        rbLakiLaki.Font = New Font("Arial", 10.2F)
        rbLakiLaki.Location = New Point(291, 389)
        rbLakiLaki.Name = "rbLakiLaki"
        rbLakiLaki.Size = New Size(96, 23)
        rbLakiLaki.TabIndex = 118
        rbLakiLaki.TabStop = True
        rbLakiLaki.Text = "Laki-Laki"
        rbLakiLaki.UseVisualStyleBackColor = True
        ' 
        ' lbJenisKelamin
        ' 
        lbJenisKelamin.Anchor = AnchorStyles.None
        lbJenisKelamin.AutoSize = True
        lbJenisKelamin.Location = New Point(73, 381)
        lbJenisKelamin.Name = "lbJenisKelamin"
        lbJenisKelamin.Size = New Size(112, 51)
        lbJenisKelamin.TabIndex = 117
        lbJenisKelamin.Text = "Jenis Kelamin"
        ' 
        ' dtpTanggalLahir
        ' 
        dtpTanggalLahir.Anchor = AnchorStyles.None
        dtpTanggalLahir.Enabled = False
        dtpTanggalLahir.Font = New Font("Sans Serif Collection", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        dtpTanggalLahir.ImeMode = ImeMode.Hiragana
        dtpTanggalLahir.Location = New Point(291, 321)
        dtpTanggalLahir.Name = "dtpTanggalLahir"
        dtpTanggalLahir.Size = New Size(544, 47)
        dtpTanggalLahir.TabIndex = 116
        ' 
        ' lbTglLahir
        ' 
        lbTglLahir.Anchor = AnchorStyles.None
        lbTglLahir.AutoSize = True
        lbTglLahir.Location = New Point(69, 321)
        lbTglLahir.Name = "lbTglLahir"
        lbTglLahir.Size = New Size(113, 51)
        lbTglLahir.TabIndex = 115
        lbTglLahir.Text = "Tanggal Lahir"
        ' 
        ' txtNIK
        ' 
        txtNIK.Anchor = AnchorStyles.None
        txtNIK.Enabled = False
        txtNIK.Font = New Font("Arial", 10.2F)
        txtNIK.Location = New Point(291, 208)
        txtNIK.Multiline = True
        txtNIK.Name = "txtNIK"
        txtNIK.ReadOnly = True
        txtNIK.Size = New Size(544, 35)
        txtNIK.TabIndex = 114
        ' 
        ' lbNIK
        ' 
        lbNIK.Anchor = AnchorStyles.None
        lbNIK.AutoSize = True
        lbNIK.Font = New Font("Sans Serif Collection", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lbNIK.Location = New Point(71, 208)
        lbNIK.Name = "lbNIK"
        lbNIK.Size = New Size(47, 51)
        lbNIK.TabIndex = 113
        lbNIK.Text = "NIK"
        ' 
        ' txtTempatLahir
        ' 
        txtTempatLahir.Anchor = AnchorStyles.None
        txtTempatLahir.Enabled = False
        txtTempatLahir.Font = New Font("Arial", 10.2F)
        txtTempatLahir.Location = New Point(291, 267)
        txtTempatLahir.Multiline = True
        txtTempatLahir.Name = "txtTempatLahir"
        txtTempatLahir.ReadOnly = True
        txtTempatLahir.Size = New Size(544, 35)
        txtTempatLahir.TabIndex = 112
        ' 
        ' txtTanggalDaftar
        ' 
        txtTanggalDaftar.Anchor = AnchorStyles.None
        txtTanggalDaftar.Enabled = False
        txtTanggalDaftar.Font = New Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtTanggalDaftar.Location = New Point(291, 97)
        txtTanggalDaftar.Multiline = True
        txtTanggalDaftar.Name = "txtTanggalDaftar"
        txtTanggalDaftar.ReadOnly = True
        txtTanggalDaftar.Size = New Size(544, 35)
        txtTanggalDaftar.TabIndex = 110
        ' 
        ' lbTanggalRegister
        ' 
        lbTanggalRegister.Anchor = AnchorStyles.None
        lbTanggalRegister.AutoSize = True
        lbTanggalRegister.Font = New Font("Sans Serif Collection", 9F)
        lbTanggalRegister.Location = New Point(69, 91)
        lbTanggalRegister.Name = "lbTanggalRegister"
        lbTanggalRegister.Size = New Size(162, 51)
        lbTanggalRegister.TabIndex = 109
        lbTanggalRegister.Text = "Tanggal Pendaftaran"
        ' 
        ' FormPendaftaranPasienLama
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        AutoScroll = True
        AutoSize = True
        BackColor = Color.FromArgb(CByte(187), CByte(226), CByte(236))
        ClientSize = New Size(1050, 1055)
        Controls.Add(pnlKontenDaftarPasien)
        Controls.Add(lbPendaftaranPasienLama)
        Name = "FormPendaftaranPasienLama"
        StartPosition = FormStartPosition.CenterParent
        Text = "Pendaftaran Pasien Lama"
        pnlKontenDaftarPasien.ResumeLayout(False)
        pnlKontenDaftarPasien.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lbPendaftaranPasienLama As Label
    Friend WithEvents pnlKontenDaftarPasien As Panel
    Friend WithEvents txtTanggalDaftar As TextBox
    Friend WithEvents lbTanggalRegister As Label
    Friend WithEvents txtNamaPasien As TextBox
    Friend WithEvents lbNamaPasien As Label
    Friend WithEvents dtpTanggalLahir As DateTimePicker
    Friend WithEvents lbTglLahir As Label
    Friend WithEvents txtNIK As TextBox
    Friend WithEvents lbNIK As Label
    Friend WithEvents txtTempatLahir As TextBox
    Friend WithEvents lbNomerRekam As Label
    Friend WithEvents rbPerempuan As RadioButton
    Friend WithEvents rbLakiLaki As RadioButton
    Friend WithEvents lbJenisKelamin As Label
    Friend WithEvents cbTipePembayaran As ComboBox
    Friend WithEvents lbTipeBayar As Label
    Friend WithEvents txtKeluhan As TextBox
    Friend WithEvents lbKeluhan As Label
    Friend WithEvents lbNomerTelepon As Label
    Friend WithEvents txtNoTelepon As TextBox
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents lbAlamat As Label
    Friend WithEvents lbUsia As Label
    Friend WithEvents txtUsia As TextBox
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnCariNomerRekamMedis As Button
    Friend WithEvents txtbNomerRekamMedis As TextBox
    Friend WithEvents lbTempatLahir As Label
End Class
