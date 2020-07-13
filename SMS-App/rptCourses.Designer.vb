<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class rptCourses
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.StudIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CourseCodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CourseTitleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RptCoursesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SMS_DataSet = New SMS_App.SMS_DataSet()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.RptCoursesTableAdapter = New SMS_App.SMS_DataSetTableAdapters.rptCoursesTableAdapter()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RptCoursesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SMS_DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.StudIDDataGridViewTextBoxColumn, Me.CourseCodeDataGridViewTextBoxColumn, Me.CourseTitleDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.RptCoursesBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(6, 90)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(735, 377)
        Me.DataGridView1.TabIndex = 0
        '
        'StudIDDataGridViewTextBoxColumn
        '
        Me.StudIDDataGridViewTextBoxColumn.DataPropertyName = "studID"
        Me.StudIDDataGridViewTextBoxColumn.HeaderText = "studID"
        Me.StudIDDataGridViewTextBoxColumn.Name = "StudIDDataGridViewTextBoxColumn"
        Me.StudIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CourseCodeDataGridViewTextBoxColumn
        '
        Me.CourseCodeDataGridViewTextBoxColumn.DataPropertyName = "courseCode"
        Me.CourseCodeDataGridViewTextBoxColumn.HeaderText = "courseCode"
        Me.CourseCodeDataGridViewTextBoxColumn.Name = "CourseCodeDataGridViewTextBoxColumn"
        Me.CourseCodeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CourseTitleDataGridViewTextBoxColumn
        '
        Me.CourseTitleDataGridViewTextBoxColumn.DataPropertyName = "courseTitle"
        Me.CourseTitleDataGridViewTextBoxColumn.HeaderText = "courseTitle"
        Me.CourseTitleDataGridViewTextBoxColumn.Name = "CourseTitleDataGridViewTextBoxColumn"
        Me.CourseTitleDataGridViewTextBoxColumn.ReadOnly = True
        '
        'RptCoursesBindingSource
        '
        Me.RptCoursesBindingSource.DataMember = "rptCourses"
        Me.RptCoursesBindingSource.DataSource = Me.SMS_DataSet
        '
        'SMS_DataSet
        '
        Me.SMS_DataSet.DataSetName = "SMS_DataSet"
        Me.SMS_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(775, 413)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(86, 25)
        Me.Button1.TabIndex = 30
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'RptCoursesTableAdapter
        '
        Me.RptCoursesTableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(873, 74)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "WAN College" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Courses Registered"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'rptCourses
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(873, 479)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "rptCourses"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "rptCourses"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RptCoursesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SMS_DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents SMS_DataSet As SMS_DataSet
    Friend WithEvents RptCoursesBindingSource As BindingSource
    Friend WithEvents RptCoursesTableAdapter As SMS_DataSetTableAdapters.rptCoursesTableAdapter
    Friend WithEvents StudIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CourseCodeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CourseTitleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
End Class
