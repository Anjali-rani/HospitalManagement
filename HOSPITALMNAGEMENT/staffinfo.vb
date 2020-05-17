Imports System
Imports System.Data
Imports System.Configuration
Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
  
Public Class staffinfo
    Dim cmd As New SqlCommand
    Dim con As New SqlConnection
    Dim connection As String
    Dim strsqlQuery As String
    Dim ds As New DataSet
    Dim dt As DataTable



    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        If txtname.Text = "" Then
            MsgBox("Please Entet Usrname to Continue", MsgBoxStyle.DefaultButton1, "HOSPITAL MANAGEMENT")
            txtname.Focus()
        Else
        End If
       
            Dim connectionString As String
            Dim con As SqlConnection
            connectionString = "Data Source=LAPTOP-VBNDUE2B;Database=HospitalManagementdb; User Id=sa;Password=123"
            con = New SqlConnection(connectionString)
            con.Open()
            'MsgBox("Connection Open")
            cmd = New SqlCommand("insert into staffinfo(Name,Email,Gender,Position,Salary,Phoneno,Address) values(@Name,@Email,@Gender,@Position,@Salary,@Phoneno,@Address)", con)
            cmd.Parameters.AddWithValue("@Staffid", txtsid.Text.Trim())
            cmd.Parameters.AddWithValue("@Name", txtname.Text.Trim())
            cmd.Parameters.AddWithValue("@Email", txtmail.Text.Trim())
            cmd.Parameters.AddWithValue("@Gender", cmbgen.Text.Trim())
            cmd.Parameters.AddWithValue("@Position", txtpos.Text.Trim())
            cmd.Parameters.AddWithValue("@Salary", txtsal.Text.Trim())
            cmd.Parameters.AddWithValue("@Phoneno", txtphone.Text.Trim())
            cmd.Parameters.AddWithValue("@Address", txtadd.Text.Trim())

            Dim x As Integer = cmd.ExecuteNonQuery()
            If (x > 0) Then
                MsgBox("Staff Added Successfully", MsgBoxStyle.DefaultButton1, "HOSPITAL MANAGEMENT SYSTEM")
            Else
                MsgBox("Staff NOT Added", MsgBoxStyle.DefaultButton1, "HOSPITAL MANAGEMENT SYSTEM")
        End If
        txtsid.Text() = " "
        txtname.Text = " "
        txtmail.Text = " "
        cmbgen.Text = " "
        txtpos.Text = " "

        txtsal.Text = " "
        txtphone.Text = " "
        txtadd.Text = " "
    End Sub

    Private Sub btnup_Click(sender As Object, e As EventArgs) Handles btnup.Click
        Dim connectionString As String
        Dim con As SqlConnection
        connectionString = "Data Source=LAPTOP-VBNDUE2B;Database=HospitalManagementdb; User Id=sa;Password=123"
        con = New SqlConnection(connectionString)
        con.Open()
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter("Select * from staffinfo  where Name='" + txtsname.Text.Trim() + "'", con)
        strsqlQuery = "UPDATE staffinfo set Name = @Name,Email = @Email,Gender = @Gender,Position = @Position,Salary = @Salary,Phoneno = @Phoneno,Address = @Address where Name='" + txtsname.Text.Trim() + "'"
        cmd = New SqlCommand(strsqlQuery, con)

        cmd.Parameters.AddWithValue("@Name", txtname.Text)
        cmd.Parameters.AddWithValue("@Gender", cmbgen.Text)
        cmd.Parameters.AddWithValue("@Position", txtpos.Text)
        cmd.Parameters.AddWithValue("@Salary", txtsal.Text)
        cmd.Parameters.AddWithValue("@Phoneno", txtphone.Text)
        cmd.Parameters.AddWithValue("@Address", txtadd.Text)
        cmd.Parameters.AddWithValue("@Email", txtmail.Text)
        Dim x As Integer = cmd.ExecuteNonQuery()
        If (x > 0) Then
            MsgBox("Staff Information Updated Successfully", MsgBoxStyle.DefaultButton1, "HOSPITAL MANAGEMENT SYSTEM")
        Else
            MsgBox("Updation failed", MsgBoxStyle.DefaultButton1, "HOSPITAL MANAGEMENT SYSTEM")
        End If
    End Sub

    Private Sub btnclo_Click(sender As Object, e As EventArgs) Handles btnclo.Click
        Me.Close()
    End Sub


    Private Sub btnnew_Click(sender As Object, e As EventArgs) Handles btnnew.Click
        txtname.Text = ""
        txtmail.Text = ""
        cmbgen.Text = ""
        txtpos.Text = ""
        txtsal.Text = ""
        txtphone.Text = ""
        txtadd.Text = ""
    End Sub

    Private Sub btnsearch_Click(sender As Object, e As EventArgs) Handles btnsearch.Click
        Dim connectionString As String
        Dim con As SqlConnection
        connectionString = "Data Source=LAPTOP-VBNDUE2B;Database=HospitalManagementdb; User Id=sa;Password=123"
        con = New SqlConnection(connectionString)
        con.Open()
        cmd = New SqlCommand("Select * from staffinfo  where Name='" + txtsname.Text.Trim() + "'", con)
        'Dim adapter As SqlDataAdapter
        ' adapter = New SqlDataAdapter("Select * from patientregis  where Name='" + txtSearchName.Text.Trim() + "'", con)

        'adapter.Fill(ds)
        Dim reader As SqlDataReader = cmd.ExecuteReader()
        If reader.HasRows Then
            Do While reader.Read()
                'txtsid.Text = reader("Staffid").ToString()
                txtname.Text = reader("Name").ToString()
                txtmail.Text = reader("Email").ToString()
                cmbgen.Text = reader("Gender").ToString()
                txtpos.Text = reader("Position").ToString()
                txtsal.Text = reader("Salary").ToString()
                txtphone.Text = reader("Phoneno").ToString()
                txtadd.Text = reader("Address").ToString()
            Loop
        Else
            MessageBox.Show("Record not exist")


        End If
        reader.Close()



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

    Private Sub txtsname_TextChanged(sender As Object, e As EventArgs) Handles txtsname.TextChanged
        Dim connectionString As String
        Dim con As SqlConnection
        connectionString = "Data Source=LAPTOP-VBNDUE2B;Database=HospitalManagementdb; User Id=sa;Password=123"
        con = New SqlConnection(connectionString)
        con.Open()



        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter("Select Name,Email,Gender,Position,Salary,Phoneno,Address from staffinfo", con)


        'adapter.Fill(dt)
        adapter.Fill(ds, Name)
        Dim col As New AutoCompleteStringCollection
        For i = 0 To ds.Tables(0).Rows.Count - 1
            col.Add(ds.Tables(0).Rows(i)(0).ToString)
        Next
        txtsname.AutoCompleteSource = AutoCompleteSource.CustomSource
        txtsname.AutoCompleteCustomSource = col
        txtsname.AutoCompleteMode = AutoCompleteMode.SuggestAppend


        txtname.Text = ""
        txtmail.Text = ""
        cmbgen.Text = ""
        txtpos.Text = ""
        txtsal.Text = ""
        txtphone.Text = ""
        txtadd.Text = ""
        cmd = New SqlCommand("Select * from staffinfo  where Name='" + txtsname.Text.Trim() + "'", con)
        'Dim adapter As SqlDataAdapter
        ' adapter = New SqlDataAdapter("Select * from patientregis  where Name='" + txtSearchName.Text.Trim() + "'", con)

        'adapter.Fill(ds)
        Dim reader As SqlDataReader = cmd.ExecuteReader()
        If reader.HasRows Then
            Do While reader.Read()
                'txtsid.Text = reader("Staffid").ToString()
                txtname.Text = reader("Name").ToString()
                txtmail.Text = reader("Email").ToString()
                cmbgen.Text = reader("Gender").ToString()
                txtpos.Text = reader("Position").ToString()
                txtsal.Text = reader("Salary").ToString()
                txtphone.Text = reader("Phoneno").ToString()
                txtadd.Text = reader("Address").ToString()
            Loop
        End If
        reader.Close()
    End Sub

    Private Sub staffinfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connectionString As String
        Dim con As SqlConnection
        connectionString = "Data Source=LAPTOP-VBNDUE2B;Database=HospitalManagementdb; User Id=sa;Password=123"
        con = New SqlConnection(connectionString)
        con.Open()



        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter("Select Name,Email,Gender,Position,Salary,Phoneno,Address from staffinfo", con)


        'adapter.Fill(dt)
        adapter.Fill(ds, Name)
        Dim col As New AutoCompleteStringCollection
        For i = 0 To ds.Tables(0).Rows.Count - 1
            col.Add(ds.Tables(0).Rows(i)(0).ToString)
        Next
        txtsname.AutoCompleteSource = AutoCompleteSource.CustomSource
        txtsname.AutoCompleteCustomSource = col
        txtsname.AutoCompleteMode = AutoCompleteMode.SuggestAppend

    End Sub

    Private Sub txtmail_TextChanged(sender As Object, e As EventArgs) Handles txtmail.TextChanged

    End Sub

    Private Sub txtmail_Validating(sender As Object, e As ComponentModel.CancelEventArgs) Handles txtmail.Validating
        Dim pattern As String = "^[a-z][a-z|0-9|]*([_][a-z|0-9]+)*([.][a-z|0-9]+([_][a-z|0-9]+)*)?@[a-z][a-z|0-9|]*\.([a-z][a-z|0-9]*(\.[a-z][a-z|0-9]*)?)$"


        Dim match As System.Text.RegularExpressions.Match = Regex.Match(txtmail.Text.Trim(), pattern, RegexOptions.IgnoreCase)
        If (match.Success) Then
            txtpos.Focus()
        Else
            MessageBox.Show("Please enter a valid email id", "Checking")
            txtmail.Clear()
        End If
    End Sub

    Private Sub cmbgen_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbgen.KeyPress
        If cmbgen.Items.Contains(cmbgen.Text) = False Then
            cmbgen.Select()
            MessageBox.Show("select item from combobox")
            cmbgen.Text = ""
            cmbgen.Focus()
        End If
    End Sub

    Private Sub cmbgen_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbgen.SelectedIndexChanged

    End Sub
End Class