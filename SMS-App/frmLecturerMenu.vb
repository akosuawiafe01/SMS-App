Imports System.Data.SqlClient

Public Class frmLecturerMenu
    Private Sub SearchForStudentToolStripMenuItem_Click(sender As Object, e As EventArgs)
        frmEditStudent.Show()
    End Sub

    Private Sub lblLecturerFN_Click(sender As Object, e As EventArgs) Handles lblLecturerFN.Click

    End Sub

    Private Sub StudentListToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub frmLecturerMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Try

            Dim constr As String = "Data Source=.;Initial Catalog=SMS-Db;Integrated Security=True"
            Using con As SqlConnection = New SqlConnection(constr)
                Using cmd As SqlCommand = New SqlCommand("select distinct lectName from Logins where lectID='" & frmLecturerLogin.txtlectId.Text & "' ")
                    cmd.CommandType = CommandType.Text
                    cmd.Connection = con
                    con.Open()
                    Using sdr As SqlDataReader = cmd.ExecuteReader()
                        sdr.Read()

                        lblLecturerFN.Text = sdr("lectName").ToString()



                    End Using
                    con.Close()
                End Using
            End Using


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub GradeEntryToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles GradeEntryToolStripMenuItem1.Click
        frmGradeEntry.Show()
        Me.Hide()
    End Sub

    Private Sub AddStudentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddStudentToolStripMenuItem.Click
        'frmStudent.Show()
        'Me.Hide()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        frmLogin.Show()
        clearAll()
        Me.Hide()
    End Sub

    Public Sub clearAll()
        frmLecturerLogin.txtlectId.Clear()
        frmLecturerLogin.txtPassword.Clear()
    End Sub

    Private Sub AddNewStudentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddNewStudentToolStripMenuItem.Click
        frmStudent.Show()
        Me.Hide()
    End Sub

    Private Sub StudentListToolStripMenuItem1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub SearchForStudentToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SearchForStudentToolStripMenuItem1.Click
        frmEditStudent.Show()
        Me.Close()
    End Sub

    Private Sub StudentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StudentToolStripMenuItem.Click
        rptStudent.Show()
        Me.Hide()
    End Sub

    Private Sub HallToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HallToolStripMenuItem.Click
        rptHall.Show()
        Me.Close()
    End Sub

    Private Sub CoursesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CoursesToolStripMenuItem.Click
        rptCourses.Show()

        Me.Hide()
    End Sub
End Class