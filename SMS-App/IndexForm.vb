﻿Public Class IndexForm
    Private Sub StudentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StudentToolStripMenuItem.Click
        Dim studentFrm As New frmStudent
        studentFrm.MdiParent = Me
        studentFrm.Show()
    End Sub

    Private Sub CourseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CourseToolStripMenuItem.Click
        Dim courseFrm As New frmCourse
        courseFrm.MdiParent = Me
        courseFrm.Show()
    End Sub

    Private Sub GradeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GradeToolStripMenuItem.Click
        Dim gradeFrm As New frmGrade
        gradeFrm.MdiParent = Me
        gradeFrm.Show()
    End Sub
End Class
