Public Class Home
    Private Sub ButtonConfig_Click(sender As Object, e As EventArgs) Handles ButtonConfig.Click
        Configure.Show()
    End Sub

    Private Sub ButtonSend_Click(sender As Object, e As EventArgs) Handles ButtonSend.Click
        Try
            Dim emailObj, emailConfig
            emailObj = CreateObject("CDO.Message")

            emailObj.From = Me.EmailBox.Text
            emailObj.To = Me.ToBox.Text

            emailObj.Subject = Me.SubBox.Text
            emailObj.TextBody = Me.TextBox.Text

            emailConfig = emailObj.Configuration

            emailConfig.Fields("http://schemas.microsoft.com/cdo/configuration/smtpserver") = My.Settings.SMTPServer
            emailConfig.Fields("http://schemas.microsoft.com/cdo/configuration/smtpserverport") = My.Settings.SMTPPort
            emailConfig.Fields("http://schemas.microsoft.com/cdo/configuration/sendusing") = 2
            emailConfig.Fields("http://schemas.microsoft.com/cdo/configuration/smtpauthenticate") = 1
            emailConfig.Fields("http://schemas.microsoft.com/cdo/configuration/smtpconnectiontimeout") = My.Settings.SMTPTimeOut
            emailConfig.Fields("http://schemas.microsoft.com/cdo/configuration/smtpusessl") = My.Settings.SMTPSSL

            emailConfig.Fields("http://schemas.microsoft.com/cdo/configuration/sendusername") = My.Settings.Username
            emailConfig.Fields("http://schemas.microsoft.com/cdo/configuration/sendpassword") = My.Settings.Password

            emailConfig.Fields.Update
            emailObj.Send

            MsgBox("Sent!")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        User.Text = My.Settings.Username
        Server.Text = My.Settings.SMTPServer
    End Sub
End Class
