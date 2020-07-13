Imports System.Data.SqlClient

Public Class frmEditStudent
    'Student Table data adapter
    Dim studentAdapter As SMS_DataSetTableAdapters.StudentTableAdapter = New SMS_DataSetTableAdapters.StudentTableAdapter()
    'Student Table dataset
    Dim studentDataSet As SMS_DataSet = New SMS_DataSet()
    'Variable for storing student data collected
    Dim studentRow As SMS_DataSet.StudentRow
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try

            Dim constr As String = "Data Source=.;Initial Catalog=SMS-Db;Integrated Security=True"
            Using con As SqlConnection = New SqlConnection(constr)
                Using cmd As SqlCommand = New SqlCommand("Select * from Student where studentID= '" & txtStudentID.Text & "' ")
                    cmd.CommandType = CommandType.Text
                    cmd.Connection = con
                    con.Open()
                    Using sdr As SqlDataReader = cmd.ExecuteReader()
                        sdr.Read()

                        txtFirstName.Text = sdr("firstName").ToString()
                        txtLastName.Text = sdr("lastName").ToString()
                        txtOtherName.Text = sdr("otherName").ToString()
                        txtContact.Text = sdr("contact").ToString()
                        txtEmail.Text = sdr("email").ToString()
                        txtPostalAddress.Text = sdr("postalAddress").ToString()
                        txtMarStats.Text = sdr("maritalStatus").ToString()
                        txtCollege.Text = sdr("college").ToString()
                        txtGender.Text = sdr("gender").ToString()
                        txtHomeLang.Text = sdr("homeLanguage").ToString()
                        txtProg.Text = sdr("programme").ToString()
                        txtCitizenship.Text = sdr("citizenship").ToString()
                        txtDOB.Text = sdr("DOB").ToString()
                        txtLevel.Text = sdr("academicLevel").ToString()


                    End Using
                    con.Close()
                End Using
            End Using


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnUpdateStudent_Click(sender As Object, e As EventArgs) Handles btnUpdateStudent.Click

        studentAdapter.UpdateStudent(txtFirstName.Text, txtLastName.Text, txtOtherName.Text, txtContact.Text, txtEmail.Text, txtPostalAddress.Text, txtMarStats.Text, txtCollege.Text, txtGender.Text, txtHomeLang.Text, txtProg.Text, txtCitizenship.Text, txtDOB.Text, txtLevel.Text, txtStudentID.Text)

        btnUpdateStudent.Enabled = False
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