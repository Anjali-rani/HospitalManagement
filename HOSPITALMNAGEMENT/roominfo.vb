Imports System
Imports System.Data
Imports System.Configuration
Imports System.Data.SqlClient
Public Class roominfo
    Dim cmd As New SqlCommand
    Dim con As New SqlConnection
    Dim connection As String
    Dim strsqlQuery As String
    Dim ds As New DataSet
    Dim dt As DataTable
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles txtsearch.Click
        Dim connectionString As String
        Dim con As SqlConnection
        connectionString = "Data Source=LAPTOP-VBNDUE2B;Database=HospitalManagementdb; User Id=sa;Password=123"
        con = New SqlConnection(connectionString)
        con.Open()
        'Dim adapter As SqlDataAdapter
        cmd = New SqlCommand("Select * from Addward  where Buildingno='" + txtsrchroom.Text.Trim() + "'", con)

        Dim reader As SqlDataReader = cmd.ExecuteReader()
        If reader.HasRows Then
            Do While reader.Read()
                cmbbuild.Text = reader("Buildingno").ToString()
                cmbfloor.Text = reader("Floorno").ToString()
                cmbroom.Text = reader("Roomno").ToString()
                cmbroomt.Text = reader("Roomtype").ToString()
                txtbed.Text = reader("Beds").ToString()
                txtprice.Text = reader("Price").ToString()
                txtstatus.Text = reader("Status").ToString()
            Loop
        Else
            MessageBox.Show("Record not found")


        End If
        reader.Close()




    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim connectionString As String
        Dim con As SqlConnection

        connectionString = "Data Source=LAPTOP-VBNDUE2B;Database=HospitalManagementdb; User Id=sa;Password=123"
        con = New SqlConnection(connectionString)
        con.Open()
        'Dim adapter As SqlDataAdapter
        'adapter = New SqlDataAdapter("Select * from patientregis  where Name='" + txtSearcchName.Text.Trim() + "'", con)
        strsqlQuery = "DELETE Addward  where Buildingno='" + txtsrchroom.Text.Trim() + "'"
        cmd = New SqlCommand(strsqlQuery, con)
        Dim x As Integer = cmd.ExecuteNonQuery()
        If (x > 0) Then
            MsgBox("Room Information Deleted Successfully", MsgBoxStyle.DefaultButton1, "HOSPITAL MANAGEMENT SYSTEM")
            cmbbuild.Text = ""
            cmbfloor.Text = ""
            cmbroom.Text = ""
            cmbroomt.Text = ""
            txtbed.Text = ""
            txtprice.Text = ""
            txtstatus.Text = ""

           


        Else
            MsgBox("Room Information not Deleted ", MsgBoxStyle.DefaultButton1, "HOSPITAL MANAGEMENT SYSTEM")
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        Dim connectionString As String
        Dim con As SqlConnection
        connectionString = "Data Source=LAPTOP-VBNDUE2B;Database=HospitalManagementdb; User Id=sa;Password=123"
        con = New SqlConnection(connectionString)
        con.Open()
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter("Select * from Addward  where Name='" + txtsrchroom.Text.Trim() + "'", con)

        strsqlQuery = "UPDATE Addward  set Buildingno = @Buildingno, Floorno = @Floorno, Roomno= @Roomno, Roomtype = @Roomtype, Beds= @Beds, Price = @Price, Status = @Status where Buildingno='" + txtsrchroom.Text.Trim() + "'"
        cmd = New SqlCommand(strsqlQuery, con)
        cmd.Parameters.AddWithValue("@Buildingno", cmbbuild.Text)
        cmd.Parameters.AddWithValue("@Floorno", cmbfloor.Text)
        cmd.Parameters.AddWithValue("@Roomno", cmbroom.Text)
        cmd.Parameters.AddWithValue("@Roomtype", cmbroomt.Text)
        cmd.Parameters.AddWithValue("@Beds", txtbed.Text)
        cmd.Parameters.AddWithValue("@Price", txtprice.Text)
        cmd.Parameters.AddWithValue("@Status", txtstatus.Text)
        Dim x As Integer = cmd.ExecuteNonQuery()
        If (x > 0) Then
            MsgBox("Room Information Updated Successfully", MsgBoxStyle.DefaultButton1, "HOSPITAL MANAGEMENT SYSTEM")
        Else
            MsgBox("Room Information not Updated ", MsgBoxStyle.DefaultButton1, "HOSPITAL MANAGEMENT SYSTEM")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub roominfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class