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
        Label1 = New Label()
        Limit = New Label()
        Label2 = New Label()
        btnSave = New Button()
        lblmrcode = New Label()
        txtMrCode = New TextBox()
        SuspendLayout()
        ' 
        ' txtKuota
        ' 
        txtKuota.Location = New Point(143, 69)
        txtKuota.Name = "txtKuota"
        txtKuota.Size = New Size(100, 23)
        txtKuota.TabIndex = 0
        ' 
        ' txtLimit
        ' 
        txtLimit.Location = New Point(143, 105)
        txtLimit.Name = "txtLimit"
        txtLimit.Size = New Size(100, 23)
        txtLimit.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(66, 69)
        Label1.Name = "Label1"
        Label1.Size = New Size(38, 15)
        Label1.TabIndex = 2
        Label1.Text = "Kuota"
        ' 
        ' Limit
        ' 
        Limit.AutoSize = True
        Limit.Location = New Point(66, 113)
        Limit.Name = "Limit"
        Limit.Size = New Size(34, 15)
        Limit.TabIndex = 3
        Limit.Text = "Limit"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(66, 33)
        Label2.Name = "Label2"
        Label2.Size = New Size(85, 15)
        Label2.TabIndex = 4
        Label2.Text = "Config Antrian"
        ' 
        ' btnSave
        ' 
        btnSave.Location = New Point(66, 208)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(114, 34)
        btnSave.TabIndex = 5
        btnSave.Text = "Simpan"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' lblmrcode
        ' 
        lblmrcode.AutoSize = True
        lblmrcode.Location = New Point(66, 155)
        lblmrcode.Name = "lblmrcode"
        lblmrcode.Size = New Size(108, 15)
        lblmrcode.TabIndex = 6
        lblmrcode.Text = "Kode Rekam Medis"
        ' 
        ' txtMrCode
        ' 
        txtMrCode.Location = New Point(196, 147)
        txtMrCode.Name = "txtMrCode"
        txtMrCode.Size = New Size(100, 23)
        txtMrCode.TabIndex = 7
        ' 
        ' FormConfig
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(txtMrCode)
        Controls.Add(lblmrcode)
        Controls.Add(btnSave)
        Controls.Add(Label2)
        Controls.Add(Limit)
        Controls.Add(Label1)
        Controls.Add(txtLimit)
        Controls.Add(txtKuota)
        Name = "FormConfig"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtKuota As TextBox
    Friend WithEvents txtLimit As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Limit As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents lblmrcode As Label
    Friend WithEvents txtMrCode As TextBox
End Class
