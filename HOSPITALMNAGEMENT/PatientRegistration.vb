Imports System
Imports System.Data
Imports System.Configuration
Imports System.Data.SqlClient
Imports Microsoft.VisualBasic
Imports System.Data.DataTable
Imports System.Text.RegularExpressions

Public Class PatientRegistration
    Dim cmd As New SqlCommand
    Dim con As New SqlConnection
    Dim connection As String
    Dim strsqlQuery As String
    
   
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Btnadd.Click
        'If txtname.Text = "" Then
        '    MsgBox("Enter your username")
        'End Ifsw

        Dim dt1 As DateTime = Convert.ToDateTime(datpik.Text)
        Dim connectionString As String
        Dim con As SqlConnection
        connectionString = "Data Source=LAPTOP-VBNDUE2B;Database=HospitalManagementdb; User Id=sa;Password=123"
        con = New SqlConnection(connectionString)
        con.Open()
        'MsgBox("Connection Open")
        cmd = New SqlCommand("insert into patientregis(Date,Name,Gender,Age,Phone,Address,Disease,Bloodgroup,Building,Roomno,Roomtype,Price) values(@Date,@Name,@Gender,@Age,@Phone,@Address,@Disease,@Bloodgroup,@Building,@Roomno,@Roomtype,@Price)", con)
        cmd.Parameters.AddWithValue("@Date", dt1)
        cmd.Parameters.AddWithValue("@Name", txtname.Text.Trim())
        cmd.Parameters.AddWithValue("@Gender", Cmbgen.Text.Trim())
        cmd.Parameters.AddWithValue("@Age", txtage.Text.Trim())
        cmd.Parameters.AddWithValue("@Phone", txtphone.Text.Trim())
        cmd.Parameters.AddWithValue("@Address", Txtadd.Text.Trim())
        cmd.Parameters.AddWithValue("@Disease", Txtdise.Text.Trim())
        cmd.Parameters.AddWithValue("@Bloodgroup", txtblodgrp.Text.Trim())
        cmd.Parameters.AddWithValue("@Building", cmbbuild.Text.Trim())
        cmd.Parameters.AddWithValue("@Roomno", cmbroom.Text.Trim())
        cmd.Parameters.AddWithValue("@Roomtype", cmbroomt.Text.Trim())
        cmd.Parameters.AddWithValue("@Price", txtprice.Text.Trim())
        
        Dim x As Integer = cmd.ExecuteNonQuery()
        
            If (x > 0) Then
                MsgBox("Patient Added Successfully", MsgBoxStyle.DefaultButton1, "HOSPITAL MANAGEMENT SYSTEM")
                BindPatientInfo()
            Else
                MsgBox("Patient NOT Added", MsgBoxStyle.DefaultButton1, "HOSPITAL MANAGEMENT SYSTEM")
            End If
            txtname.Text = " "
            Cmbgen.Text = " "
            txtage.Text = " "
            txtphone.Text = " "
            Txtadd.Text = " "
            Txtdise.Text = " "
            txtblodgrp.Text = " "
            cmbbuild.Text = " "
            cmbroom.Text = " "
            cmbroomt.Text = " "
        txtprice.Text = " "
        txtpid.Text() = ""
            ViewAllPatientInfo.Show()

    End Sub
    Public Sub BindPatientInfo()
        Dim connectionString As String
        Dim con As SqlConnection
        connectionString = "Data Source=LAPTOP-VBNDUE2B;Database=HospitalManagementdb; User Id=sa;Password=123"
        con = New SqlConnection(connectionString)
        con.Open()
        Dim com As String = "select * from patientregis"
        Dim adapter As New SqlDataAdapter(com, con)
        Dim ds As New DataSet()
        adapter.Fill(ds, "patientregis")
        DataGridView1.DataSource = ds.Tables(0)
    End Sub


   
    Dim Table As New DataTable("Table")
    Private Sub PatientRegistration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
      
        'txtdt.Text = DateTime.Today.ToShortDateString()
        'datpik.Text = DateTime.Today.ToShortDateString()
        Dim dt1 As DateTime = Convert.ToDateTime(datpik.Text)
        BindPatientInfo()

    End Sub

 
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

   




    







    Private Sub txtdt_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtphone_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtphone.KeyPress
        If txtphone.Text.Length > 9 Then
            MsgBox("Phone numbers must be 10 digits")
            txtphone.Text = ""
            txtphone.Focus()
            txtphone.BackColor = Color.Red
            txtphone.ForeColor = Color.White
        Else
            txtphone.BackColor = Color.White
            txtphone.ForeColor = Color.Blue

        End If
        If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
            e.Handled = True
            txtphone.Text = ""
            txtphone.Focus()
            MessageBox.Show("You can only Input number!")
            txtphone.BackColor = Color.Red
            txtphone.ForeColor = Color.White
        Else
            txtphone.BackColor = Color.White
            txtphone.ForeColor = Color.Black
        End If

    End Sub

    Private Sub txtphone_TextChanged(sender As Object, e As EventArgs) Handles txtphone.TextChanged

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim Index As Integer
        Index = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = DataGridView1.Rows(Index)
        datpik.Text = selectedRow.Cells(0).Value.ToString()

        txtname.Text = selectedRow.Cells(2).Value.ToString()
        Cmbgen.Text = selectedRow.Cells(3).Value.ToString()
        txtage.Text = selectedRow.Cells(4).Value.ToString()
        txtphone.Text = selectedRow.Cells(5).Value.ToString()
        Txtadd.Text = selectedRow.Cells(6).Value.ToString()
        Txtdise.Text = selectedRow.Cells(7).Value.ToString()
        txtblodgrp.Text = selectedRow.Cells(8).Value.ToString()
        cmbbuild.Text = selectedRow.Cells(9).Value.ToString()
        cmbroom.Text = selectedRow.Cells(10).Value.ToString()
        cmbroomt.Text = selectedRow.Cells(11).Value.ToString()
        txtprice.Text = selectedRow.Cells(12).Value.ToString()

    End Sub

    

    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs) Handles GroupBox3.Enter

    End Sub

    Private Sub txtname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtname.KeyPress
        
    
        Dim allowedChars As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz,. "

        If allowedChars.IndexOf(e.KeyChar) = -1 Then
            If Not e.KeyChar = Chr(Keys.Back) Then
                e.Handled = True
                Beep()
                MsgBox("You can only Input letter!.", MsgBoxStyle.Information, "Checking")
            End If
        End If
    End Sub

   

    

    'Private Sub txtname_TextChanged(sender As Object, e As EventArgs) Handles txtname.TextChanged
    '    If txtname.Text = "" Then
    '        MsgBox("Enter your Name")
    '    End If
    'End Sub

    Private Sub txtage_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtage.KeyPress
        If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
            e.Handled = True
            txtage.Text = ""
            txtage.Focus()
            MsgBox("You can only Input number!.", MsgBoxStyle.Information, "Checking")

        End If
    End Sub


    'Private Sub txtage_Validating(sender As Object, e As ComponentModel.CancelEventArgs) Handles txtage.Validating
    '    Dim dat As Date



    '    If Date.TryParse(txtage.Text, dat) Then 'Then

    '        'Label7.Text = dat.ToShortDateString
    '        ' txtage.Text = dat.ToString



    '    Else

    '        MsgBox("Please enter date in MM/DD/Format")



    '    End If






    Private Sub txtprice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtprice.KeyPress
        If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
            e.Handled = True
            txtprice.Text = ""
            txtprice.Focus()


        End If

    End Sub

    ' Private Sub txtprice_Leave(sender As Object, e As EventArgs) Handles txtprice.Leave

    'End Sub

    Private Sub txtprice_TextChanged(sender As Object, e As EventArgs) Handles txtprice.TextChanged

    End Sub

    Private Sub Cmbgen_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Cmbgen.KeyPress
        If Cmbgen.Items.Contains(Cmbgen.Text) = False Then
            Cmbgen.Select()
            MessageBox.Show("select item from combobox")
            Cmbgen.Text = ""
            Cmbgen.Focus()

        End If

    End Sub


    Private Sub Cmbgen_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cmbgen.SelectedIndexChanged

    End Sub

    Private Sub txtname_LostFocus(sender As Object, e As EventArgs) Handles txtname.LostFocus
        If txtname.Text = "" Then
            MsgBox("First Enter your Name")
            txtname.Focus()
        End If
        'End Sub
    End Sub

    'Private Sub txtname_MouseDown(sender As Object, e As MouseEventArgs) Handles txtname.MouseDown
    '    If txtname.Text = "" Then
    '        MsgBox("Enter your Name")
    '    End If
    '    'End Sub
    'End Sub

   


    Private Sub txtname_TextChanged(sender As Object, e As EventArgs) Handles txtname.TextChanged

    End Sub

    Private Sub cmbbuild_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbbuild.KeyPress
        If cmbbuild.Items.Contains(Cmbgen.Text) = False Then
            cmbbuild.Select()
            MessageBox.Show("select item from combobox")
            cmbbuild.Text = ""
            cmbbuild.Focus()

        End If
    End Sub

    Private Sub cmbbuild_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbbuild.SelectedIndexChanged

    End Sub

    Private Sub cmbroom_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbroom.KeyPress
        If cmbroom.Items.Contains(Cmbgen.Text) = False Then
            cmbroom.Select()
            MessageBox.Show("select item from combobox")
            cmbroom.Text = ""
            cmbroom.Focus()

        End If
    End Sub

    Private Sub cmbroom_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbroom.SelectedIndexChanged

    End Sub

    Private Sub cmbroomt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbroomt.KeyPress
        If cmbroomt.Items.Contains(Cmbgen.Text) = False Then
            cmbroomt.Select()
            MessageBox.Show("select item from combobox")
            cmbroomt.Text = ""
            cmbroomt.Focus()

        End If
    End Sub

    Private Sub cmbroomt_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbroomt.SelectedIndexChanged

    End Sub
End Class