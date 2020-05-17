Imports System
Imports System.Data
Imports System.Configuration
Imports System.Data.SqlClient
Public Class searchpatient
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
        cmd = New SqlCommand("Select * from patientregis  where Name='" + txtSearchName.Text.Trim() + "'", con)
        'Dim adapter As SqlDataAdapter
        ' adapter = New SqlDataAdapter("Select * from patientregis  where Name='" + txtSearchName.Text.Trim() + "'", con)

        'adapter.Fill(ds)
        Dim reader As SqlDataReader = cmd.ExecuteReader()
        If reader.HasRows Then
            Do While reader.Read()

                txtName.Text = reader("Name").ToString()
                Cmbgen.Text = reader("Gender").ToString()
                txtage.Text = reader("Age").ToString()
                txtphone.Text = reader("Phone").ToString()
                Txtadd.Text = reader("Address").ToString()
                Txtdise.Text = reader("Disease").ToString()
                txtblodgrp.Text = reader("Bloodgroup").ToString()
                cmbbuild.Text = reader("Building").ToString()
                cmbroom.Text = reader("Roomno").ToString()
                txtroomt.Text = reader("Roomtype").ToString()
                txtprice.Text = reader("Price").ToString()
                txtdate.Text = reader("Date").ToString()
            Loop
        Else
            MessageBox.Show("Record not found")

        
        End If
        reader.Close()




    End Sub

    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs) Handles GroupBox3.Enter

    End Sub

    Private Sub btndel_Click(sender As Object, e As EventArgs) Handles btndel.Click
        Dim connectionString As String
        Dim con As SqlConnection

        connectionString = "Data Source=LAPTOP-VBNDUE2B;Database=HospitalManagementdb; User Id=sa;Password=123"
        con = New SqlConnection(connectionString)
        con.Open()
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter("Select * from patientregis  where Name='" + txtSearchName.Text.Trim() + "'", con)
        strsqlQuery = "DELETE patientregis   where Name='" + txtSearchName.Text.Trim() + "'"
        cmd = New SqlCommand(strsqlQuery, con)
        Dim x As Integer = cmd.ExecuteNonQuery()
        If (x > 0) Then
            MsgBox("Patient Information Deleted Successfully", MsgBoxStyle.DefaultButton1, "HOSPITAL MANAGEMENT SYSTEM")
            txtName.Text = ""
            Cmbgen.Text = ""
            txtage.Text = ""
            txtphone.Text = ""
            Txtadd.Text = ""
            Txtdise.Text = ""
            txtblodgrp.Text = ""
            cmbbuild.Text = ""
            cmbroom.Text = ""
            txtroomt.Text = ""

            txtprice.Text = ""



        Else
            MsgBox("Patient Information Deleted Successfully", MsgBoxStyle.DefaultButton1, "HOSPITAL MANAGEMENT SYSTEM")

        End If

    End Sub

    Private Sub btnupdt_Click(sender As Object, e As EventArgs) Handles btnupdt.Click

        Dim connectionString As String
        Dim con As SqlConnection
        connectionString = "Data Source=LAPTOP-VBNDUE2B;Database=HospitalManagementdb; User Id=sa;Password=123"
        con = New SqlConnection(connectionString)
        con.Open()
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter("Select * from patientregis  where Name='" + txtSearchName.Text.Trim() + "'", con)

        strsqlQuery = "UPDATE patientregis  set Name = @Name, Gender = @Gender, Age = @Age, Phone = @Phone, Address= @Address, Disease = @Disease, Bloodgroup = @Bloodgroup where Name='" + txtSearchName.Text.Trim() + "'"
        cmd = New SqlCommand(strsqlQuery, con)

        cmd.Parameters.AddWithValue("@Name", txtName.Text)
        cmd.Parameters.AddWithValue("@Gender", Cmbgen.Text)
        cmd.Parameters.AddWithValue("@Age", txtage.Text)
        cmd.Parameters.AddWithValue("@Phone", txtphone.Text)
        cmd.Parameters.AddWithValue("@Address", Txtadd.Text)
        cmd.Parameters.AddWithValue("@Disease", Txtdise.Text)
        cmd.Parameters.AddWithValue("@Bloodgroup", txtblodgrp.Text)
        Dim x As Integer = cmd.ExecuteNonQuery()
        If (x > 0) Then
            MsgBox("Patient Information Updated Successfully", MsgBoxStyle.DefaultButton1, "HOSPITAL MANAGEMENT SYSTEM")
        Else
            MsgBox("Patient Information Updated Successfully", MsgBoxStyle.DefaultButton1, "HOSPITAL MANAGEMENT SYSTEM")

        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub btnclr_Click(sender As Object, e As EventArgs) Handles btnclr.Click
        txtName.Text = ""
        Cmbgen.Text = ""
        txtage.Text = ""
        txtphone.Text = ""
        Txtadd.Text = ""
        Txtdise.Text = ""
        txtblodgrp.Text = ""
        cmbbuild.Text = ""
        cmbroom.Text = ""
        txtroomt.Text = ""
        txtprice.Text = ""
    End Sub

    Private Sub txtphone_TextChanged(sender As Object, e As EventArgs) Handles txtphone.TextChanged

    End Sub

   
   

    Private Sub txtSearchName_TextChanged(sender As Object, e As EventArgs) Handles txtSearchName.TextChanged
        Dim connectionString As String
        Dim con As SqlConnection
        connectionString = "Data Source=LAPTOP-VBNDUE2B;Database=HospitalManagementdb; User Id=sa;Password=123"
        con = New SqlConnection(connectionString)
        con.Open()



        'Dim adapter As SqlDataAdapter
        'adapter = New SqlDataAdapter("Select Name,Gender,Age,Phone,Address,Disease,Bloodgroup,Building,Roomno,Roomtype,Price  from patientregis", con)


        ''adapter.Fill(dt)
        'adapter.Fill(ds, Name)
        'Dim col As New AutoCompleteStringCollection
        'For i = 0 To ds.Tables(0).Rows.Count - 1
        '    col.Add(ds.Tables(0).Rows(i)(0).ToString)
        'Next
        'txtSearchName.AutoCompleteSource = AutoCompleteSource.CustomSource
        'txtSearchName.AutoCompleteCustomSource = col
        'txtSearchName.AutoCompleteMode = AutoCompleteMode.SuggestAppend



        txtName.Text = ""
        Cmbgen.Text = ""
        txtage.Text = ""
        txtphone.Text = ""
        Txtadd.Text = ""
        Txtdise.Text = ""
        txtblodgrp.Text = ""
        cmbbuild.Text = ""
        cmbroom.Text = ""
        txtroomt.Text = ""
        txtprice.Text = ""

        'for search
        cmd = New SqlCommand("Select * from patientregis  where Name='" + txtSearchName.Text.Trim() + "'", con)

        Dim reader As SqlDataReader = cmd.ExecuteReader()
        If reader.HasRows Then
            Do While reader.Read()
                txtName.Text = reader("Name").ToString()
                Cmbgen.Text = reader("Gender").ToString()
                txtage.Text = reader("Age").ToString()
                txtphone.Text = reader("Phone").ToString()
                Txtadd.Text = reader("Address").ToString()
                Txtdise.Text = reader("Disease").ToString()
                txtblodgrp.Text = reader("Bloodgroup").ToString()
                cmbbuild.Text = reader("Building").ToString()
                cmbroom.Text = reader("Roomno").ToString()
                txtroomt.Text = reader("Roomtype").ToString()
                txtprice.Text = reader("Price").ToString()
                txtdate.Text = reader("Date").ToString()
            Loop
        End If
        reader.Close()

    End Sub

    Private Sub searchpatient_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        txtName.Enabled = False
        txtdate.Enabled = False
        Cmbgen.Enabled = False
        txtage.Enabled = False
        Txtdise.Enabled = False
        txtblodgrp.Enabled = False

        Dim connectionString As String
        Dim con As SqlConnection
        connectionString = "Data Source=LAPTOP-VBNDUE2B;Database=HospitalManagementdb; User Id=sa;Password=123"
        con = New SqlConnection(connectionString)
        con.Open()



        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter("Select Name,Gender,Age,Phone,Address,Disease,Bloodgroup,Building,Roomno,Roomtype,Price,Date  from patientregis", con)


        'adapter.Fill(dt)
        adapter.Fill(ds, Name)
        Dim col As New AutoCompleteStringCollection
        For i = 0 To ds.Tables(0).Rows.Count - 1
            col.Add(ds.Tables(0).Rows(i)(0).ToString)
        Next
        txtSearchName.AutoCompleteSource = AutoCompleteSource.CustomSource
        txtSearchName.AutoCompleteCustomSource = col
        txtSearchName.AutoCompleteMode = AutoCompleteMode.SuggestAppend



    End Sub
End Class