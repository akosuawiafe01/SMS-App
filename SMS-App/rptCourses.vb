Public Class rptCourses
    Private Sub rptCourses_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_SMS_DbDataSet1.Course' table. You can move, or remove it, as needed.
        Me.CourseTableAdapter.Fill(Me._SMS_DbDataSet1.Course)

    End Sub
End Class