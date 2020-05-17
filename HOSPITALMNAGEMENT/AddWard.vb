Imports System
Imports System.Data
Imports System.Configuration
Imports System.Data.SqlClient
Public Class Form4
    Dim cmd As New SqlCommand
    Dim con As New SqlConnection
    Dim Connection As String
    Dim strsqlQuery As String

    

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        Dim connectionString As String
        Dim con As SqlConnection
        connectionString = "Data Source=LAPTOP-VBNDUE2B;Database=HospitalManagementdb; User Id=sa;Password=123"
        con = New SqlConnection(connectionString)
        con.Open()
        'MsgBox("Connection Open")
        cmd = New SqlCommand("insert into  Addward (Buildingno,Floorno,Roomno,Roomtype,Beds,Price,Status) values(@Buildingno,@Floorno,@Roomno,@Roomtype,@Beds,@Price,@Status)", con)

        cmd.Parameters.AddWithValue("@Buildingno", cmbbuild.Text.Trim())
        cmd.Parameters.AddWithValue("@Floorno", cmbfloor.Text.Trim())
        cmd.Parameters.AddWithValue("@Roomno", cmbroom.Text.Trim())
        cmd.Parameters.AddWithValue("@Roomtype", cmbroomt.Text.Trim())
        cmd.Parameters.AddWithValue("@Beds", txtbed.Text.Trim())
        cmd.Parameters.AddWithValue("@Price", txtprice.Text.Trim())
        cmd.Parameters.AddWithValue("@Status", txtstatus.Text.Trim())
        Dim x As Integer = cmd.ExecuteNonQuery()
        If (x > 0) Then
            MsgBox("Ward Added Successfully", MsgBoxStyle.DefaultButton1, "HOSPITAL MANAGEMENT SYSTEM")
        Else
            MsgBox("Ward Not Added", MsgBoxStyle.DefaultButton1, "HOSPITAL MANAGEMENT SYSTEM")
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbbuild.SelectedIndexChanged

    End Sub
End Class