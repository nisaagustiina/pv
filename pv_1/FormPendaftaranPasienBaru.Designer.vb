﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPendaftaranPasienBaru
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
        pnlKontenDaftarPasien = New Panel()
        txtTanggalDaftar = New TextBox()
        lbTanggalRegister = New Label()
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
        txtNamaPasien = New TextBox()
        lbNamaPasien = New Label()
        txtTempatLahir = New TextBox()
        lbTempatLahir = New Label()
        lbPendaftaranPasienBaru = New Label()
        pnlKontenDaftarPasien.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlKontenDaftarPasien
        ' 
        pnlKontenDaftarPasien.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        pnlKontenDaftarPasien.AutoSize = True
        pnlKontenDaftarPasien.BackColor = Color.FromArgb(CByte(25), CByte(69), CByte(107))
        pnlKontenDaftarPasien.Controls.Add(txtTanggalDaftar)
        pnlKontenDaftarPasien.Controls.Add(lbTanggalRegister)
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
        pnlKontenDaftarPasien.Controls.Add(txtNamaPasien)
        pnlKontenDaftarPasien.Controls.Add(lbNamaPasien)
        pnlKontenDaftarPasien.Controls.Add(txtTempatLahir)
        pnlKontenDaftarPasien.Controls.Add(lbTempatLahir)
        pnlKontenDaftarPasien.Font = New Font("Sans Serif Collection", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        pnlKontenDaftarPasien.ForeColor = SystemColors.Control
        pnlKontenDaftarPasien.Location = New Point(65, 94)
        pnlKontenDaftarPasien.Margin = New Padding(50)
        pnlKontenDaftarPasien.Name = "pnlKontenDaftarPasien"
        pnlKontenDaftarPasien.Size = New Size(926, 889)
        pnlKontenDaftarPasien.TabIndex = 0
        ' 
        ' txtTanggalDaftar
        ' 
        txtTanggalDaftar.Anchor = AnchorStyles.None
        txtTanggalDaftar.Font = New Font("Arial", 10.2F)
        txtTanggalDaftar.Location = New Point(291, 18)
        txtTanggalDaftar.Multiline = True
        txtTanggalDaftar.Name = "txtTanggalDaftar"
        txtTanggalDaftar.ReadOnly = True
        txtTanggalDaftar.Size = New Size(544, 35)
        txtTanggalDaftar.TabIndex = 106
        ' 
        ' lbTanggalRegister
        ' 
        lbTanggalRegister.Anchor = AnchorStyles.None
        lbTanggalRegister.AutoSize = True
        lbTanggalRegister.Font = New Font("Sans Serif Collection", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lbTanggalRegister.Location = New Point(69, 21)
        lbTanggalRegister.Name = "lbTanggalRegister"
        lbTanggalRegister.Size = New Size(162, 51)
        lbTanggalRegister.TabIndex = 105
        lbTanggalRegister.Text = "Tanggal Pendaftaran"
        ' 
        ' btnHapus
        ' 
        btnHapus.Anchor = AnchorStyles.None
        btnHapus.BackColor = Color.FromArgb(CByte(13), CByte(146), CByte(118))
        btnHapus.Font = New Font("Arial", 10.2F, FontStyle.Bold)
        btnHapus.ForeColor = Color.FromArgb(CByte(255), CByte(246), CByte(233))
        btnHapus.Location = New Point(551, 774)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(137, 52)
        btnHapus.TabIndex = 102
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
        btnSimpan.Location = New Point(363, 774)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(137, 52)
        btnSimpan.TabIndex = 101
        btnSimpan.Text = "SIMPAN"
        btnSimpan.UseVisualStyleBackColor = False
        ' 
        ' cbTipePembayaran
        ' 
        cbTipePembayaran.Anchor = AnchorStyles.None
        cbTipePembayaran.FormattingEnabled = True
        cbTipePembayaran.Location = New Point(290, 673)
        cbTipePembayaran.Name = "cbTipePembayaran"
        cbTipePembayaran.Size = New Size(544, 59)
        cbTipePembayaran.TabIndex = 100
        ' 
        ' lbTipeBayar
        ' 
        lbTipeBayar.Anchor = AnchorStyles.None
        lbTipeBayar.AutoSize = True
        lbTipeBayar.Location = New Point(72, 673)
        lbTipeBayar.Name = "lbTipeBayar"
        lbTipeBayar.Size = New Size(140, 51)
        lbTipeBayar.TabIndex = 99
        lbTipeBayar.Text = "Tipe Pembayaran"
        ' 
        ' txtKeluhan
        ' 
        txtKeluhan.Anchor = AnchorStyles.None
        txtKeluhan.Font = New Font("Arial", 10.2F)
        txtKeluhan.Location = New Point(291, 565)
        txtKeluhan.Multiline = True
        txtKeluhan.Name = "txtKeluhan"
        txtKeluhan.Size = New Size(544, 80)
        txtKeluhan.TabIndex = 96
        ' 
        ' lbKeluhan
        ' 
        lbKeluhan.Anchor = AnchorStyles.None
        lbKeluhan.AutoSize = True
        lbKeluhan.Location = New Point(73, 568)
        lbKeluhan.Name = "lbKeluhan"
        lbKeluhan.Size = New Size(78, 51)
        lbKeluhan.TabIndex = 95
        lbKeluhan.Text = "Keluhan"
        ' 
        ' lbNomerTelepon
        ' 
        lbNomerTelepon.Anchor = AnchorStyles.None
        lbNomerTelepon.AutoSize = True
        lbNomerTelepon.Location = New Point(73, 496)
        lbNomerTelepon.Name = "lbNomerTelepon"
        lbNomerTelepon.Size = New Size(126, 51)
        lbNomerTelepon.TabIndex = 94
        lbNomerTelepon.Text = "Nomer Telepon"
        ' 
        ' txtNoTelepon
        ' 
        txtNoTelepon.Anchor = AnchorStyles.None
        txtNoTelepon.Font = New Font("Arial", 10.2F)
        txtNoTelepon.Location = New Point(291, 505)
        txtNoTelepon.Multiline = True
        txtNoTelepon.Name = "txtNoTelepon"
        txtNoTelepon.Size = New Size(544, 35)
        txtNoTelepon.TabIndex = 93
        ' 
        ' txtAlamat
        ' 
        txtAlamat.Anchor = AnchorStyles.None
        txtAlamat.Font = New Font("Arial", 10.2F)
        txtAlamat.Location = New Point(291, 417)
        txtAlamat.Multiline = True
        txtAlamat.Name = "txtAlamat"
        txtAlamat.Size = New Size(544, 67)
        txtAlamat.TabIndex = 92
        ' 
        ' lbAlamat
        ' 
        lbAlamat.Anchor = AnchorStyles.None
        lbAlamat.AutoSize = True
        lbAlamat.Location = New Point(69, 417)
        lbAlamat.Name = "lbAlamat"
        lbAlamat.Size = New Size(71, 51)
        lbAlamat.TabIndex = 91
        lbAlamat.Text = "Alamat"
        ' 
        ' lbUsia
        ' 
        lbUsia.Anchor = AnchorStyles.None
        lbUsia.AutoSize = True
        lbUsia.Location = New Point(73, 352)
        lbUsia.Name = "lbUsia"
        lbUsia.Size = New Size(52, 51)
        lbUsia.TabIndex = 90
        lbUsia.Text = "Usia"
        ' 
        ' txtUsia
        ' 
        txtUsia.Anchor = AnchorStyles.None
        txtUsia.Font = New Font("Arial", 10.2F)
        txtUsia.Location = New Point(291, 361)
        txtUsia.Multiline = True
        txtUsia.Name = "txtUsia"
        txtUsia.Size = New Size(544, 35)
        txtUsia.TabIndex = 89
        ' 
        ' rbPerempuan
        ' 
        rbPerempuan.Anchor = AnchorStyles.None
        rbPerempuan.AutoSize = True
        rbPerempuan.Font = New Font("Arial", 10.2F)
        rbPerempuan.Location = New Point(442, 310)
        rbPerempuan.Name = "rbPerempuan"
        rbPerempuan.Size = New Size(114, 23)
        rbPerempuan.TabIndex = 88
        rbPerempuan.TabStop = True
        rbPerempuan.Text = "Perempuan"
        rbPerempuan.UseVisualStyleBackColor = True
        ' 
        ' rbLakiLaki
        ' 
        rbLakiLaki.Anchor = AnchorStyles.None
        rbLakiLaki.AutoSize = True
        rbLakiLaki.Font = New Font("Arial", 10.2F)
        rbLakiLaki.Location = New Point(292, 310)
        rbLakiLaki.Name = "rbLakiLaki"
        rbLakiLaki.Size = New Size(96, 23)
        rbLakiLaki.TabIndex = 87
        rbLakiLaki.TabStop = True
        rbLakiLaki.Text = "Laki-Laki"
        rbLakiLaki.UseVisualStyleBackColor = True
        ' 
        ' lbJenisKelamin
        ' 
        lbJenisKelamin.Anchor = AnchorStyles.None
        lbJenisKelamin.AutoSize = True
        lbJenisKelamin.Location = New Point(73, 302)
        lbJenisKelamin.Name = "lbJenisKelamin"
        lbJenisKelamin.Size = New Size(112, 51)
        lbJenisKelamin.TabIndex = 86
        lbJenisKelamin.Text = "Jenis Kelamin"
        ' 
        ' dtpTanggalLahir
        ' 
        dtpTanggalLahir.Anchor = AnchorStyles.None
        dtpTanggalLahir.ImeMode = ImeMode.Disable
        dtpTanggalLahir.Location = New Point(291, 241)
        dtpTanggalLahir.Name = "dtpTanggalLahir"
        dtpTanggalLahir.Size = New Size(544, 47)
        dtpTanggalLahir.TabIndex = 85
        ' 
        ' lbTglLahir
        ' 
        lbTglLahir.Anchor = AnchorStyles.None
        lbTglLahir.AutoSize = True
        lbTglLahir.Location = New Point(69, 241)
        lbTglLahir.Name = "lbTglLahir"
        lbTglLahir.Size = New Size(113, 51)
        lbTglLahir.TabIndex = 84
        lbTglLahir.Text = "Tanggal Lahir"
        ' 
        ' txtNIK
        ' 
        txtNIK.Anchor = AnchorStyles.None
        txtNIK.Font = New Font("Arial", 10.2F)
        txtNIK.Location = New Point(291, 129)
        txtNIK.Multiline = True
        txtNIK.Name = "txtNIK"
        txtNIK.Size = New Size(544, 35)
        txtNIK.TabIndex = 83
        ' 
        ' lbNIK
        ' 
        lbNIK.Anchor = AnchorStyles.None
        lbNIK.AutoSize = True
        lbNIK.Font = New Font("Sans Serif Collection", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lbNIK.Location = New Point(71, 129)
        lbNIK.Name = "lbNIK"
        lbNIK.Size = New Size(47, 51)
        lbNIK.TabIndex = 82
        lbNIK.Text = "NIK"
        ' 
        ' txtNamaPasien
        ' 
        txtNamaPasien.Anchor = AnchorStyles.None
        txtNamaPasien.Font = New Font("Arial", 10.2F)
        txtNamaPasien.Location = New Point(291, 73)
        txtNamaPasien.Multiline = True
        txtNamaPasien.Name = "txtNamaPasien"
        txtNamaPasien.Size = New Size(544, 35)
        txtNamaPasien.TabIndex = 81
        ' 
        ' lbNamaPasien
        ' 
        lbNamaPasien.Anchor = AnchorStyles.None
        lbNamaPasien.AutoSize = True
        lbNamaPasien.Font = New Font("Sans Serif Collection", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lbNamaPasien.Location = New Point(69, 76)
        lbNamaPasien.Name = "lbNamaPasien"
        lbNamaPasien.Size = New Size(110, 51)
        lbNamaPasien.TabIndex = 80
        lbNamaPasien.Text = "Nama Pasien"
        ' 
        ' txtTempatLahir
        ' 
        txtTempatLahir.Anchor = AnchorStyles.None
        txtTempatLahir.Font = New Font("Arial", 10.2F)
        txtTempatLahir.Location = New Point(291, 187)
        txtTempatLahir.Multiline = True
        txtTempatLahir.Name = "txtTempatLahir"
        txtTempatLahir.Size = New Size(544, 35)
        txtTempatLahir.TabIndex = 79
        ' 
        ' lbTempatLahir
        ' 
        lbTempatLahir.Anchor = AnchorStyles.None
        lbTempatLahir.AutoSize = True
        lbTempatLahir.Font = New Font("Sans Serif Collection", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lbTempatLahir.Location = New Point(69, 178)
        lbTempatLahir.Name = "lbTempatLahir"
        lbTempatLahir.Size = New Size(110, 51)
        lbTempatLahir.TabIndex = 78
        lbTempatLahir.Text = "Tempat Lahir"
        ' 
        ' lbPendaftaranPasienBaru
        ' 
        lbPendaftaranPasienBaru.Anchor = AnchorStyles.None
        lbPendaftaranPasienBaru.AutoSize = True
        lbPendaftaranPasienBaru.Font = New Font("Arial", 13.8F, FontStyle.Bold)
        lbPendaftaranPasienBaru.ForeColor = Color.FromArgb(CByte(25), CByte(69), CByte(107))
        lbPendaftaranPasienBaru.Location = New Point(383, 19)
        lbPendaftaranPasienBaru.Margin = New Padding(10)
        lbPendaftaranPasienBaru.Name = "lbPendaftaranPasienBaru"
        lbPendaftaranPasienBaru.Size = New Size(350, 27)
        lbPendaftaranPasienBaru.TabIndex = 103
        lbPendaftaranPasienBaru.Text = "PENDAFTARAN PASIEN BARU"
        lbPendaftaranPasienBaru.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' FormPendaftaranPasienBaru
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        AutoScroll = True
        AutoSize = True
        BackColor = Color.FromArgb(CByte(187), CByte(226), CByte(236))
        ClientSize = New Size(1050, 1027)
        Controls.Add(lbPendaftaranPasienBaru)
        Controls.Add(pnlKontenDaftarPasien)
        Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ForeColor = Color.White
        Name = "FormPendaftaranPasienBaru"
        StartPosition = FormStartPosition.CenterParent
        Text = "Pendaftaran Pasien Baru"
        pnlKontenDaftarPasien.ResumeLayout(False)
        pnlKontenDaftarPasien.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents pnlKontenDaftarPasien As Panel
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnSimpan As Button
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
    Friend WithEvents rbPerempuan As RadioButton
    Friend WithEvents rbLakiLaki As RadioButton
    Friend WithEvents lbJenisKelamin As Label
    Friend WithEvents dtpTanggalLahir As DateTimePicker
    Friend WithEvents lbTglLahir As Label
    Friend WithEvents txtNIK As TextBox
    Friend WithEvents lbNIK As Label
    Friend WithEvents txtNamaPasien As TextBox
    Friend WithEvents lbNamaPasien As Label
    Friend WithEvents txtTempatLahir As TextBox
    Friend WithEvents lbTempatLahir As Label
    Friend WithEvents lbPendaftaranPasienBaru As Label
    Friend WithEvents txtTanggalDaftar As TextBox
    Friend WithEvents lbTanggalRegister As Label

End Class
