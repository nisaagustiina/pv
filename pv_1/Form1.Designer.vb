<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        btnBMI = New Button()
        btnTekananDarah = New Button()
        MenuStrip1 = New MenuStrip()
        menuExit = New ToolStripMenuItem()
        menuAbout = New ToolStripMenuItem()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnBMI
        ' 
        btnBMI.Location = New Point(149, 152)
        btnBMI.Margin = New Padding(3, 4, 3, 4)
        btnBMI.Name = "btnBMI"
        btnBMI.RightToLeft = RightToLeft.Yes
        btnBMI.Size = New Size(86, 31)
        btnBMI.TabIndex = 0
        btnBMI.Text = "BMI"
        btnBMI.UseVisualStyleBackColor = True
        ' 
        ' btnTekananDarah
        ' 
        btnTekananDarah.Location = New Point(267, 152)
        btnTekananDarah.Margin = New Padding(3, 4, 3, 4)
        btnTekananDarah.Name = "btnTekananDarah"
        btnTekananDarah.RightToLeft = RightToLeft.Yes
        btnTekananDarah.Size = New Size(86, 31)
        btnTekananDarah.TabIndex = 1
        btnTekananDarah.Text = "Tekanan Darah"
        btnTekananDarah.UseVisualStyleBackColor = True
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {menuExit, menuAbout})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Padding = New Padding(7, 3, 0, 3)
        MenuStrip1.Size = New Size(914, 30)
        MenuStrip1.TabIndex = 2
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' menuExit
        ' 
        menuExit.Name = "menuExit"
        menuExit.Size = New Size(47, 24)
        menuExit.Text = "Exit"
        ' 
        ' menuAbout
        ' 
        menuAbout.Name = "menuAbout"
        menuAbout.Size = New Size(64, 24)
        menuAbout.Text = "About"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(914, 600)
        Controls.Add(btnTekananDarah)
        Controls.Add(btnBMI)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Margin = New Padding(3, 4, 3, 4)
        Name = "Form1"
        Text = "Form1"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnBMI As Button
    Friend WithEvents btnTekananDarah As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents menuExit As ToolStripMenuItem
    Friend WithEvents menuAbout As ToolStripMenuItem
End Class
