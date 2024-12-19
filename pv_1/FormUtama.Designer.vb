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
        PictureBox1 = New PictureBox()
        btnDataDaftarPasien = New Button()
        btnTekanan = New Button()
        btnBMI = New Button()
        btnPendaftaran = New Button()
        pnlKonten = New Panel()
        plnNavigasi.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' plnNavigasi
        ' 
        plnNavigasi.Controls.Add(PictureBox1)
        plnNavigasi.Controls.Add(btnDataDaftarPasien)
        plnNavigasi.Controls.Add(btnTekanan)
        plnNavigasi.Controls.Add(btnBMI)
        plnNavigasi.Controls.Add(btnPendaftaran)
        plnNavigasi.Dock = DockStyle.Left
        plnNavigasi.Location = New Point(0, 0)
        plnNavigasi.Margin = New Padding(4, 5, 4, 5)
        plnNavigasi.Name = "plnNavigasi"
        plnNavigasi.Size = New Size(376, 1055)
        plnNavigasi.TabIndex = 0
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.Pink_Simple_Creative_And_Professional_Medical_Home_Logo_Design_Template_removebg_preview1
        PictureBox1.Location = New Point(8, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(361, 202)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 4
        PictureBox1.TabStop = False
        ' 
        ' btnDataDaftarPasien
        ' 
        btnDataDaftarPasien.Location = New Point(30, 502)
        btnDataDaftarPasien.Margin = New Padding(4, 5, 4, 5)
        btnDataDaftarPasien.Name = "btnDataDaftarPasien"
        btnDataDaftarPasien.Size = New Size(314, 46)
        btnDataDaftarPasien.TabIndex = 3
        btnDataDaftarPasien.Text = "Data Daftar Pasien"
        btnDataDaftarPasien.UseVisualStyleBackColor = True
        ' 
        ' btnTekanan
        ' 
        btnTekanan.Location = New Point(30, 435)
        btnTekanan.Margin = New Padding(4, 5, 4, 5)
        btnTekanan.Name = "btnTekanan"
        btnTekanan.Size = New Size(314, 46)
        btnTekanan.TabIndex = 2
        btnTekanan.Text = "Perhitungan Tekanan Darah "
        btnTekanan.UseVisualStyleBackColor = True
        ' 
        ' btnBMI
        ' 
        btnBMI.Location = New Point(30, 369)
        btnBMI.Margin = New Padding(4, 5, 4, 5)
        btnBMI.Name = "btnBMI"
        btnBMI.Size = New Size(314, 46)
        btnBMI.TabIndex = 1
        btnBMI.Text = "Perhitungan BMI"
        btnBMI.UseVisualStyleBackColor = True
        ' 
        ' btnPendaftaran
        ' 
        btnPendaftaran.Location = New Point(30, 302)
        btnPendaftaran.Margin = New Padding(4, 5, 4, 5)
        btnPendaftaran.Name = "btnPendaftaran"
        btnPendaftaran.Size = New Size(314, 46)
        btnPendaftaran.TabIndex = 0
        btnPendaftaran.Text = "Pendaftaran Pasien"
        btnPendaftaran.UseVisualStyleBackColor = True
        ' 
        ' pnlKonten
        ' 
        pnlKonten.Dock = DockStyle.Fill
        pnlKonten.Location = New Point(376, 0)
        pnlKonten.Margin = New Padding(4, 5, 4, 5)
        pnlKonten.Name = "pnlKonten"
        pnlKonten.Size = New Size(1352, 1055)
        pnlKonten.TabIndex = 1
        ' 
        ' FormUtama
        ' 
        AutoScaleDimensions = New SizeF(9F, 24F)
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
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents plnNavigasi As Panel
    Friend WithEvents btnTekanan As Button
    Friend WithEvents btnBMI As Button
    Friend WithEvents btnPendaftaran As Button
    Friend WithEvents btnDataDaftarPasien As Button
    Friend WithEvents pnlKonten As Panel
    Friend WithEvents PictureBox1 As PictureBox
End Class
