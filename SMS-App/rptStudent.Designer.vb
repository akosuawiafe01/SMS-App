<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class rptStudent
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.FirstNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OtherNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DeptNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HallNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CollegeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GenderDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProgrammeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AcademicLevelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StudentIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StudentListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SMS_DataSet = New SMS_App.SMS_DataSet()
        Me.Student_ListTableAdapter = New SMS_App.SMS_DataSetTableAdapters.Student_ListTableAdapter()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SMS_DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(764, 413)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(86, 25)
        Me.Button1.TabIndex = 32
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FirstNameDataGridViewTextBoxColumn, Me.LastNameDataGridViewTextBoxColumn, Me.OtherNameDataGridViewTextBoxColumn, Me.DeptNameDataGridViewTextBoxColumn, Me.HallNameDataGridViewTextBoxColumn, Me.CollegeDataGridViewTextBoxColumn, Me.GenderDataGridViewTextBoxColumn, Me.ProgrammeDataGridViewTextBoxColumn, Me.AcademicLevelDataGridViewTextBoxColumn, Me.StudentIDDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.StudentListBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(6, 143)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(735, 377)
        Me.DataGridView1.TabIndex = 31
        '
        'FirstNameDataGridViewTextBoxColumn
        '
        Me.FirstNameDataGridViewTextBoxColumn.DataPropertyName = "firstName"
        Me.FirstNameDataGridViewTextBoxColumn.HeaderText = "firstName"
        Me.FirstNameDataGridViewTextBoxColumn.Name = "FirstNameDataGridViewTextBoxColumn"
        '
        'LastNameDataGridViewTextBoxColumn
        '
        Me.LastNameDataGridViewTextBoxColumn.DataPropertyName = "lastName"
        Me.LastNameDataGridViewTextBoxColumn.HeaderText = "lastName"
        Me.LastNameDataGridViewTextBoxColumn.Name = "LastNameDataGridViewTextBoxColumn"
        '
        'OtherNameDataGridViewTextBoxColumn
        '
        Me.OtherNameDataGridViewTextBoxColumn.DataPropertyName = "otherName"
        Me.OtherNameDataGridViewTextBoxColumn.HeaderText = "otherName"
        Me.OtherNameDataGridViewTextBoxColumn.Name = "OtherNameDataGridViewTextBoxColumn"
        '
        'DeptNameDataGridViewTextBoxColumn
        '
        Me.DeptNameDataGridViewTextBoxColumn.DataPropertyName = "deptName"
        Me.DeptNameDataGridViewTextBoxColumn.HeaderText = "deptName"
        Me.DeptNameDataGridViewTextBoxColumn.Name = "DeptNameDataGridViewTextBoxColumn"
        '
        'HallNameDataGridViewTextBoxColumn
        '
        Me.HallNameDataGridViewTextBoxColumn.DataPropertyName = "hallName"
        Me.HallNameDataGridViewTextBoxColumn.HeaderText = "hallName"
        Me.HallNameDataGridViewTextBoxColumn.Name = "HallNameDataGridViewTextBoxColumn"
        '
        'CollegeDataGridViewTextBoxColumn
        '
        Me.CollegeDataGridViewTextBoxColumn.DataPropertyName = "college"
        Me.CollegeDataGridViewTextBoxColumn.HeaderText = "college"
        Me.CollegeDataGridViewTextBoxColumn.Name = "CollegeDataGridViewTextBoxColumn"
        '
        'GenderDataGridViewTextBoxColumn
        '
        Me.GenderDataGridViewTextBoxColumn.DataPropertyName = "gender"
        Me.GenderDataGridViewTextBoxColumn.HeaderText = "gender"
        Me.GenderDataGridViewTextBoxColumn.Name = "GenderDataGridViewTextBoxColumn"
        '
        'ProgrammeDataGridViewTextBoxColumn
        '
        Me.ProgrammeDataGridViewTextBoxColumn.DataPropertyName = "programme"
        Me.ProgrammeDataGridViewTextBoxColumn.HeaderText = "programme"
        Me.ProgrammeDataGridViewTextBoxColumn.Name = "ProgrammeDataGridViewTextBoxColumn"
        '
        'AcademicLevelDataGridViewTextBoxColumn
        '
        Me.AcademicLevelDataGridViewTextBoxColumn.DataPropertyName = "academicLevel"
        Me.AcademicLevelDataGridViewTextBoxColumn.HeaderText = "academicLevel"
        Me.AcademicLevelDataGridViewTextBoxColumn.Name = "AcademicLevelDataGridViewTextBoxColumn"
        '
        'StudentIDDataGridViewTextBoxColumn
        '
        Me.StudentIDDataGridViewTextBoxColumn.DataPropertyName = "studentID"
        Me.StudentIDDataGridViewTextBoxColumn.HeaderText = "studentID"
        Me.StudentIDDataGridViewTextBoxColumn.Name = "StudentIDDataGridViewTextBoxColumn"
        '
        'StudentListBindingSource
        '
        Me.StudentListBindingSource.DataMember = "Student_List"
        Me.StudentListBindingSource.DataSource = Me.SMS_DataSet
        '
        'SMS_DataSet
        '
        Me.SMS_DataSet.DataSetName = "SMS_DataSet"
        Me.SMS_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Student_ListTableAdapter
        '
        Me.Student_ListTableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(877, 96)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "WAN College" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Students List"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'rptStudent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(877, 532)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "rptStudent"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "rptStudent"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SMS_DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents SMS_DataSet As SMS_DataSet
    Friend WithEvents StudentListBindingSource As BindingSource
    Friend WithEvents Student_ListTableAdapter As SMS_DataSetTableAdapters.Student_ListTableAdapter
    Friend WithEvents FirstNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LastNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OtherNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DeptNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HallNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CollegeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GenderDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProgrammeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AcademicLevelDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StudentIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
End Class
