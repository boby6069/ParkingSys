<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        DataGridView1 = New DataGridView()
        TextBox1 = New TextBox()
        Label3 = New Label()
        exitbtn = New Button()
        backbtn = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(-2, 99)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(803, 291)
        DataGridView1.TabIndex = 0
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = Color.Black
        TextBox1.Location = New Point(-2, 1)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(803, 92)
        TextBox1.TabIndex = 10
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Black
        Label3.Font = New Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.White
        Label3.Location = New Point(347, 25)
        Label3.Name = "Label3"
        Label3.Size = New Size(99, 50)
        Label3.TabIndex = 9
        Label3.Text = "Data"
        ' 
        ' exitbtn
        ' 
        exitbtn.BackColor = Color.Red
        exitbtn.ForeColor = SystemColors.ActiveCaptionText
        exitbtn.Location = New Point(613, 402)
        exitbtn.Name = "exitbtn"
        exitbtn.Size = New Size(74, 36)
        exitbtn.TabIndex = 16
        exitbtn.Text = "Exit"
        exitbtn.UseVisualStyleBackColor = False
        ' 
        ' backbtn
        ' 
        backbtn.BackColor = Color.DodgerBlue
        backbtn.ForeColor = SystemColors.ActiveCaptionText
        backbtn.Location = New Point(714, 402)
        backbtn.Name = "backbtn"
        backbtn.Size = New Size(74, 36)
        backbtn.TabIndex = 17
        backbtn.Text = "Return"
        backbtn.UseVisualStyleBackColor = False
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Gold
        ClientSize = New Size(800, 450)
        Controls.Add(backbtn)
        Controls.Add(exitbtn)
        Controls.Add(Label3)
        Controls.Add(TextBox1)
        Controls.Add(DataGridView1)
        Name = "Form4"
        Text = "Out"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents exitbtn As Button
    Friend WithEvents backbtn As Button
End Class
