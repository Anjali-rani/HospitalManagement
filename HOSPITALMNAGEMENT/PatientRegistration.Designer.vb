<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PatientRegistration
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Me.GroupBox3 = New System.Windows.Forms.GroupBox()
		Me.cmbroomt = New System.Windows.Forms.ComboBox()
		Me.txtprice = New System.Windows.Forms.TextBox()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.cmbroom = New System.Windows.Forms.ComboBox()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.cmbbuild = New System.Windows.Forms.ComboBox()
		Me.Btnadd = New System.Windows.Forms.Button()
		Me.Label10 = New System.Windows.Forms.Label()
		Me.Label9 = New System.Windows.Forms.Label()
		Me.Cmbgen = New System.Windows.Forms.ComboBox()
		Me.txtname = New System.Windows.Forms.TextBox()
		Me.Label7 = New System.Windows.Forms.Label()
		Me.txtage = New System.Windows.Forms.TextBox()
		Me.Label11 = New System.Windows.Forms.Label()
		Me.Label12 = New System.Windows.Forms.Label()
		Me.txtphone = New System.Windows.Forms.TextBox()
		Me.Label13 = New System.Windows.Forms.Label()
		Me.Txtdise = New System.Windows.Forms.TextBox()
		Me.GroupBox4 = New System.Windows.Forms.GroupBox()
		Me.txtblodgrp = New System.Windows.Forms.TextBox()
		Me.Label15 = New System.Windows.Forms.Label()
		Me.Txtadd = New System.Windows.Forms.TextBox()
		Me.DataGridView1 = New System.Windows.Forms.DataGridView()
		Me.Button3 = New System.Windows.Forms.Button()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.GroupBox1 = New System.Windows.Forms.GroupBox()
		Me.datpik = New System.Windows.Forms.DateTimePicker()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
		Me.txtpid = New System.Windows.Forms.TextBox()
		Me.GroupBox3.SuspendLayout()
		Me.GroupBox4.SuspendLayout()
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.GroupBox1.SuspendLayout()
		Me.SuspendLayout()
		'
		'GroupBox3
		'
		Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
		Me.GroupBox3.Controls.Add(Me.cmbroomt)
		Me.GroupBox3.Controls.Add(Me.txtprice)
		Me.GroupBox3.Controls.Add(Me.Label6)
		Me.GroupBox3.Controls.Add(Me.Label5)
		Me.GroupBox3.Controls.Add(Me.cmbroom)
		Me.GroupBox3.Controls.Add(Me.Label4)
		Me.GroupBox3.Controls.Add(Me.Label3)
		Me.GroupBox3.Controls.Add(Me.cmbbuild)
		Me.GroupBox3.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.GroupBox3.ForeColor = System.Drawing.Color.DarkMagenta
		Me.GroupBox3.Location = New System.Drawing.Point(433, 105)
		Me.GroupBox3.Name = "GroupBox3"
		Me.GroupBox3.Size = New System.Drawing.Size(355, 225)
		Me.GroupBox3.TabIndex = 2
		Me.GroupBox3.TabStop = False
		Me.GroupBox3.Text = "Room Information"
		'
		'cmbroomt
		'
		Me.cmbroomt.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmbroomt.ForeColor = System.Drawing.Color.Navy
		Me.cmbroomt.FormattingEnabled = True
		Me.cmbroomt.Items.AddRange(New Object() {"Normal", "Medium", "VIP"})
		Me.cmbroomt.Location = New System.Drawing.Point(146, 128)
		Me.cmbroomt.Name = "cmbroomt"
		Me.cmbroomt.Size = New System.Drawing.Size(156, 26)
		Me.cmbroomt.TabIndex = 11
		'
		'txtprice
		'
		Me.txtprice.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtprice.ForeColor = System.Drawing.Color.Navy
		Me.txtprice.Location = New System.Drawing.Point(146, 171)
		Me.txtprice.Name = "txtprice"
		Me.txtprice.Size = New System.Drawing.Size(156, 26)
		Me.txtprice.TabIndex = 10
		'
		'Label6
		'
		Me.Label6.AutoSize = True
		Me.Label6.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label6.ForeColor = System.Drawing.Color.Maroon
		Me.Label6.Location = New System.Drawing.Point(36, 174)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(51, 18)
		Me.Label6.TabIndex = 9
		Me.Label6.Text = "Price"
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label5.ForeColor = System.Drawing.Color.Maroon
		Me.Label5.Location = New System.Drawing.Point(21, 27)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(79, 18)
		Me.Label5.TabIndex = 7
		Me.Label5.Text = "Building"
		'
		'cmbroom
		'
		Me.cmbroom.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmbroom.ForeColor = System.Drawing.Color.Navy
		Me.cmbroom.FormattingEnabled = True
		Me.cmbroom.Items.AddRange(New Object() {"101", "102", "103"})
		Me.cmbroom.Location = New System.Drawing.Point(146, 73)
		Me.cmbroom.Name = "cmbroom"
		Me.cmbroom.Size = New System.Drawing.Size(156, 26)
		Me.cmbroom.TabIndex = 8
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label4.ForeColor = System.Drawing.Color.Maroon
		Me.Label4.Location = New System.Drawing.Point(14, 131)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(101, 18)
		Me.Label4.TabIndex = 5
		Me.Label4.Text = "Room Type"
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.ForeColor = System.Drawing.Color.Maroon
		Me.Label3.Location = New System.Drawing.Point(21, 76)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(86, 18)
		Me.Label3.TabIndex = 4
		Me.Label3.Text = "Room no."
		'
		'cmbbuild
		'
		Me.cmbbuild.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmbbuild.ForeColor = System.Drawing.Color.Navy
		Me.cmbbuild.FormattingEnabled = True
		Me.cmbbuild.Items.AddRange(New Object() {"A", "B", "C"})
		Me.cmbbuild.Location = New System.Drawing.Point(146, 27)
		Me.cmbbuild.Name = "cmbbuild"
		Me.cmbbuild.Size = New System.Drawing.Size(156, 26)
		Me.cmbbuild.TabIndex = 7
		'
		'Btnadd
		'
		Me.Btnadd.Font = New System.Drawing.Font("Georgia", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Btnadd.ForeColor = System.Drawing.Color.Green
		Me.Btnadd.Location = New System.Drawing.Point(794, 239)
		Me.Btnadd.Name = "Btnadd"
		Me.Btnadd.Size = New System.Drawing.Size(90, 36)
		Me.Btnadd.TabIndex = 11
		Me.Btnadd.Text = "Add"
		Me.Btnadd.UseVisualStyleBackColor = True
		'
		'Label10
		'
		Me.Label10.AutoSize = True
		Me.Label10.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label10.ForeColor = System.Drawing.Color.Maroon
		Me.Label10.Location = New System.Drawing.Point(19, 34)
		Me.Label10.Name = "Label10"
		Me.Label10.Size = New System.Drawing.Size(56, 18)
		Me.Label10.TabIndex = 4
		Me.Label10.Text = "Name"
		'
		'Label9
		'
		Me.Label9.AutoSize = True
		Me.Label9.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label9.ForeColor = System.Drawing.Color.Maroon
		Me.Label9.Location = New System.Drawing.Point(11, 66)
		Me.Label9.Name = "Label9"
		Me.Label9.Size = New System.Drawing.Size(69, 18)
		Me.Label9.TabIndex = 5
		Me.Label9.Text = "Gender"
		'
		'Cmbgen
		'
		Me.Cmbgen.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Cmbgen.ForeColor = System.Drawing.Color.Indigo
		Me.Cmbgen.FormattingEnabled = True
		Me.Cmbgen.Items.AddRange(New Object() {"Male", "Female", "Others"})
		Me.Cmbgen.Location = New System.Drawing.Point(151, 66)
		Me.Cmbgen.Name = "Cmbgen"
		Me.Cmbgen.Size = New System.Drawing.Size(151, 26)
		Me.Cmbgen.TabIndex = 1
		'
		'txtname
		'
		Me.txtname.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtname.ForeColor = System.Drawing.Color.Indigo
		Me.txtname.Location = New System.Drawing.Point(150, 31)
		Me.txtname.Name = "txtname"
		Me.txtname.Size = New System.Drawing.Size(149, 26)
		Me.txtname.TabIndex = 1
		Me.ToolTip1.SetToolTip(Me.txtname, "Enter Your Name here")
		'
		'Label7
		'
		Me.Label7.AutoSize = True
		Me.Label7.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label7.ForeColor = System.Drawing.Color.Maroon
		Me.Label7.Location = New System.Drawing.Point(32, 100)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(38, 18)
		Me.Label7.TabIndex = 9
		Me.Label7.Text = "Age"
		'
		'txtage
		'
		Me.txtage.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtage.ForeColor = System.Drawing.Color.Indigo
		Me.txtage.Location = New System.Drawing.Point(153, 101)
		Me.txtage.Name = "txtage"
		Me.txtage.Size = New System.Drawing.Size(151, 26)
		Me.txtage.TabIndex = 2
		'
		'Label11
		'
		Me.Label11.AutoSize = True
		Me.Label11.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label11.ForeColor = System.Drawing.Color.Maroon
		Me.Label11.Location = New System.Drawing.Point(19, 132)
		Me.Label11.Name = "Label11"
		Me.Label11.Size = New System.Drawing.Size(60, 18)
		Me.Label11.TabIndex = 11
		Me.Label11.Text = "Phone"
		'
		'Label12
		'
		Me.Label12.AutoSize = True
		Me.Label12.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label12.ForeColor = System.Drawing.Color.Maroon
		Me.Label12.Location = New System.Drawing.Point(11, 174)
		Me.Label12.Name = "Label12"
		Me.Label12.Size = New System.Drawing.Size(75, 18)
		Me.Label12.TabIndex = 12
		Me.Label12.Text = "Address"
		'
		'txtphone
		'
		Me.txtphone.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtphone.ForeColor = System.Drawing.Color.Indigo
		Me.txtphone.Location = New System.Drawing.Point(155, 137)
		Me.txtphone.Name = "txtphone"
		Me.txtphone.Size = New System.Drawing.Size(151, 26)
		Me.txtphone.TabIndex = 3
		'
		'Label13
		'
		Me.Label13.AutoSize = True
		Me.Label13.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label13.ForeColor = System.Drawing.Color.Maroon
		Me.Label13.Location = New System.Drawing.Point(15, 239)
		Me.Label13.Name = "Label13"
		Me.Label13.Size = New System.Drawing.Size(70, 18)
		Me.Label13.TabIndex = 14
		Me.Label13.Text = "Disease"
		'
		'Txtdise
		'
		Me.Txtdise.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Txtdise.ForeColor = System.Drawing.Color.Indigo
		Me.Txtdise.Location = New System.Drawing.Point(159, 233)
		Me.Txtdise.Name = "Txtdise"
		Me.Txtdise.Size = New System.Drawing.Size(154, 26)
		Me.Txtdise.TabIndex = 5
		'
		'GroupBox4
		'
		Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
		Me.GroupBox4.Controls.Add(Me.txtblodgrp)
		Me.GroupBox4.Controls.Add(Me.Label15)
		Me.GroupBox4.Controls.Add(Me.Txtadd)
		Me.GroupBox4.Controls.Add(Me.Txtdise)
		Me.GroupBox4.Controls.Add(Me.Label13)
		Me.GroupBox4.Controls.Add(Me.Label10)
		Me.GroupBox4.Controls.Add(Me.txtphone)
		Me.GroupBox4.Controls.Add(Me.Label12)
		Me.GroupBox4.Controls.Add(Me.Label11)
		Me.GroupBox4.Controls.Add(Me.txtage)
		Me.GroupBox4.Controls.Add(Me.Label7)
		Me.GroupBox4.Controls.Add(Me.txtname)
		Me.GroupBox4.Controls.Add(Me.Cmbgen)
		Me.GroupBox4.Controls.Add(Me.Label9)
		Me.GroupBox4.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.GroupBox4.ForeColor = System.Drawing.Color.Indigo
		Me.GroupBox4.Location = New System.Drawing.Point(8, 95)
		Me.GroupBox4.Name = "GroupBox4"
		Me.GroupBox4.Size = New System.Drawing.Size(404, 313)
		Me.GroupBox4.TabIndex = 6
		Me.GroupBox4.TabStop = False
		Me.GroupBox4.Text = "Patient's Information"
		'
		'txtblodgrp
		'
		Me.txtblodgrp.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtblodgrp.ForeColor = System.Drawing.Color.Indigo
		Me.txtblodgrp.Location = New System.Drawing.Point(162, 270)
		Me.txtblodgrp.Name = "txtblodgrp"
		Me.txtblodgrp.Size = New System.Drawing.Size(154, 26)
		Me.txtblodgrp.TabIndex = 6
		'
		'Label15
		'
		Me.Label15.AutoSize = True
		Me.Label15.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label15.ForeColor = System.Drawing.Color.Maroon
		Me.Label15.Location = New System.Drawing.Point(4, 273)
		Me.Label15.Name = "Label15"
		Me.Label15.Size = New System.Drawing.Size(113, 18)
		Me.Label15.TabIndex = 22
		Me.Label15.Text = "Blood Group"
		'
		'Txtadd
		'
		Me.Txtadd.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Txtadd.ForeColor = System.Drawing.Color.Indigo
		Me.Txtadd.Location = New System.Drawing.Point(157, 171)
		Me.Txtadd.Multiline = True
		Me.Txtadd.Name = "Txtadd"
		Me.Txtadd.Size = New System.Drawing.Size(154, 55)
		Me.Txtadd.TabIndex = 4
		'
		'DataGridView1
		'
		Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.DataGridView1.Location = New System.Drawing.Point(8, 414)
		Me.DataGridView1.Name = "DataGridView1"
		Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.DataGridView1.Size = New System.Drawing.Size(1056, 123)
		Me.DataGridView1.TabIndex = 7
		'
		'Button3
		'
		Me.Button3.Font = New System.Drawing.Font("Georgia", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Button3.ForeColor = System.Drawing.Color.Green
		Me.Button3.Location = New System.Drawing.Point(890, 240)
		Me.Button3.Name = "Button3"
		Me.Button3.Size = New System.Drawing.Size(90, 35)
		Me.Button3.TabIndex = 12
		Me.Button3.Text = "Close"
		Me.Button3.UseVisualStyleBackColor = True
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.ForeColor = System.Drawing.Color.Red
		Me.Label2.Location = New System.Drawing.Point(15, 35)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(56, 23)
		Me.Label2.TabIndex = 1
		Me.Label2.Text = "Date"
		'
		'GroupBox1
		'
		Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
		Me.GroupBox1.Controls.Add(Me.datpik)
		Me.GroupBox1.Controls.Add(Me.Label2)
		Me.GroupBox1.Location = New System.Drawing.Point(12, 3)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Size = New System.Drawing.Size(331, 78)
		Me.GroupBox1.TabIndex = 8
		Me.GroupBox1.TabStop = False
		Me.GroupBox1.Text = "Registration Id"
		'
		'datpik
		'
		Me.datpik.Location = New System.Drawing.Point(93, 32)
		Me.datpik.Name = "datpik"
		Me.datpik.Size = New System.Drawing.Size(202, 29)
		Me.datpik.TabIndex = 0
		'
		'txtpid
		'
		Me.txtpid.Location = New System.Drawing.Point(810, 84)
		Me.txtpid.Name = "txtpid"
		Me.txtpid.Size = New System.Drawing.Size(100, 29)
		Me.txtpid.TabIndex = 13
		Me.txtpid.Visible = False
		'
		'PatientRegistration
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 23.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.White
		Me.BackgroundImage = Global.HOSPITALMNAGEMENT.My.Resources.Resources.EFHPA_leaflet_picture_1
		Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
		Me.ClientSize = New System.Drawing.Size(1067, 538)
		Me.Controls.Add(Me.txtpid)
		Me.Controls.Add(Me.GroupBox1)
		Me.Controls.Add(Me.DataGridView1)
		Me.Controls.Add(Me.GroupBox4)
		Me.Controls.Add(Me.Button3)
		Me.Controls.Add(Me.Btnadd)
		Me.Controls.Add(Me.GroupBox3)
		Me.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.ForeColor = System.Drawing.Color.Indigo
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
		Me.Margin = New System.Windows.Forms.Padding(7, 5, 7, 5)
		Me.Name = "PatientRegistration"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "..3"
		Me.GroupBox3.ResumeLayout(False)
		Me.GroupBox3.PerformLayout()
		Me.GroupBox4.ResumeLayout(False)
		Me.GroupBox4.PerformLayout()
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.GroupBox1.ResumeLayout(False)
		Me.GroupBox1.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbbuild As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmbroom As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtprice As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Btnadd As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Cmbgen As System.Windows.Forms.ComboBox
    Friend WithEvents txtname As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtage As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtphone As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Txtdise As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Txtadd As System.Windows.Forms.TextBox
    Friend WithEvents txtblodgrp As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents datpik As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmbroomt As System.Windows.Forms.ComboBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents txtpid As System.Windows.Forms.TextBox
End Class
