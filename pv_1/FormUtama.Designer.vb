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
        pnlKonten = New Panel()
        plnNavigasi.SuspendLayout()
        CType(picLogo, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' plnNavigasi
        ' 
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
        btnDataPendaftaran.Location = New Point(24, 573)
        btnDataPendaftaran.Name = "btnDataPendaftaran"
        btnDataPendaftaran.Size = New Size(294, 41)
        btnDataPendaftaran.TabIndex = 6
        btnDataPendaftaran.Text = "Data Pendaftaran Pasien"
        btnDataPendaftaran.UseVisualStyleBackColor = True
        ' 
        ' btnConfig
        ' 
        btnConfig.Location = New Point(24, 638)
        btnConfig.Name = "btnConfig"
        btnConfig.Size = New Size(294, 46)
        btnConfig.TabIndex = 5
        btnConfig.Text = "Config"
        btnConfig.UseVisualStyleBackColor = True
        ' 
        ' picLogo
        ' 
        picLogo.Image = My.Resources.Resources.Pink_Simple_Creative_And_Professional_Medical_Home_Logo_Design_Template_removebg_preview1
        picLogo.Location = New Point(8, 12)
        picLogo.Name = "picLogo"
        picLogo.Size = New Size(334, 202)
        picLogo.SizeMode = PictureBoxSizeMode.Zoom
        picLogo.TabIndex = 4
        picLogo.TabStop = False
        ' 
        ' btnDataPasien
        ' 
        btnDataPasien.Location = New Point(24, 508)
        btnDataPasien.Margin = New Padding(4, 5, 4, 5)
        btnDataPasien.Name = "btnDataPasien"
        btnDataPasien.Size = New Size(294, 46)
        btnDataPasien.TabIndex = 3
        btnDataPasien.Text = "Data Pasien"
        btnDataPasien.UseVisualStyleBackColor = True
        ' 
        ' btnTekanan
        ' 
        btnTekanan.Location = New Point(24, 441)
        btnTekanan.Margin = New Padding(4, 5, 4, 5)
        btnTekanan.Name = "btnTekanan"
        btnTekanan.Size = New Size(294, 46)
        btnTekanan.TabIndex = 2
        btnTekanan.Text = "Perhitungan Tekanan Darah "
        btnTekanan.UseVisualStyleBackColor = True
        ' 
        ' btnBMI
        ' 
        btnBMI.Location = New Point(24, 375)
        btnBMI.Margin = New Padding(4, 5, 4, 5)
        btnBMI.Name = "btnBMI"
        btnBMI.Size = New Size(294, 46)
        btnBMI.TabIndex = 1
        btnBMI.Text = "Perhitungan BMI"
        btnBMI.UseVisualStyleBackColor = True
        ' 
        ' btnPendaftaran
        ' 
        btnPendaftaran.Location = New Point(24, 308)
        btnPendaftaran.Margin = New Padding(4, 5, 4, 5)
        btnPendaftaran.Name = "btnPendaftaran"
        btnPendaftaran.Size = New Size(294, 46)
        btnPendaftaran.TabIndex = 0
        btnPendaftaran.Text = "Pendaftaran Pasien"
        btnPendaftaran.UseVisualStyleBackColor = True
        ' 
        ' pnlKonten
        ' 
        pnlKonten.Dock = DockStyle.Fill
        pnlKonten.Location = New Point(346, 0)
        pnlKonten.Margin = New Padding(4, 5, 4, 5)
        pnlKonten.Name = "pnlKonten"
        pnlKonten.Size = New Size(1382, 1055)
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
        CType(picLogo, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents plnNavigasi As Panel
    Friend WithEvents btnTekanan As Button
    Friend WithEvents btnBMI As Button
    Friend WithEvents btnPendaftaran As Button
    Friend WithEvents btnDataPasien As Button
    Friend WithEvents pnlKonten As Panel
    Friend WithEvents picLogo As PictureBox
    Friend WithEvents btnConfig As Button
    Friend WithEvents btnDataPendaftaran As Button
End Class
