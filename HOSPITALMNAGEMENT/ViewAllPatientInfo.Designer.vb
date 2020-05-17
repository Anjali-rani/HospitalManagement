<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewAllPatientInfo
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.PIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GenderDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AgeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PhoneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiseaseDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BloodgroupDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PatientregisBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HospitalManagementdbDataSet = New HOSPITALMNAGEMENT.HospitalManagementdbDataSet()
        Me.PatientregisTableAdapter = New HOSPITALMNAGEMENT.HospitalManagementdbDataSetTableAdapters.patientregisTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PatientregisBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HospitalManagementdbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PIDDataGridViewTextBoxColumn, Me.NameDataGridViewTextBoxColumn, Me.GenderDataGridViewTextBoxColumn, Me.AgeDataGridViewTextBoxColumn, Me.PhoneDataGridViewTextBoxColumn, Me.AddressDataGridViewTextBoxColumn, Me.DiseaseDataGridViewTextBoxColumn, Me.BloodgroupDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.PatientregisBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(20, 18)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(845, 208)
        Me.DataGridView1.TabIndex = 0
        '
        'PIDDataGridViewTextBoxColumn
        '
        Me.PIDDataGridViewTextBoxColumn.DataPropertyName = "PID"
        Me.PIDDataGridViewTextBoxColumn.HeaderText = "PID"
        Me.PIDDataGridViewTextBoxColumn.Name = "PIDDataGridViewTextBoxColumn"
        Me.PIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "Name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "Name"
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        '
        'GenderDataGridViewTextBoxColumn
        '
        Me.GenderDataGridViewTextBoxColumn.DataPropertyName = "Gender"
        Me.GenderDataGridViewTextBoxColumn.HeaderText = "Gender"
        Me.GenderDataGridViewTextBoxColumn.Name = "GenderDataGridViewTextBoxColumn"
        '
        'AgeDataGridViewTextBoxColumn
        '
        Me.AgeDataGridViewTextBoxColumn.DataPropertyName = "Age"
        Me.AgeDataGridViewTextBoxColumn.HeaderText = "Age"
        Me.AgeDataGridViewTextBoxColumn.Name = "AgeDataGridViewTextBoxColumn"
        '
        'PhoneDataGridViewTextBoxColumn
        '
        Me.PhoneDataGridViewTextBoxColumn.DataPropertyName = "Phone"
        Me.PhoneDataGridViewTextBoxColumn.HeaderText = "Phone"
        Me.PhoneDataGridViewTextBoxColumn.Name = "PhoneDataGridViewTextBoxColumn"
        '
        'AddressDataGridViewTextBoxColumn
        '
        Me.AddressDataGridViewTextBoxColumn.DataPropertyName = "Address"
        Me.AddressDataGridViewTextBoxColumn.HeaderText = "Address"
        Me.AddressDataGridViewTextBoxColumn.Name = "AddressDataGridViewTextBoxColumn"
        '
        'DiseaseDataGridViewTextBoxColumn
        '
        Me.DiseaseDataGridViewTextBoxColumn.DataPropertyName = "Disease"
        Me.DiseaseDataGridViewTextBoxColumn.HeaderText = "Disease"
        Me.DiseaseDataGridViewTextBoxColumn.Name = "DiseaseDataGridViewTextBoxColumn"
        '
        'BloodgroupDataGridViewTextBoxColumn
        '
        Me.BloodgroupDataGridViewTextBoxColumn.DataPropertyName = "Bloodgroup"
        Me.BloodgroupDataGridViewTextBoxColumn.HeaderText = "Bloodgroup"
        Me.BloodgroupDataGridViewTextBoxColumn.Name = "BloodgroupDataGridViewTextBoxColumn"
        '
        'PatientregisBindingSource
        '
        Me.PatientregisBindingSource.DataMember = "patientregis"
        Me.PatientregisBindingSource.DataSource = Me.HospitalManagementdbDataSet
        '
        'HospitalManagementdbDataSet
        '
        Me.HospitalManagementdbDataSet.DataSetName = "HospitalManagementdbDataSet"
        Me.HospitalManagementdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PatientregisTableAdapter
        '
        Me.PatientregisTableAdapter.ClearBeforeFill = True
        '
        'ViewAllPatientInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(886, 248)
        Me.Controls.Add(Me.DataGridView1)
        Me.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ViewAllPatientInfo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ViewAllPatientInfo"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PatientregisBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HospitalManagementdbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents HospitalManagementdbDataSet As HOSPITALMNAGEMENT.HospitalManagementdbDataSet
    Friend WithEvents PatientregisBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PatientregisTableAdapter As HOSPITALMNAGEMENT.HospitalManagementdbDataSetTableAdapters.patientregisTableAdapter
    Friend WithEvents PIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GenderDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AgeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PhoneDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AddressDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DiseaseDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BloodgroupDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
