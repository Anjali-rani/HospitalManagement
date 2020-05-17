<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class For1
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(For1))
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
		Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
		Me.TextBox1 = New System.Windows.Forms.TextBox()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.SuspendLayout()
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(32, 320)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(79, 13)
		Me.Label1.TabIndex = 1
		Me.Label1.Text = "Initializing........."
		'
		'Timer1
		'
		Me.Timer1.Enabled = True
		Me.Timer1.Interval = 50
		'
		'ProgressBar1
		'
		Me.ProgressBar1.BackColor = System.Drawing.Color.Aqua
		Me.ProgressBar1.ForeColor = System.Drawing.Color.Red
		Me.ProgressBar1.Location = New System.Drawing.Point(35, 336)
		Me.ProgressBar1.Name = "ProgressBar1"
		Me.ProgressBar1.Size = New System.Drawing.Size(638, 23)
		Me.ProgressBar1.TabIndex = 2
		'
		'TextBox1
		'
		Me.TextBox1.BackColor = System.Drawing.SystemColors.AppWorkspace
		Me.TextBox1.Font = New System.Drawing.Font("Algerian", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TextBox1.ForeColor = System.Drawing.Color.DarkSlateGray
		Me.TextBox1.Location = New System.Drawing.Point(2, 365)
		Me.TextBox1.Multiline = True
		Me.TextBox1.Name = "TextBox1"
		Me.TextBox1.Size = New System.Drawing.Size(768, 78)
		Me.TextBox1.TabIndex = 3
		Me.TextBox1.Text = resources.GetString("TextBox1.Text")
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.BackColor = System.Drawing.SystemColors.ActiveCaption
		Me.Label2.Font = New System.Drawing.Font("Showcard Gothic", 27.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.ForeColor = System.Drawing.Color.Navy
		Me.Label2.Location = New System.Drawing.Point(54, 30)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(581, 46)
		Me.Label2.TabIndex = 4
		Me.Label2.Text = "WELCOME TO AArpit HOSPITAL"
		'
		'For1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackgroundImage = Global.HOSPITALMNAGEMENT.My.Resources.Resources.hillcrest_hero
		Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
		Me.ClientSize = New System.Drawing.Size(773, 448)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.TextBox1)
		Me.Controls.Add(Me.ProgressBar1)
		Me.Controls.Add(Me.Label1)
		Me.ForeColor = System.Drawing.Color.Black
		Me.Name = "For1"
		Me.Text = "For1"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
