﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPendaftaranPasien
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
        btnHapus = New Button()
        btnSimpan = New Button()
        cbTipePembayaran = New ComboBox()
        lbTipeBayar = New Label()
        cbJenisPendaftaran = New ComboBox()
        lbJenisDaftar = New Label()
        txtRiwayatPenyakit = New TextBox()
        lbRiwayatPenyakit = New Label()
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
        txtNoRekamMedis = New TextBox()
        lbNomerRekam = New Label()
        lbPendaftaranPasien = New Label()
        pnlKontenDaftarPasien.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlKontenDaftarPasien
        ' 
        pnlKontenDaftarPasien.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        pnlKontenDaftarPasien.BackColor = Color.SteelBlue
        pnlKontenDaftarPasien.Controls.Add(btnHapus)
        pnlKontenDaftarPasien.Controls.Add(btnSimpan)
        pnlKontenDaftarPasien.Controls.Add(cbTipePembayaran)
        pnlKontenDaftarPasien.Controls.Add(lbTipeBayar)
        pnlKontenDaftarPasien.Controls.Add(cbJenisPendaftaran)
        pnlKontenDaftarPasien.Controls.Add(lbJenisDaftar)
        pnlKontenDaftarPasien.Controls.Add(txtRiwayatPenyakit)
        pnlKontenDaftarPasien.Controls.Add(lbRiwayatPenyakit)
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
        pnlKontenDaftarPasien.Controls.Add(txtNoRekamMedis)
        pnlKontenDaftarPasien.Controls.Add(lbNomerRekam)
        pnlKontenDaftarPasien.Font = New Font("Sans Serif Collection", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        pnlKontenDaftarPasien.ForeColor = SystemColors.ControlLightLight
        pnlKontenDaftarPasien.Location = New Point(113, 38)
        pnlKontenDaftarPasien.Name = "pnlKontenDaftarPasien"
        pnlKontenDaftarPasien.Size = New Size(832, 856)
        pnlKontenDaftarPasien.TabIndex = 0
        ' 
        ' btnHapus
        ' 
        btnHapus.Anchor = AnchorStyles.None
        btnHapus.FlatStyle = FlatStyle.Flat
        btnHapus.ForeColor = Color.DarkBlue
        btnHapus.Location = New Point(490, 775)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(137, 39)
        btnHapus.TabIndex = 102
        btnHapus.Text = "HAPUS"
        btnHapus.UseVisualStyleBackColor = True
        ' 
        ' btnSimpan
        ' 
        btnSimpan.Anchor = AnchorStyles.None
        btnSimpan.BackgroundImageLayout = ImageLayout.None
        btnSimpan.FlatStyle = FlatStyle.Flat
        btnSimpan.ForeColor = Color.DarkBlue
        btnSimpan.Location = New Point(302, 775)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(137, 39)
        btnSimpan.TabIndex = 101
        btnSimpan.Text = "SIMPAN"
        btnSimpan.UseVisualStyleBackColor = True
        ' 
        ' cbTipePembayaran
        ' 
        cbTipePembayaran.Anchor = AnchorStyles.None
        cbTipePembayaran.FormattingEnabled = True
        cbTipePembayaran.Location = New Point(231, 706)
        cbTipePembayaran.Name = "cbTipePembayaran"
        cbTipePembayaran.Size = New Size(544, 40)
        cbTipePembayaran.TabIndex = 100
        ' 
        ' lbTipeBayar
        ' 
        lbTipeBayar.Anchor = AnchorStyles.None
        lbTipeBayar.AutoSize = True
        lbTipeBayar.Location = New Point(7, 705)
        lbTipeBayar.Name = "lbTipeBayar"
        lbTipeBayar.Size = New Size(180, 32)
        lbTipeBayar.TabIndex = 99
        lbTipeBayar.Text = "Tipe Pembayaran"
        ' 
        ' cbJenisPendaftaran
        ' 
        cbJenisPendaftaran.Anchor = AnchorStyles.None
        cbJenisPendaftaran.FormattingEnabled = True
        cbJenisPendaftaran.Location = New Point(231, 643)
        cbJenisPendaftaran.Name = "cbJenisPendaftaran"
        cbJenisPendaftaran.Size = New Size(544, 40)
        cbJenisPendaftaran.TabIndex = 98
        ' 
        ' lbJenisDaftar
        ' 
        lbJenisDaftar.Anchor = AnchorStyles.None
        lbJenisDaftar.AutoSize = True
        lbJenisDaftar.Location = New Point(7, 641)
        lbJenisDaftar.Name = "lbJenisDaftar"
        lbJenisDaftar.Size = New Size(185, 32)
        lbJenisDaftar.TabIndex = 97
        lbJenisDaftar.Text = "Jenis Pendaftaran"
        ' 
        ' txtRiwayatPenyakit
        ' 
        txtRiwayatPenyakit.Anchor = AnchorStyles.None
        txtRiwayatPenyakit.Location = New Point(231, 551)
        txtRiwayatPenyakit.Multiline = True
        txtRiwayatPenyakit.Name = "txtRiwayatPenyakit"
        txtRiwayatPenyakit.Size = New Size(544, 62)
        txtRiwayatPenyakit.TabIndex = 96
        ' 
        ' lbRiwayatPenyakit
        ' 
        lbRiwayatPenyakit.Anchor = AnchorStyles.None
        lbRiwayatPenyakit.AutoSize = True
        lbRiwayatPenyakit.Location = New Point(11, 554)
        lbRiwayatPenyakit.Name = "lbRiwayatPenyakit"
        lbRiwayatPenyakit.Size = New Size(176, 32)
        lbRiwayatPenyakit.TabIndex = 95
        lbRiwayatPenyakit.Text = "Riwayat Penyakit"
        ' 
        ' lbNomerTelepon
        ' 
        lbNomerTelepon.Anchor = AnchorStyles.None
        lbNomerTelepon.AutoSize = True
        lbNomerTelepon.Location = New Point(9, 492)
        lbNomerTelepon.Name = "lbNomerTelepon"
        lbNomerTelepon.Size = New Size(158, 32)
        lbNomerTelepon.TabIndex = 94
        lbNomerTelepon.Text = "Nomer Telepon"
        ' 
        ' txtNoTelepon
        ' 
        txtNoTelepon.Anchor = AnchorStyles.None
        txtNoTelepon.Location = New Point(231, 490)
        txtNoTelepon.Multiline = True
        txtNoTelepon.Name = "txtNoTelepon"
        txtNoTelepon.Size = New Size(544, 35)
        txtNoTelepon.TabIndex = 93
        ' 
        ' txtAlamat
        ' 
        txtAlamat.Anchor = AnchorStyles.None
        txtAlamat.Location = New Point(231, 399)
        txtAlamat.Multiline = True
        txtAlamat.Name = "txtAlamat"
        txtAlamat.Size = New Size(544, 67)
        txtAlamat.TabIndex = 92
        ' 
        ' lbAlamat
        ' 
        lbAlamat.Anchor = AnchorStyles.None
        lbAlamat.AutoSize = True
        lbAlamat.Location = New Point(9, 403)
        lbAlamat.Name = "lbAlamat"
        lbAlamat.Size = New Size(80, 32)
        lbAlamat.TabIndex = 91
        lbAlamat.Text = "Alamat"
        ' 
        ' lbUsia
        ' 
        lbUsia.Anchor = AnchorStyles.None
        lbUsia.AutoSize = True
        lbUsia.Location = New Point(9, 346)
        lbUsia.Name = "lbUsia"
        lbUsia.Size = New Size(57, 32)
        lbUsia.TabIndex = 90
        lbUsia.Text = "Usia"
        ' 
        ' txtUsia
        ' 
        txtUsia.Anchor = AnchorStyles.None
        txtUsia.Font = New Font("Sans Serif Collection", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtUsia.Location = New Point(231, 343)
        txtUsia.Multiline = True
        txtUsia.Name = "txtUsia"
        txtUsia.Size = New Size(544, 35)
        txtUsia.TabIndex = 89
        ' 
        ' rbPerempuan
        ' 
        rbPerempuan.Anchor = AnchorStyles.None
        rbPerempuan.AutoSize = True
        rbPerempuan.Location = New Point(381, 289)
        rbPerempuan.Name = "rbPerempuan"
        rbPerempuan.Size = New Size(145, 36)
        rbPerempuan.TabIndex = 88
        rbPerempuan.TabStop = True
        rbPerempuan.Text = "Perempuan"
        rbPerempuan.UseVisualStyleBackColor = True
        ' 
        ' rbLakiLaki
        ' 
        rbLakiLaki.Anchor = AnchorStyles.None
        rbLakiLaki.AutoSize = True
        rbLakiLaki.Location = New Point(231, 289)
        rbLakiLaki.Name = "rbLakiLaki"
        rbLakiLaki.Size = New Size(119, 36)
        rbLakiLaki.TabIndex = 87
        rbLakiLaki.TabStop = True
        rbLakiLaki.Text = "Laki-Laki"
        rbLakiLaki.UseVisualStyleBackColor = True
        ' 
        ' lbJenisKelamin
        ' 
        lbJenisKelamin.Anchor = AnchorStyles.None
        lbJenisKelamin.AutoSize = True
        lbJenisKelamin.Location = New Point(8, 288)
        lbJenisKelamin.Name = "lbJenisKelamin"
        lbJenisKelamin.Size = New Size(145, 32)
        lbJenisKelamin.TabIndex = 86
        lbJenisKelamin.Text = "Jenis Kelamin"
        ' 
        ' dtpTanggalLahir
        ' 
        dtpTanggalLahir.Anchor = AnchorStyles.None
        dtpTanggalLahir.ImeMode = ImeMode.Disable
        dtpTanggalLahir.Location = New Point(231, 230)
        dtpTanggalLahir.Name = "dtpTanggalLahir"
        dtpTanggalLahir.Size = New Size(544, 39)
        dtpTanggalLahir.TabIndex = 85
        ' 
        ' lbTglLahir
        ' 
        lbTglLahir.Anchor = AnchorStyles.None
        lbTglLahir.AutoSize = True
        lbTglLahir.Location = New Point(5, 230)
        lbTglLahir.Name = "lbTglLahir"
        lbTglLahir.Size = New Size(143, 32)
        lbTglLahir.TabIndex = 84
        lbTglLahir.Text = "Tanggal Lahir"
        ' 
        ' txtNIK
        ' 
        txtNIK.Anchor = AnchorStyles.None
        txtNIK.Font = New Font("Sans Serif Collection", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtNIK.Location = New Point(231, 176)
        txtNIK.Multiline = True
        txtNIK.Name = "txtNIK"
        txtNIK.Size = New Size(544, 35)
        txtNIK.TabIndex = 83
        ' 
        ' lbNIK
        ' 
        lbNIK.Anchor = AnchorStyles.None
        lbNIK.AutoSize = True
        lbNIK.Font = New Font("Sans Serif Collection", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lbNIK.Location = New Point(5, 174)
        lbNIK.Name = "lbNIK"
        lbNIK.Size = New Size(48, 32)
        lbNIK.TabIndex = 82
        lbNIK.Text = "NIK"
        ' 
        ' txtNamaPasien
        ' 
        txtNamaPasien.Anchor = AnchorStyles.None
        txtNamaPasien.Font = New Font("Sans Serif Collection", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtNamaPasien.Location = New Point(231, 120)
        txtNamaPasien.Multiline = True
        txtNamaPasien.Name = "txtNamaPasien"
        txtNamaPasien.Size = New Size(544, 35)
        txtNamaPasien.TabIndex = 81
        ' 
        ' lbNamaPasien
        ' 
        lbNamaPasien.Anchor = AnchorStyles.None
        lbNamaPasien.AutoSize = True
        lbNamaPasien.Font = New Font("Sans Serif Collection", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lbNamaPasien.Location = New Point(5, 118)
        lbNamaPasien.Name = "lbNamaPasien"
        lbNamaPasien.Size = New Size(139, 32)
        lbNamaPasien.TabIndex = 80
        lbNamaPasien.Text = "Nama Pasien"
        ' 
        ' txtNoRekamMedis
        ' 
        txtNoRekamMedis.Anchor = AnchorStyles.None
        txtNoRekamMedis.Font = New Font("Sans Serif Collection", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtNoRekamMedis.Location = New Point(231, 70)
        txtNoRekamMedis.Multiline = True
        txtNoRekamMedis.Name = "txtNoRekamMedis"
        txtNoRekamMedis.Size = New Size(544, 35)
        txtNoRekamMedis.TabIndex = 79
        ' 
        ' lbNomerRekam
        ' 
        lbNomerRekam.Anchor = AnchorStyles.None
        lbNomerRekam.AutoSize = True
        lbNomerRekam.Font = New Font("Sans Serif Collection", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lbNomerRekam.Location = New Point(5, 68)
        lbNomerRekam.Name = "lbNomerRekam"
        lbNomerRekam.Size = New Size(208, 32)
        lbNomerRekam.TabIndex = 78
        lbNomerRekam.Text = "Nomer Rekam Medis"
        ' 
        ' lbPendaftaranPasien
        ' 
        lbPendaftaranPasien.Anchor = AnchorStyles.None
        lbPendaftaranPasien.AutoSize = True
        lbPendaftaranPasien.Cursor = Cursors.Cross
        lbPendaftaranPasien.Font = New Font("Sans Serif Collection", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbPendaftaranPasien.Location = New Point(406, 9)
        lbPendaftaranPasien.Name = "lbPendaftaranPasien"
        lbPendaftaranPasien.Size = New Size(304, 37)
        lbPendaftaranPasien.TabIndex = 103
        lbPendaftaranPasien.Text = "PENDAFTARAN PASIEN"
        ' 
        ' FormPendaftaranPasien
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1050, 932)
        Controls.Add(lbPendaftaranPasien)
        Controls.Add(pnlKontenDaftarPasien)
        Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Name = "FormPendaftaranPasien"
        Text = "Pendaftaran Pasien"
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
    Friend WithEvents cbJenisPendaftaran As ComboBox
    Friend WithEvents lbJenisDaftar As Label
    Friend WithEvents txtRiwayatPenyakit As TextBox
    Friend WithEvents lbRiwayatPenyakit As Label
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
    Friend WithEvents txtNoRekamMedis As TextBox
    Friend WithEvents lbNomerRekam As Label
    Friend WithEvents lbPendaftaranPasien As Label
End Class
