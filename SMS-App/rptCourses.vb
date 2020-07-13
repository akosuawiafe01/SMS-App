Public Class rptCourses
    Private Sub rptCourses_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SMS_DataSet.rptCourses' table. You can move, or remove it, as needed.
        Me.RptCoursesTableAdapter.Fill(Me.SMS_DataSet.rptCourses)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cancelOption = MessageBox.Show("Do you want to stop the registration process?", "Student Registration", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)

        If cancelOption = DialogResult.Yes Then
            frmLecturerMenu.Show()
            Me.Close()

        Else
            Me.Show()
        End If
    End Sub
End Class