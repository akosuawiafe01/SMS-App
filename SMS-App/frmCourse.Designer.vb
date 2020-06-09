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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtStudeID = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbAcaYear = New System.Windows.Forms.ComboBox()
        Me.cmbSemester = New System.Windows.Forms.ComboBox()
        Me.cmbCreditCourses = New System.Windows.Forms.ComboBox()
        Me.CourseBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SMS_DataSet = New SMS_App.SMS_DataSet()
        Me.cmbCourseTitle = New System.Windows.Forms.ComboBox()
        Me.cmbCourseCode = New System.Windows.Forms.ComboBox()
        Me.btnRegisterCourse = New System.Windows.Forms.Button()
        Me.btnCancelCourse = New System.Windows.Forms.Button()
        Me.CourseTableAdapter = New SMS_App.SMS_DataSetTableAdapters.CourseTableAdapter()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cmbHours2 = New System.Windows.Forms.ComboBox()
        Me.cmbCours2 = New System.Windows.Forms.ComboBox()
        Me.cmbTitle2 = New System.Windows.Forms.ComboBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.cmbHours3 = New System.Windows.Forms.ComboBox()
        Me.cmbCours3 = New System.Windows.Forms.ComboBox()
        Me.cmbTitle3 = New System.Windows.Forms.ComboBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.CourseBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SMS_DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
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
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(874, 83)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Semester"
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
        Me.GroupBox1.Controls.Add(Me.txtStudeID)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.cmbAcaYear)
        Me.GroupBox1.Controls.Add(Me.cmbSemester)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
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
        'txtStudeID
        '
        Me.txtStudeID.Location = New System.Drawing.Point(982, 19)
        Me.txtStudeID.Name = "txtStudeID"
        Me.txtStudeID.Size = New System.Drawing.Size(159, 20)
        Me.txtStudeID.TabIndex = 18
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(874, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 13)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Student ID"
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
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.cmbCreditCourses)
        Me.GroupBox2.Controls.Add(Me.cmbCourseCode)
        Me.GroupBox2.Controls.Add(Me.cmbCourseTitle)
        Me.GroupBox2.Location = New System.Drawing.Point(14, 133)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(354, 194)
        Me.GroupBox2.TabIndex = 17
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Option 1"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.cmbHours2)
        Me.GroupBox3.Controls.Add(Me.cmbCours2)
        Me.GroupBox3.Controls.Add(Me.cmbTitle2)
        Me.GroupBox3.Location = New System.Drawing.Point(408, 133)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(354, 194)
        Me.GroupBox3.TabIndex = 18
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Option 2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Course Code"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 140)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(65, 13)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Credit Hours"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(8, 104)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(63, 13)
        Me.Label12.TabIndex = 9
        Me.Label12.Text = "Course Title"
        '
        'cmbHours2
        '
        Me.cmbHours2.DataSource = Me.CourseBindingSource
        Me.cmbHours2.DisplayMember = "creditHours"
        Me.cmbHours2.FormattingEnabled = True
        Me.cmbHours2.Location = New System.Drawing.Point(188, 137)
        Me.cmbHours2.Name = "cmbHours2"
        Me.cmbHours2.Size = New System.Drawing.Size(159, 21)
        Me.cmbHours2.TabIndex = 12
        Me.cmbHours2.ValueMember = "creditHours"
        '
        'cmbCours2
        '
        Me.cmbCours2.DataSource = Me.CourseBindingSource
        Me.cmbCours2.DisplayMember = "courseCode"
        Me.cmbCours2.FormattingEnabled = True
        Me.cmbCours2.Location = New System.Drawing.Point(188, 60)
        Me.cmbCours2.Name = "cmbCours2"
        Me.cmbCours2.Size = New System.Drawing.Size(159, 21)
        Me.cmbCours2.TabIndex = 10
        Me.cmbCours2.ValueMember = "courseCode"
        '
        'cmbTitle2
        '
        Me.cmbTitle2.DataSource = Me.CourseBindingSource
        Me.cmbTitle2.DisplayMember = "courseTitle"
        Me.cmbTitle2.FormattingEnabled = True
        Me.cmbTitle2.Location = New System.Drawing.Point(188, 96)
        Me.cmbTitle2.Name = "cmbTitle2"
        Me.cmbTitle2.Size = New System.Drawing.Size(159, 21)
        Me.cmbTitle2.TabIndex = 11
        Me.cmbTitle2.ValueMember = "courseTitle"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Controls.Add(Me.Label15)
        Me.GroupBox4.Controls.Add(Me.Label17)
        Me.GroupBox4.Controls.Add(Me.cmbHours3)
        Me.GroupBox4.Controls.Add(Me.cmbCours3)
        Me.GroupBox4.Controls.Add(Me.cmbTitle3)
        Me.GroupBox4.Location = New System.Drawing.Point(802, 133)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(354, 194)
        Me.GroupBox4.TabIndex = 18
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Option 3"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(6, 68)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(68, 13)
        Me.Label13.TabIndex = 1
        Me.Label13.Text = "Course Code"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(6, 140)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(65, 13)
        Me.Label15.TabIndex = 8
        Me.Label15.Text = "Credit Hours"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(8, 104)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(63, 13)
        Me.Label17.TabIndex = 9
        Me.Label17.Text = "Course Title"
        '
        'cmbHours3
        '
        Me.cmbHours3.DataSource = Me.CourseBindingSource
        Me.cmbHours3.DisplayMember = "creditHours"
        Me.cmbHours3.FormattingEnabled = True
        Me.cmbHours3.Location = New System.Drawing.Point(188, 137)
        Me.cmbHours3.Name = "cmbHours3"
        Me.cmbHours3.Size = New System.Drawing.Size(159, 21)
        Me.cmbHours3.TabIndex = 12
        Me.cmbHours3.ValueMember = "creditHours"
        '
        'cmbCours3
        '
        Me.cmbCours3.DataSource = Me.CourseBindingSource
        Me.cmbCours3.DisplayMember = "courseCode"
        Me.cmbCours3.FormattingEnabled = True
        Me.cmbCours3.Location = New System.Drawing.Point(188, 60)
        Me.cmbCours3.Name = "cmbCours3"
        Me.cmbCours3.Size = New System.Drawing.Size(159, 21)
        Me.cmbCours3.TabIndex = 10
        Me.cmbCours3.ValueMember = "courseCode"
        '
        'cmbTitle3
        '
        Me.cmbTitle3.DataSource = Me.CourseBindingSource
        Me.cmbTitle3.DisplayMember = "courseTitle"
        Me.cmbTitle3.FormattingEnabled = True
        Me.cmbTitle3.Location = New System.Drawing.Point(188, 96)
        Me.cmbTitle3.Name = "cmbTitle3"
        Me.cmbTitle3.Size = New System.Drawing.Size(159, 21)
        Me.cmbTitle3.TabIndex = 11
        Me.cmbTitle3.ValueMember = "courseTitle"
        '
        'frmCourse
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1261, 540)
        Me.Controls.Add(Me.btnCancelCourse)
        Me.Controls.Add(Me.btnRegisterCourse)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmCourse"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmCourse"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.CourseBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SMS_DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
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
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents cmbHours3 As ComboBox
    Friend WithEvents cmbCours3 As ComboBox
    Friend WithEvents cmbTitle3 As ComboBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents cmbHours2 As ComboBox
    Friend WithEvents cmbCours2 As ComboBox
    Friend WithEvents cmbTitle2 As ComboBox
End Class
