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
        txtName = New TextBox()
        btnCalculate = New Button()
        pnlBmi = New Panel()
        btnReset = New Button()
        lblPerhitunganBMI = New Label()
        pnlBmi.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblWeight
        ' 
        lblWeight.AutoSize = True
        lblWeight.Font = New Font("Sans Serif Collection", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblWeight.ForeColor = SystemColors.ControlLightLight
        lblWeight.Location = New Point(97, 132)
        lblWeight.Name = "lblWeight"
        lblWeight.Size = New Size(105, 51)
        lblWeight.TabIndex = 0
        lblWeight.Text = "Berat Badan"
        ' 
        ' txtWeight
        ' 
        txtWeight.Font = New Font("Arial", 10.2F)
        txtWeight.Location = New Point(281, 132)
        txtWeight.Margin = New Padding(3, 4, 3, 4)
        txtWeight.Multiline = True
        txtWeight.Name = "txtWeight"
        txtWeight.Size = New Size(246, 47)
        txtWeight.TabIndex = 1
        ' 
        ' lblHeight
        ' 
        lblHeight.AutoSize = True
        lblHeight.Font = New Font("Sans Serif Collection", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblHeight.ForeColor = SystemColors.ControlLightLight
        lblHeight.Location = New Point(97, 204)
        lblHeight.Name = "lblHeight"
        lblHeight.Size = New Size(111, 51)
        lblHeight.TabIndex = 2
        lblHeight.Text = "Tinggi Badan"
        ' 
        ' txtHeight
        ' 
        txtHeight.Font = New Font("Arial", 10.2F)
        txtHeight.Location = New Point(281, 204)
        txtHeight.Margin = New Padding(3, 4, 3, 4)
        txtHeight.Multiline = True
        txtHeight.Name = "txtHeight"
        txtHeight.Size = New Size(246, 47)
        txtHeight.TabIndex = 3
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.Font = New Font("Sans Serif Collection", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblName.ForeColor = SystemColors.ControlLightLight
        lblName.Location = New Point(97, 59)
        lblName.Name = "lblName"
        lblName.Size = New Size(63, 51)
        lblName.TabIndex = 78
        lblName.Text = "Nama"
        ' 
        ' txtName
        ' 
        txtName.Font = New Font("Arial", 10.2F)
        txtName.Location = New Point(281, 59)
        txtName.Margin = New Padding(3, 4, 3, 4)
        txtName.Multiline = True
        txtName.Name = "txtName"
        txtName.Size = New Size(246, 47)
        txtName.TabIndex = 5
        ' 
        ' btnCalculate
        ' 
        btnCalculate.BackColor = Color.FromArgb(CByte(13), CByte(146), CByte(118))
        btnCalculate.BackgroundImageLayout = ImageLayout.None
        btnCalculate.FlatAppearance.BorderColor = Color.FromArgb(CByte(255), CByte(246), CByte(233))
        btnCalculate.Font = New Font("Arial", 10.2F, FontStyle.Bold)
        btnCalculate.ForeColor = Color.FromArgb(CByte(255), CByte(246), CByte(233))
        btnCalculate.Location = New Point(281, 284)
        btnCalculate.Margin = New Padding(3, 4, 3, 4)
        btnCalculate.Name = "btnCalculate"
        btnCalculate.Size = New Size(86, 49)
        btnCalculate.TabIndex = 6
        btnCalculate.Text = "HITUNG"
        btnCalculate.UseVisualStyleBackColor = False
        ' 
        ' pnlBmi
        ' 
        pnlBmi.Anchor = AnchorStyles.None
        pnlBmi.BackColor = Color.FromArgb(CByte(25), CByte(69), CByte(107))
        pnlBmi.Controls.Add(btnReset)
        pnlBmi.Controls.Add(txtName)
        pnlBmi.Controls.Add(txtHeight)
        pnlBmi.Controls.Add(txtWeight)
        pnlBmi.Controls.Add(lblName)
        pnlBmi.Controls.Add(btnCalculate)
        pnlBmi.Controls.Add(lblWeight)
        pnlBmi.Controls.Add(lblHeight)
        pnlBmi.Location = New Point(139, 90)
        pnlBmi.Margin = New Padding(3, 4, 3, 4)
        pnlBmi.Name = "pnlBmi"
        pnlBmi.Size = New Size(611, 398)
        pnlBmi.TabIndex = 8
        ' 
        ' btnReset
        ' 
        btnReset.BackColor = Color.FromArgb(CByte(13), CByte(146), CByte(118))
        btnReset.FlatAppearance.BorderSize = 0
        btnReset.Font = New Font("Arial", 10.2F, FontStyle.Bold)
        btnReset.ForeColor = Color.FromArgb(CByte(255), CByte(246), CByte(233))
        btnReset.Location = New Point(409, 284)
        btnReset.Margin = New Padding(3, 4, 3, 4)
        btnReset.Name = "btnReset"
        btnReset.Size = New Size(86, 49)
        btnReset.TabIndex = 79
        btnReset.Text = "HAPUS"
        btnReset.UseMnemonic = False
        btnReset.UseVisualStyleBackColor = False
        ' 
        ' lblPerhitunganBMI
        ' 
        lblPerhitunganBMI.Anchor = AnchorStyles.None
        lblPerhitunganBMI.AutoSize = True
        lblPerhitunganBMI.BackColor = Color.FromArgb(CByte(187), CByte(226), CByte(236))
        lblPerhitunganBMI.Cursor = Cursors.Cross
        lblPerhitunganBMI.Font = New Font("Arial", 13.8F, FontStyle.Bold)
        lblPerhitunganBMI.ForeColor = Color.FromArgb(CByte(25), CByte(69), CByte(107))
        lblPerhitunganBMI.Location = New Point(349, 32)
        lblPerhitunganBMI.Name = "lblPerhitunganBMI"
        lblPerhitunganBMI.Size = New Size(229, 27)
        lblPerhitunganBMI.TabIndex = 9
        lblPerhitunganBMI.Text = "PERHITUNGAN BMI"
        lblPerhitunganBMI.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' FormBmi
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(187), CByte(226), CByte(236))
        ClientSize = New Size(914, 600)
        Controls.Add(lblPerhitunganBMI)
        Controls.Add(pnlBmi)
        Margin = New Padding(3, 4, 3, 4)
        Name = "FormBmi"
        StartPosition = FormStartPosition.CenterParent
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
    Friend WithEvents txtName As TextBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnReturn As Button
    Friend WithEvents pnlBmi As Panel
    Friend WithEvents lblPerhitunganBMI As Label
    Friend WithEvents btnReset As Button
End Class
