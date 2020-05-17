Imports System
Imports System.Data
Imports System.Configuration
Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Public Class userinfo
    Dim cmd As New SqlCommand
    Dim con As New SqlConnection
    Dim connection As String
    Dim strsqlQuery As String

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
    Public Sub BindPatientInfo()
        Dim connectionString As String
        Dim con As SqlConnection
        connectionString = "Data Source=LAPTOP-VBNDUE2B;Database=HospitalManagementdb; User Id=sa;Password=123"
        con = New SqlConnection(connectionString)
        con.Open()
        Dim com As String = "select * from tblregister"
        Dim adapter As New SqlDataAdapter(com, con)
        Dim ds As New DataSet()
        adapter.Fill(ds, "tblregister")
        DataGridView1.DataSource = ds.Tables(0)
    End Sub

    Private Sub userinfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BindPatientInfo()
    End Sub
End Class