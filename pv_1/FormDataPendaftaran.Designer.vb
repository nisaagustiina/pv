<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDataPendaftaran
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
        dgvDataPendaftaran = New DataGridView()
        CType(dgvDataPendaftaran, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvDataPendaftaran
        ' 
        dgvDataPendaftaran.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvDataPendaftaran.Location = New Point(61, 43)
        dgvDataPendaftaran.Name = "dgvDataPendaftaran"
        dgvDataPendaftaran.Size = New Size(1116, 563)
        dgvDataPendaftaran.TabIndex = 0
        ' 
        ' FormDataPendaftaran
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1242, 674)
        Controls.Add(dgvDataPendaftaran)
        Name = "FormDataPendaftaran"
        Text = "Form Data Pendaftaran"
        CType(dgvDataPendaftaran, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents dgvDataPendaftaran As DataGridView
End Class
