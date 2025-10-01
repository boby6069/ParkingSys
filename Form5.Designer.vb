<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Label3 = New Label()
        Label2 = New Label()
        Label4 = New Label()
        TextBox3 = New TextBox()
        ComboBox1 = New ComboBox()
        savebtn = New Button()
        backbtn = New Button()
        SuspendLayout()
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = Color.Gold
        TextBox1.BorderStyle = BorderStyle.None
        TextBox1.Enabled = False
        TextBox1.Font = New Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox1.ForeColor = Color.Black
        TextBox1.Location = New Point(-162, -3)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.ReadOnly = True
        TextBox1.Size = New Size(803, 96)
        TextBox1.TabIndex = 2
        TextBox1.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Gold
        Label3.Font = New Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(103, 21)
        Label3.Name = "Label3"
        Label3.Size = New Size(154, 50)
        Label3.TabIndex = 7
        Label3.Text = "Register"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(12, 137)
        Label2.Name = "Label2"
        Label2.Size = New Size(109, 21)
        Label2.TabIndex = 8
        Label2.Text = "Plate Number:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(19, 186)
        Label4.Name = "Label4"
        Label4.Size = New Size(102, 21)
        Label4.TabIndex = 9
        Label4.Text = "Vechicle Type"
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(145, 139)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(173, 23)
        TextBox3.TabIndex = 10
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"4 wheels ", "2 wheels"})
        ComboBox1.Location = New Point(145, 188)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(121, 23)
        ComboBox1.TabIndex = 11
        ' 
        ' savebtn
        ' 
        savebtn.BackColor = Color.Gold
        savebtn.Location = New Point(273, 245)
        savebtn.Name = "savebtn"
        savebtn.Size = New Size(74, 36)
        savebtn.TabIndex = 12
        savebtn.Text = "Input"
        savebtn.UseVisualStyleBackColor = False
        ' 
        ' backbtn
        ' 
        backbtn.BackColor = Color.DodgerBlue
        backbtn.ForeColor = SystemColors.ActiveCaptionText
        backbtn.Location = New Point(19, 245)
        backbtn.Name = "backbtn"
        backbtn.Size = New Size(74, 36)
        backbtn.TabIndex = 18
        backbtn.Text = "Return"
        backbtn.UseVisualStyleBackColor = False
        ' 
        ' Form5
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        ClientSize = New Size(359, 293)
        Controls.Add(backbtn)
        Controls.Add(savebtn)
        Controls.Add(ComboBox1)
        Controls.Add(TextBox3)
        Controls.Add(Label4)
        Controls.Add(Label2)
        Controls.Add(Label3)
        Controls.Add(TextBox1)
        Name = "Form5"
        Text = "Register"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents savebtn As Button
    Friend WithEvents backbtn As Button
End Class
