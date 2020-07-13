<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLecturerMenu
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
        Me.GradeEntryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddStudentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddNewStudentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchForStudentToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.GradeEntryToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StudentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HallToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CoursesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblLecturerFN = New System.Windows.Forms.Label()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GradeEntryToolStripMenuItem, Me.AddStudentToolStripMenuItem, Me.GradeEntryToolStripMenuItem1, Me.ReportsToolStripMenuItem, Me.LogoutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(913, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'GradeEntryToolStripMenuItem
        '
        Me.GradeEntryToolStripMenuItem.Name = "GradeEntryToolStripMenuItem"
        Me.GradeEntryToolStripMenuItem.Size = New System.Drawing.Size(22, 20)
        Me.GradeEntryToolStripMenuItem.Text = " "
        '
        'AddStudentToolStripMenuItem
        '
        Me.AddStudentToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddNewStudentToolStripMenuItem, Me.SearchForStudentToolStripMenuItem1})
        Me.AddStudentToolStripMenuItem.Name = "AddStudentToolStripMenuItem"
        Me.AddStudentToolStripMenuItem.Size = New System.Drawing.Size(94, 20)
        Me.AddStudentToolStripMenuItem.Text = "Student Menu"
        '
        'AddNewStudentToolStripMenuItem
        '
        Me.AddNewStudentToolStripMenuItem.Name = "AddNewStudentToolStripMenuItem"
        Me.AddNewStudentToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.AddNewStudentToolStripMenuItem.Text = "Add New Student"
        '
        'SearchForStudentToolStripMenuItem1
        '
        Me.SearchForStudentToolStripMenuItem1.Name = "SearchForStudentToolStripMenuItem1"
        Me.SearchForStudentToolStripMenuItem1.Size = New System.Drawing.Size(171, 22)
        Me.SearchForStudentToolStripMenuItem1.Text = "Search for Student"
        '
        'GradeEntryToolStripMenuItem1
        '
        Me.GradeEntryToolStripMenuItem1.Name = "GradeEntryToolStripMenuItem1"
        Me.GradeEntryToolStripMenuItem1.Size = New System.Drawing.Size(80, 20)
        Me.GradeEntryToolStripMenuItem1.Text = "Grade Entry"
        '
        'ReportsToolStripMenuItem
        '
        Me.ReportsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StudentToolStripMenuItem, Me.HallToolStripMenuItem, Me.CoursesToolStripMenuItem})
        Me.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem"
        Me.ReportsToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.ReportsToolStripMenuItem.Text = "Reports"
        '
        'StudentToolStripMenuItem
        '
        Me.StudentToolStripMenuItem.Name = "StudentToolStripMenuItem"
        Me.StudentToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.StudentToolStripMenuItem.Text = "Student"
        '
        'HallToolStripMenuItem
        '
        Me.HallToolStripMenuItem.Name = "HallToolStripMenuItem"
        Me.HallToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.HallToolStripMenuItem.Text = "Hall"
        '
        'CoursesToolStripMenuItem
        '
        Me.CoursesToolStripMenuItem.Name = "CoursesToolStripMenuItem"
        Me.CoursesToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.CoursesToolStripMenuItem.Text = "Courses"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(913, 81)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "WAN College"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Location = New System.Drawing.Point(0, 105)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(913, 345)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Welcome Back to school"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLecturerFN
        '
        Me.lblLecturerFN.Location = New System.Drawing.Point(706, 0)
        Me.lblLecturerFN.Name = "lblLecturerFN"
        Me.lblLecturerFN.Size = New System.Drawing.Size(207, 24)
        Me.lblLecturerFN.TabIndex = 3
        Me.lblLecturerFN.Text = "Lecturer Name"
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer"
        Me.ReportViewer1.Size = New System.Drawing.Size(396, 246)
        Me.ReportViewer1.TabIndex = 0
        '
        'frmLecturerMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(913, 450)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblLecturerFN)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmLecturerMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lecturer Menu"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents GradeEntryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GradeEntryToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ReportsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblLecturerFN As Label
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddStudentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StudentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HallToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CoursesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddNewStudentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SearchForStudentToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
End Class
