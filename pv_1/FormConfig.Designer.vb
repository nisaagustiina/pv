<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormConfig
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
        txtKuota = New TextBox()
        txtLimit = New TextBox()
        btnSave = New Button()
        lblKodeRekamMedis = New Label()
        txtMrCode = New TextBox()
        pnlTekananDarah = New Panel()
        lbKuota = New Label()
        lblLimit = New Label()

        lblPerhitunganTekanan = New Label()
        pnlTekananDarah.SuspendLayout()
        SuspendLayout()
        ' 
        ' txtKuota
        ' 
        txtKuota.Location = New Point(284, 78)
        txtKuota.Margin = New Padding(3, 4, 3, 4)
        txtKuota.Multiline = True
        txtKuota.Name = "txtKuota"
        txtKuota.Size = New Size(246, 47)
        txtKuota.TabIndex = 0
        ' 
        ' txtLimit
        ' 
        txtLimit.Location = New Point(284, 149)
        txtLimit.Margin = New Padding(3, 4, 3, 4)
        txtLimit.Multiline = True
        txtLimit.Name = "txtLimit"
        txtLimit.Size = New Size(246, 47)
        txtLimit.TabIndex = 1
        ' 
        ' lblLimit
        ' 
        Me.lblLimit.AutoSize = True
        Me.lblLimit.Font = New Font("Sans Serif Collection", 9F)
        Me.lblLimit.ForeColor = SystemColors.ControlLightLight
        Me.lblLimit.Location = New Point(85, 143)
        Me.lblLimit.Name = "lblLimit"
        Me.lblLimit.Size = New Size(57, 51)
        Me.lblLimit.TabIndex = 3
        Me.lblLimit.Text = "Limit"
        ' 
        ' btnSave
        ' 
        btnSave.BackColor = Color.FromArgb(CByte(13), CByte(146), CByte(118))
        btnSave.Font = New Font("Arial", 10.2F, FontStyle.Bold)
        btnSave.ForeColor = Color.FromArgb(CByte(255), CByte(246), CByte(233))
        btnSave.Location = New Point(284, 317)
        btnSave.Margin = New Padding(3, 4, 3, 4)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(130, 45)
        btnSave.TabIndex = 5
        btnSave.Text = "SIMPAN"
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' lblKodeRekamMedis
        ' 
        lblKodeRekamMedis.AutoSize = True
        lblKodeRekamMedis.Font = New Font("Sans Serif Collection", 9F)
        lblKodeRekamMedis.ForeColor = SystemColors.ControlLightLight
        lblKodeRekamMedis.Location = New Point(85, 212)
        lblKodeRekamMedis.Name = "lblKodeRekamMedis"
        lblKodeRekamMedis.Size = New Size(150, 51)
        lblKodeRekamMedis.TabIndex = 6
        lblKodeRekamMedis.Text = "Kode Rekam Medis"
        ' 
        ' txtMrCode
        ' 
        txtMrCode.Location = New Point(284, 218)
        txtMrCode.Margin = New Padding(3, 4, 3, 4)
        txtMrCode.Multiline = True
        txtMrCode.Name = "txtMrCode"
        txtMrCode.Size = New Size(246, 47)
        txtMrCode.TabIndex = 7
        ' 
        ' pnlTekananDarah
        ' 
        pnlTekananDarah.Anchor = AnchorStyles.None
        pnlTekananDarah.BackColor = Color.FromArgb(CByte(25), CByte(69), CByte(107))
        pnlTekananDarah.Controls.Add(lbKuota)
        pnlTekananDarah.Controls.Add(txtMrCode)
        pnlTekananDarah.Controls.Add(txtLimit)
        pnlTekananDarah.Controls.Add(lblKodeRekamMedis)
        pnlTekananDarah.Controls.Add(txtKuota)
        pnlTekananDarah.Controls.Add(btnSave)
        pnlTekananDarah.Controls.Add(Me.lblLimit)
        pnlTekananDarah.Location = New Point(135, 87)
        pnlTekananDarah.Margin = New Padding(3, 4, 3, 4)
        pnlTekananDarah.Name = "pnlTekananDarah"
        pnlTekananDarah.Size = New Size(622, 435)
        pnlTekananDarah.TabIndex = 9
        ' 
        ' lbKuota
        ' 
        lbKuota.AutoSize = True
        lbKuota.Font = New Font("Sans Serif Collection", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lbKuota.ForeColor = SystemColors.ControlLightLight
        lbKuota.Location = New Point(85, 72)
        lbKuota.Name = "lbKuota"
        lbKuota.Size = New Size(62, 51)
        lbKuota.TabIndex = 11
        lbKuota.Text = "Kuota"
        ' 
        ' lblPerhitunganTekanan
        ' 
        lblPerhitunganTekanan.Anchor = AnchorStyles.None
        lblPerhitunganTekanan.AutoSize = True
        lblPerhitunganTekanan.Font = New Font("Arial", 13.8F, FontStyle.Bold)
        lblPerhitunganTekanan.ForeColor = Color.FromArgb(CByte(25), CByte(69), CByte(107))
        lblPerhitunganTekanan.Location = New Point(348, 40)
        lblPerhitunganTekanan.Name = "lblPerhitunganTekanan"
        lblPerhitunganTekanan.Size = New Size(211, 27)
        lblPerhitunganTekanan.TabIndex = 10
        lblPerhitunganTekanan.Text = "CONFIG ANTRIAN"
        lblPerhitunganTekanan.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' FormConfig
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(187), CByte(226), CByte(236))
        ClientSize = New Size(914, 600)
        Controls.Add(lblPerhitunganTekanan)
        Controls.Add(pnlTekananDarah)
        Margin = New Padding(3, 4, 3, 4)
        Name = "FormConfig"
        Text = "Config Antrian"
        pnlTekananDarah.ResumeLayout(False)
        pnlTekananDarah.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtKuota As TextBox
    Friend WithEvents txtLimit As TextBox
    Friend WithEvents lblLimit As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents lblKodeRekamMedis As Label
    Friend WithEvents txtMrCode As TextBox
    Friend WithEvents pnlTekananDarah As Panel
    Friend WithEvents lbKuota As Label
    Friend WithEvents lblPerhitunganTekanan As Label
End Class
