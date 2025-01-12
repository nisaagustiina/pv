<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormBmi
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
        lblWeight = New Label()
        txtWeight = New TextBox()
        lblHeight = New Label()
        txtHeight = New TextBox()
        lblName = New Label()
        txtMRName = New TextBox()
        btnCalculate = New Button()
        pnlBmi = New Panel()
        btnReset = New Button()
        lblTitle = New Label()
        pnlBmi.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblWeight
        ' 
        lblWeight.AutoSize = True
        lblWeight.Font = New Font("Sans Serif Collection", 7.8F)
        lblWeight.ForeColor = SystemColors.ControlLightLight
        lblWeight.Location = New Point(85, 93)
        lblWeight.Name = "lblWeight"
        lblWeight.Size = New Size(79, 37)
        lblWeight.TabIndex = 0
        lblWeight.Text = "Berat Badan"
        ' 
        ' txtWeight
        ' 
        txtWeight.Font = New Font("Sans Serif Collection", 9F)
        txtWeight.Location = New Point(246, 93)
        txtWeight.Name = "txtWeight"
        txtWeight.Size = New Size(216, 39)
        txtWeight.TabIndex = 1
        ' 
        ' lblHeight
        ' 
        lblHeight.AutoSize = True
        lblHeight.Font = New Font("Sans Serif Collection", 7.8F)
        lblHeight.ForeColor = SystemColors.ControlLightLight
        lblHeight.Location = New Point(85, 142)
        lblHeight.Name = "lblHeight"
        lblHeight.Size = New Size(84, 37)
        lblHeight.TabIndex = 2
        lblHeight.Text = "Tinggi Badan"
        ' 
        ' txtHeight
        ' 
        txtHeight.Font = New Font("Sans Serif Collection", 9F)
        txtHeight.Location = New Point(246, 142)
        txtHeight.Name = "txtHeight"
        txtHeight.Size = New Size(216, 39)
        txtHeight.TabIndex = 3
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.Font = New Font("Sans Serif Collection", 7.8F)
        lblName.ForeColor = SystemColors.ControlLightLight
        lblName.Location = New Point(85, 44)
        lblName.Name = "lblName"
        lblName.Size = New Size(50, 37)
        lblName.TabIndex = 78
        lblName.Text = "No RM"
        ' 
        ' txtMRName
        ' 
        txtMRName.Font = New Font("Sans Serif Collection", 9F)
        txtMRName.Location = New Point(246, 44)
        txtMRName.Name = "txtMRName"
        txtMRName.Size = New Size(216, 39)
        txtMRName.TabIndex = 5
        ' 
        ' btnCalculate
        ' 
        btnCalculate.BackColor = Color.FromArgb(CByte(13), CByte(146), CByte(118))
        btnCalculate.BackgroundImageLayout = ImageLayout.None
        btnCalculate.FlatAppearance.BorderSize = 0
        btnCalculate.FlatStyle = FlatStyle.Flat
        btnCalculate.Font = New Font("Sans Serif Collection", 7.8F)
        btnCalculate.ForeColor = Color.FromArgb(CByte(255), CByte(246), CByte(233))
        btnCalculate.Location = New Point(246, 204)
        btnCalculate.Name = "btnCalculate"
        btnCalculate.Size = New Size(75, 37)
        btnCalculate.TabIndex = 6
        btnCalculate.Text = "Hitung"
        btnCalculate.UseVisualStyleBackColor = False
        ' 
        ' pnlBmi
        ' 
        pnlBmi.BackColor = Color.FromArgb(CByte(25), CByte(69), CByte(107))
        pnlBmi.Controls.Add(btnReset)
        pnlBmi.Controls.Add(txtMRName)
        pnlBmi.Controls.Add(txtHeight)
        pnlBmi.Controls.Add(txtWeight)
        pnlBmi.Controls.Add(lblName)
        pnlBmi.Controls.Add(btnCalculate)
        pnlBmi.Controls.Add(lblWeight)
        pnlBmi.Controls.Add(lblHeight)
        pnlBmi.Location = New Point(121, 57)
        pnlBmi.Name = "pnlBmi"
        pnlBmi.Size = New Size(534, 353)
        pnlBmi.TabIndex = 8
        ' 
        ' btnReset
        ' 
        btnReset.BackColor = Color.FromArgb(CByte(13), CByte(146), CByte(118))
        btnReset.FlatAppearance.BorderSize = 0
        btnReset.FlatStyle = FlatStyle.Flat
        btnReset.Font = New Font("Sans Serif Collection", 7.8F)
        btnReset.ForeColor = Color.FromArgb(CByte(255), CByte(246), CByte(233))
        btnReset.Location = New Point(338, 204)
        btnReset.Name = "btnReset"
        btnReset.Size = New Size(75, 37)
        btnReset.TabIndex = 79
        btnReset.Text = "Hapus"
        btnReset.UseMnemonic = False
        btnReset.UseVisualStyleBackColor = False
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.BackColor = Color.FromArgb(CByte(187), CByte(226), CByte(236))
        lblTitle.Cursor = Cursors.Cross
        lblTitle.Font = New Font("Sans Serif Collection", 9F, FontStyle.Bold)
        lblTitle.ForeColor = Color.FromArgb(CByte(25), CByte(69), CByte(107))
        lblTitle.Location = New Point(290, 41)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(143, 41)
        lblTitle.TabIndex = 9
        lblTitle.Text = "PERHITUNGAN BMI"
        ' 
        ' FormBmi
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(187), CByte(226), CByte(236))
        ClientSize = New Size(800, 450)
        Controls.Add(lblTitle)
        Controls.Add(pnlBmi)
        Name = "FormBmi"
        Text = "Perhitungan BMI"
        pnlBmi.ResumeLayout(False)
        pnlBmi.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblWeight As Label
    Friend WithEvents txtWeight As TextBox
    Friend WithEvents lblHeight As Label
    Friend WithEvents txtHeight As TextBox
    Friend WithEvents lblName As Label
    Friend WithEvents txtMRName As TextBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnReturn As Button
    Friend WithEvents pnlBmi As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents btnReset As Button
End Class
