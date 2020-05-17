Public Class For1

  
    Private Sub btnlogin_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(1)
        If ProgressBar1.Value = 100 Then
            LoginForm1.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs)

    End Sub
End Class