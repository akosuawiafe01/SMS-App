Public Class frmCourse


    'Transcript Table data adapter
    Dim transAdapter As SMS_DataSetTableAdapters.TranscriptTableAdapter = New SMS_DataSetTableAdapters.TranscriptTableAdapter
    'Student Table dataset
    Dim transDataSet As SMS_DataSet = New SMS_DataSet()
    'Variable for storing student data collected
    Dim transRow As SMS_DataSet.TranscriptRow


    Private Sub frmCourse_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SMS_DataSet.Course' table. You can move, or remove it, as needed.
        Me.CourseTableAdapter.Fill(Me.SMS_DataSet.Course)


    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub cmbCourseTitle_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCourseTitle.SelectedIndexChanged

    End Sub

    Private Sub cmbCreditCourses_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCreditCourses.SelectedIndexChanged

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub btnRegisterCourse_Click(sender As Object, e As EventArgs) Handles btnRegisterCourse.Click
        'row = tabledataset.table.NewRow
        transRow = transDataSet.Transcript.NewRow



        'recieving data from text boxes
        transRow.courseCode1 = cmbCourseCode.SelectedValue.ToString
        transRow.courseCode2 = cmbCours2.SelectedValue.ToString
        transRow.courseCode3 = cmbCours3.SelectedValue.ToString
        transRow.studID = txtStudeID.Text
        transRow.academicYear = cmbAcaYear.SelectedItem.ToString
        transRow.semesterNo = cmbSemester.SelectedItem.ToString


        Try
            'transRow.semesterNo = cmbSemester.SelectedValue.ToString
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


        'saving the Courses into the database
        transDataSet.Transcript.AddTranscriptRow(transRow)
        transAdapter.Update(transDataSet.Transcript)


        'Saving data into database
        MessageBox.Show("Your courses have been saved successfully", "Registration Successful", MessageBoxButtons.OK)

    End Sub

    Private Sub btnCancelCourse_Click(sender As Object, e As EventArgs) Handles btnCancelCourse.Click
        Dim cancelOption = MessageBox.Show("Do you want to stop the registration process?", "Hall Regstration", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)

        If cancelOption = DialogResult.Yes Then
            frmLogin.Show()

            Me.Close()
        Else
            Me.Close()
        End If
    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub txtStudeID_TextChanged(sender As Object, e As EventArgs) Handles txtStudeID.TextChanged

    End Sub
End Class