Imports System
Imports System.Data
Imports System.Configuration
Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class Registration
    Dim cmd As New SqlCommand
    Dim con As New SqlConnection
    Dim connection As String
    Dim strsqlQuery As String

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
       

        Dim connectionString As String
        Dim con As SqlConnection
        connectionString = "Data Source=LAPTOP-VBNDUE2B;Database=HospitalManagementdb; User Id=sa;Password=123"
        con = New SqlConnection(connectionString)
        con.Open()
        Dim strSqlQuery As String
        strSqlQuery = "insert into tblregister (Username,Password,Email,Position) values(@Username,@Password,@Email,@Position)"
        cmd = New SqlCommand(strSqlQuery, con)
        cmd.Parameters.AddWithValue("@Username", txtUsername.Text.Trim())
        cmd.Parameters.AddWithValue("@Password", txtPassword.Text.Trim())
        cmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim())
        cmd.Parameters.AddWithValue("@Position", txtpos.Text.Trim())
        Dim x As Integer = cmd.ExecuteNonQuery()
        If txtPassword.Text.Length < 8 Then
            MsgBox("Password must be Strong")
        ElseIf (x > 0) Then
            MsgBox("User Registerd Successfully", MsgBoxStyle.DefaultButton1, "HOSPITAL MANAGEMENT SYSTEM")
        Else
            MsgBox("NOT Registered Successfully", "HOSPITAL MANAGEMENT SYSTEM")
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Function txtpid() As Object
        Throw New NotImplementedException
    End Function

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    'Private Sub txtEmail_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtEmail.KeyPress
    '    Dim ac As String = "@"
    '    If e.KeyChar <> ChrW(Keys.Back) Then
    '        If Asc(e.KeyChar) < 97 Or Asc(e.KeyChar) > 122 Then
    '            If Asc(e.KeyChar) <> 46 And Asc(e.KeyChar) <> 95 Then
    '                If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
    '                    If ac.IndexOf(e.KeyChar) = -1 Then
    '                        e.Handled = True

    '                    Else

    '                        If txtEmail.Text.Contains("@") And e.KeyChar = "@" Then
    '                            e.Handled = True
    '                        End If

    '                        End
    '                    End If

    '                End If


    '            End If
    '        End If
    '    End If



    'End Sub

    Private Sub txtEmail_TextChanged(sender As Object, e As EventArgs) Handles txtEmail.TextChanged

    End Sub

    Private Sub txtEmail_Validating(sender As Object, e As ComponentModel.CancelEventArgs) Handles txtEmail.Validating
        Dim pattern As String = "^[a-z][a-z|0-9|]*([_][a-z|0-9]+)*([.][a-z|0-9]+([_][a-z|0-9]+)*)?@[a-z][a-z|0-9|]*\.([a-z][a-z|0-9]*(\.[a-z][a-z|0-9]*)?)$"


        Dim match As System.Text.RegularExpressions.Match = Regex.Match(txtEmail.Text.Trim(), pattern, RegexOptions.IgnoreCase)
        If (match.Success) Then
            txtpos.Focus()
        Else
            MessageBox.Show("Please enter a valid email id", "Checking")
            txtEmail.Clear()
            txtEmail.Focus()
        End If

    End Sub

    'Private Sub txtcpw_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcpw.KeyPress
    '    If txtcpw.Text <> txtPassword.Text Then
    '        MsgBox("Password not Match!,Please Re-type.", MsgBoxStyle.Critical)
    '        txtcpw.Text = ""
    '        txtcpw.Focus()
    '    End If
    '    Dim pattern As String = txtPassword.Text

    '    Dim match As System.Text.RegularExpressions.Match = Regex.Match(txtcpw.Text.Trim(), pattern, RegexOptions.IgnoreCase)
    '    If (match.Success) Then
    '        txtEmail.Focus()
    '    Else
    '        MessageBox.Show("Password not matched", "Checking")


    '    End If
    'End Sub

    'Private Sub txtPassword_SystemColorsChanged(sender As Object, e As EventArgs) Handles txtPassword.SystemColorsChanged

    'End Sub

    ' Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged


    ' End Sub

    'Private Sub txtcpw_TextChanged(sender As Object, e As EventArgs) Handles txtcpw.TextChanged
    '    Dim pattern As String = txtPassword.Text

    '    Dim match As System.Text.RegularExpressions.Match = Regex.Match(txtcpw.Text.Trim(), pattern, RegexOptions.IgnoreCase)
    '    If (match.Success) Then
    '        txtEmail.Focus()
    '    Else
    '        MessageBox.Show("Password not matched", "Checking")


    '    End If
    'End Sub

    Private Sub Registration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
       
    End Sub

    Private Sub txtcpw_Validating(sender As Object, e As ComponentModel.CancelEventArgs) Handles txtcpw.Validating
        Dim pattern As String = txtPassword.Text

        Dim match As System.Text.RegularExpressions.Match = Regex.Match(txtcpw.Text.Trim(), pattern, RegexOptions.IgnoreCase)
        If (match.Success) Then
            txtEmail.Focus()
        Else
            MessageBox.Show("Password not matched", "Checking")
            txtcpw.Focus()

        End If
    End Sub

    Private Sub txtcpw_TextChanged(sender As Object, e As EventArgs) Handles txtcpw.TextChanged

    End Sub
End Class