<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormBmi
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
        Label1 = New Label()
        TxtWeight = New TextBox()
        Label2 = New Label()
        TxtHeight = New TextBox()
        Label3 = New Label()
        txtName = New TextBox()
        btnCalculate = New Button()
        lblResult = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(69, 115)
        Label1.Name = "Label1"
        Label1.Size = New Size(90, 20)
        Label1.TabIndex = 0
        Label1.Text = "Berat Badan"
        ' 
        ' TxtWeight
        ' 
        TxtWeight.Location = New Point(197, 111)
        TxtWeight.Margin = New Padding(3, 4, 3, 4)
        TxtWeight.Name = "TxtWeight"
        TxtWeight.Size = New Size(165, 27)
        TxtWeight.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(69, 168)
        Label2.Name = "Label2"
        Label2.Size = New Size(97, 20)
        Label2.TabIndex = 2
        Label2.Text = "Tinggi Badan"
        ' 
        ' TxtHeight
        ' 
        TxtHeight.Location = New Point(197, 157)
        TxtHeight.Margin = New Padding(3, 4, 3, 4)
        TxtHeight.Name = "TxtHeight"
        TxtHeight.Size = New Size(165, 27)
        TxtHeight.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(69, 69)
        Label3.Name = "Label3"
        Label3.Size = New Size(49, 20)
        Label3.TabIndex = 4
        Label3.Text = "Nama"
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(197, 59)
        txtName.Margin = New Padding(3, 4, 3, 4)
        txtName.Name = "txtName"
        txtName.Size = New Size(165, 27)
        txtName.TabIndex = 5
        ' 
        ' btnCalculate
        ' 
        btnCalculate.Location = New Point(73, 239)
        btnCalculate.Margin = New Padding(3, 4, 3, 4)
        btnCalculate.Name = "btnCalculate"
        btnCalculate.Size = New Size(86, 31)
        btnCalculate.TabIndex = 6
        btnCalculate.Text = "Hitung"
        btnCalculate.UseVisualStyleBackColor = True
        ' 
        ' lblResult
        ' 
        lblResult.AutoSize = True
        lblResult.Location = New Point(76, 299)
        lblResult.Name = "lblResult"
        lblResult.Size = New Size(42, 20)
        lblResult.TabIndex = 7
        lblResult.Text = "Hasil"
        ' 
        ' FormBmi
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(914, 600)
        Controls.Add(lblResult)
        Controls.Add(btnCalculate)
        Controls.Add(txtName)
        Controls.Add(Label3)
        Controls.Add(TxtHeight)
        Controls.Add(Label2)
        Controls.Add(TxtWeight)
        Controls.Add(Label1)
        Margin = New Padding(3, 4, 3, 4)
        name = "FormBmi"
        Text = "Perhitungan BMI"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TxtWeight As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtHeight As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents lblResult As Label
    Friend WithEvents btnReturn As Button
End Class
