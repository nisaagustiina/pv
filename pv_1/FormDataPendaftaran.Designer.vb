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
        btnDowlondFile = New Button()
        lbDataPasien = New Label()
        CType(dgvDataPendaftaran, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvDataPendaftaran
        ' 
        dgvDataPendaftaran.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvDataPendaftaran.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvDataPendaftaran.BackgroundColor = SystemColors.ControlLightLight
        dgvDataPendaftaran.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvDataPendaftaran.Location = New Point(51, 102)
        dgvDataPendaftaran.Margin = New Padding(3, 7, 3, 7)
        dgvDataPendaftaran.Name = "dgvDataPendaftaran"
        dgvDataPendaftaran.RowHeadersWidth = 51
        dgvDataPendaftaran.Size = New Size(1115, 595)
        dgvDataPendaftaran.TabIndex = 0
        ' 
        ' btnDowlondFile
        ' 
        btnDowlondFile.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnDowlondFile.BackColor = Color.FromArgb(CByte(13), CByte(146), CByte(118))
        btnDowlondFile.Font = New Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDowlondFile.ForeColor = Color.FromArgb(CByte(255), CByte(246), CByte(233))
        btnDowlondFile.Location = New Point(992, 51)
        btnDowlondFile.Margin = New Padding(10)
        btnDowlondFile.Name = "btnDowlondFile"
        btnDowlondFile.Size = New Size(174, 47)
        btnDowlondFile.TabIndex = 1
        btnDowlondFile.Text = "Download File"
        btnDowlondFile.UseVisualStyleBackColor = False
        ' 
        ' lbDataPasien
        ' 
        lbDataPasien.Anchor = AnchorStyles.Top
        lbDataPasien.AutoSize = True
        lbDataPasien.Font = New Font("Arial", 13.8F, FontStyle.Bold)
        lbDataPasien.ForeColor = Color.FromArgb(CByte(25), CByte(69), CByte(107))
        lbDataPasien.Location = New Point(498, 19)
        lbDataPasien.Margin = New Padding(10)
        lbDataPasien.Name = "lbDataPasien"
        lbDataPasien.Size = New Size(255, 27)
        lbDataPasien.TabIndex = 105
        lbDataPasien.Text = "DATA PENDAFTARAN"
        lbDataPasien.TextAlign = ContentAlignment.TopCenter
        ' 
        ' FormDataPendaftaran
        ' 
        AutoScaleDimensions = New SizeF(8F, 44F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(187), CByte(226), CByte(236))
        ClientSize = New Size(1200, 754)
        Controls.Add(lbDataPasien)
        Controls.Add(btnDowlondFile)
        Controls.Add(dgvDataPendaftaran)
        Font = New Font("Sans Serif Collection", 7.8F)
        Margin = New Padding(3, 7, 3, 7)
        Name = "FormDataPendaftaran"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form Data Pendaftaran"
        CType(dgvDataPendaftaran, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgvDataPendaftaran As DataGridView
    Friend WithEvents btnDowlondFile As Button
    Friend WithEvents lbDataPasien As Label
End Class
