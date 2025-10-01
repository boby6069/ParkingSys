<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form3
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
        usernamebtn = New TextBox()
        passwordbtn = New TextBox()
        loginbtn = New Button()
        TextBox1 = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        SuspendLayout()
        ' 
        ' usernamebtn
        ' 
        usernamebtn.Location = New Point(48, 91)
        usernamebtn.Name = "usernamebtn"
        usernamebtn.Size = New Size(207, 23)
        usernamebtn.TabIndex = 0
        ' 
        ' passwordbtn
        ' 
        passwordbtn.CharacterCasing = CharacterCasing.Lower
        passwordbtn.Location = New Point(48, 147)
        passwordbtn.Name = "passwordbtn"
        passwordbtn.Size = New Size(207, 23)
        passwordbtn.TabIndex = 1
        ' 
        ' loginbtn
        ' 
        loginbtn.Location = New Point(97, 214)
        loginbtn.Name = "loginbtn"
        loginbtn.Size = New Size(99, 36)
        loginbtn.TabIndex = 2
        loginbtn.Text = "Login"
        loginbtn.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = SystemColors.Control
        TextBox1.BorderStyle = BorderStyle.None
        TextBox1.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox1.ForeColor = Color.Black
        TextBox1.Location = New Point(-30, -1)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(382, 43)
        TextBox1.TabIndex = 3
        TextBox1.Text = "Welcome!"
        TextBox1.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(118, 117)
        Label1.Name = "Label1"
        Label1.Size = New Size(78, 20)
        Label1.TabIndex = 4
        Label1.Text = "Username:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(118, 173)
        Label2.Name = "Label2"
        Label2.Size = New Size(73, 20)
        Label2.TabIndex = 5
        Label2.Text = "Password:"
        ' 
        ' form3
        ' 
        AcceptButton = loginbtn
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(309, 262)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(TextBox1)
        Controls.Add(loginbtn)
        Controls.Add(passwordbtn)
        Controls.Add(usernamebtn)
        Name = "form3"
        Text = "Login"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents usernamebtn As TextBox
    Friend WithEvents passwordbtn As TextBox
    Friend WithEvents loginbtn As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
