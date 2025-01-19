<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormDataPasien
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
        dgvPasien = New DataGridView()
        lbDataPasien = New Label()
        btnDowlondFile = New Button()
        CType(dgvPasien, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvPasien
        ' 
        dgvPasien.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvPasien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvPasien.BackgroundColor = SystemColors.ControlLightLight
        dgvPasien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvPasien.GridColor = SystemColors.ControlDarkDark
        dgvPasien.Location = New Point(51, 102)
        dgvPasien.Margin = New Padding(4, 5, 4, 5)
        dgvPasien.Name = "dgvPasien"
        dgvPasien.RowHeadersWidth = 51
        dgvPasien.Size = New Size(1115, 595)
        dgvPasien.TabIndex = 0
        ' 
        ' lbDataPasien
        ' 
        lbDataPasien.Anchor = AnchorStyles.Top
        lbDataPasien.AutoSize = True
        lbDataPasien.Font = New Font("Arial", 13.8F, FontStyle.Bold)
        lbDataPasien.ForeColor = Color.FromArgb(CByte(25), CByte(69), CByte(107))
        lbDataPasien.Location = New Point(516, 19)
        lbDataPasien.Margin = New Padding(10)
        lbDataPasien.Name = "lbDataPasien"
        lbDataPasien.Size = New Size(161, 27)
        lbDataPasien.TabIndex = 104
        lbDataPasien.Text = "DATA PASIEN"
        lbDataPasien.TextAlign = ContentAlignment.TopCenter
        ' 
        ' btnDowlondFile
        ' 
        btnDowlondFile.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnDowlondFile.BackColor = Color.FromArgb(CByte(13), CByte(146), CByte(118))
        btnDowlondFile.Font = New Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDowlondFile.ForeColor = Color.FromArgb(CByte(255), CByte(246), CByte(233))
        btnDowlondFile.Location = New Point(992, 52)
        btnDowlondFile.Margin = New Padding(10)
        btnDowlondFile.Name = "btnDowlondFile"
        btnDowlondFile.Size = New Size(174, 47)
        btnDowlondFile.TabIndex = 1
        btnDowlondFile.Text = "Download File"
        btnDowlondFile.UseVisualStyleBackColor = False
        ' 
        ' FormDataPasien
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 44.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(187), CByte(226), CByte(236))
        ClientSize = New Size(1200, 754)
        Controls.Add(btnDowlondFile)
        Controls.Add(lbDataPasien)
        Controls.Add(dgvPasien)
        Font = New Font("Sans Serif Collection", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Margin = New Padding(4, 5, 4, 5)
        Name = "FormDataPasien"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Data Pasien"
        CType(dgvPasien, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgvPasien As DataGridView
    Friend WithEvents lbDataPasien As Label
    Friend WithEvents btnDowlondFile As Button
End Class
