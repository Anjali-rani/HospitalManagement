Public Class MDIForm

    Private Sub MDIForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Form1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Form1ToolStripMenuItem.Click
        Dim objForm1 As New PatientRegistration()
        objForm1.MdiParent = Me
        objForm1.Show()
    End Sub

    Private Sub Form2ToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form3ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Form3ToolStripMenuItem.Click
        Dim objForm3 As New patchekout()
        objForm3.MdiParent = Me
        objForm3.Show()
    End Sub

    Private Sub Form4ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Form4ToolStripMenuItem.Click
        Dim objForm4 As New form4()
        objForm4.MdiParent = Me
        objForm4.Show()
    End Sub

    Private Sub Menu3ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Menu3ToolStripMenuItem.Click

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub Submenu1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Submenu1ToolStripMenuItem.Click
        Dim objSubmenu1 As New Doctorinfo()
        objSubmenu1.MdiParent = Me
        objSubmenu1.Show()
    End Sub

  

   
   

   

    

    Private Sub Sub2ToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Sub3ToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

   

   

    

   

    


   

   

    Private Sub RoomInformationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RoomInformationToolStripMenuItem.Click
        Dim objRoomInformation As New roominfo
        objRoomInformation.MdiParent = Me
        objRoomInformation.Show()
    End Sub

    Private Sub StaffInformationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StaffInformationToolStripMenuItem.Click
        Dim objStaffInformation As New staffinfo
        objStaffInformation.MdiParent = Me
        objStaffInformation.Show()
    End Sub

    Private Sub ViewAllPatientsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewAllPatientsToolStripMenuItem.Click
        Dim objStaffInformation As New ViewAllPatientInfo
        objStaffInformation.MdiParent = Me
        objStaffInformation.Show()
    End Sub

    Private Sub MyFormToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MyFormToolStripMenuItem.Click
        'Dim objMyForm As New MyForm
        'objMyForm.MdiParent = Me
        'objMyForm.Show()
    End Sub

   

    Private Sub Sub1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Sub1ToolStripMenuItem.Click
        Dim objDoctorReports As New DoctorReports()
        objDoctorReports.MdiParent = Me
        objDoctorReports.Show()
    End Sub

   

    Private Sub PatientReportToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub WARDToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PatientToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PatientToolStripMenuItem.Click
        Dim objPatient As New Patients()
        objPatient.MdiParent = Me
        objPatient.Show()
    End Sub

    Private Sub FORMSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FORMSToolStripMenuItem.Click

    End Sub

    Private Sub UserInfotmationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UserInfotmationToolStripMenuItem.Click
        Dim objuserinfo As New userinfo()
        objuserinfo.MdiParent = Me
        objuserinfo.Show()
    End Sub

    Private Sub MobileNumberValidationToolStripMenuItem_Click(sender As Object, e As EventArgs)
        'Dim objMobileNumber As New Calculator()
        'objMobileNumber.MdiParent = Me
        'objMobileNumber.Show()
    End Sub

    Private Sub PatientInformationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PatientInformationToolStripMenuItem.Click
        Dim objsearchpatient As New searchpatient()
        objsearchpatient.MdiParent = Me
        objsearchpatient.Show()
    End Sub

    Private Sub AddNewUserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddNewUserToolStripMenuItem.Click
        'Dim objNewUser As New NewUser()
        ' objNewUser.MdiParent = Me
        'objNewUser.Show()
        Dim objRegistration As New Registration()
        objRegistration.MdiParent = Me
        objRegistration.Show()

    End Sub

    Private Sub MailServicesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MailServicesToolStripMenuItem.Click
        Dim objMailServices As New Mail()
        objMailServices.MdiParent = Me
        objMailServices.Show()
    End Sub

    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub CalculatorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalculatorToolStripMenuItem.Click
        Dim objMobileNumber As New Calculator()
        objMobileNumber.MdiParent = Me
        objMobileNumber.Show()
    End Sub

    Private Sub ExitToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem1.Click
        Me.Close()

    End Sub
End Class
