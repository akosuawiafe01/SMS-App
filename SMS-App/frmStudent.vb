Imports System.Text.RegularExpressions


Public Class frmStudent
    Dim randInt As Integer = 5
    Dim valid_inputs As Boolean = True
    'Student Table data adapter
    Dim studentAdapter As SMS_DataSetTableAdapters.StudentTableAdapter = New SMS_DataSetTableAdapters.StudentTableAdapter()
    'Student Table dataset
    Dim studentDataSet As SMS_DataSet = New SMS_DataSet()
    'Variable for storing student data collected
    Dim studentRow As SMS_DataSet.StudentRow




    Private Sub frmStudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtStudentID.Text = ("106" + randomInteger(randInt))
        txtStudentPin.Text = randomInteger(randInt)
        'TODO: This line of code loads data into the 'SMS_DataSet.Department' table. You can move, or remove it, as needed.
        Me.DepartmentTableAdapter.Fill(Me.SMS_DataSet.Department)
        ' = frmLogin.txtStudID.Text 

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

    Private Sub Label16_Click(sender As Object, e As EventArgs) Handles Label22.Click

    End Sub

    Private Sub clearAllFields()
        txtCitizenship.Clear()
        'txtCollege.Clear()
        txtContact.Clear()
        txtEmail.Clear()
        txtFirstName.Clear()
        txtLastName.Clear()
        txtOtherName.Clear()
        txtHomeLang.Clear()
        txtPostalAddress.Clear()
        'txtProgramme.Clear()
        txtStudentID.Clear()
        txtStudentPin.Clear()
        cmbCollege.Items.Clear()
        cmbGender.Items.Clear()
        cmbMaritalStatus.Items.Clear()
        cmbProgramme.Items.Clear()
        cmbStudentLevel.Items.Clear()



    End Sub


    Private Sub validateTextFields()

        If txtStudentID.Text.Length = 0 Then
            MessageBox.Show("fields cannot be left empty")

            'ElseIf txtCollege.Text.Length = 0 Then
            ' MessageBox.Show("Citizenship field cannot be left empty")
        ElseIf txtContact.Text.Length = 0 Or txtContact.Text.Length > 10 Then
            MessageBox.Show(" Invalid entry in field")
        ElseIf txtEmail.Text.Length = 0 Then
            MessageBox.Show(" field cannot be left empty")
        ElseIf txtLastName.Text.Length = 0 Then
            MessageBox.Show(" field cannot be left empty")
        ElseIf txtOtherName.Text.Length = 0 Then
            MessageBox.Show(" field cannot be left empty")
            'ElseIf txtHomeLang.Text.Length = 0 Then
            'MessageBox.Show(" field cannot be left empty")
        ElseIf txtPostalAddress.Text.Length = 0 Then
            MessageBox.Show(" field cannot be left empty")
            ' ElseIf txtProgramme.Text.Length = 0 Then
            'MessageBox.Show(" field cannot be left empty")
        ElseIf txtStudentID.Text.Length = 0 Then
            MessageBox.Show(" field cannot be left empty")
            'ElseIf txtCitizenship.Text.Length = 0 Then
            'MessageBox.Show(" field cannot be left empty")
        ElseIf txtFirstName.Text.Length = 0 Then
            MessageBox.Show(" field cannot be left empty")
        ElseIf cmbGender.Text.Length = 0 Then
            MessageBox.Show(" field cannot be left empty")
        ElseIf cmbMaritalStatus.Text.Length = 0 Then
            MessageBox.Show(" field cannot be left empty")
        ElseIf cmbProgramme.Text.Length = 0 Then
            MessageBox.Show(" field cannot be left empty")
        ElseIf cmbStudentLevel.Text.Length = 0 Then
            MessageBox.Show(" field cannot be left empty")



        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Dim cancelOption = MessageBox.Show("Do you want to stop the registration process?", "Student Registration", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)

        If cancelOption = DialogResult.Yes Then
            frmLecturerMenu.Show()
            Me.Close()

        Else
            Me.Show()
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'Valid character that can be in email are assigned to variable
        Dim validCharacters As String = "^([0-9a-zA-Z]([-\.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$"
        'Validation for email
        If Regex.IsMatch(txtEmail.Text, validCharacters) Then

            valid_inputs = False
            MessageBox.Show("Invalid Email")
        End If
        Try
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
            studentRow.studentID = txtStudentID.Text
            studentRow.studentPin = txtStudentPin.Text
            studentRow.gender = cmbGender.Text
            studentRow.maritalStatus = cmbMaritalStatus.Text
            studentRow.DOB = dtpDOB.Value.Date

            validateTextFields()

            'updating the Student table in the database
            studentDataSet.Student.AddStudentRow(studentRow)
            studentAdapter.Update(studentDataSet.Student)

            'saving data into database
            MessageBox.Show(fname & ", your details have been saved successfully", "Registration Successful", MessageBoxButtons.OK)

            clearAllFields()
            btnSave.Enabled = False

        Catch ex As Exception
            MessageBox.Show("Please Check your input values", ex.Message.ToString)
        End Try

    End Sub

    Private Sub TextBox2_TextChanged_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtStudentPin_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label23_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label19_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub GroupBox4_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label17_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub cmbCollege_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub cmbDepartment_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub cmbProgramme_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub GroupBox4_Enter_1(sender As Object, e As EventArgs) Handles GroupBox4.Enter

    End Sub
End Class