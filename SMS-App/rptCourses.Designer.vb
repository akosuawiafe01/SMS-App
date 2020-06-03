<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class rptCourses
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
        Me._SMS_DbDataSet1 = New SMS_App._SMS_DbDataSet1()
        Me.CourseBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CourseTableAdapter = New SMS_App._SMS_DbDataSet1TableAdapters.CourseTableAdapter()
        Me.CourseCodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CourseTitleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LecturerIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SemesterNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CreditHoursDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AcademicYearDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._SMS_DbDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CourseBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CourseCodeDataGridViewTextBoxColumn, Me.CourseTitleDataGridViewTextBoxColumn, Me.LecturerIDDataGridViewTextBoxColumn, Me.SemesterNoDataGridViewTextBoxColumn, Me.CreditHoursDataGridViewTextBoxColumn, Me.AcademicYearDataGridViewTextBoxColumn, Me.StatusDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.CourseBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 61)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(735, 172)
        Me.DataGridView1.TabIndex = 0
        '
        '_SMS_DbDataSet1
        '
        Me._SMS_DbDataSet1.DataSetName = "_SMS_DbDataSet1"
        Me._SMS_DbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CourseBindingSource
        '
        Me.CourseBindingSource.DataMember = "Course"
        Me.CourseBindingSource.DataSource = Me._SMS_DbDataSet1
        '
        'CourseTableAdapter
        '
        Me.CourseTableAdapter.ClearBeforeFill = True
        '
        'CourseCodeDataGridViewTextBoxColumn
        '
        Me.CourseCodeDataGridViewTextBoxColumn.DataPropertyName = "courseCode"
        Me.CourseCodeDataGridViewTextBoxColumn.HeaderText = "courseCode"
        Me.CourseCodeDataGridViewTextBoxColumn.Name = "CourseCodeDataGridViewTextBoxColumn"
        '
        'CourseTitleDataGridViewTextBoxColumn
        '
        Me.CourseTitleDataGridViewTextBoxColumn.DataPropertyName = "courseTitle"
        Me.CourseTitleDataGridViewTextBoxColumn.HeaderText = "courseTitle"
        Me.CourseTitleDataGridViewTextBoxColumn.Name = "CourseTitleDataGridViewTextBoxColumn"
        '
        'LecturerIDDataGridViewTextBoxColumn
        '
        Me.LecturerIDDataGridViewTextBoxColumn.DataPropertyName = "lecturerID"
        Me.LecturerIDDataGridViewTextBoxColumn.HeaderText = "lecturerID"
        Me.LecturerIDDataGridViewTextBoxColumn.Name = "LecturerIDDataGridViewTextBoxColumn"
        '
        'SemesterNoDataGridViewTextBoxColumn
        '
        Me.SemesterNoDataGridViewTextBoxColumn.DataPropertyName = "semesterNo"
        Me.SemesterNoDataGridViewTextBoxColumn.HeaderText = "semesterNo"
        Me.SemesterNoDataGridViewTextBoxColumn.Name = "SemesterNoDataGridViewTextBoxColumn"
        '
        'CreditHoursDataGridViewTextBoxColumn
        '
        Me.CreditHoursDataGridViewTextBoxColumn.DataPropertyName = "creditHours"
        Me.CreditHoursDataGridViewTextBoxColumn.HeaderText = "creditHours"
        Me.CreditHoursDataGridViewTextBoxColumn.Name = "CreditHoursDataGridViewTextBoxColumn"
        '
        'AcademicYearDataGridViewTextBoxColumn
        '
        Me.AcademicYearDataGridViewTextBoxColumn.DataPropertyName = "academicYear"
        Me.AcademicYearDataGridViewTextBoxColumn.HeaderText = "academicYear"
        Me.AcademicYearDataGridViewTextBoxColumn.Name = "AcademicYearDataGridViewTextBoxColumn"
        '
        'StatusDataGridViewTextBoxColumn
        '
        Me.StatusDataGridViewTextBoxColumn.DataPropertyName = "status"
        Me.StatusDataGridViewTextBoxColumn.HeaderText = "status"
        Me.StatusDataGridViewTextBoxColumn.Name = "StatusDataGridViewTextBoxColumn"
        '
        'rptCourses
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "rptCourses"
        Me.Text = "rptCourses"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._SMS_DbDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CourseBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents _SMS_DbDataSet1 As _SMS_DbDataSet1
    Friend WithEvents CourseBindingSource As BindingSource
    Friend WithEvents CourseTableAdapter As _SMS_DbDataSet1TableAdapters.CourseTableAdapter
    Friend WithEvents CourseCodeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CourseTitleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LecturerIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SemesterNoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CreditHoursDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AcademicYearDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
