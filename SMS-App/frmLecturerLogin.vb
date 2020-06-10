Public Class frmLecturerLogin

    'Student Table data adapter
    Dim loginAdapter As SMS_DataSetTableAdapters.LoginsTableAdapter = New SMS_DataSetTableAdapters.LoginsTableAdapter()
    'Student Table dataset
    Dim loginDataset As SMS_DataSet = New SMS_DataSet()
    'Variable for storing student data collected
    Dim loginRow As SMS_DataSet.StudentRow
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        Dim lecturerID, password As String

        lecturerID = txtlectId.Text
        password = txtPassword.Text

        Try
            Dim strCon As String = "Data Source=.;Initial Catalog=SMS-Db;Integrated Security=True"
            Dim strSQL As String = "select lectID, Password from Lecturer where lectID='" & lecturerID & "' and Password='" & password & "' "
            Dim dataAdapter As New SqlClient.SqlDataAdapter(strSQL, strCon)
            Dim sqlCmd As SqlClient.SqlCommand
            Dim dataTable As New DataTable
            dataAdapter.Fill(dataTable)



            If dataTable.Rows.Count > 0 Then



                MessageBox.Show("Login Successful")
                frmLecturerMenu.Show()
                Me.Hide()

            ElseIf loginDataset.Student.Rows.Count = 0 Then
                MessageBox.Show("Incorrect ID or pin kindly email UGCS for assistance!", "No Record Found")

            End If

            clearAll()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        clearAll()

    End Sub

    Private Sub frmLecturerLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmLogin.Hide()
    End Sub

    Private Sub frmLecturerLogin_Leave(sender As Object, e As EventArgs) Handles MyBase.Leave
        'frmLogin.Show()
    End Sub

    Public Sub clearAll()
        txtlectId.Clear()
        txtPassword.Clear()
    End Sub
End Class