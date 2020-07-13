<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCourse
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtStudeID = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbAcaYear = New System.Windows.Forms.ComboBox()
        Me.cmbSemester = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmbCreditCourses = New System.Windows.Forms.ComboBox()
        Me.CourseBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SMS_DataSet = New SMS_App.SMS_DataSet()
        Me.cmbCourseCode = New System.Windows.Forms.ComboBox()
        Me.cmbCourseTitle = New System.Windows.Forms.ComboBox()
        Me.btnRegisterCourse = New System.Windows.Forms.Button()
        Me.btnCancelCourse = New System.Windows.Forms.Button()
        Me.CourseTableAdapter = New SMS_App.SMS_DataSetTableAdapters.CourseTableAdapter()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.CourseBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SMS_DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Course Code"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(8, 137)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 13)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Credit Hours"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(8, 104)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(63, 13)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Course Title"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtStudeID)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cmbAcaYear)
        Me.GroupBox1.Controls.Add(Me.cmbSemester)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox1.Location = New System.Drawing.Point(-2, 155)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1205, 353)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Course Registration"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(864, 91)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Semester"
        '
        'txtStudeID
        '
        Me.txtStudeID.Enabled = False
        Me.txtStudeID.Location = New System.Drawing.Point(982, 19)
        Me.txtStudeID.Name = "txtStudeID"
        Me.txtStudeID.Size = New System.Drawing.Size(159, 20)
        Me.txtStudeID.TabIndex = 18
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(864, 49)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 13)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Academic Year"
        '
        'cmbAcaYear
        '
        Me.cmbAcaYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAcaYear.FormattingEnabled = True
        Me.cmbAcaYear.Items.AddRange(New Object() {"2016/2017", "2017/2018", "2018/2019", "2019/2020", "2020/2021", "2021/2022", "2022/2023", "2023/2024", "2024/2025"})
        Me.cmbAcaYear.Location = New System.Drawing.Point(982, 49)
        Me.cmbAcaYear.Name = "cmbAcaYear"
        Me.cmbAcaYear.Size = New System.Drawing.Size(159, 21)
        Me.cmbAcaYear.TabIndex = 15
        '
        'cmbSemester
        '
        Me.cmbSemester.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSemester.FormattingEnabled = True
        Me.cmbSemester.Items.AddRange(New Object() {"1", "2"})
        Me.cmbSemester.Location = New System.Drawing.Point(982, 83)
        Me.cmbSemester.Name = "cmbSemester"
        Me.cmbSemester.Size = New System.Drawing.Size(159, 21)
        Me.cmbSemester.TabIndex = 14
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(864, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 13)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Student ID"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.cmbCreditCourses)
        Me.GroupBox2.Controls.Add(Me.cmbCourseCode)
        Me.GroupBox2.Controls.Add(Me.cmbCourseTitle)
        Me.GroupBox2.Location = New System.Drawing.Point(221, 115)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(552, 194)
        Me.GroupBox2.TabIndex = 17
        Me.GroupBox2.TabStop = False
        '
        'cmbCreditCourses
        '
        Me.cmbCreditCourses.DataSource = Me.CourseBindingSource
        Me.cmbCreditCourses.DisplayMember = "creditHours"
        Me.cmbCreditCourses.FormattingEnabled = True
        Me.cmbCreditCourses.Location = New System.Drawing.Point(188, 137)
        Me.cmbCreditCourses.Name = "cmbCreditCourses"
        Me.cmbCreditCourses.Size = New System.Drawing.Size(159, 21)
        Me.cmbCreditCourses.TabIndex = 12
        Me.cmbCreditCourses.ValueMember = "creditHours"
        '
        'CourseBindingSource
        '
        Me.CourseBindingSource.DataMember = "Course"
        Me.CourseBindingSource.DataSource = Me.SMS_DataSet
        '
        'SMS_DataSet
        '
        Me.SMS_DataSet.DataSetName = "SMS_DataSet"
        Me.SMS_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cmbCourseCode
        '
        Me.cmbCourseCode.DataSource = Me.CourseBindingSource
        Me.cmbCourseCode.DisplayMember = "courseCode"
        Me.cmbCourseCode.FormattingEnabled = True
        Me.cmbCourseCode.Location = New System.Drawing.Point(188, 60)
        Me.cmbCourseCode.Name = "cmbCourseCode"
        Me.cmbCourseCode.Size = New System.Drawing.Size(159, 21)
        Me.cmbCourseCode.TabIndex = 10
        Me.cmbCourseCode.ValueMember = "courseCode"
        '
        'cmbCourseTitle
        '
        Me.cmbCourseTitle.DataSource = Me.CourseBindingSource
        Me.cmbCourseTitle.DisplayMember = "courseTitle"
        Me.cmbCourseTitle.FormattingEnabled = True
        Me.cmbCourseTitle.Location = New System.Drawing.Point(188, 96)
        Me.cmbCourseTitle.Name = "cmbCourseTitle"
        Me.cmbCourseTitle.Size = New System.Drawing.Size(159, 21)
        Me.cmbCourseTitle.TabIndex = 11
        Me.cmbCourseTitle.ValueMember = "courseTitle"
        '
        'btnRegisterCourse
        '
        Me.btnRegisterCourse.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRegisterCourse.Location = New System.Drawing.Point(433, 514)
        Me.btnRegisterCourse.Name = "btnRegisterCourse"
        Me.btnRegisterCourse.Size = New System.Drawing.Size(75, 23)
        Me.btnRegisterCourse.TabIndex = 12
        Me.btnRegisterCourse.Text = "Save"
        Me.btnRegisterCourse.UseVisualStyleBackColor = True
        '
        'btnCancelCourse
        '
        Me.btnCancelCourse.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelCourse.Location = New System.Drawing.Point(628, 514)
        Me.btnCancelCourse.Name = "btnCancelCourse"
        Me.btnCancelCourse.Size = New System.Drawing.Size(83, 22)
        Me.btnCancelCourse.TabIndex = 13
        Me.btnCancelCourse.Text = "Cancel"
        Me.btnCancelCourse.UseVisualStyleBackColor = True
        '
        'CourseTableAdapter
        '
        Me.CourseTableAdapter.ClearBeforeFill = True
        '
        'frmCourse
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1261, 540)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnCancelCourse)
        Me.Controls.Add(Me.btnRegisterCourse)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmCourse"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmCourse"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.CourseBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SMS_DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbAcaYear As ComboBox
    Friend WithEvents cmbSemester As ComboBox
    Friend WithEvents cmbCreditCourses As ComboBox
    Friend WithEvents cmbCourseTitle As ComboBox
    Friend WithEvents cmbCourseCode As ComboBox
    Friend WithEvents btnRegisterCourse As Button
    Friend WithEvents btnCancelCourse As Button
    Friend WithEvents SMS_DataSet As SMS_DataSet
    Friend WithEvents CourseBindingSource As BindingSource
    Friend WithEvents CourseTableAdapter As SMS_DataSetTableAdapters.CourseTableAdapter
    Friend WithEvents txtStudeID As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label1 As Label
End Class
