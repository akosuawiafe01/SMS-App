Public Class frmLecturerMenu
    Private Sub SearchForStudentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SearchForStudentToolStripMenuItem.Click

    End Sub

    Private Sub lblLecturerFN_Click(sender As Object, e As EventArgs) Handles lblLecturerFN.Click

    End Sub

    Private Sub StudentListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StudentListToolStripMenuItem.Click

    End Sub

    Private Sub frmLecturerMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'lblLecturerFN.Text = frmLecturerLogin.txtlectId.Text
    End Sub

    Private Sub GradeEntryToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles GradeEntryToolStripMenuItem1.Click
        frmGradeEntry.Show()
    End Sub
End Class