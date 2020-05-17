Imports System.Net.Mail
Public Class Mail

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    'Private Sub btnsend_Click(sender As Object, e As EventArgs)
    '    Dim Mail As New MailMessage
    '    Mail.Subject = "From AArpit HOSPITAL"
    '    Mail.To.Add(txtto.Text)
    '    Mail.From = New MailAddress("Anokhiraaz@gmail.com")
    '    Mail.Body = txtbody.Text
    '    Dim SMTP As New SmtpClient("smtp.gmail.com")
    '    SMTP.EnableSsl = True
    '    SMTP.Credentials = New System.Net.NetworkCredential("Anokhiraaz@gmail.com", "9470838298")
    '    SMTP.Port = "587"
    '    SMTP.Send(Mail)
    '    MsgBox("Mail sent successfully")


    'End Sub

    Private Sub Mail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtfrom.Text = New MailAddress("AArpit@gmail.com").ToString
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Mail As New MailMessage
        Mail.Subject = "From AArpit HOSPITAL"
        Mail.To.Add(txtto.Text)
        Mail.From = New MailAddress("Anokhiraaz@gmail.com")
        Mail.Body = txtbody.Text
        Dim SMTP As New SmtpClient("smtp.gmail.com")
        SMTP.EnableSsl = True
        SMTP.Credentials = New System.Net.NetworkCredential("Anokhiraaz@gmail.com", "9470838298")
        SMTP.Port = "587"
        SMTP.Send(Mail)
        MsgBox("Mail sent successfully")
    End Sub
End Class