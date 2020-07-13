Imports System.Data.SqlClient

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

    Private Sub StudentToolStripMenuItem1_Click(sender As Object, e As EventArgs)
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

    Private Sub StudentsToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim rptStudent As New rptStudent
        rptStudent.MdiParent = Me
        rptStudent.StartPosition = FormStartPosition.CenterScreen
        rptStudent.Show()
    End Sub

    Private Sub HallToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub LecturersToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim rptLecturers As New frmLecturerMenu
        rptLecturers.MdiParent = Me
        rptLecturers.StartPosition = FormStartPosition.CenterScreen
        rptLecturers.Show()
    End Sub

    Private Sub CoursesToolStripMenuItem_Click(sender As Object, e As EventArgs)
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
        frmLogin.txtStudID.Clear()
        frmLogin.txtPin.Clear()

        frmLogin.Show()
        Me.Hide()
    End Sub

    Private Sub MiscalToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub IndexForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try

            Dim constr As String = "Data Source=.;Initial Catalog=SMS-Db;Integrated Security=True"
            Using con As SqlConnection = New SqlConnection(constr)
                Using cmd As SqlCommand = New SqlCommand("select distinct firstName from Logins where studentID='" & frmLogin.txtStudID.Text & "' ")
                    cmd.CommandType = CommandType.Text
                    cmd.Connection = con
                    con.Open()
                    Using sdr As SqlDataReader = cmd.ExecuteReader()
                        sdr.Read()

                        lblStudName.Text = sdr("firstName").ToString()



                    End Using
                    con.Close()
                End Using
            End Using


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        'Me.Close()


    End Sub

    Private Sub ReportToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub
End Class
