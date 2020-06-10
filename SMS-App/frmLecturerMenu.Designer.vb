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
        Me.StudentListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GradeEntryToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchForStudentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblLecturerFN = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GradeEntryToolStripMenuItem, Me.StudentListToolStripMenuItem, Me.GradeEntryToolStripMenuItem1, Me.SearchForStudentToolStripMenuItem, Me.ReportsToolStripMenuItem})
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
        'StudentListToolStripMenuItem
        '
        Me.StudentListToolStripMenuItem.Name = "StudentListToolStripMenuItem"
        Me.StudentListToolStripMenuItem.Size = New System.Drawing.Size(81, 20)
        Me.StudentListToolStripMenuItem.Text = "Student List"
        '
        'GradeEntryToolStripMenuItem1
        '
        Me.GradeEntryToolStripMenuItem1.Name = "GradeEntryToolStripMenuItem1"
        Me.GradeEntryToolStripMenuItem1.Size = New System.Drawing.Size(80, 20)
        Me.GradeEntryToolStripMenuItem1.Text = "Grade Entry"
        '
        'SearchForStudentToolStripMenuItem
        '
        Me.SearchForStudentToolStripMenuItem.Name = "SearchForStudentToolStripMenuItem"
        Me.SearchForStudentToolStripMenuItem.Size = New System.Drawing.Size(123, 20)
        Me.SearchForStudentToolStripMenuItem.Text = "Edit Student Record"
        '
        'ReportsToolStripMenuItem
        '
        Me.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem"
        Me.ReportsToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.ReportsToolStripMenuItem.Text = "Reports"
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
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
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
        Me.lblLecturerFN.Location = New System.Drawing.Point(718, 105)
        Me.lblLecturerFN.Name = "lblLecturerFN"
        Me.lblLecturerFN.Size = New System.Drawing.Size(195, 38)
        Me.lblLecturerFN.TabIndex = 3
        Me.lblLecturerFN.Text = "Lecturer Name"
        '
        'frmLecturerMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(913, 450)
        Me.Controls.Add(Me.lblLecturerFN)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmLecturerMenu"
        Me.Text = "Lecturer Menu"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents GradeEntryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StudentListToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GradeEntryToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ReportsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents SearchForStudentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblLecturerFN As Label
End Class
