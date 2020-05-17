Imports System
Imports System.Data
Imports System.Configuration
Imports System.Data.SqlClient

Public Class staff_search
    Dim cmd As New SqlCommand
    Dim con As New SqlConnection
    Dim connection As String
    Dim strsqlQuery As String
    Dim ds As New DataSet
    Dim dt As DataTable

    Private Sub btnsearch_Click(sender As Object, e As EventArgs) Handles btnsearch.Click
        Dim connectionString As String
        Dim con As SqlConnection
        connectionString = "Data Source=LAPTOP-VBNDUE2B;Database=HospitalManagementdb; User Id=sa;Password=123"
        con = New SqlConnection(connectionString)
        con.Open()
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter("Select * from staffinfo  where Name='" + txtSearcchId.Text.Trim() + "'", con)
        'cmd = New SqlCommand("Select * from staffinfo  WHERE Name =('" + txtSearcchName.Text.Trim() + "'),con")
        adapter.Fill(ds)
        If ds.Tables(0).Rows.Count > 0 Then
            txtname.Text = ds.Tables(0).Rows(0)("Name").ToString()
            txtmail.Text = ds.Tables(0).Rows(0)("Email").ToString()
            cmbgen.Text = ds.Tables(0).Rows(0)("Gender").ToString()
            txtpos.Text = ds.Tables(0).Rows(0)("Position").ToString()
            txtsal.Text = ds.Tables(0).Rows(0)("Salary").ToString()
            txtphone.Text = ds.Tables(0).Rows(0)("Phoneno").ToString()
            txtadd.Text = ds.Tables(0).Rows(0)("Address").ToString()
          
        End If


    End Sub

    Private Sub btnclo_Click(sender As Object, e As EventArgs) Handles btnclo.Click
        Me.Close()
    End Sub

    Private Sub txtphone_TextChanged(sender As Object, e As EventArgs) Handles txtphone.TextChanged

    End Sub
End Class