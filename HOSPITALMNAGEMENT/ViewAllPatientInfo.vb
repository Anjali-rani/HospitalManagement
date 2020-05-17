Public Class ViewAllPatientInfo

    Private Sub ViewAllPatientInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'HospitalManagementdbDataSet.patientregis' table. You can move, or remove it, as needed.
        Me.PatientregisTableAdapter.Fill(Me.HospitalManagementdbDataSet.patientregis)

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class