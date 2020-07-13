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

        txtHallStudID.Text = frmLogin.txtStudID.Text

        Try
            studentAdapter.fillStudentDeats(studentDataSet.Student, txtHallStudID.Text)

            enableStudentDeats(False)

            If studentDataSet.Student.Rows.Count > 0 Then


                studentRow = studentDataSet.Student.Rows(0)

                'enableCombos(False)
                enableStudentDeats(False)
                btnHallSave.Enabled = False
                btnHallUpdate.Enabled = False

                txtHallFN.Text = studentRow.firstName
                txtHallLN.Text = studentRow.lastName
                txtHallON.Text = studentRow.otherName
                txtHallCollege.Text = studentRow.college
                txtHallLevl.Text = studentRow.academicLevel
                If studentRow.hall_ID = 1 Then
                    cmbHallName.Text = "Akuafo"
                ElseIf studentRow.hall_ID = 2 Then
                    cmbHallName.Text = "CommonWealth"
                ElseIf studentRow.hall_ID = 3 Then
                    cmbHallName.Text = "Legon"
                ElseIf studentRow.hall_ID = 4 Then
                    cmbHallName.Text = "Mensah Sarbah"
                ElseIf studentRow.hall_ID = 5 Then
                    cmbHallName.Text = "Volta"
                ElseIf studentRow.hall_ID = 6 Then
                    cmbHallName.Text = "Non-Resident"
                End If

            ElseIf studentDataSet.Student.Rows.Count = 0 Then
                    MessageBox.Show("Incorrect Student ID please email UGCS for assistance!", "No Student Record")

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        If cmbHallName.Text.Length = 0 Then
            enableCombos(True)
            btnHallSave.Enabled = True
            btnHallUpdate.Enabled = False
        Else
            enableCombos(True)
            btnHallSave.Enabled = False
            btnHallUpdate.Enabled = True

        End If
    End Sub





    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub btnHallUpdate_Click(sender As Object, e As EventArgs) Handles btnHallUpdate.Click
        'btnHallSave.Enabled = True
        'btnHallUpdate.Enabled = False

        studentAdapter.UpdateHallstats(cmbHallName.SelectedValue.ToString, "True", cmbRoomNo.SelectedItem.ToString, cmbAcaYear.SelectedItem.ToString, txtHallStudID.Text)
        btnHallUpdate.Enabled = False

        MessageBox.Show("Update Successful", "Hall Registration")
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub txtHallCollege_TextChanged(sender As Object, e As EventArgs) Handles txtHallCollege.TextChanged

    End Sub

    Private Sub btnHallSave_Click(sender As Object, e As EventArgs) Handles btnHallSave.Click


        Try
            enableCombos(True)
            Dim update = MessageBox.Show("Do you want to update your hall details?", "Hall Regstration", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)

            If update = DialogResult.Yes Then
                studentAdapter.UpdateHallstats(cmbHallName.SelectedValue.ToString, "true", cmbRoomNo.SelectedItem.ToString, cmbAcaYear.SelectedItem.ToString, txtHallStudID.Text)
                MessageBox.Show("Details saved successfully", "Hall Registration Complete")
                clearStudentFills()
            End If
        Catch ex As Exception

        End Try


    End Sub

    Private Sub btnHall_Click(sender As Object, e As EventArgs) Handles btnCancelHall.Click
        Dim cancelOption = MessageBox.Show("Go back to main menu?", "Hall Regstration", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)

        If cancelOption = DialogResult.Yes Then
            IndexForm.Show()

            Me.Close()



        Else
            Me.Show()
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


    Private Sub enableCombos(status As Boolean)
        cmbAcaYear.Enabled = status
        cmbHallName.Enabled = status
        cmbRoomNo.Enabled = status
    End Sub

    Private Sub txtHallStudID_Enter(sender As Object, e As EventArgs) Handles txtHallStudID.Enter

    End Sub

    Private Sub choosehall()
        Dim choice As String = studentRow.hall_ID

        Select Case choice
            Case "1"
                cmbHallName.Text = "Akuafo"
            Case "2"
                cmbHallName.Text = "Commonwealth"
            Case "3"
                cmbHallName.Text = "Legons"
            Case "4"
                cmbHallName.Text = "Mensah Sarbah"
            Case "5"
                cmbHallName.Text = "Volta"
            Case "6"
                cmbHallName.Text = "Non-Resident"

        End Select
    End Sub
End Class