Imports System
Imports System.Data
Imports System.Configuration
Imports System.Data.SqlClient
Imports Microsoft.VisualBasic
Public Class NewUser
    Dim cmd As New SqlCommand
    Dim con As New SqlConnection
    Dim connection As String
    Dim strsqlQuery As String

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        Dim connectionString As String
        Dim con As SqlConnection
        connectionString = "Data Source=LAPTOP-VBNDUE2B;Database=HospitalManagementdb; User Id=sa;Password=123"
        con = New SqlConnection(connectionString)
        con.Open()
        'MsgBox("Connection Open")
        cmd = New SqlCommand("insert into NewUser(UserName,Password,ConfirmPassword,Position) values(@UserName,@Password,@ConfirmPassword,@Position)", con)

        cmd.Parameters.AddWithValue("@UserName", txtuser.Text.Trim())
        cmd.Parameters.AddWithValue("@Password", txtpw.Text.Trim())
        cmd.Parameters.AddWithValue("@ConfirmPassword", txtcpw.Text.Trim())
        cmd.Parameters.AddWithValue("@Position", txtpos.Text.Trim())
        
        Dim x As Integer = cmd.ExecuteNonQuery()
        If (x > 0) Then
            MsgBox("User Added Successfully", MsgBoxStyle.DefaultButton1, "HOSPITAL MANAGEMENT SYSTEM")

        Else
            MsgBox("User NOT Added", MsgBoxStyle.DefaultButton1, "HOSPITAL MANAGEMENT SYSTEM")
        End If




    End Sub
End Class