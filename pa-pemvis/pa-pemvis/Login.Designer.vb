<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
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
        components = New ComponentModel.Container()
        Panel1 = New Panel()
        PictureBox1 = New PictureBox()
        Label3 = New Label()
        Panel2 = New Panel()
        Btnlogin = New Button()
        Label2 = New Label()
        TxtPw = New TextBox()
        Label1 = New Label()
        txtUsername = New TextBox()
        Timer1 = New Timer(components)
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ButtonHighlight
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(Label3)
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(600, 150)
        Panel1.TabIndex = 0
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.kaki_anjing_removebg_preview
        PictureBox1.Location = New Point(361, 44)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(156, 73)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 5
        PictureBox1.TabStop = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft PhagsPa", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(150, 60)
        Label3.Name = "Label3"
        Label3.Size = New Size(194, 44)
        Label3.TabIndex = 4
        Label3.Text = "PET HOTEL"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.AliceBlue
        Panel2.Controls.Add(Btnlogin)
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(TxtPw)
        Panel2.Controls.Add(Label1)
        Panel2.Controls.Add(txtUsername)
        Panel2.Location = New Point(0, 150)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(600, 350)
        Panel2.TabIndex = 1
        ' 
        ' Btnlogin
        ' 
        Btnlogin.Font = New Font("Microsoft PhagsPa", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Btnlogin.Location = New Point(150, 240)
        Btnlogin.Name = "Btnlogin"
        Btnlogin.Size = New Size(300, 40)
        Btnlogin.TabIndex = 2
        Btnlogin.Text = "Login"
        Btnlogin.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft PhagsPa", 10.2F)
        Label2.Location = New Point(150, 140)
        Label2.Name = "Label2"
        Label2.Size = New Size(81, 22)
        Label2.TabIndex = 3
        Label2.Text = "Password"
        ' 
        ' TxtPw
        ' 
        TxtPw.Location = New Point(150, 170)
        TxtPw.MaxLength = 10
        TxtPw.Name = "TxtPw"
        TxtPw.PasswordChar = "."c
        TxtPw.Size = New Size(300, 27)
        TxtPw.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft PhagsPa", 10.2F)
        Label1.Location = New Point(150, 60)
        Label1.Name = "Label1"
        Label1.Size = New Size(87, 22)
        Label1.TabIndex = 0
        Label1.Text = "Username"
        ' 
        ' txtUsername
        ' 
        txtUsername.BackColor = SystemColors.HighlightText
        txtUsername.Location = New Point(150, 90)
        txtUsername.MaxLength = 6
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(300, 27)
        txtUsername.TabIndex = 0
        ' 
        ' Timer1
        ' 
        Timer1.Enabled = True
        Timer1.Interval = 10
        ' 
        ' Login
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(600, 500)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Login"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Login"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Btnlogin As Button
    Friend WithEvents TxtPw As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class