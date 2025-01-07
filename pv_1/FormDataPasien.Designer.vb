<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDataPasien
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
        dgvPasien = New DataGridView()
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
        dgvPasien.Location = New Point(74, 30)
        dgvPasien.Margin = New Padding(4, 5, 4, 5)
        dgvPasien.Name = "dgvPasien"
        dgvPasien.RowHeadersWidth = 51
        dgvPasien.Size = New Size(1064, 654)
        dgvPasien.TabIndex = 0
        ' 
        ' FormDataPasien
        ' 
        AutoScaleDimensions = New SizeF(9F, 24F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1200, 720)
        Controls.Add(dgvPasien)
        Font = New Font("Sans Serif Collection", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Margin = New Padding(4, 5, 4, 5)
        Name = "FormDataPasien"
        Text = "Data Pasien"
        CType(dgvPasien, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents dgvPasien As DataGridView
End Class
