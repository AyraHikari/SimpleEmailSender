<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Configure
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.SMTPSSL = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Password = New System.Windows.Forms.TextBox()
        Me.Username = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SMTPTimeOut = New System.Windows.Forms.TextBox()
        Me.SMTPPort = New System.Windows.Forms.TextBox()
        Me.SMTPServer = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.SMTPSSL)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.SMTPTimeOut)
        Me.GroupBox1.Controls.Add(Me.SMTPPort)
        Me.GroupBox1.Controls.Add(Me.SMTPServer)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(259, 236)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Config"
        '
        'SMTPSSL
        '
        Me.SMTPSSL.AutoSize = True
        Me.SMTPSSL.Checked = True
        Me.SMTPSSL.CheckState = System.Windows.Forms.CheckState.Checked
        Me.SMTPSSL.Location = New System.Drawing.Point(104, 70)
        Me.SMTPSSL.Name = "SMTPSSL"
        Me.SMTPSSL.Size = New System.Drawing.Size(68, 17)
        Me.SMTPSSL.TabIndex = 10
        Me.SMTPSSL.Text = "Use SSL"
        Me.SMTPSSL.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(178, 207)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Save"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Password)
        Me.GroupBox2.Controls.Add(Me.Username)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Location = New System.Drawing.Point(9, 118)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(244, 83)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Account"
        '
        'Password
        '
        Me.Password.Location = New System.Drawing.Point(95, 49)
        Me.Password.Name = "Password"
        Me.Password.Size = New System.Drawing.Size(143, 20)
        Me.Password.TabIndex = 3
        Me.Password.Text = "example"
        Me.Password.UseSystemPasswordChar = True
        '
        'Username
        '
        Me.Username.Location = New System.Drawing.Point(95, 19)
        Me.Username.Name = "Username"
        Me.Username.Size = New System.Drawing.Size(143, 20)
        Me.Username.TabIndex = 2
        Me.Username.Text = "example@host.com"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 52)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Password:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Username:"
        '
        'SMTPTimeOut
        '
        Me.SMTPTimeOut.Location = New System.Drawing.Point(104, 92)
        Me.SMTPTimeOut.Name = "SMTPTimeOut"
        Me.SMTPTimeOut.Size = New System.Drawing.Size(149, 20)
        Me.SMTPTimeOut.TabIndex = 7
        Me.SMTPTimeOut.Text = "60"
        '
        'SMTPPort
        '
        Me.SMTPPort.Location = New System.Drawing.Point(104, 43)
        Me.SMTPPort.Name = "SMTPPort"
        Me.SMTPPort.Size = New System.Drawing.Size(149, 20)
        Me.SMTPPort.TabIndex = 5
        Me.SMTPPort.Text = "465"
        '
        'SMTPServer
        '
        Me.SMTPServer.Location = New System.Drawing.Point(104, 17)
        Me.SMTPServer.Name = "SMTPServer"
        Me.SMTPServer.Size = New System.Drawing.Size(149, 20)
        Me.SMTPServer.TabIndex = 4
        Me.SMTPServer.Text = "smtp.gmail.com"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 95)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Time Out: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Use SSL:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "SMTP Port: "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "SMTP Server:"
        '
        'Configure
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Configure"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Configure"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents SMTPSSL As CheckBox
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Password As TextBox
    Friend WithEvents Username As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents SMTPTimeOut As TextBox
    Friend WithEvents SMTPPort As TextBox
    Friend WithEvents SMTPServer As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
