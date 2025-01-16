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
        lblPesan.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        lblPesan.Font = New Font("Arial", 10.2F)
        lblPesan.Location = New Point(65, 27)
        lblPesan.Name = "lblPesan"
        lblPesan.Size = New Size(288, 19)
        lblPesan.TabIndex = 0
        lblPesan.Text = "Apakah Anda yakin ingin menghapus?"
        lblPesan.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btnYes
        ' 
        btnYes.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        btnYes.Font = New Font("Arial", 10.2F)
        btnYes.Location = New Point(80, 77)
        btnYes.Name = "btnYes"
        btnYes.Size = New Size(94, 29)
        btnYes.TabIndex = 1
        btnYes.Text = "IYA"
        btnYes.UseVisualStyleBackColor = True
        ' 
        ' btnNo
        ' 
        btnNo.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnNo.Font = New Font("Arial", 10.2F)
        btnNo.Location = New Point(237, 77)
        btnNo.Name = "btnNo"
        btnNo.Size = New Size(94, 29)
        btnNo.TabIndex = 2
        btnNo.Text = "TIDAK"
        btnNo.UseVisualStyleBackColor = True
        ' 
        ' FormCustomDialog
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        BackColor = SystemColors.ControlLightLight
        ClientSize = New Size(402, 153)
        ControlBox = False
        Controls.Add(btnNo)
        Controls.Add(btnYes)
        Controls.Add(lblPesan)
        FormBorderStyle = FormBorderStyle.FixedDialog
        Name = "FormCustomDialog"
        StartPosition = FormStartPosition.CenterParent
        Text = "Form Custom Dialog"
        ResumeLayout(False)
    End Sub

    Friend WithEvents lblPesan As Label
    Friend WithEvents btnYes As Button
    Friend WithEvents btnNo As Button
End Class
