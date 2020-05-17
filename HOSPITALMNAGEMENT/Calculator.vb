'Imports System
'Imports System.Data
'Imports System.Configuration
'Imports System.Data.SqlClient


Public Class Calculator
    Dim Firstnum As Decimal
    Dim secondnum As Decimal
    Dim Operations As Integer
    Dim Operator_selector As Boolean = False
    'Dim cmd As New SqlCommand
    'Dim con As New SqlConnection
    'Dim connection As String
    'Dim strsqlQuery As String
    'Dim ds As New DataSet
    'Dim dt As DataTable









    'Private Sub MobileNumber_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    '        Dim connectionString As String
    '        Dim con As SqlConnection
    '        connectionString = "Data Source=LAPTOP-VBNDUE2B;Database=HospitalManagementdb; User Id=sa;Password=123"
    '        con = New SqlConnection(connectionString)
    '        con.Open()



    '        Dim adapter As SqlDataAdapter
    '        adapter = New SqlDataAdapter("Select Name  from patientregis", con)


    '        'adapter.Fill(dt)
    '        adapter.Fill(ds, Name)
    '        Dim col As New AutoCompleteStringCollection
    '        For i = 0 To ds.Tables(0).Rows.Count - 1
    '            col.Add(ds.Tables(0).Rows(i)(0).ToString)
    '        Next
    '        txtname.AutoCompleteSource = AutoCompleteSource.CustomSource
    '        txtname.AutoCompleteCustomSource = col
    '        txtname.AutoCompleteMode = AutoCompleteMode.SuggestAppend

    '        ' Dim r As DataRow
    '        'txtname.AutoCompleteCustomSource.Clear()
    '        'For Each r In dt.Rows
    '        '   txtname.AutoCompleteCustomSource.Add(r.Item(2).ToString)
    '        '  Next
    '        'con.Close()
    '        'Catch ex As Exception
    '        '   MessageBox.Show(ex.ToString)




    '        'End Try
    '    End Sub

    '    Private Sub txtname_TextChanged(sender As Object, e As EventArgs)

    '    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If TextBox1.Text <> "0" Then
            TextBox1.Text += "5"
        Else
            TextBox1.Text = "5"
        End If
    End Sub

    Private Sub MobileNumber_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub




    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If TextBox1.Text <> "0" Then
            TextBox1.Text += "1"
        Else
            TextBox1.Text = "1"
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If TextBox1.Text <> "0" Then
            TextBox1.Text += "2"
        Else
            TextBox1.Text = "2"
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If TextBox1.Text <> "0" Then
            TextBox1.Text += "3"
        Else
            TextBox1.Text = "3"
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If TextBox1.Text <> "0" Then
            TextBox1.Text += "4"
        Else
            TextBox1.Text = "4"
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If TextBox1.Text <> "0" Then
            TextBox1.Text += "6"
        Else
            TextBox1.Text = "6"
        End If
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        If TextBox1.Text <> "0" Then
            TextBox1.Text += "7"
        Else
            TextBox1.Text = "7"
        End If
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        If TextBox1.Text <> "0" Then
            TextBox1.Text += "8"
        Else
            TextBox1.Text = "8"
        End If
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        If TextBox1.Text <> "0" Then
            TextBox1.Text += "9"
        Else
            TextBox1.Text = "9"
        End If
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        If TextBox1.Text <> "0" Then
            TextBox1.Text += "0"

        End If
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        TextBox1.Text = "0"
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        If Not (TextBox1.Text.Contains(".")) Then
            TextBox1.Text += "."

        End If
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        If Operator_selector = True Then
            secondnum = TextBox1.Text
            If Operations = 1 Then
                TextBox1.Text = Firstnum + secondnum
            ElseIf Operations = 2 Then
                TextBox1.Text = Firstnum - secondnum
            ElseIf Operations = 3 Then
                TextBox1.Text = Firstnum * secondnum
            Else
                If secondnum = 0 Then
                    TextBox1.Text = "error"
                Else
                    TextBox1.Text = Firstnum / secondnum


                End If



            End If
            Operator_selector = False

        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Firstnum = TextBox1.Text
        TextBox1.Text = 0
        Operator_selector = True
        Operations = 4 ' = /
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Firstnum = TextBox1.Text
        TextBox1.Text = 0
        Operator_selector = True
        Operations = 3 ' = *
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Firstnum = TextBox1.Text
        TextBox1.Text = 0
        Operator_selector = True
        Operations = 2 ' = -
    End Sub
End Class





