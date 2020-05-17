Imports System.Data
Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms

Public Class DoctorReports

    Private Sub DoctorReports_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dsDoctors As Doctors = GetData()
        'Dim datasource As New ReportDataSource("Doctors", dsDoctors.Tables(0))
        Dim datasource As New ReportDataSource("Doctors", dsDoctors.Tables(0))
        Me.ReportViewer1.LocalReport.DataSources.Clear()
        Me.ReportViewer1.LocalReport.DataSources.Add(datasource)
        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Function GetData() As Doctors
        Dim constr As String = "Data Source=LAPTOP-VBNDUE2B;Database=HospitalManagementdb; User Id=sa;Password=123"
        Using con As New SqlConnection(constr)
            Using cmd As New SqlCommand("SELECT TOP 20 * FROM docinfor")
                Using sda As New SqlDataAdapter()
                    cmd.Connection = con
                    sda.SelectCommand = cmd
                    Using dsDoctors As New Doctors()
                        'sda.Fill(dsDoctors, "Doctors")
                        sda.Fill(dsDoctors, "DataTable1")
                        Return dsDoctors
                    End Using
                End Using
            End Using
        End Using
    End Function
End Class