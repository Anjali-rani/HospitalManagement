Imports System.Data
Imports System.Configuration
Imports System.Data.SqlClient
Public Class LoginForm1
    Dim cmd As New SqlCommand
    Dim con As New SqlConnection
    Dim connection As String
    Dim strsqlQuery As String
   
        
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
      
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
       
        'Dim connectionString As String

        'Dim con As SqlConnection
        'connectionString = "Data Source=LAPTOP-VBNDUE2B;Database=HospitalManagementdb; User Id=sa;Password=123"
        'con = New SqlConnection(connectionString)
        'con.Open()

        'Dim command As New SqlCommand("Select * from tblregister where Username = @Username and Password= @Password", con)
        'command.Parameters.Add("@Username", SqlDbType.VarChar).Value = UsernameTextBox.Text
        'command.Parameters.Add("@Password", SqlDbType.VarChar).Value = PasswordTextBox.Text
        'Dim adapter As New SqlDataAdapter(command)

        'Dim Table As New DataTable()
        'adapter.Fill(Table)
        'If UsernameTextBox.Text = "" And PasswordTextBox.Text = "" Then
        '    MsgBox("Please enter your Username and Password.", MsgBoxStyle.Information, "LOGIN")
        '    ElseIf Table.Rows.Count() <= 0 Then

        '    MessageBox.Show("Userame or Password Are Invalid")
        'Else
        '    MessageBox.Show("Login Successfully")

        '    MDIForm.Show()
        '    UsernameTextBox.Text = ""
        '    PasswordTextBox.Text = ""

        Dim connectionString As String

        Dim con As SqlConnection
		connectionString = "Data Source=LAPTOP-VBNDUE2B;Database=HospitalManagementdb; User Id=sa;Password=123"
		con = New SqlConnection(connectionString)
		con.Open();

        Dim command As New SqlCommand("Select * from tblregister where Position = @Position and Password= @Password", con)
        command.Parameters.Add("@Position", SqlDbType.VarChar).Value = UsernameTextBox.Text
        command.Parameters.Add("@Password", SqlDbType.VarChar).Value = PasswordTextBox.Text
        Dim adapter As New SqlDataAdapter(command)

        Dim Table As New DataTable()
        adapter.Fill(Table)
        If UsernameTextBox.Text = "" And PasswordTextBox.Text = "" Then
            MsgBox("Please enter your Username and Password.", MsgBoxStyle.Information, "LOGIN")
        ElseIf Table.Rows.Count() <= 0 Then

            MessageBox.Show("Userame or Password Are Invalid")
        Else
            MessageBox.Show("Login Successfully")

            MDIForm.Show()
            UsernameTextBox.Text = ""
            PasswordTextBox.Text = ""


            'cmd = New SqlCommand("insert into logintable (Username,Password) values('" + UsernameTextBox.Text.Trim() + "','" + PasswordTextBox.Text.Trim() + "')", con)
            'Dim Admin As String
            'Dim Admin123 As String
            'Dim Manager As String
            'Dim Manager123 As String
            '' user = "user"
            ''pass = "pass"
            ''user2 = "username"
            ''pass2 = "Password"
            ''If UsernameTextBox.Text = user And PasswordTextBox.Text = pass Then
            ''MDIForm.Show()
            'Admin = "Admin"
            'Admin123 = "Admin123"
            'Manager = "Manager"
            'Manager123 = "Manager123"
            'If UsernameTextBox.Text = Admin And PasswordTextBox.Text = Admin123 Then
            '    MDIForm.Show()
            'ElseIf UsernameTextBox.Text = Manager And PasswordTextBox.Text = Manager123 Then
            '    MDIForm.Show()
            'Else
            '    MsgBox("invalid username and password", vbCritical)

            '    'ElseIf UsernameTextBox.Text = user2 And PasswordTextBox.Text = pass2 Then
            '    'MDIForm.Show()

            '    'Else
            '    'MsgBox("invalid username and password", vbCritical)

        End If
    End Sub

    'Private Sub LogoPictureBox_Click(sender As Object, e As EventArgs)

    'End Sub


    'Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    'End Sub

    'Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    'End Sub

    'Private Sub LoginForm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    '  End Sub




    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class
