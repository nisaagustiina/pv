<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormDataPendaftaran
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
        dgvDataPendaftaran = New DataGridView()
        Button1 = New Button()
        CType(dgvDataPendaftaran, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvDataPendaftaran
        ' 
        dgvDataPendaftaran.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvDataPendaftaran.Location = New Point(61, 69)
        dgvDataPendaftaran.Name = "dgvDataPendaftaran"
        dgvDataPendaftaran.Size = New Size(1116, 563)
        dgvDataPendaftaran.TabIndex = 0
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(983, 32)
        Button1.Name = "Button1"
        Button1.Size = New Size(194, 31)
        Button1.TabIndex = 1
        Button1.Text = "Download  Data  Pendaftaran"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' FormDataPendaftaran
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1242, 674)
        Controls.Add(Button1)
        Controls.Add(dgvDataPendaftaran)
        Name = "FormDataPendaftaran"
        Text = "Form Data Pendaftaran"
        CType(dgvDataPendaftaran, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents dgvDataPendaftaran As DataGridView
    Friend WithEvents Button1 As Button
End Class
