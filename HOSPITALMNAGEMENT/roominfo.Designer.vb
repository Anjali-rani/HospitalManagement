<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class roominfo
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
        Me.txtsrchroom = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtprice = New System.Windows.Forms.TextBox()
        Me.txtbed = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbroomt = New System.Windows.Forms.ComboBox()
        Me.cmbroom = New System.Windows.Forms.ComboBox()
        Me.cmbfloor = New System.Windows.Forms.ComboBox()
        Me.cmbbuild = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtstatus = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnupdate = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.txtsearch = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtsrchroom
        '
        Me.txtsrchroom.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsrchroom.ForeColor = System.Drawing.Color.Green
        Me.txtsrchroom.FormattingEnabled = True
        Me.txtsrchroom.Items.AddRange(New Object() {"Block A", "Block B", "Block C"})
        Me.txtsrchroom.Location = New System.Drawing.Point(180, 20)
        Me.txtsrchroom.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtsrchroom.Name = "txtsrchroom"
        Me.txtsrchroom.Size = New System.Drawing.Size(162, 31)
        Me.txtsrchroom.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Green
        Me.Label1.Location = New System.Drawing.Point(9, 20)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 23)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Building no."
        '
        'txtprice
        '
        Me.txtprice.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtprice.ForeColor = System.Drawing.Color.Green
        Me.txtprice.Location = New System.Drawing.Point(180, 377)
        Me.txtprice.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtprice.Name = "txtprice"
        Me.txtprice.Size = New System.Drawing.Size(273, 29)
        Me.txtprice.TabIndex = 25
        '
        'txtbed
        '
        Me.txtbed.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbed.ForeColor = System.Drawing.Color.Green
        Me.txtbed.Location = New System.Drawing.Point(180, 327)
        Me.txtbed.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtbed.Name = "txtbed"
        Me.txtbed.Size = New System.Drawing.Size(273, 29)
        Me.txtbed.TabIndex = 24
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Green
        Me.Label6.Location = New System.Drawing.Point(9, 275)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(121, 23)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Room Type"
        '
        'cmbroomt
        '
        Me.cmbroomt.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbroomt.ForeColor = System.Drawing.Color.Green
        Me.cmbroomt.FormattingEnabled = True
        Me.cmbroomt.Location = New System.Drawing.Point(180, 267)
        Me.cmbroomt.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmbroomt.Name = "cmbroomt"
        Me.cmbroomt.Size = New System.Drawing.Size(273, 31)
        Me.cmbroomt.TabIndex = 22
        '
        'cmbroom
        '
        Me.cmbroom.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbroom.ForeColor = System.Drawing.Color.Green
        Me.cmbroom.FormattingEnabled = True
        Me.cmbroom.Items.AddRange(New Object() {"102", "202", "203", "105", "106"})
        Me.cmbroom.Location = New System.Drawing.Point(180, 217)
        Me.cmbroom.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmbroom.Name = "cmbroom"
        Me.cmbroom.Size = New System.Drawing.Size(273, 31)
        Me.cmbroom.TabIndex = 21
        '
        'cmbfloor
        '
        Me.cmbfloor.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbfloor.ForeColor = System.Drawing.Color.Green
        Me.cmbfloor.FormattingEnabled = True
        Me.cmbfloor.Items.AddRange(New Object() {"1", "2", "3", "4", "5"})
        Me.cmbfloor.Location = New System.Drawing.Point(180, 157)
        Me.cmbfloor.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmbfloor.Name = "cmbfloor"
        Me.cmbfloor.Size = New System.Drawing.Size(273, 31)
        Me.cmbfloor.TabIndex = 20
        '
        'cmbbuild
        '
        Me.cmbbuild.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbbuild.ForeColor = System.Drawing.Color.Green
        Me.cmbbuild.FormattingEnabled = True
        Me.cmbbuild.Items.AddRange(New Object() {"Block A", "Block B", "Block C"})
        Me.cmbbuild.Location = New System.Drawing.Point(180, 98)
        Me.cmbbuild.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmbbuild.Name = "cmbbuild"
        Me.cmbbuild.Size = New System.Drawing.Size(273, 31)
        Me.cmbbuild.TabIndex = 19
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Green
        Me.Label5.Location = New System.Drawing.Point(13, 377)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(107, 23)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "unit Price"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Green
        Me.Label4.Location = New System.Drawing.Point(13, 327)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 23)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "No.of bed"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Green
        Me.Label3.Location = New System.Drawing.Point(9, 217)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 23)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Room no."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Green
        Me.Label2.Location = New System.Drawing.Point(9, 157)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 23)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Floor no."
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Green
        Me.Label7.Location = New System.Drawing.Point(13, 98)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(131, 23)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Building no."
        '
        'txtstatus
        '
        Me.txtstatus.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtstatus.ForeColor = System.Drawing.Color.Green
        Me.txtstatus.Location = New System.Drawing.Point(180, 430)
        Me.txtstatus.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtstatus.Name = "txtstatus"
        Me.txtstatus.Size = New System.Drawing.Size(273, 29)
        Me.txtstatus.TabIndex = 27
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Green
        Me.Label8.Location = New System.Drawing.Point(30, 436)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 23)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "Status"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Green
        Me.Button1.Location = New System.Drawing.Point(7, 477)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(123, 42)
        Me.Button1.TabIndex = 30
        Me.Button1.Text = "New"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnupdate
        '
        Me.btnupdate.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnupdate.ForeColor = System.Drawing.Color.Green
        Me.btnupdate.Location = New System.Drawing.Point(150, 477)
        Me.btnupdate.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(111, 42)
        Me.btnupdate.TabIndex = 31
        Me.btnupdate.Text = "update"
        Me.btnupdate.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Green
        Me.Button3.Location = New System.Drawing.Point(292, 477)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(110, 42)
        Me.Button3.TabIndex = 32
        Me.Button3.Text = "Delete"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.Green
        Me.Button4.Location = New System.Drawing.Point(441, 477)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(105, 42)
        Me.Button4.TabIndex = 33
        Me.Button4.Text = "close"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'txtsearch
        '
        Me.txtsearch.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsearch.ForeColor = System.Drawing.Color.Green
        Me.txtsearch.Location = New System.Drawing.Point(410, 20)
        Me.txtsearch.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(118, 31)
        Me.txtsearch.TabIndex = 34
        Me.txtsearch.Text = "Search"
        Me.txtsearch.UseVisualStyleBackColor = True
        '
        'roominfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGreen
        Me.BackgroundImage = Global.HOSPITALMNAGEMENT.My.Resources.Resources.hospital_ward_beds_medical_equipment_interior_new_empty_room_752240971
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(683, 521)
        Me.Controls.Add(Me.txtsearch)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.btnupdate)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtstatus)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtprice)
        Me.Controls.Add(Me.txtbed)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cmbroomt)
        Me.Controls.Add(Me.cmbroom)
        Me.Controls.Add(Me.cmbfloor)
        Me.Controls.Add(Me.cmbbuild)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtsrchroom)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "roominfo"
        Me.Text = "Form26"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtsrchroom As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtprice As System.Windows.Forms.TextBox
    Friend WithEvents txtbed As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmbroomt As System.Windows.Forms.ComboBox
    Friend WithEvents cmbroom As System.Windows.Forms.ComboBox
    Friend WithEvents cmbfloor As System.Windows.Forms.ComboBox
    Friend WithEvents cmbbuild As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtstatus As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnupdate As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents txtsearch As System.Windows.Forms.Button
End Class
