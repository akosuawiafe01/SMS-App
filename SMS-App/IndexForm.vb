Public Class IndexForm
    Private Sub StudentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StudentToolStripMenuItem.Click

    End Sub

    Private Sub CourseToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub GradeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GradeToolStripMenuItem.Click
        Dim gradeFrm As New frmTranscript
        gradeFrm.MdiParent = Me
        gradeFrm.Show()
    End Sub

    Private Sub StudentToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles StudentToolStripMenuItem1.Click
        Dim studentFrm As New frmStudent
        studentFrm.MdiParent = Me
        studentFrm.StartPosition = FormStartPosition.CenterScreen
        studentFrm.Show()
    End Sub

    Private Sub CourseToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CourseToolStripMenuItem1.Click
        Dim courseFrm As New frmCourse
        courseFrm.MdiParent = Me
        courseFrm.StartPosition = FormStartPosition.CenterScreen
        courseFrm.Show()
    End Sub

    Private Sub StudentsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StudentsToolStripMenuItem.Click
        Dim rptStudent As New rptStudent
        rptStudent.MdiParent = Me
        rptStudent.StartPosition = FormStartPosition.CenterScreen
        rptStudent.Show()
    End Sub

    Private Sub HallToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HallToolStripMenuItem.Click

    End Sub

    Private Sub LecturersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LecturersToolStripMenuItem.Click
        Dim rptLecturers As New frmLecturerMenu
        rptLecturers.MdiParent = Me
        rptLecturers.StartPosition = FormStartPosition.CenterScreen
        rptLecturers.Show()
    End Sub

    Private Sub CoursesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CoursesToolStripMenuItem.Click
        Dim rptCourses As New rptCourses
        rptCourses.MdiParent = Me
        rptCourses.StartPosition = FormStartPosition.CenterScreen
        rptCourses.Show()
    End Sub

    Private Sub HallToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles HallToolStripMenuItem1.Click
        Dim frmhall As New frmHall
        frmhall.MdiParent = Me
        frmhall.StartPosition = FormStartPosition.CenterScreen
        frmhall.Show()
    End Sub

    Private Sub LoginToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoginToolStripMenuItem.Click
        Dim frmLogin As New frmLogin
        frmLogin.MdiParent = Me
        frmLogin.StartPosition = FormStartPosition.CenterScreen
        frmLogin.Show()
    End Sub

    Private Sub MiscalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MiscalToolStripMenuItem.Click
        Dim frmTests As New Tests
        frmTests.MdiParent = Me
        frmTests.StartPosition = FormStartPosition.CenterScreen
        frmTests.Show()
    End Sub

    Private Sub IndexForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        frmLogin.Show()

        'Me.Close()


    End Sub
End Class
