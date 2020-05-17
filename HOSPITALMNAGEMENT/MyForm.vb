Public Class MyForm

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub MyForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        If txtnm.Text = "" And txtpw.Text = "" Then
            MsgBox("Please Entet Usrname or Password")
        End If
    End Sub
End Class