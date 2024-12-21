<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormCustomDialog
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
        lblPesan = New Label()
        btnYes = New Button()
        btnNo = New Button()
        SuspendLayout()
        ' 
        ' lblPesan
        ' 
        lblPesan.AutoSize = True
        lblPesan.Location = New Point(12, 21)
        lblPesan.Name = "lblPesan"
        lblPesan.Size = New Size(261, 20)
        lblPesan.TabIndex = 0
        lblPesan.Text = "Apakah Anda yakin ingin menghapus?"
        lblPesan.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btnYes
        ' 
        btnYes.Location = New Point(37, 65)
        btnYes.Name = "btnYes"
        btnYes.Size = New Size(94, 29)
        btnYes.TabIndex = 1
        btnYes.Text = "IYA"
        btnYes.UseVisualStyleBackColor = True
        ' 
        ' btnNo
        ' 
        btnNo.Location = New Point(156, 65)
        btnNo.Name = "btnNo"
        btnNo.Size = New Size(94, 29)
        btnNo.TabIndex = 2
        btnNo.Text = "TIDAK"
        btnNo.UseVisualStyleBackColor = True
        ' 
        ' FormCustomDialog
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(299, 110)
        ControlBox = False
        Controls.Add(btnNo)
        Controls.Add(btnYes)
        Controls.Add(lblPesan)
        FormBorderStyle = FormBorderStyle.FixedDialog
        Name = "FormCustomDialog"
        StartPosition = FormStartPosition.CenterScreen
        Text = "FormCustomDialog"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblPesan As Label
    Friend WithEvents btnYes As Button
    Friend WithEvents btnNo As Button
End Class
