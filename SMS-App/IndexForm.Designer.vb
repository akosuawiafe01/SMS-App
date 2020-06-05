<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IndexForm
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.StudentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StudentToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CourseToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.HallToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.GradeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StudentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HallToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LecturersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CoursesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoginToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MiscalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StudentToolStripMenuItem, Me.GradeToolStripMenuItem, Me.ReportToolStripMenuItem, Me.LoginToolStripMenuItem, Me.MiscalToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'StudentToolStripMenuItem
        '
        Me.StudentToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StudentToolStripMenuItem1, Me.CourseToolStripMenuItem1, Me.HallToolStripMenuItem1})
        Me.StudentToolStripMenuItem.Name = "StudentToolStripMenuItem"
        Me.StudentToolStripMenuItem.Size = New System.Drawing.Size(82, 20)
        Me.StudentToolStripMenuItem.Text = "Registration"
        '
        'StudentToolStripMenuItem1
        '
        Me.StudentToolStripMenuItem1.Name = "StudentToolStripMenuItem1"
        Me.StudentToolStripMenuItem1.Size = New System.Drawing.Size(115, 22)
        Me.StudentToolStripMenuItem1.Text = "Student"
        '
        'CourseToolStripMenuItem1
        '
        Me.CourseToolStripMenuItem1.Name = "CourseToolStripMenuItem1"
        Me.CourseToolStripMenuItem1.Size = New System.Drawing.Size(115, 22)
        Me.CourseToolStripMenuItem1.Text = "Course"
        '
        'HallToolStripMenuItem1
        '
        Me.HallToolStripMenuItem1.Name = "HallToolStripMenuItem1"
        Me.HallToolStripMenuItem1.Size = New System.Drawing.Size(115, 22)
        Me.HallToolStripMenuItem1.Text = "Hall"
        '
        'GradeToolStripMenuItem
        '
        Me.GradeToolStripMenuItem.Name = "GradeToolStripMenuItem"
        Me.GradeToolStripMenuItem.Size = New System.Drawing.Size(70, 20)
        Me.GradeToolStripMenuItem.Text = "Transcript"
        '
        'ReportToolStripMenuItem
        '
        Me.ReportToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StudentsToolStripMenuItem, Me.HallToolStripMenuItem, Me.LecturersToolStripMenuItem, Me.CoursesToolStripMenuItem})
        Me.ReportToolStripMenuItem.Name = "ReportToolStripMenuItem"
        Me.ReportToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.ReportToolStripMenuItem.Text = "Report"
        '
        'StudentsToolStripMenuItem
        '
        Me.StudentsToolStripMenuItem.Name = "StudentsToolStripMenuItem"
        Me.StudentsToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.StudentsToolStripMenuItem.Text = "Students"
        '
        'HallToolStripMenuItem
        '
        Me.HallToolStripMenuItem.Name = "HallToolStripMenuItem"
        Me.HallToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.HallToolStripMenuItem.Text = "Hall"
        '
        'LecturersToolStripMenuItem
        '
        Me.LecturersToolStripMenuItem.Name = "LecturersToolStripMenuItem"
        Me.LecturersToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.LecturersToolStripMenuItem.Text = "Lecturers"
        '
        'CoursesToolStripMenuItem
        '
        Me.CoursesToolStripMenuItem.Name = "CoursesToolStripMenuItem"
        Me.CoursesToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.CoursesToolStripMenuItem.Text = "Courses"
        '
        'LoginToolStripMenuItem
        '
        Me.LoginToolStripMenuItem.Name = "LoginToolStripMenuItem"
        Me.LoginToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.LoginToolStripMenuItem.Text = "Login"
        '
        'MiscalToolStripMenuItem
        '
        Me.MiscalToolStripMenuItem.Name = "MiscalToolStripMenuItem"
        Me.MiscalToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.MiscalToolStripMenuItem.Text = "Inputs"
        '
        'IndexForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "IndexForm"
        Me.Text = "Student Management System"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents StudentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GradeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StudentToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents CourseToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents StudentsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HallToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LecturersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CoursesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HallToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents LoginToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MiscalToolStripMenuItem As ToolStripMenuItem
End Class
