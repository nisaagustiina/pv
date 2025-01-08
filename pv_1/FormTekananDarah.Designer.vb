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
        btnReset = New Button()
        lblTitle = New Label()
        Label1 = New Label()
        txtMrCode = New TextBox()
        pnlTekananDarah.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblSistolik
        ' 
        lblSistolik.AutoSize = True
        lblSistolik.Font = New Font("Sans Serif Collection", 7.8F)
        lblSistolik.ForeColor = SystemColors.ControlLightLight
        lblSistolik.Location = New Point(40, 114)
        lblSistolik.Name = "lblSistolik"
        lblSistolik.Size = New Size(195, 27)
        lblSistolik.TabIndex = 2
        lblSistolik.Text = "Tekanan Darah Sistolik"
        ' 
        ' txtSistolik
        ' 
        txtSistolik.Font = New Font("Sans Serif Collection", 7.8F)
        txtSistolik.Location = New Point(269, 114)
        txtSistolik.Name = "txtSistolik"
        txtSistolik.Size = New Size(202, 33)
        txtSistolik.TabIndex = 3
        ' 
        ' lblDiastolik
        ' 
        lblDiastolik.AutoSize = True
        lblDiastolik.Font = New Font("Sans Serif Collection", 7.8F)
        lblDiastolik.ForeColor = SystemColors.ControlLightLight
        lblDiastolik.Location = New Point(40, 174)
        lblDiastolik.Name = "lblDiastolik"
        lblDiastolik.Size = New Size(206, 27)
        lblDiastolik.TabIndex = 4
        lblDiastolik.Text = "Tekanan Darah Diastolik"
        ' 
        ' txtDiastolik
        ' 
        txtDiastolik.Font = New Font("Sans Serif Collection", 7.8F)
        txtDiastolik.Location = New Point(269, 174)
        txtDiastolik.Name = "txtDiastolik"
        txtDiastolik.Size = New Size(202, 33)
        txtDiastolik.TabIndex = 5
        ' 
        ' btnCalculate
        ' 
        btnCalculate.BackColor = Color.FromArgb(CByte(13), CByte(146), CByte(118))
        btnCalculate.BackgroundImageLayout = ImageLayout.None
        btnCalculate.FlatAppearance.BorderSize = 0
        btnCalculate.FlatStyle = FlatStyle.Flat
        btnCalculate.Font = New Font("Sans Serif Collection", 7.8F)
        btnCalculate.ForeColor = Color.FromArgb(CByte(255), CByte(246), CByte(233))
        btnCalculate.Location = New Point(269, 235)
        btnCalculate.Name = "btnCalculate"
        btnCalculate.Size = New Size(82, 35)
        btnCalculate.TabIndex = 6
        btnCalculate.Text = "Hitung"
        btnCalculate.UseVisualStyleBackColor = False
        ' 
        ' pnlTekananDarah
        ' 
        pnlTekananDarah.BackColor = Color.FromArgb(CByte(25), CByte(69), CByte(107))
        pnlTekananDarah.Controls.Add(txtMrCode)
        pnlTekananDarah.Controls.Add(Label1)
        pnlTekananDarah.Controls.Add(btnReset)
        pnlTekananDarah.Controls.Add(lblSistolik)
        pnlTekananDarah.Controls.Add(txtSistolik)
        pnlTekananDarah.Controls.Add(btnCalculate)
        pnlTekananDarah.Controls.Add(lblDiastolik)
        pnlTekananDarah.Controls.Add(txtDiastolik)
        pnlTekananDarah.Location = New Point(118, 65)
        pnlTekananDarah.Name = "pnlTekananDarah"
        pnlTekananDarah.Size = New Size(544, 326)
        pnlTekananDarah.TabIndex = 8
        ' 
        ' btnReset
        ' 
        btnReset.BackColor = Color.FromArgb(CByte(13), CByte(146), CByte(118))
        btnReset.BackgroundImageLayout = ImageLayout.None
        btnReset.FlatAppearance.BorderSize = 0
        btnReset.FlatStyle = FlatStyle.Flat
        btnReset.Font = New Font("Sans Serif Collection", 7.8F)
        btnReset.ForeColor = Color.FromArgb(CByte(255), CByte(246), CByte(233))
        btnReset.Location = New Point(379, 235)
        btnReset.Name = "btnReset"
        btnReset.Size = New Size(75, 35)
        btnReset.TabIndex = 8
        btnReset.Text = "Hapus"
        btnReset.UseVisualStyleBackColor = False
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Sans Serif Collection", 9F, FontStyle.Bold)
        lblTitle.ForeColor = Color.FromArgb(CByte(25), CByte(69), CByte(107))
        lblTitle.Location = New Point(225, 49)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(324, 29)
        lblTitle.TabIndex = 9
        lblTitle.Text = "PERHITUNGAN TEKANAN DARAH"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Sans Serif Collection", 7.8F)
        Label1.ForeColor = SystemColors.ControlLightLight
        Label1.Location = New Point(54, 52)
        Label1.Name = "Label1"
        Label1.Size = New Size(65, 27)
        Label1.TabIndex = 9
        Label1.Text = "No RM"
        ' 
        ' txtMrCode
        ' 
        txtMrCode.Font = New Font("Sans Serif Collection", 7.8F)
        txtMrCode.Location = New Point(269, 61)
        txtMrCode.Name = "txtMrCode"
        txtMrCode.Size = New Size(202, 33)
        txtMrCode.TabIndex = 10
        ' 
        ' FormTekananDarah
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(187), CByte(226), CByte(236))
        ClientSize = New Size(800, 450)
        Controls.Add(lblTitle)
        Controls.Add(pnlTekananDarah)
        Name = "FormTekananDarah"
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
    Friend WithEvents lblTitle As Label
    Friend WithEvents btnReset As Button
    Friend WithEvents txtMrCode As TextBox
    Friend WithEvents Label1 As Label

End Class
