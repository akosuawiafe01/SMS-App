Public Class frmHall

    'Student Table data adapter
    Dim studentAdapter As SMS_DataSetTableAdapters.StudentTableAdapter = New SMS_DataSetTableAdapters.StudentTableAdapter()
    'Student Table dataset
    Dim studentDataSet As SMS_DataSet = New SMS_DataSet()
    'Variable for storing student data collected
    Dim studentRow As SMS_DataSet.StudentRow



    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub frmHall_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SMS_DataSet.Hall' table. You can move, or remove it, as needed.
        Me.HallTableAdapter.Fill(Me.SMS_DataSet.Hall)
        'TODO: This line of code loads data into the 'SMS_DataSet.Hall' table. You can move, or remove it, as needed.
        Me.HallTableAdapter.Fill(Me.SMS_DataSet.Hall)




    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub btnHallUpdate_Click(sender As Object, e As EventArgs) Handles btnHallUpdate.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub txtHallCollege_TextChanged(sender As Object, e As EventArgs) Handles txtHallCollege.TextChanged

    End Sub

    Private Sub btnHallSave_Click(sender As Object, e As EventArgs) Handles btnHallSave.Click



        Try
            If (cmbHallName.SelectedItem.Equals("6")) Then
                studentAdapter.UpdateHallstats(cmbHallName.SelectedValue.ToString, "False", cmbRoomNo.SelectedItem, cmbAcaYear.SelectedItem, txtHallStudID.Text)
                cmbRoomNo.Enabled = False
                MessageBox.Show("Hall Saved Successfully", "Registration Success")
                clearStudentFills()
            Else
                studentAdapter.UpdateHallstats(cmbHallName.SelectedItem.ToString, "True", cmbAcaYear.SelectedItem, cmbRoomNo.SelectedItem, txtHallStudID.Text)
                MessageBox.Show("Hall Saved Successfully", "Registration Success")
                clearStudentFills()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub btnHall_Click(sender As Object, e As EventArgs) Handles btnCancelHall.Click
        Dim cancelOption = MessageBox.Show("Do you want to stop the registration process?", "Hall Regstration", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)

        If cancelOption = DialogResult.Yes Then
            frmLogin.Show()

            Me.Close()



        Else
            Me.Close()
        End If
    End Sub

    Private Sub txtHallStudID_TextChanged(sender As Object, e As EventArgs) Handles txtHallStudID.TextChanged

    End Sub

    Private Sub clearStudentFills()

        txtHallStudID.Clear()
        txtHallFN.Clear()
        txtHallLN.Clear()
        txtHallON.Clear()
        txtHallCollege.Clear()
        txtHallLevl.Clear()

    End Sub

    Private Sub enableStudentDeats(status As Boolean)
        txtHallON.Enabled = status
        txtHallLN.Enabled = status
        txtHallFN.Enabled = status
        txtHallCollege.Enabled = status
        txtHallLevl.Enabled = status
    End Sub

    Private Sub txtHallStudID_Enter(sender As Object, e As EventArgs) Handles txtHallStudID.Enter

    End Sub

    Private Sub txtHallStudID_Leave(sender As Object, e As EventArgs) Handles txtHallStudID.Leave
        Try
            studentAdapter.fillStudentDeats(studentDataSet.Student, txtHallStudID.Text)

            enableStudentDeats(False)

            If studentDataSet.Student.Rows.Count > 0 Then

                studentRow = studentDataSet.Student.Rows(0)

                txtHallFN.Text = studentRow.firstName
                txtHallLN.Text = studentRow.lastName
                txtHallON.Text = studentRow.otherName
                txtHallCollege.Text = studentRow.college
                txtHallLevl.Text = studentRow.academicLevel

            ElseIf studentDataSet.Student.Rows.Count = 0 Then
                MessageBox.Show("Incorrect Student ID please email UGCS for assistance!", "No Student Record")

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class