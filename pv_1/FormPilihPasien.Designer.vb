<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPilihPasien
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPilihPasien))
        btnPilihPasienBaru = New Button()
        btnPilihPasienLama = New Button()
        SuspendLayout()
        ' 
        ' btnPilihPasienBaru
        ' 
        btnPilihPasienBaru.Anchor = AnchorStyles.None
        btnPilihPasienBaru.FlatAppearance.BorderColor = Color.Black
        btnPilihPasienBaru.FlatStyle = FlatStyle.Flat
        btnPilihPasienBaru.Font = New Font("Sans Serif Collection", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnPilihPasienBaru.Image = CType(resources.GetObject("btnPilihPasienBaru.Image"), Image)
        btnPilihPasienBaru.ImageAlign = ContentAlignment.MiddleLeft
        btnPilihPasienBaru.Location = New Point(48, 204)
        btnPilihPasienBaru.Name = "btnPilihPasienBaru"
        btnPilihPasienBaru.Size = New Size(476, 146)
        btnPilihPasienBaru.TabIndex = 0
        btnPilihPasienBaru.Text = "Pendaftaran Pasien Baru"
        btnPilihPasienBaru.TextAlign = ContentAlignment.MiddleRight
        btnPilihPasienBaru.UseVisualStyleBackColor = True
        ' 
        ' btnPilihPasienLama
        ' 
        btnPilihPasienLama.Anchor = AnchorStyles.None
        btnPilihPasienLama.FlatStyle = FlatStyle.Flat
        btnPilihPasienLama.Font = New Font("Sans Serif Collection", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnPilihPasienLama.Image = CType(resources.GetObject("btnPilihPasienLama.Image"), Image)
        btnPilihPasienLama.ImageAlign = ContentAlignment.MiddleLeft
        btnPilihPasienLama.Location = New Point(582, 204)
        btnPilihPasienLama.Name = "btnPilihPasienLama"
        btnPilihPasienLama.Size = New Size(476, 146)
        btnPilihPasienLama.TabIndex = 0
        btnPilihPasienLama.Text = "Pendaftaran Pasien Lama"
        btnPilihPasienLama.TextAlign = ContentAlignment.MiddleRight
        btnPilihPasienLama.UseVisualStyleBackColor = True
        ' 
        ' FormPilihPasien
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(187), CByte(226), CByte(236))
        ClientSize = New Size(1100, 517)
        Controls.Add(btnPilihPasienLama)
        Controls.Add(btnPilihPasienBaru)
        Name = "FormPilihPasien"
        StartPosition = FormStartPosition.CenterParent
        Text = "Pilih Jenis Pasien"
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnPilihPasienBaru As Button
    Friend WithEvents btnPilihPasienLama As Button
End Class
