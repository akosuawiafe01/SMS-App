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

    Private Sub Label3_Click(sender As Object, e As EventArgs)



    End Sub

    Private Sub Label2_Click_1(sender As Object, e As EventArgs) 
        frmStudent.Show()
        Me.Hide()
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
            Dim strCon As String = "Data Source=.;Initial Catalog=SMS-Db;Integrated Security=True"
            Dim strSQL As String = "select studentID, studentPin from Student where studentID='" & studentID & "' and studentPin='" & pin & "' "
            Dim dataAdapter As New SqlClient.SqlDataAdapter(strSQL, strCon)
            Dim dataTable As New DataTable
            dataAdapter.Fill(dataTable)

            If dataTable.Rows.Count > 0 Then



                'MessageBox.Show("Login Successful")
                IndexForm.Show()
                Me.Hide()

            ElseIf loginDataset.Student.Rows.Count = 0 Then
                MessageBox.Show("Incorrect Student ID or pin kindly email UGCS for assistance!", "No Student Record")

            End If



        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        'clearAll()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        frmLecturerLogin.Show()

    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub frmLogin_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        'Me.Close()
    End Sub

    Private Sub frmLogin_Leave(sender As Object, e As EventArgs) Handles MyBase.Leave
        Me.Close()
        frmCourse.Close()
        frmEditStudent.Close()
        frmGradeEntry.Close()
        frmHall.Close()
        frmLecturerLogin.Close()
        frmLecturerMenu.Close()
        rptCourses.Close()
        rptHall.Close()
        rptStudent.Close()
        frmTranscript.Close()
        frmStudent.Close()

        For Each form As Form In My.Application.OpenForms
            form.Close()
        Next

    End Sub
End Class