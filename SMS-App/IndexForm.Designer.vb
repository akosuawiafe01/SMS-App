<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class IndexForm
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.StudentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CourseToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.HallToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.GradeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoginToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblStudName = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StudentToolStripMenuItem, Me.GradeToolStripMenuItem, Me.LoginToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'StudentToolStripMenuItem
        '
        Me.StudentToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CourseToolStripMenuItem1, Me.HallToolStripMenuItem1})
        Me.StudentToolStripMenuItem.Name = "StudentToolStripMenuItem"
        Me.StudentToolStripMenuItem.Size = New System.Drawing.Size(82, 20)
        Me.StudentToolStripMenuItem.Text = "Registration"
        '
        'CourseToolStripMenuItem1
        '
        Me.CourseToolStripMenuItem1.Name = "CourseToolStripMenuItem1"
        Me.CourseToolStripMenuItem1.Size = New System.Drawing.Size(111, 22)
        Me.CourseToolStripMenuItem1.Text = "Course"
        '
        'HallToolStripMenuItem1
        '
        Me.HallToolStripMenuItem1.Name = "HallToolStripMenuItem1"
        Me.HallToolStripMenuItem1.Size = New System.Drawing.Size(111, 22)
        Me.HallToolStripMenuItem1.Text = "Hall"
        '
        'GradeToolStripMenuItem
        '
        Me.GradeToolStripMenuItem.Name = "GradeToolStripMenuItem"
        Me.GradeToolStripMenuItem.Size = New System.Drawing.Size(70, 20)
        Me.GradeToolStripMenuItem.Text = "Transcript"
        '
        'LoginToolStripMenuItem
        '
        Me.LoginToolStripMenuItem.Name = "LoginToolStripMenuItem"
        Me.LoginToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.LoginToolStripMenuItem.Text = "Logout"
        '
        'lblStudName
        '
        Me.lblStudName.Location = New System.Drawing.Point(631, 4)
        Me.lblStudName.Name = "lblStudName"
        Me.lblStudName.Size = New System.Drawing.Size(169, 20)
        Me.lblStudName.TabIndex = 3
        Me.lblStudName.Text = "Label1"
        '
        'IndexForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblStudName)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "IndexForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
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
    Friend WithEvents CourseToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents HallToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents LoginToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblStudName As Label
End Class
