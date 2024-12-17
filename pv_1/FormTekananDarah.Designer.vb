<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormTekananDarah
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
        MenuStrip1 = New MenuStrip()
        Label1 = New Label()
        txtSistolik = New TextBox()
        Label2 = New Label()
        txtDiastolik = New TextBox()
        btnHitung = New Button()
        lblHasil = New Label()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Padding = New Padding(7, 3, 0, 3)
        MenuStrip1.Size = New Size(914, 24)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(70, 87)
        Label1.Name = "Label1"
        Label1.Size = New Size(158, 20)
        Label1.TabIndex = 2
        Label1.Text = "Tekanan Darah Sistolik"
        ' 
        ' txtSistolik
        ' 
        txtSistolik.Location = New Point(247, 87)
        txtSistolik.Margin = New Padding(3, 4, 3, 4)
        txtSistolik.Name = "txtSistolik"
        txtSistolik.Size = New Size(205, 27)
        txtSistolik.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(70, 145)
        Label2.Name = "Label2"
        Label2.Size = New Size(169, 20)
        Label2.TabIndex = 4
        Label2.Text = "Tekanan Darah Diastolik"
        ' 
        ' txtDiastolik
        ' 
        txtDiastolik.Location = New Point(247, 145)
        txtDiastolik.Margin = New Padding(3, 4, 3, 4)
        txtDiastolik.Name = "txtDiastolik"
        txtDiastolik.Size = New Size(205, 27)
        txtDiastolik.TabIndex = 5
        ' 
        ' btnHitung
        ' 
        btnHitung.Location = New Point(70, 215)
        btnHitung.Margin = New Padding(3, 4, 3, 4)
        btnHitung.Name = "btnHitung"
        btnHitung.Size = New Size(86, 31)
        btnHitung.TabIndex = 6
        btnHitung.Text = "Hitung"
        btnHitung.UseVisualStyleBackColor = True
        ' 
        ' lblHasil
        ' 
        lblHasil.AutoSize = True
        lblHasil.Location = New Point(70, 263)
        lblHasil.Name = "lblHasil"
        lblHasil.Size = New Size(42, 20)
        lblHasil.TabIndex = 7
        lblHasil.Text = "Hasil"
        ' 
        ' FormTekananDarah
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(914, 600)
        Controls.Add(lblHasil)
        Controls.Add(btnHitung)
        Controls.Add(txtDiastolik)
        Controls.Add(Label2)
        Controls.Add(txtSistolik)
        Controls.Add(Label1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Margin = New Padding(3, 4, 3, 4)
        Name = "FormTekananDarah"
        Text = "Perhitungan Tekanan Darah"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenuStrip2 As MenuStrip
    Friend WithEvents menuExit As ToolStripMenuItem
    Friend WithEvents menuAbout As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents txtSistolik As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtDiastolik As TextBox
    Friend WithEvents btnHitung As Button
    Friend WithEvents lblHasil As Label

End Class
