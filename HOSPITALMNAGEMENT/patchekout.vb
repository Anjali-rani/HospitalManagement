Imports System
Imports System.Data
Imports System.Configuration
Imports System.Data.SqlClient
Public Class patchekout
    Dim cmd As New SqlCommand
    Dim con As New SqlConnection
    Dim Connection As String
    Dim strsqlQuery As String
    Dim ds As New DataSet
    Dim dt As DataTable




    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnok.Click
        If True Then
            Dim dt1 As DateTime = Convert.ToDateTime(txtch.Text)
            Dim dt2 As DateTime = Convert.ToDateTime(txtdtot.Text)
            Dim ts As TimeSpan = dt2.Subtract(dt1)
            If Convert.ToInt32(ts.Days) >= 0 Then
                lblday.Text = Convert.ToInt32(ts.Days)
                ' MessageBox.Show("Total Days are " & Convert.ToInt32(ts.Days))
            Else
                MessageBox.Show("Invalid Input")
            End If
        End If
        Dim Number1 As Integer
        Dim Number2 As Integer
        Dim sum As Integer
        Number1 = txtup.Text
        Number2 = txtmedicine.Text
        sum = (Number1 + Number2) * lblday.Text
        txttotal.Text = sum


        Dim connectionString As String
        Dim con As SqlConnection
        connectionString = "Data Source=LAPTOP-VBNDUE2B;Database=HospitalManagementdb; User Id=sa;Password=123"
        con = New SqlConnection(connectionString)
        con.Open()
        'MsgBox("Connection Open")
        cmd = New SqlCommand("insert into  tblPatient(Name,Gender,Age,Phone,Address,Disease,DateIn,DateOut,Roomno,Roomtype,Price,Building,Status,Medicine,Total,TotalDays) values(@Name,@Gender,@Age,@Phone,@Address,@Disease,@DateIn,@DateOut,@Roomno,@Roomtype,@Building,@Status,@Medicine,@Price,@Total,@TotalDays)", con)
        cmd.Parameters.AddWithValue("@Name", txtnm.Text.Trim())
        cmd.Parameters.AddWithValue("@Phone", txtph.Text.Trim())
        cmd.Parameters.AddWithValue("@Gender", cmbgnd.Text.Trim())
        cmd.Parameters.AddWithValue("@Age", txtage.Text.Trim())

        cmd.Parameters.AddWithValue("@Address", txtadd.Text.Trim())
        cmd.Parameters.AddWithValue("@Disease", txtdis.Text.Trim())
        cmd.Parameters.AddWithValue("@DateIn", txtch.Text.Trim())
        cmd.Parameters.AddWithValue("@DateOut", txtdtot.Text.Trim())
        cmd.Parameters.AddWithValue("@Roomno", cmbrmno.Text.Trim())
        cmd.Parameters.AddWithValue("@Roomtype", cmbrmt.Text.Trim())
        cmd.Parameters.AddWithValue("@Price", txtup.Text.Trim())
        cmd.Parameters.AddWithValue("@Building", cmbbuild.Text.Trim())
        cmd.Parameters.AddWithValue("@Status", cmdstatus.Text.Trim())
        cmd.Parameters.AddWithValue("@Medicine", txtmedicine.Text.Trim())
        cmd.Parameters.AddWithValue("@Total", txttotal.Text.Trim())
        cmd.Parameters.AddWithValue("@TotalDays", lblday.Text.Trim())
        Dim x As Integer = cmd.ExecuteNonQuery()
        If (x > 0) Then
            MsgBox("Patient checkout Successfully", MsgBoxStyle.DefaultButton1, "HOSPITAL MANAGEMENT SYSTEM")
        Else
            MsgBox("checkout not done", MsgBoxStyle.DefaultButton1, "HOSPITAL MANAGEMENT SYSTEM")

        End If

        Deletepatient()
    End Sub

    Private Sub btnclo_Click(sender As Object, e As EventArgs) Handles btnclo.Click
        Me.Close()

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtadd_TextChanged(sender As Object, e As EventArgs) Handles txtadd.TextChanged

    End Sub

    'Private Sub patchekout_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    'txtch.Text = DateTime.Today.ToShortDateString()
    'Dim connectionString As String
    'Dim con As SqlConnection
    'connectionString = "Data Source=LAPTOP-VBNDUE2B;Database=HospitalManagementdb; User Id=sa;Password=123"
    'con = New SqlConnection(connectionString)
    'con.Open()



    'Dim adapter As SqlDataAdapter
    'adapter = New SqlDataAdapter("Select Name,Gender,Age,Phone,Address,Disease,Building,Roomno,Roomtype,Price  from patientregis", con)


    ''adapter.Fill(dt)
    'adapter.Fill(ds, Name)
    'Dim col As New AutoCompleteStringCollection
    'For i = 0 To ds.Tables(0).Rows.Count - 1
    '    col.Add(ds.Tables(0).Rows(i)(0).ToString)
    'Next
    'txtsearch.AutoCompleteSource = AutoCompleteSource.CustomSource
    'txtsearch.AutoCompleteCustomSource = col
    'txtsearch.AutoCompleteMode = AutoCompleteMode.SuggestAppend



    ' End Sub

    Private Sub txtdn_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Name_Click(sender As Object, e As EventArgs) Handles Name.Click

    End Sub

    Private Sub btmsearch_Click(sender As Object, e As EventArgs) Handles btnsearch.Click
        Dim connectionString As String
        Dim con As SqlConnection
        connectionString = "Data Source=LAPTOP-VBNDUE2B;Database=HospitalManagementdb; User Id=sa;Password=123"
        con = New SqlConnection(connectionString)
        con.Open()
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter("Select * from patientregis  where Name='" + txtsearch.Text.Trim() + "'", con)

        adapter.Fill(ds)
        If ds.Tables(0).Rows.Count > 0 Then
            txtch.Text = ds.Tables(0).Rows(0)("Date").ToString()
            'txtdtot.Text = ds.Tables(0).Rows(0)("DateOut").ToString()
            txtnm.Text = ds.Tables(0).Rows(0)("Name").ToString()
            cmbgnd.Text = ds.Tables(0).Rows(0)("Gender").ToString()
            txtage.Text = ds.Tables(0).Rows(0)("Age").ToString()
            txtph.Text = ds.Tables(0).Rows(0)("Phone").ToString()
            txtadd.Text = ds.Tables(0).Rows(0)("Address").ToString()
            txtdis.Text = ds.Tables(0).Rows(0)("Disease").ToString()
            txtup.Text = ds.Tables(0).Rows(0)("Price").ToString()

            ' txtdays.Text = ds.Tables(0).Rows(0)("TotalDays").ToString()
            cmbbuild.Text = ds.Tables(0).Rows(0)("Building").ToString()
            cmbrmno.Text = ds.Tables(0).Rows(0)("Roomno").ToString()
            cmbrmt.Text = ds.Tables(0).Rows(0)("Roomtype").ToString()





        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txttotal.TextChanged

    End Sub

    Private Sub txtsearch_TextChanged(sender As Object, e As EventArgs) Handles txtsearch.TextChanged
        Dim connectionString As String
        Dim con As SqlConnection
        connectionString = "Data Source=LAPTOP-VBNDUE2B;Database=HospitalManagementdb; User Id=sa;Password=123"
        con = New SqlConnection(connectionString)
        con.Open()



        'Dim adapter As SqlDataAdapter
        'adapter = New SqlDataAdapter("Select Name,Gender,Age,Phone,Address,Disease,Bloodgroup,Building,Roomno,Roomtype,Price  from patientregis", con)


        ''adapter.Fill(dt)
        'adapter.Fill(ds, "")
        'Dim col As New AutoCompleteStringCollection
        'For i = 0 To ds.Tables(0).Rows.Count - 1
        '    col.Add(ds.Tables(0).Rows(i)(0).ToString)
        'Next
        'txtsearch.AutoCompleteSource = AutoCompleteSource.CustomSource
        'txtsearch.AutoCompleteCustomSource = col
        'txtsearch.AutoCompleteMode = AutoCompleteMode.SuggestAppend


        txtch.Text = ""
        txtnm.Text = ""
        cmbgnd.Text = ""
        txtage.Text = ""
        txtph.Text = ""
        txtadd.Text = ""
        txtdis.Text = ""

        cmbbuild.Text = ""
        cmbrmt.Text = ""
        cmbrmno.Text = ""
        txtup.Text = ""

        'for search
        cmd = New SqlCommand("Select * from patientregis  where Name='" + txtsearch.Text.Trim() + "'", con)

        Dim reader As SqlDataReader = cmd.ExecuteReader()
        If reader.HasRows Then
            Do While reader.Read()
                txtnm.Text = reader("Name").ToString()
                cmbgnd.Text = reader("Gender").ToString()
                txtage.Text = reader("Age").ToString()
                txtph.Text = reader("Phone").ToString()

                txtadd.Text = reader("Address").ToString()
                txtdis.Text = reader("Disease").ToString()

                cmbbuild.Text = reader("Building").ToString()
                cmbrmno.Text = reader("Roomno").ToString()
                cmbrmt.Text = reader("Roomtype").ToString()
                txtup.Text = reader("Price").ToString()
                txtch.Text = reader("Date").ToString
            Loop
        End If
        reader.Close()

    End Sub


    Private Sub patchekout_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub
    Public Sub Deletepatient()
        Dim connectionString As String
        Dim con As SqlConnection
        connectionString = "Data Source=LAPTOP-VBNDUE2B;Database=HospitalManagementdb; User Id=sa;Password=123"
        con = New SqlConnection(connectionString)
        con.Open()

        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter("Select * from patientregis  where Name='" + txtsearch.Text.Trim() + "'", con)
        strsqlQuery = "DELETE patientregis   where Name='" + txtsearch.Text.Trim() + "'"
        cmd = New SqlCommand(strsqlQuery, con)
        Dim x As Integer = cmd.ExecuteNonQuery()
        If (x > 0) Then

            txtnm.Text = ""
            cmbgnd.Text = ""
            txtage.Text = ""
            txtph.Text = ""
            txtadd.Text = ""
            txtdis.Text = ""
            txtup.Text = ""
            cmbbuild.Text = ""
            cmbrmno.Text = ""
            cmbrmt.Text = ""
            txttotal.Text = ""
            txtch.Text = ""
            txtpid.Text = ""
            cmdstatus.Text = ""
            txtdtot.Text = ""
            txtch.Text = ""
            lblday.Text = ""
            txtmedicine.Text = ""



        End If

    End Sub
End Class