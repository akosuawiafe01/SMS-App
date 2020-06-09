<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCourse
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbAcaYear = New System.Windows.Forms.ComboBox()
        Me.CourseBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SMS_DataSet = New SMS_App.SMS_DataSet()
        Me.cmbSemester = New System.Windows.Forms.ComboBox()
        Me.cmbCreditCourses = New System.Windows.Forms.ComboBox()
        Me.cmbCourseTitle = New System.Windows.Forms.ComboBox()
        Me.cmbCourseCode = New System.Windows.Forms.ComboBox()
        Me.btnRegisterCourse = New System.Windows.Forms.Button()
        Me.btnCancelCourse = New System.Windows.Forms.Button()
        Me.CourseTableAdapter = New SMS_App.SMS_DataSetTableAdapters.CourseTableAdapter()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtStudeID = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.CourseBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SMS_DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1203, 105)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "University of Ghana"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(184, 144)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Course Code"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(191, 253)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Semester"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(184, 216)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 13)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Credit Hours"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(186, 180)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(63, 13)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Course Title"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.SlateGray
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label3.Font = New System.Drawing.Font("Candara", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(0, 105)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(556, 435)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Student Management System " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(9) & "Course Registration"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.txtStudeID)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cmbAcaYear)
        Me.GroupBox1.Controls.Add(Me.cmbSemester)
        Me.GroupBox1.Controls.Add(Me.cmbCreditCourses)
        Me.GroupBox1.Controls.Add(Me.cmbCourseTitle)
        Me.GroupBox1.Controls.Add(Me.cmbCourseCode)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox1.Location = New System.Drawing.Point(562, 105)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(629, 378)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Course Registration"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(186, 297)
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
        Me.cmbAcaYear.Location = New System.Drawing.Point(366, 297)
        Me.cmbAcaYear.Name = "cmbAcaYear"
        Me.cmbAcaYear.Size = New System.Drawing.Size(159, 21)
        Me.cmbAcaYear.TabIndex = 15
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
        'cmbSemester
        '
        Me.cmbSemester.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSemester.FormattingEnabled = True
        Me.cmbSemester.Items.AddRange(New Object() {"1", "2"})
        Me.cmbSemester.Location = New System.Drawing.Point(366, 253)
        Me.cmbSemester.Name = "cmbSemester"
        Me.cmbSemester.Size = New System.Drawing.Size(159, 21)
        Me.cmbSemester.TabIndex = 14
        '
        'cmbCreditCourses
        '
        Me.cmbCreditCourses.DataSource = Me.CourseBindingSource
        Me.cmbCreditCourses.DisplayMember = "creditHours"
        Me.cmbCreditCourses.FormattingEnabled = True
        Me.cmbCreditCourses.Location = New System.Drawing.Point(366, 213)
        Me.cmbCreditCourses.Name = "cmbCreditCourses"
        Me.cmbCreditCourses.Size = New System.Drawing.Size(159, 21)
        Me.cmbCreditCourses.TabIndex = 12
        Me.cmbCreditCourses.ValueMember = "creditHours"
        '
        'cmbCourseTitle
        '
        Me.cmbCourseTitle.DataSource = Me.CourseBindingSource
        Me.cmbCourseTitle.DisplayMember = "courseTitle"
        Me.cmbCourseTitle.FormattingEnabled = True
        Me.cmbCourseTitle.Location = New System.Drawing.Point(366, 172)
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
        Me.cmbCourseCode.Location = New System.Drawing.Point(366, 136)
        Me.cmbCourseCode.Name = "cmbCourseCode"
        Me.cmbCourseCode.Size = New System.Drawing.Size(159, 21)
        Me.cmbCourseCode.TabIndex = 10
        Me.cmbCourseCode.ValueMember = "courseCode"
        '
        'btnRegisterCourse
        '
        Me.btnRegisterCourse.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRegisterCourse.Location = New System.Drawing.Point(979, 513)
        Me.btnRegisterCourse.Name = "btnRegisterCourse"
        Me.btnRegisterCourse.Size = New System.Drawing.Size(75, 23)
        Me.btnRegisterCourse.TabIndex = 12
        Me.btnRegisterCourse.Text = "Save"
        Me.btnRegisterCourse.UseVisualStyleBackColor = True
        '
        'btnCancelCourse
        '
        Me.btnCancelCourse.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelCourse.Location = New System.Drawing.Point(1108, 514)
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
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(187, 100)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 13)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Student ID"
        '
        'txtStudeID
        '
        Me.txtStudeID.Location = New System.Drawing.Point(366, 100)
        Me.txtStudeID.Name = "txtStudeID"
        Me.txtStudeID.Size = New System.Drawing.Size(159, 20)
        Me.txtStudeID.TabIndex = 18
        '
        'frmCourse
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1203, 540)
        Me.Controls.Add(Me.btnCancelCourse)
        Me.Controls.Add(Me.btnRegisterCourse)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmCourse"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmCourse"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.CourseBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SMS_DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label3 As Label
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
End Class
