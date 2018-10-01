Public Class Configure
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Settings.SMTPServer = SMTPServer.Text
        My.Settings.SMTPPort = SMTPPort.Text
        My.Settings.SMTPSSL = SMTPSSL.Checked
        My.Settings.SMTPTimeOut = SMTPTimeOut.Text
        My.Settings.Username = Username.Text
        My.Settings.Password = Password.Text
        My.Settings.Save()
        Me.Close()
        Home.User.Text = My.Settings.Username
        Home.Server.Text = My.Settings.SMTPServer
    End Sub

    Private Sub Configure_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SMTPServer.Text = My.Settings.SMTPServer
        SMTPPort.Text = My.Settings.SMTPPort
        SMTPSSL.Checked = My.Settings.SMTPSSL
        SMTPTimeOut.Text = My.Settings.SMTPTimeOut
        Username.Text = My.Settings.Username
        Password.Text = My.Settings.Password
    End Sub
End Class