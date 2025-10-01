<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        TextBox1 = New TextBox()
        btnin = New Button()
        btnout = New Button()
        Label3 = New Label()
        exitbtn = New Button()
        SuspendLayout()
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = Color.Black
        TextBox1.BorderStyle = BorderStyle.None
        TextBox1.Enabled = False
        TextBox1.Font = New Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox1.ForeColor = Color.White
        TextBox1.Location = New Point(0, -1)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.ReadOnly = True
        TextBox1.Size = New Size(654, 96)
        TextBox1.TabIndex = 0
        TextBox1.TextAlign = HorizontalAlignment.Center
        ' 
        ' btnin
        ' 
        btnin.Location = New Point(110, 206)
        btnin.Name = "btnin"
        btnin.Size = New Size(213, 51)
        btnin.TabIndex = 1
        btnin.Text = "In"
        btnin.UseVisualStyleBackColor = True
        ' 
        ' btnout
        ' 
        btnout.Location = New Point(110, 291)
        btnout.Name = "btnout"
        btnout.Size = New Size(213, 51)
        btnout.TabIndex = 2
        btnout.Text = "Out"
        btnout.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Black
        Label3.Font = New Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.White
        Label3.Location = New Point(147, 21)
        Label3.Name = "Label3"
        Label3.Size = New Size(154, 50)
        Label3.TabIndex = 8
        Label3.Text = "Register"
        ' 
        ' exitbtn
        ' 
        exitbtn.BackColor = Color.Red
        exitbtn.ForeColor = SystemColors.ActiveCaptionText
        exitbtn.Location = New Point(12, 392)
        exitbtn.Name = "exitbtn"
        exitbtn.Size = New Size(74, 36)
        exitbtn.TabIndex = 15
        exitbtn.Text = "Exit"
        exitbtn.UseVisualStyleBackColor = False
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Gold
        ClientSize = New Size(450, 430)
        Controls.Add(exitbtn)
        Controls.Add(Label3)
        Controls.Add(btnout)
        Controls.Add(btnin)
        Controls.Add(TextBox1)
        Name = "Form2"
        Text = "Welcome"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btnin As Button
    Friend WithEvents btnout As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents exitbtn As Button
End Class
