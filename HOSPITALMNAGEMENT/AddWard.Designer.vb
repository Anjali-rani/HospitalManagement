<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtstatus = New System.Windows.Forms.TextBox()
        Me.btnclose = New System.Windows.Forms.Button()
        Me.btnadd = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.GroupBox1.Controls.Add(Me.txtstatus)
        Me.GroupBox1.Controls.Add(Me.btnclose)
        Me.GroupBox1.Controls.Add(Me.btnadd)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtprice)
        Me.GroupBox1.Controls.Add(Me.txtbed)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.cmbroomt)
        Me.GroupBox1.Controls.Add(Me.cmbroom)
        Me.GroupBox1.Controls.Add(Me.cmbfloor)
        Me.GroupBox1.Controls.Add(Me.cmbbuild)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Green
        Me.GroupBox1.Location = New System.Drawing.Point(69, 96)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(571, 297)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Add new ward"
        '
        'txtstatus
        '
        Me.txtstatus.Location = New System.Drawing.Point(197, 256)
        Me.txtstatus.Name = "txtstatus"
        Me.txtstatus.Size = New System.Drawing.Size(239, 29)
        Me.txtstatus.TabIndex = 15
        '
        'btnclose
        '
        Me.btnclose.Location = New System.Drawing.Point(467, 186)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(100, 39)
        Me.btnclose.TabIndex = 6
        Me.btnclose.Text = "Close"
        Me.btnclose.UseVisualStyleBackColor = True
        '
        'btnadd
        '
        Me.btnadd.Location = New System.Drawing.Point(456, 86)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(111, 39)
        Me.btnadd.TabIndex = 5
        Me.btnadd.Text = "Add"
        Me.btnadd.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Label7.Location = New System.Drawing.Point(44, 256)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 23)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Staus"
        '
        'txtprice
        '
        Me.txtprice.Location = New System.Drawing.Point(197, 221)
        Me.txtprice.Name = "txtprice"
        Me.txtprice.Size = New System.Drawing.Size(239, 29)
        Me.txtprice.TabIndex = 13
        '
        'txtbed
        '
        Me.txtbed.Location = New System.Drawing.Point(197, 186)
        Me.txtbed.Name = "txtbed"
        Me.txtbed.Size = New System.Drawing.Size(239, 29)
        Me.txtbed.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Label6.Location = New System.Drawing.Point(11, 149)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(121, 23)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Room Type"
        '
        'cmbroomt
        '
        Me.cmbroomt.FormattingEnabled = True
        Me.cmbroomt.Items.AddRange(New Object() {"Normal", "Medium", "VIP"})
        Me.cmbroomt.Location = New System.Drawing.Point(197, 149)
        Me.cmbroomt.Name = "cmbroomt"
        Me.cmbroomt.Size = New System.Drawing.Size(239, 31)
        Me.cmbroomt.TabIndex = 10
        '
        'cmbroom
        '
        Me.cmbroom.FormattingEnabled = True
        Me.cmbroom.Items.AddRange(New Object() {"101", "102", "202", "602", "802"})
        Me.cmbroom.Location = New System.Drawing.Point(197, 111)
        Me.cmbroom.Name = "cmbroom"
        Me.cmbroom.Size = New System.Drawing.Size(239, 31)
        Me.cmbroom.TabIndex = 9
        '
        'cmbfloor
        '
        Me.cmbfloor.FormattingEnabled = True
        Me.cmbfloor.Items.AddRange(New Object() {"1", "2", "3", "4", "5"})
        Me.cmbfloor.Location = New System.Drawing.Point(197, 74)
        Me.cmbfloor.Name = "cmbfloor"
        Me.cmbfloor.Size = New System.Drawing.Size(239, 31)
        Me.cmbfloor.TabIndex = 8
        '
        'cmbbuild
        '
        Me.cmbbuild.FormattingEnabled = True
        Me.cmbbuild.Items.AddRange(New Object() {"Block A", "Block B", "Block C", "Block D", "Block E"})
        Me.cmbbuild.Location = New System.Drawing.Point(197, 37)
        Me.cmbbuild.Name = "cmbbuild"
        Me.cmbbuild.Size = New System.Drawing.Size(239, 31)
        Me.cmbbuild.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Label5.Location = New System.Drawing.Point(20, 227)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(107, 23)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "unit Price"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Label4.Location = New System.Drawing.Point(23, 189)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 23)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "No.of bed"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Label3.Location = New System.Drawing.Point(20, 111)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 23)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Room no."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Label2.Location = New System.Drawing.Point(23, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Floor no."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Label1.Location = New System.Drawing.Point(11, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Building no."
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.HOSPITALMNAGEMENT.My.Resources.Resources.stock_photo_hospital_ward_with_beds_and_medical_equipment_106279382
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(699, 497)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(7, 5, 7, 5)
        Me.Name = "Form4"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Addward"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtbed As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmbroomt As System.Windows.Forms.ComboBox
    Friend WithEvents cmbroom As System.Windows.Forms.ComboBox
    Friend WithEvents cmbfloor As System.Windows.Forms.ComboBox
    Friend WithEvents cmbbuild As System.Windows.Forms.ComboBox
    Friend WithEvents btnclose As System.Windows.Forms.Button
    Friend WithEvents btnadd As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtprice As System.Windows.Forms.TextBox
    Friend WithEvents txtstatus As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
