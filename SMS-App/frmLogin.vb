Public Class frmLogin
    Private Sub lblSchName_Click(sender As Object, e As EventArgs) Handles lblSchName.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(sender As Object, e As MouseEventArgs)

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub registerStudents_Click(sender As Object, e As MouseEventArgs)

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles lblRegisterStudent.Click
        Dim frmRegisterStudent As New frmStudent

        frmRegisterStudent.Show()

        frmRegisterStudent = Nothing


    End Sub

    Private Sub Label2_Click_1(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class