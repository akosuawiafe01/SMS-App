Public Class frmLogin


    'Student Table data adapter
    Dim loginAdapter As SMS_DataSetTableAdapters.LoginsTableAdapter = New SMS_DataSetTableAdapters.LoginsTableAdapter()
    'Student Table dataset
    Dim loginDataset As SMS_DataSet = New SMS_DataSet()
    'Variable for storing student data collected
    Dim loginRow As SMS_DataSet.StudentRow


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



    End Sub

    Private Sub Label2_Click_1(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click_1(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Public Sub clearAll()
        txtPin.Clear()
        txtStudID.Clear()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim studentID, pin As String

        studentID = txtStudID.Text
        pin = txtPin.Text

        Try
            loginAdapter.getstudentLogs(studentID)



            If loginDataset.Student.Rows.Count > 0 Then

                loginRow = loginDataset.Student.Rows(0)

                MessageBox.Show("Login Successful")
                IndexForm.Show()

            ElseIf loginDataset.Student.Rows.Count = 0 Then
                MessageBox.Show("Incorrect Student ID or pin kindly email UGCS for assistance!", "No Student Record")

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        clearAll()
    End Sub
End Class