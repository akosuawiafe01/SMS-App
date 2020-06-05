Public Class frmStudent

    'Student Table data adapter
    Dim studentAdapter As SMS_DataSetTableAdapters.StudentTableAdapter = New SMS_DataSetTableAdapters.StudentTableAdapter()
    'Student Table dataset
    Dim studentDataSet As SMS_DataSet = New SMS_DataSet()
    'Variable for storing student data collected
    Dim studentRow As SMS_DataSet.StudentRow


    Private Sub frmStudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SMS_DataSet.Department' table. You can move, or remove it, as needed.
        Me.DepartmentTableAdapter.Fill(Me.SMS_DataSet.Department)

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtHomeLang.TextChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Label16_Click(sender As Object, e As EventArgs) Handles Label16.Click, Label22.Click

    End Sub

    Private Sub clearAllFields()
        txtCitizenship.Clear()
        txtCollege.Clear()
        txtContact.Clear()
        txtEmail.Clear()
        txtFirstName.Clear()
        txtLastName.Clear()
        txtOtherName.Clear()
        txtHomeLang.Clear()
        txtPostalAddress.Clear()
        txtProgramme.Clear()
        TextBox1.Clear()
        TextBox2.Clear()

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Dim cancelOption = MessageBox.Show("Do you want to stop the registration process?", "Cancel Registration", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)

        If cancelOption = DialogResult.Yes Then
            frmLogin.Show()

            Me.Close()



        Else
            MessageBox.Show("No")
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Dim fname = txtFirstName.Text

        'row = tabledataset.table.NewRow
        studentRow = studentDataSet.Student.NewRow

        'recieving data from text boxes
        studentRow.citizenship = txtCitizenship.Text
        studentRow.college = cmbCollege.Text
        studentRow.contact = txtContact.Text
        studentRow.deptID = cmbDepartment.SelectedValue.ToString
        studentRow.email = txtEmail.Text
        studentRow.firstName = txtFirstName.Text
        studentRow.lastName = txtLastName.Text
        studentRow.otherName = txtOtherName.Text
        studentRow.homeLanguage = txtHomeLang.Text
        studentRow.postalAddress = txtPostalAddress.Text
        studentRow.programme = cmbProgramme.Text
        studentRow.academicLevel = cmbStudentLevel.Text
        studentRow.studentID = TextBox1.Text
        studentRow.studentPin = TextBox2.Text
        studentRow.gender = cmbGender.Text
        studentRow.maritalStatus = cmbMaritalStatus.Text
        studentRow.DOB = dtpDOB.Value.Date


        'updating the Student table in the database
        studentDataSet.Student.AddStudentRow(studentRow)
        studentAdapter.Update(studentDataSet.Student)

        'saving data into database
        MessageBox.Show(fname & ", your details have been saved successfully", "Registration Successful", MessageBoxButtons.OK)

        clearAllFields()

    End Sub
End Class