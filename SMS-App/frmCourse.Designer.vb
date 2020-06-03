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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmbCourseCode = New System.Windows.Forms.ComboBox()
        Me.cmbCourseTitle = New System.Windows.Forms.ComboBox()
        Me.cmbCreditCourses = New System.Windows.Forms.ComboBox()
        Me.cmbLecturer = New System.Windows.Forms.ComboBox()
        Me.cmbSemester = New System.Windows.Forms.ComboBox()
        Me.cmbAcaYear = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnRegisterCourse = New System.Windows.Forms.Button()
        Me.btnCancelCourse = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
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
        Me.Label6.Location = New System.Drawing.Point(186, 286)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Semester"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(191, 247)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Lecturer"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(191, 207)
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
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cmbAcaYear)
        Me.GroupBox1.Controls.Add(Me.cmbSemester)
        Me.GroupBox1.Controls.Add(Me.cmbLecturer)
        Me.GroupBox1.Controls.Add(Me.cmbCreditCourses)
        Me.GroupBox1.Controls.Add(Me.cmbCourseTitle)
        Me.GroupBox1.Controls.Add(Me.cmbCourseCode)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label7)
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
        'cmbCourseCode
        '
        Me.cmbCourseCode.FormattingEnabled = True
        Me.cmbCourseCode.Location = New System.Drawing.Point(366, 136)
        Me.cmbCourseCode.Name = "cmbCourseCode"
        Me.cmbCourseCode.Size = New System.Drawing.Size(101, 21)
        Me.cmbCourseCode.TabIndex = 10
        '
        'cmbCourseTitle
        '
        Me.cmbCourseTitle.FormattingEnabled = True
        Me.cmbCourseTitle.Location = New System.Drawing.Point(366, 172)
        Me.cmbCourseTitle.Name = "cmbCourseTitle"
        Me.cmbCourseTitle.Size = New System.Drawing.Size(98, 21)
        Me.cmbCourseTitle.TabIndex = 11
        '
        'cmbCreditCourses
        '
        Me.cmbCreditCourses.FormattingEnabled = True
        Me.cmbCreditCourses.Location = New System.Drawing.Point(366, 199)
        Me.cmbCreditCourses.Name = "cmbCreditCourses"
        Me.cmbCreditCourses.Size = New System.Drawing.Size(98, 21)
        Me.cmbCreditCourses.TabIndex = 12
        '
        'cmbLecturer
        '
        Me.cmbLecturer.FormattingEnabled = True
        Me.cmbLecturer.Location = New System.Drawing.Point(366, 239)
        Me.cmbLecturer.Name = "cmbLecturer"
        Me.cmbLecturer.Size = New System.Drawing.Size(101, 21)
        Me.cmbLecturer.TabIndex = 13
        '
        'cmbSemester
        '
        Me.cmbSemester.FormattingEnabled = True
        Me.cmbSemester.Location = New System.Drawing.Point(366, 278)
        Me.cmbSemester.Name = "cmbSemester"
        Me.cmbSemester.Size = New System.Drawing.Size(101, 21)
        Me.cmbSemester.TabIndex = 14
        '
        'cmbAcaYear
        '
        Me.cmbAcaYear.FormattingEnabled = True
        Me.cmbAcaYear.Location = New System.Drawing.Point(366, 317)
        Me.cmbAcaYear.Name = "cmbAcaYear"
        Me.cmbAcaYear.Size = New System.Drawing.Size(98, 21)
        Me.cmbAcaYear.TabIndex = 15
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(184, 325)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 13)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Academic Year"
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
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "frmCourse"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbAcaYear As ComboBox
    Friend WithEvents cmbSemester As ComboBox
    Friend WithEvents cmbLecturer As ComboBox
    Friend WithEvents cmbCreditCourses As ComboBox
    Friend WithEvents cmbCourseTitle As ComboBox
    Friend WithEvents cmbCourseCode As ComboBox
    Friend WithEvents btnRegisterCourse As Button
    Friend WithEvents btnCancelCourse As Button
End Class
