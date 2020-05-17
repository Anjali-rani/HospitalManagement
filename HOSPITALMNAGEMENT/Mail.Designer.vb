<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Mail
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
		Me.Button1 = New System.Windows.Forms.Button()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.PictureBox1 = New System.Windows.Forms.PictureBox()
		Me.txtbody = New System.Windows.Forms.TextBox()
		Me.txtto = New System.Windows.Forms.TextBox()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.txtfrom = New System.Windows.Forms.TextBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.GroupBox1.SuspendLayout()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'GroupBox1
		'
		Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
		Me.GroupBox1.Controls.Add(Me.Button1)
		Me.GroupBox1.Controls.Add(Me.Label3)
		Me.GroupBox1.Controls.Add(Me.PictureBox1)
		Me.GroupBox1.Controls.Add(Me.txtbody)
		Me.GroupBox1.Controls.Add(Me.txtto)
		Me.GroupBox1.Controls.Add(Me.Label2)
		Me.GroupBox1.Controls.Add(Me.txtfrom)
		Me.GroupBox1.Controls.Add(Me.Label1)
		Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.GroupBox1.ForeColor = System.Drawing.Color.LavenderBlush
		Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Size = New System.Drawing.Size(325, 163)
		Me.GroupBox1.TabIndex = 6
		Me.GroupBox1.TabStop = False
		Me.GroupBox1.Text = "Email Services"
		'
		'Button1
		'
		Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Button1.ForeColor = System.Drawing.Color.MediumVioletRed
		Me.Button1.Location = New System.Drawing.Point(67, 130)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(75, 27)
		Me.Button1.TabIndex = 7
		Me.Button1.Text = "Send"
		Me.Button1.UseVisualStyleBackColor = True
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.System
		Me.Label3.Font = New System.Drawing.Font("Georgia", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.ForeColor = System.Drawing.Color.Crimson
		Me.Label3.Location = New System.Drawing.Point(0, 72)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(107, 27)
		Me.Label3.TabIndex = 13
		Me.Label3.Text = "Message"
		'
		'PictureBox1
		'
		Me.PictureBox1.BackgroundImage = Global.HOSPITALMNAGEMENT.My.Resources.Resources.directmail1
		Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.PictureBox1.ErrorImage = Nothing
		Me.PictureBox1.InitialImage = Nothing
		Me.PictureBox1.Location = New System.Drawing.Point(148, 18)
		Me.PictureBox1.Name = "PictureBox1"
		Me.PictureBox1.Size = New System.Drawing.Size(149, 112)
		Me.PictureBox1.TabIndex = 12
		Me.PictureBox1.TabStop = False
		'
		'txtbody
		'
		Me.txtbody.BackColor = System.Drawing.SystemColors.InactiveCaption
		Me.txtbody.Font = New System.Drawing.Font("Georgia", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtbody.ForeColor = System.Drawing.Color.Yellow
		Me.txtbody.Location = New System.Drawing.Point(50, 56)
		Me.txtbody.Multiline = True
		Me.txtbody.Name = "txtbody"
		Me.txtbody.Size = New System.Drawing.Size(92, 56)
		Me.txtbody.TabIndex = 11
		'
		'txtto
		'
		Me.txtto.BackColor = System.Drawing.SystemColors.ScrollBar
		Me.txtto.Font = New System.Drawing.Font("Georgia", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
		Me.txtto.Location = New System.Drawing.Point(50, 38)
		Me.txtto.Name = "txtto"
		Me.txtto.Size = New System.Drawing.Size(92, 31)
		Me.txtto.TabIndex = 9
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.System
		Me.Label2.Font = New System.Drawing.Font("Georgia", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.ForeColor = System.Drawing.Color.Crimson
		Me.Label2.Location = New System.Drawing.Point(6, 45)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(41, 27)
		Me.Label2.TabIndex = 8
		Me.Label2.Text = "To"
		'
		'txtfrom
		'
		Me.txtfrom.BackColor = System.Drawing.SystemColors.InactiveCaption
		Me.txtfrom.Enabled = False
		Me.txtfrom.Font = New System.Drawing.Font("Georgia", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtfrom.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
		Me.txtfrom.Location = New System.Drawing.Point(50, 19)
		Me.txtfrom.Name = "txtfrom"
		Me.txtfrom.Size = New System.Drawing.Size(92, 31)
		Me.txtfrom.TabIndex = 7
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.System
		Me.Label1.Font = New System.Drawing.Font("Georgia", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.ForeColor = System.Drawing.Color.Crimson
		Me.Label1.Location = New System.Drawing.Point(0, 23)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(73, 27)
		Me.Label1.TabIndex = 6
		Me.Label1.Text = "From"
		'
		'Mail
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackgroundImage = Global.HOSPITALMNAGEMENT.My.Resources.Resources.email_newsletter_going_around_the_world2
		Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.ClientSize = New System.Drawing.Size(525, 294)
		Me.Controls.Add(Me.GroupBox1)
		Me.ForeColor = System.Drawing.Color.DarkOliveGreen
		Me.Name = "Mail"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Mail"
		Me.GroupBox1.ResumeLayout(False)
		Me.GroupBox1.PerformLayout()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txtbody As System.Windows.Forms.TextBox
    Friend WithEvents txtto As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtfrom As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
