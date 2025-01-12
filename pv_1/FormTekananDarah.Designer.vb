<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormTekananDarah
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        lblSistolik = New Label()
        txtSistolik = New TextBox()
        lblDiastolik = New Label()
        txtDiastolik = New TextBox()
        btnCalculate = New Button()
        pnlTekananDarah = New Panel()
        txtMrCode = New TextBox()
        lbNomerRekamMedis = New Label()
        btnReset = New Button()
        lblPerhitunganTekanan = New Label()
        pnlTekananDarah.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblSistolik
        ' 
        lblSistolik.AutoSize = True
        lblSistolik.Font = New Font("Sans Serif Collection", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblSistolik.ForeColor = SystemColors.ControlLightLight
        lblSistolik.Location = New Point(46, 151)
        lblSistolik.Name = "lblSistolik"
        lblSistolik.Size = New Size(174, 51)
        lblSistolik.TabIndex = 2
        lblSistolik.Text = "Tekanan Darah Sistolik"
        ' 
        ' txtSistolik
        ' 
        txtSistolik.Font = New Font("Arial", 10.2F)
        txtSistolik.Location = New Point(307, 152)
        txtSistolik.Margin = New Padding(3, 4, 3, 4)
        txtSistolik.Multiline = True
        txtSistolik.Name = "txtSistolik"
        txtSistolik.Size = New Size(246, 47)
        txtSistolik.TabIndex = 3
        ' 
        ' lblDiastolik
        ' 
        lblDiastolik.AutoSize = True
        lblDiastolik.Font = New Font("Sans Serif Collection", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblDiastolik.ForeColor = SystemColors.ControlLightLight
        lblDiastolik.Location = New Point(46, 225)
        lblDiastolik.Name = "lblDiastolik"
        lblDiastolik.Size = New Size(185, 51)
        lblDiastolik.TabIndex = 4
        lblDiastolik.Text = "Tekanan Darah Diastolik"
        ' 
        ' txtDiastolik
        ' 
        txtDiastolik.Font = New Font("Arial", 10.2F)
        txtDiastolik.Location = New Point(307, 226)
        txtDiastolik.Margin = New Padding(3, 4, 3, 4)
        txtDiastolik.Multiline = True
        txtDiastolik.Name = "txtDiastolik"
        txtDiastolik.Size = New Size(246, 47)
        txtDiastolik.TabIndex = 5
        ' 
        ' btnCalculate
        ' 
        btnCalculate.BackColor = Color.FromArgb(CByte(13), CByte(146), CByte(118))
        btnCalculate.BackgroundImageLayout = ImageLayout.None
        btnCalculate.FlatAppearance.BorderSize = 0
        btnCalculate.Font = New Font("Arial", 10.2F, FontStyle.Bold)
        btnCalculate.ForeColor = Color.FromArgb(CByte(255), CByte(246), CByte(233))
        btnCalculate.Location = New Point(307, 313)
        btnCalculate.Margin = New Padding(3, 4, 3, 4)
        btnCalculate.Name = "btnCalculate"
        btnCalculate.Size = New Size(94, 47)
        btnCalculate.TabIndex = 6
        btnCalculate.Text = "HITUNG"
        btnCalculate.UseVisualStyleBackColor = False
        ' 
        ' pnlTekananDarah
        ' 
        pnlTekananDarah.Anchor = AnchorStyles.None
        pnlTekananDarah.BackColor = Color.FromArgb(CByte(25), CByte(69), CByte(107))
        pnlTekananDarah.Controls.Add(txtMrCode)
        pnlTekananDarah.Controls.Add(lbNomerRekamMedis)
        pnlTekananDarah.Controls.Add(btnReset)
        pnlTekananDarah.Controls.Add(lblSistolik)
        pnlTekananDarah.Controls.Add(txtSistolik)
        pnlTekananDarah.Controls.Add(btnCalculate)
        pnlTekananDarah.Controls.Add(lblDiastolik)
        pnlTekananDarah.Controls.Add(txtDiastolik)
        pnlTekananDarah.Location = New Point(135, 87)
        pnlTekananDarah.Margin = New Padding(3, 4, 3, 4)
        pnlTekananDarah.Name = "pnlTekananDarah"
        pnlTekananDarah.Size = New Size(622, 435)
        pnlTekananDarah.TabIndex = 8
        ' 
        ' txtMrCode
        ' 
        txtMrCode.Font = New Font("Arial", 10.2F)
        txtMrCode.Location = New Point(307, 81)
        txtMrCode.Margin = New Padding(3, 4, 3, 4)
        txtMrCode.Multiline = True
        txtMrCode.Name = "txtMrCode"
        txtMrCode.Size = New Size(246, 47)
        txtMrCode.TabIndex = 10
        ' 
        ' lbNomerRekamMedis
        ' 
        lbNomerRekamMedis.AutoSize = True
        lbNomerRekamMedis.Font = New Font("Sans Serif Collection", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lbNomerRekamMedis.ForeColor = SystemColors.ControlLightLight
        lbNomerRekamMedis.Location = New Point(46, 80)
        lbNomerRekamMedis.Name = "lbNomerRekamMedis"
        lbNomerRekamMedis.Size = New Size(135, 51)
        lbNomerRekamMedis.TabIndex = 9
        lbNomerRekamMedis.Text = "No Rekam Medis"
        ' 
        ' btnReset
        ' 
        btnReset.BackColor = Color.FromArgb(CByte(13), CByte(146), CByte(118))
        btnReset.BackgroundImageLayout = ImageLayout.None
        btnReset.FlatAppearance.BorderSize = 0
        btnReset.Font = New Font("Arial", 10.2F, FontStyle.Bold)
        btnReset.ForeColor = Color.FromArgb(CByte(255), CByte(246), CByte(233))
        btnReset.Location = New Point(433, 313)
        btnReset.Margin = New Padding(3, 4, 3, 4)
        btnReset.Name = "btnReset"
        btnReset.Size = New Size(86, 47)
        btnReset.TabIndex = 8
        btnReset.Text = "HAPUS"
        btnReset.UseVisualStyleBackColor = False
        ' 
        ' lblPerhitunganTekanan
        ' 
        lblPerhitunganTekanan.Anchor = AnchorStyles.None
        lblPerhitunganTekanan.AutoSize = True
        lblPerhitunganTekanan.Font = New Font("Arial", 13.8F, FontStyle.Bold)
        lblPerhitunganTekanan.ForeColor = Color.FromArgb(CByte(25), CByte(69), CByte(107))
        lblPerhitunganTekanan.Location = New Point(260, 38)
        lblPerhitunganTekanan.Name = "lblPerhitunganTekanan"
        lblPerhitunganTekanan.Size = New Size(394, 27)
        lblPerhitunganTekanan.TabIndex = 9
        lblPerhitunganTekanan.Text = "PERHITUNGAN TEKANAN DARAH"
        lblPerhitunganTekanan.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' FormTekananDarah
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(187), CByte(226), CByte(236))
        ClientSize = New Size(914, 600)
        Controls.Add(lblPerhitunganTekanan)
        Controls.Add(pnlTekananDarah)
        Margin = New Padding(3, 4, 3, 4)
        Name = "FormTekananDarah"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Perhitungan Tekanan Darah"
        pnlTekananDarah.ResumeLayout(False)
        pnlTekananDarah.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents MenuStrip2 As MenuStrip
    Friend WithEvents menuExit As ToolStripMenuItem
    Friend WithEvents menuAbout As ToolStripMenuItem
    Friend WithEvents lblSistolik As Label
    Friend WithEvents txtSistolik As TextBox
    Friend WithEvents lblDiastolik As Label
    Friend WithEvents txtDiastolik As TextBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents pnlTekananDarah As Panel
    Friend WithEvents lblPerhitunganTekanan As Label
    Friend WithEvents btnReset As Button
    Friend WithEvents txtMrCode As TextBox
    Friend WithEvents lbNomerRekamMedis As Label

End Class
