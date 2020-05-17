Imports System
Imports System.Data
Imports System.Configuration
Imports System.Data.SqlClient

Public Class patntinfo
    Dim cmd As New SqlCommand
    Dim con As New SqlConnection
    Dim connection As String
    Dim strsqlQuery As String
    Dim dt As DataTable
    Dim ds As New DataSet
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim connectionString As String
        Dim con As SqlConnection
        connectionString = "Data Source=LAPTOP-VBNDUE2B;Database=HospitalManagementdb; User Id=sa;Password=123"
        con = New SqlConnection(connectionString)
        con.Open()
        'MsgBox("Connection Open")
        cmd = New SqlCommand("insert into  tblPatient(Name,Gender,Age,Phone,Address,Disease,DateIn,DateOut,Roomno,Roomtype,Price,Building,Status,Medicine,Total) values(@Name,@Gender,@Age,@Phone,@Address,@Disease,@DateIn,@DateOut,@Roomno,@Roomtype,@Building,@Status,@Medicine,@Price,@Total)", con)
        cmd.Parameters.AddWithValue("@Name", txtnm.Text.Trim())
        cmd.Parameters.AddWithValue("@Gender", cmbgn.Text.Trim())
        cmd.Parameters.AddWithValue("@Age", txtage.Text.Trim())
        cmd.Parameters.AddWithValue("@Phone", txtphone.Text.Trim())
        cmd.Parameters.AddWithValue("@Address", txtadd.Text.Trim())
        cmd.Parameters.AddWithValue("@Disease", txtdise.Text.Trim())
        cmd.Parameters.AddWithValue("@DateIn", txtdatin.Text.Trim())
        cmd.Parameters.AddWithValue("@DateOut", txtdtout.Text.Trim())
        cmd.Parameters.AddWithValue("@Roomno", cmbroomno.Text.Trim())
        cmd.Parameters.AddWithValue("@Roomtype", cmbroomt.Text.Trim())
        cmd.Parameters.AddWithValue("@Price", txtunit.Text.Trim())
        cmd.Parameters.AddWithValue("@Building", cmbbuild.Text.Trim())
        cmd.Parameters.AddWithValue("@Status", cmbstatus.Text.Trim())
        cmd.Parameters.AddWithValue("@Medicine", txtmedicine.Text.Trim())
        cmd.Parameters.AddWithValue("@Total", txttotal.Text.Trim())
        Dim x As Integer = cmd.ExecuteNonQuery()
        If (x > 0) Then
            MsgBox("Patient information entered Successfully", MsgBoxStyle.DefaultButton1, "HOSPITAL MANAGEMENT SYSTEM")
        Else
            MsgBox(" not done", MsgBoxStyle.DefaultButton1, "HOSPITAL MANAGEMENT SYSTEM")
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub txttotal_TextChanged(sender As Object, e As EventArgs) Handles txttotal.TextChanged

    End Sub

    Private Sub patntinfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtdatin.Text = DateTime.Today.ToShortDateString()
    End Sub
End Class