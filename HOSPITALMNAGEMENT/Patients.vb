Imports System.Data
Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms
Public Class Patients

    Private Sub Patients_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim dsPatientchekout As Patientchekout = GetData()
        Dim datasource As New ReportDataSource("Patientchekout", dsPatientchekout.Tables(0))
        Me.ReportViewer1.LocalReport.DataSources.Clear()
        Me.ReportViewer1.LocalReport.DataSources.Add(datasource)
        Me.ReportViewer1.RefreshReport()
    End Sub
    Private Function GetData() As Patientchekout
        Dim constr As String = "Data Source=LAPTOP-VBNDUE2B;Database=HospitalManagementdb; User Id=sa;Password=123"
        Using con As New SqlConnection(constr)
            Using cmd As New SqlCommand("SELECT TOP 20 * FROM tblPatient")
                Using sda As New SqlDataAdapter()
                    cmd.Connection = con
                    sda.SelectCommand = cmd
                    Using dsPatientchekout As New Patientchekout()
                        sda.Fill(dsPatientchekout, "DataTable1")
                        Return dsPatientchekout
                    End Using
                End Using
            End Using
        End Using
    End Function

    ' Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load

    ' End Sub
End Class