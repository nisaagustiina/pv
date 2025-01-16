<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormUtama
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
        plnNavigasi = New Panel()
        btnDataPendaftaran = New Button()
        btnConfig = New Button()
        picLogo = New PictureBox()
        btnDataPasien = New Button()
        btnTekanan = New Button()
        btnBMI = New Button()
        btnPendaftaran = New Button()
        TableLayoutPanel1 = New TableLayoutPanel()
        lbDeskripsi = New Label()
        Label3 = New Label()
        pnlKonten = New Panel()
        plnNavigasi.SuspendLayout()
        CType(picLogo, ComponentModel.ISupportInitialize).BeginInit()
        TableLayoutPanel1.SuspendLayout()
        pnlKonten.SuspendLayout()
        SuspendLayout()
        ' 
        ' plnNavigasi
        ' 
        plnNavigasi.BackColor = Color.FromArgb(CByte(13), CByte(146), CByte(118))
        plnNavigasi.Controls.Add(btnDataPendaftaran)
        plnNavigasi.Controls.Add(btnConfig)
        plnNavigasi.Controls.Add(picLogo)
        plnNavigasi.Controls.Add(btnDataPasien)
        plnNavigasi.Controls.Add(btnTekanan)
        plnNavigasi.Controls.Add(btnBMI)
        plnNavigasi.Controls.Add(btnPendaftaran)
        plnNavigasi.Dock = DockStyle.Left
        plnNavigasi.Location = New Point(0, 0)
        plnNavigasi.Margin = New Padding(4, 5, 4, 5)
        plnNavigasi.Name = "plnNavigasi"
        plnNavigasi.Size = New Size(346, 1055)
        plnNavigasi.TabIndex = 0
        ' 
        ' btnDataPendaftaran
        ' 
        btnDataPendaftaran.Anchor = AnchorStyles.None
        btnDataPendaftaran.BackColor = Color.FromArgb(CByte(25), CByte(69), CByte(107))
        btnDataPendaftaran.FlatAppearance.BorderSize = 0
        btnDataPendaftaran.FlatStyle = FlatStyle.Flat
        btnDataPendaftaran.Font = New Font("Arial", 13.8F, FontStyle.Bold)
        btnDataPendaftaran.ForeColor = Color.FromArgb(CByte(255), CByte(246), CByte(233))
        btnDataPendaftaran.Location = New Point(26, 661)
        btnDataPendaftaran.Name = "btnDataPendaftaran"
        btnDataPendaftaran.Size = New Size(294, 80)
        btnDataPendaftaran.TabIndex = 6
        btnDataPendaftaran.Text = "Data Pendaftaran Pasien"
        btnDataPendaftaran.UseVisualStyleBackColor = False
        ' 
        ' btnConfig
        ' 
        btnConfig.Anchor = AnchorStyles.None
        btnConfig.BackColor = Color.FromArgb(CByte(25), CByte(69), CByte(107))
        btnConfig.FlatAppearance.BorderSize = 0
        btnConfig.FlatStyle = FlatStyle.Flat
        btnConfig.Font = New Font("Arial", 13.8F, FontStyle.Bold)
        btnConfig.ForeColor = Color.FromArgb(CByte(255), CByte(246), CByte(233))
        btnConfig.Location = New Point(26, 759)
        btnConfig.Name = "btnConfig"
        btnConfig.Size = New Size(294, 55)
        btnConfig.TabIndex = 5
        btnConfig.Text = "Config"
        btnConfig.UseVisualStyleBackColor = False
        ' 
        ' picLogo
        ' 
        picLogo.Image = My.Resources.Resources.Pink_Simple_Creative_And_Professional_Medical_Home_Logo_Design_Template_removebg_preview1
        picLogo.Location = New Point(8, 9)
        picLogo.Name = "picLogo"
        picLogo.Size = New Size(334, 202)
        picLogo.SizeMode = PictureBoxSizeMode.Zoom
        picLogo.TabIndex = 4
        picLogo.TabStop = False
        ' 
        ' btnDataPasien
        ' 
        btnDataPasien.Anchor = AnchorStyles.None
        btnDataPasien.BackColor = Color.FromArgb(CByte(25), CByte(69), CByte(107))
        btnDataPasien.FlatAppearance.BorderSize = 0
        btnDataPasien.FlatStyle = FlatStyle.Flat
        btnDataPasien.Font = New Font("Arial", 13.8F, FontStyle.Bold)
        btnDataPasien.ForeColor = Color.FromArgb(CByte(255), CByte(246), CByte(233))
        btnDataPasien.Location = New Point(26, 590)
        btnDataPasien.Margin = New Padding(4, 5, 4, 5)
        btnDataPasien.Name = "btnDataPasien"
        btnDataPasien.Size = New Size(294, 55)
        btnDataPasien.TabIndex = 3
        btnDataPasien.Text = "Data Pasien"
        btnDataPasien.UseVisualStyleBackColor = False
        ' 
        ' btnTekanan
        ' 
        btnTekanan.Anchor = AnchorStyles.None
        btnTekanan.BackColor = Color.FromArgb(CByte(25), CByte(69), CByte(107))
        btnTekanan.FlatAppearance.BorderSize = 0
        btnTekanan.FlatStyle = FlatStyle.Flat
        btnTekanan.Font = New Font("Arial", 13.8F, FontStyle.Bold)
        btnTekanan.ForeColor = Color.FromArgb(CByte(255), CByte(246), CByte(233))
        btnTekanan.Location = New Point(26, 498)
        btnTekanan.Margin = New Padding(4, 5, 4, 5)
        btnTekanan.Name = "btnTekanan"
        btnTekanan.Size = New Size(294, 70)
        btnTekanan.TabIndex = 2
        btnTekanan.Text = "Perhitungan Tekanan Darah "
        btnTekanan.UseVisualStyleBackColor = False
        ' 
        ' btnBMI
        ' 
        btnBMI.Anchor = AnchorStyles.None
        btnBMI.BackColor = Color.FromArgb(CByte(25), CByte(69), CByte(107))
        btnBMI.FlatAppearance.BorderSize = 0
        btnBMI.FlatStyle = FlatStyle.Flat
        btnBMI.Font = New Font("Arial", 13.8F, FontStyle.Bold)
        btnBMI.ForeColor = Color.FromArgb(CByte(255), CByte(246), CByte(233))
        btnBMI.Location = New Point(26, 424)
        btnBMI.Margin = New Padding(4, 5, 4, 5)
        btnBMI.Name = "btnBMI"
        btnBMI.Size = New Size(294, 55)
        btnBMI.TabIndex = 1
        btnBMI.Text = "Perhitungan BMI"
        btnBMI.UseVisualStyleBackColor = False
        ' 
        ' btnPendaftaran
        ' 
        btnPendaftaran.Anchor = AnchorStyles.None
        btnPendaftaran.BackColor = Color.FromArgb(CByte(25), CByte(69), CByte(107))
        btnPendaftaran.FlatAppearance.BorderSize = 0
        btnPendaftaran.FlatStyle = FlatStyle.Flat
        btnPendaftaran.Font = New Font("Arial", 13.8F, FontStyle.Bold)
        btnPendaftaran.ForeColor = Color.FromArgb(CByte(255), CByte(246), CByte(233))
        btnPendaftaran.Location = New Point(26, 353)
        btnPendaftaran.Margin = New Padding(4, 5, 4, 5)
        btnPendaftaran.Name = "btnPendaftaran"
        btnPendaftaran.Size = New Size(294, 55)
        btnPendaftaran.TabIndex = 0
        btnPendaftaran.Text = "Pendaftaran Pasien"
        btnPendaftaran.UseVisualStyleBackColor = False
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 1
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 20F))
        TableLayoutPanel1.Controls.Add(lbDeskripsi, 0, 1)
        TableLayoutPanel1.Controls.Add(Label3, 0, 0)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 2
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.Size = New Size(1382, 1055)
        TableLayoutPanel1.TabIndex = 2
        ' 
        ' lbDeskripsi
        ' 
        lbDeskripsi.AutoSize = True
        lbDeskripsi.Dock = DockStyle.Fill
        lbDeskripsi.Font = New Font("Arial Black", 16.2F, FontStyle.Bold)
        lbDeskripsi.ForeColor = Color.FromArgb(CByte(25), CByte(69), CByte(107))
        lbDeskripsi.Location = New Point(3, 527)
        lbDeskripsi.Name = "lbDeskripsi"
        lbDeskripsi.Size = New Size(1376, 528)
        lbDeskripsi.TabIndex = 8
        lbDeskripsi.Text = "Platform Digital untuk Pengelolaan Data Pasien yang Efisien!"
        lbDeskripsi.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Dock = DockStyle.Fill
        Label3.Font = New Font("Arial Black", 25.8000011F, FontStyle.Bold)
        Label3.ForeColor = Color.FromArgb(CByte(13), CByte(146), CByte(118))
        Label3.Location = New Point(3, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(1376, 527)
        Label3.TabIndex = 7
        Label3.Text = "Selamat Datang di MedicaEntry Registration"
        Label3.TextAlign = ContentAlignment.BottomCenter
        ' 
        ' pnlKonten
        ' 
        pnlKonten.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        pnlKonten.BackColor = Color.FromArgb(CByte(187), CByte(226), CByte(236))
        pnlKonten.Controls.Add(TableLayoutPanel1)
        pnlKonten.Location = New Point(346, 0)
        pnlKonten.Margin = New Padding(4, 5, 4, 5)
        pnlKonten.Name = "pnlKonten"
        pnlKonten.Size = New Size(1382, 1055)
        pnlKonten.TabIndex = 1
        ' 
        ' FormUtama
        ' 
        AutoScaleDimensions = New SizeF(8F, 44F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1728, 1055)
        Controls.Add(pnlKonten)
        Controls.Add(plnNavigasi)
        Font = New Font("Sans Serif Collection", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Margin = New Padding(4, 5, 4, 5)
        Name = "FormUtama"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Home"
        WindowState = FormWindowState.Maximized
        plnNavigasi.ResumeLayout(False)
        CType(picLogo, ComponentModel.ISupportInitialize).EndInit()
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        pnlKonten.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents plnNavigasi As Panel
    Friend WithEvents btnTekanan As Button
    Friend WithEvents btnBMI As Button
    Friend WithEvents btnPendaftaran As Button
    Friend WithEvents btnDataPasien As Button
    Friend WithEvents picLogo As PictureBox
    Friend WithEvents btnConfig As Button
    Friend WithEvents btnDataPendaftaran As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents pnlKonten As Panel
    Friend WithEvents lbDeskripsi As Label
End Class
