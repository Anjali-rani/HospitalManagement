Imports System
Imports System.Data
Imports System.Configuration
Imports System.Data.SqlClient
Imports System.Web
Imports System.Linq
Imports System.Collections.Generic
Imports System.Text.RegularExpressions
Public Class Doctorinfo
    Dim cmd As New SqlCommand
    Dim con As New SqlConnection
    Dim connection As String
    Dim strsqlQuery As String
    Dim dt As DataTable
    Dim ds As New DataSet
    ' Dim dr As New SqlDataReader



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        Dim connectionString As String
        Dim con As SqlConnection
        connectionString = "Data Source=LAPTOP-VBNDUE2B;Database=HospitalManagementdb; User Id=sa;Password=123"
        con = New SqlConnection(connectionString)
        con.Open()
        'MsgBox("Connection Open")
        cmd = New SqlCommand("insert into dbo.docinfor(Name,Gender,DOB,Email,Specialist,Country,State,City,Address,Pincode) values(@Name,@Gender,@DOB,@Email,@Specialist,@Country,@State,@City,@Address,@Pincode)", con)

        cmd.Parameters.AddWithValue("@Name", txtname.Text.Trim())
        cmd.Parameters.AddWithValue("@Gender", cmbgen.Text.Trim())
        cmd.Parameters.AddWithValue("@DOB", txtdob.Text.Trim())
        cmd.Parameters.AddWithValue("@Email", txtmail.Text.Trim())
        cmd.Parameters.AddWithValue("@Specialist", txtspcl.Text.Trim())
        cmd.Parameters.AddWithValue("@Country", cmbCountry.Text.Trim())
        cmd.Parameters.AddWithValue("@State", cmbstate.Text.Trim())
        cmd.Parameters.AddWithValue("@City", cmbcity.Text.Trim())
        cmd.Parameters.AddWithValue("@Address", txtadd.Text.Trim())
        cmd.Parameters.AddWithValue("@Pincode", txtpin.Text.Trim())
        Dim x As Integer = cmd.ExecuteNonQuery()
        If (x > 0) Then
            MsgBox("Doctor Added Successfully", MsgBoxStyle.DefaultButton1, "HOSPITAL MANAGEMENT SYSTEM")
        Else
            MsgBox("Doctor NOT Added", MsgBoxStyle.DefaultButton1, "HOSPITAL MANAGEMENT SYSTEM")
        End If

    End Sub
    Public Sub Binddocinfor()
        Dim connectionString As String
        Dim con As SqlConnection
        connectionString = "Data Source=LAPTOP-VBNDUE2B;Database=HospitalManagementdb; User Id=sa;Password=123"
        con = New SqlConnection(connectionString)
        con.Open()
        Dim com As String = "select * from docinfor"
        Dim adapter As New SqlDataAdapter(com, con)
        Dim ds As New DataSet()
        adapter.Fill(ds, "docinfor")
        DataGridView1.DataSource = ds.Tables(0)
    End Sub
    Private Sub cmbmon_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Doctorinfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BindCountry()
        BindState()
        BindCity()
        Dim connectionString As String
        Dim con As SqlConnection
        connectionString = "Data Source=LAPTOP-VBNDUE2B;Database=HospitalManagementdb; User Id=sa;Password=123"
        con = New SqlConnection(connectionString)
        con.Open()



        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter("Select Name,Gender,Email,Address,DOB,City,State,Country,Specialist,Pincode from docinfor", con)


        'adapter.Fill(dt)
        adapter.Fill(ds, Name)
        Dim col As New AutoCompleteStringCollection
        For i = 0 To ds.Tables(0).Rows.Count - 1
            col.Add(ds.Tables(0).Rows(i)(0).ToString)
        Next
        txtDoctorName.AutoCompleteSource = AutoCompleteSource.CustomSource
        txtDoctorName.AutoCompleteCustomSource = col
        txtDoctorName.AutoCompleteMode = AutoCompleteMode.SuggestAppend


        Binddocinfor()
    End Sub

   

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btndel.Click
        Dim connectionString As String
        Dim con As SqlConnection

        connectionString = "Data Source=LAPTOP-VBNDUE2B;Database=HospitalManagementdb; User Id=sa;Password=123"
        con = New SqlConnection(connectionString)
        con.Open()
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter("Select * from docinfor  where Name='" + txtDoctorName.Text.Trim() + "'", con)
        strsqlQuery = "DELETE docinfor  where Name='" + txtDoctorName.Text.Trim() + "'"
        cmd = New SqlCommand(strsqlQuery, con)
        Dim x As Integer = cmd.ExecuteNonQuery()
        If (x > 0) Then
            MsgBox("Doctor Information Deleted Successfully", MsgBoxStyle.DefaultButton1, "HOSPITAL MANAGEMENT SYSTEM")
            txtname.Text = ""
            cmbgen.Text = ""



            txtdob.Text = ""
            txtmail.Text = ""
            txtspcl.Text = ""
            cmbCountry.Text = ""
            cmbstate.Text = ""
            cmbcity.Text = ""
            txtadd.Text = ""
            txtpin.Text = ""





        Else
            MsgBox("Doctor Information Deleted Successfully", MsgBoxStyle.DefaultButton1, "HOSPITAL MANAGEMENT SYSTEM")
        End If

    End Sub

    

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub txtsearchDoctorId_Click(sender As Object, e As EventArgs) Handles txtsearchDoctorId.Click
        Dim connectionString As String
        Dim con As SqlConnection
        connectionString = "Data Source=LAPTOP-VBNDUE2B;Database=HospitalManagementdb; User Id=sa;Password=123"
        con = New SqlConnection(connectionString)
        con.Open()
        cmd = New SqlCommand("Select * from docinfor  where Name='" + txtDoctorName.Text.Trim() + "'", con)
        'Dim adapter As SqlDataAdapter
        ' adapter = New SqlDataAdapter("Select * from patientregis  where Name='" + txtSearchName.Text.Trim() + "'", con)

        'adapter.Fill(ds)
        Dim reader As SqlDataReader = cmd.ExecuteReader()
        If reader.HasRows Then
            Do While reader.Read()
                txtname.Text = reader("Name").ToString()
                cmbgen.Text = reader("Gender").ToString()
                txtdob.Text = reader("DOB").ToString()
                txtmail.Text = reader("Email").ToString()
                txtadd.Text = reader("Address").ToString()
                txtspcl.Text = reader("Specialist").ToString()
                cmbCountry.Text = reader("Country").ToString()
                cmbstate.Text = reader("State").ToString()
                cmbcity.Text = reader("City").ToString()
                txtadd.Text = reader("Address").ToString()
                txtpin.Text = reader("Pincode").ToString()
            Loop
        Else
            MessageBox.Show("Record not found")



        End If
        reader.Close()
    End Sub

    Private Sub btnclr_Click(sender As Object, e As EventArgs) Handles btnclr.Click
        txtname.Text = ""
        cmbgen.Text = ""

        txtname.Text = ""
        cmbgen.Text = ""
        txtdob.Text = ""
        txtmail.Text = ""
        txtspcl.Text = ""
        cmbCountry.Text = ""
        cmbstate.Text = ""
        cmbcity.Text = ""
        txtadd.Text = ""
        txtpin.Text = ""
    End Sub

    Private Sub txtpin_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtpin.KeyPress
        If txtpin.Text.Length > 5 Then
            MsgBox("Pincode is not valid")
            txtpin.Text = ""
            txtpin.Focus()

        Else
        End If

        If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
            e.Handled = True
            MessageBox.Show("You can only Input number!")

            txtpin.Text = ""
            txtpin.Focus()
        End If
    End Sub

    Private Sub txtpin_TextChanged(sender As Object, e As EventArgs) Handles txtpin.TextChanged
       
    End Sub

    Private Sub DataGridView1_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridView1.SelectionChanged

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick

        Dim Index As Integer
        Index = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = DataGridView1.Rows(Index)

        txtname.Text = selectedRow.Cells(1).Value.ToString()
        cmbgen.Text = selectedRow.Cells(2).Value.ToString()
        txtdob.Text = selectedRow.Cells(3).Value.ToString()
        txtmail.Text = selectedRow.Cells(4).Value.ToString()
        txtadd.Text = selectedRow.Cells(9).Value.ToString()
        txtspcl.Text = selectedRow.Cells(5).Value.ToString()
        cmbCountry.Text = selectedRow.Cells(6).Value.ToString()
        cmbstate.Text = selectedRow.Cells(7).Value.ToString()
        cmbcity.Text = selectedRow.Cells(8).Value.ToString()

        txtpin.Text = selectedRow.Cells(10).Value.ToString()



    End Sub

    Private Sub Update_Click(sender As Object, e As EventArgs) Handles Update.Click
        Dim connectionString As String
        Dim con As SqlConnection
        connectionString = "Data Source=LAPTOP-VBNDUE2B;Database=HospitalManagementdb; User Id=sa;Password=123"
        con = New SqlConnection(connectionString)
        con.Open()
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter("Select * from Docinfor where Name='" + txtDoctorName.Text.Trim() + "'", con)

        strsqlQuery = "UPDATE Docinfor  set Name = @Name, Gender = @Gender, DOB = @DOB,  Address= @Address, Specialist = @Specialist,City = @City,State = @State,Country = @Country,Pincode = @Pincode where Name='" + txtDoctorName.Text.Trim() + "'"
        cmd = New SqlCommand(strsqlQuery, con)
        cmd.Parameters.AddWithValue("@Name", txtname.Text)
        cmd.Parameters.AddWithValue("@Gender", cmbgen.Text)
        cmd.Parameters.AddWithValue("@DOB", txtdob.Text)
        cmd.Parameters.AddWithValue("@Pincode", txtpin.Text)
        cmd.Parameters.AddWithValue("@Address", txtadd.Text)
        cmd.Parameters.AddWithValue("@Email", txtmail.Text)
        cmd.Parameters.AddWithValue("@Country", cmbCountry.Text)
        cmd.Parameters.AddWithValue("@State", cmbstate.Text)
        cmd.Parameters.AddWithValue("@City", cmbcity.Text)
        cmd.Parameters.AddWithValue("@Specialist", txtspcl.Text)
        Dim x As Integer = cmd.ExecuteNonQuery()
        If (x > 0) Then
            MsgBox("Doctor Information Updated Successfully", MsgBoxStyle.DefaultButton1, "HOSPITAL MANAGEMENT SYSTEM")
        Else
            MsgBox("Updation Failed", MsgBoxStyle.DefaultButton1, "HOSPITAL MANAGEMENT SYSTEM")
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub txtDoctorName_TextChanged(sender As Object, e As EventArgs) Handles txtDoctorName.TextChanged
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


        txtname.Text = ""
        cmbgen.Text = ""

        txtname.Text = ""
        cmbgen.Text = ""
        txtdob.Text = ""
        txtmail.Text = ""
        txtspcl.Text = ""
        cmbCountry.Text = ""
        cmbstate.Text = ""
        cmbcity.Text = ""
        txtadd.Text = ""
        txtpin.Text = ""

        'for search
        cmd = New SqlCommand("Select * from docinfor  where Name='" + txtDoctorName.Text.Trim() + "'", con)

        Dim reader As SqlDataReader = cmd.ExecuteReader()
        If reader.HasRows Then
            Do While reader.Read()
                txtname.Text = reader("Name").ToString()
                cmbgen.Text = reader("Gender").ToString()


                txtadd.Text = reader("Address").ToString()
                txtdob.Text = reader("DOB").ToString()
                txtmail.Text = reader("Email").ToString()
                txtspcl.Text = reader("Specialist").ToString()
                cmbCountry.Text = reader("Country").ToString()
                cmbcity.Text = reader("City").ToString()
                txtpin.Text = reader("Pincode").ToString()
                cmbstate.Text = reader("State").ToString()


            Loop
        End If
        reader.Close()
    End Sub





    Public Sub BindCountry()

        Using connection As SqlConnection = New SqlConnection("Data Source=LAPTOP-VBNDUE2B;Database=HospitalManagementdb; User Id=sa;Password=123")

            connection.Open()
            'conn.Open();
            strsqlQuery = "Select County from Country"
            Using comm As SqlCommand = New SqlCommand(strsqlQuery, connection)
                Dim rs As SqlDataReader = comm.ExecuteReader
                Dim dt As DataTable = New DataTable
                dt.Load(rs)
                cmbCountry.ValueMember = "County"
                cmbCountry.DisplayMember = "County"
                cmbCountry.DataSource = dt

            End Using
        End Using
    End Sub
    Public Sub BindState()

        Using connection As SqlConnection = New SqlConnection("Data Source=LAPTOP-VBNDUE2B;Database=HospitalManagementdb; User Id=sa;Password=123")

            connection.Open()
            'conn.Open();
            strsqlQuery = "Select State from countryState"
            Using comm As SqlCommand = New SqlCommand(strsqlQuery, connection)
                Dim rs As SqlDataReader = comm.ExecuteReader
                Dim dt As DataTable = New DataTable
                dt.Load(rs)
                cmbstate.ValueMember = "State"
                cmbstate.DisplayMember = "State"
                cmbstate.DataSource = dt

            End Using
        End Using
    End Sub
    Public Sub BindCity()

        Using connection As SqlConnection = New SqlConnection("Data Source=LAPTOP-VBNDUE2B;Database=HospitalManagementdb; User Id=sa;Password=123")

            connection.Open()
            'conn.Open();
            strsqlQuery = "Select City from stateCity"
            Using comm As SqlCommand = New SqlCommand(strsqlQuery, connection)
                Dim rs As SqlDataReader = comm.ExecuteReader
                Dim dt As DataTable = New DataTable
                dt.Load(rs)
                cmbcity.ValueMember = "City"
                cmbcity.DisplayMember = "City"
                cmbcity.DataSource = dt

            End Using
        End Using
    End Sub


    Private Sub cmbCountry_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCountry.SelectedIndexChanged
        cmbCountry.Text = "Your Selected Country:" &
            cmbCountry.SelectedValue
    End Sub

    Private Sub cmbcity_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbcity.SelectedIndexChanged
        cmbcity.Text = "Your Selected City:" &
            cmbcity.SelectedValue
    End Sub

    Private Sub cmbstate_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbstate.SelectedIndexChanged
        cmbstate.Text = "Your Selected State:" &
            cmbstate.SelectedValue
    End Sub

    Private Sub txtmail_TextChanged(sender As Object, e As EventArgs) Handles txtmail.TextChanged

    End Sub

    Private Sub txtmail_Validating(sender As Object, e As ComponentModel.CancelEventArgs) Handles txtmail.Validating
        Dim pattern As String = "^[a-z][a-z|0-9|]*([_][a-z|0-9]+)*([.][a-z|0-9]+([_][a-z|0-9]+)*)?@[a-z][a-z|0-9|]*\.([a-z][a-z|0-9]*(\.[a-z][a-z|0-9]*)?)$"


        Dim match As System.Text.RegularExpressions.Match = Regex.Match(txtmail.Text.Trim(), pattern, RegexOptions.IgnoreCase)
        If (match.Success) Then

        Else
            MessageBox.Show("Please enter a valid email id", "Checking")
            txtmail.Clear()
        End If
    End Sub

    Private Sub txtdob_TextChanged(sender As Object, e As EventArgs) Handles txtdob.TextChanged

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

    Private Sub txtname_LostFocus(sender As Object, e As EventArgs) Handles txtname.LostFocus
        If txtname.Text = "" Then
            MsgBox("First Enter your Name")
            txtname.Focus()
        End If

    End Sub

    Private Sub txtname_TextChanged(sender As Object, e As EventArgs) Handles txtname.TextChanged

    End Sub

    Private Sub txtdob_Validating(sender As Object, e As ComponentModel.CancelEventArgs) Handles txtdob.Validating
        Dim dat As Date



        If Date.TryParse(txtdob.Text, dat) Then 'Then

            'Label7.Text = dat.ToShortDateString
            ' txtage.Text = dat.ToString



        Else

            MsgBox("Please enter date in MM/DD/YY Format")




        End If





    End Sub
End Class
