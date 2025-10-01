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
        loginbtn = New Button()
        TextBox1 = New TextBox()
        SuspendLayout()
        ' 
        ' loginbtn
        ' 
        loginbtn.Location = New Point(161, 224)
        loginbtn.Name = "loginbtn"
        loginbtn.Size = New Size(99, 36)
        loginbtn.TabIndex = 0
        loginbtn.Text = "Login"
        loginbtn.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = SystemColors.Control
        TextBox1.BorderStyle = BorderStyle.None
        TextBox1.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox1.ForeColor = Color.Black
        TextBox1.Location = New Point(-18, 12)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(465, 43)
        TextBox1.TabIndex = 1
        TextBox1.Text = "Welcome!"
        TextBox1.TextAlign = HorizontalAlignment.Center
        ' 
        ' Form1
        ' 
        AcceptButton = loginbtn
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(423, 287)
        Controls.Add(TextBox1)
        Controls.Add(loginbtn)
        Name = "Form1"
        Text = "Login"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents loginbtn As Button
    Friend WithEvents TextBox1 As TextBox
End Class
