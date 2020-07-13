Imports System.Data.SqlClient

Public Class frmGradeEntry
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtStuID.TextChanged

    End Sub

    Private Sub txtStuID_Leave(sender As Object, e As EventArgs) Handles txtStuID.Leave
        Dim strCon As String = "Data Source=.;Initial Catalog=SMS-Db;Integrated Security=True"
        Dim strSQL As String = "select courseCode, courseTitle, creditHours, score, grade  from Transcript_ResultSlip where studID='" & txtStuID.Text & "' "
        Dim dataAdapter As New SqlClient.SqlDataAdapter(strSQL, strCon)
        Dim table As New DataTable
        dataAdapter.Fill(table)
        dgvGradeEntry.DataSource = table

        txtStuID.Enabled = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


    End Sub

    Private Sub btnStudentSearch_Click(sender As Object, e As EventArgs) Handles btnStudentSearch.Click
        Try

            Dim constr As String = "Data Source=.;Initial Catalog=SMS-Db;Integrated Security=True"
            Using con As SqlConnection = New SqlConnection(constr)
                Using cmd As SqlCommand = New SqlCommand("Select * from Student where studentID= '" & txtStuID.Text & "' ")
                    cmd.CommandType = CommandType.Text
                    cmd.Connection = con
                    con.Open()
                    Using sdr As SqlDataReader = cmd.ExecuteReader()
                        sdr.Read()

                        txtFN.Text = sdr("firstName").ToString()
                        txtLN.Text = sdr("lastName").ToString()
                        txtLev.Text = sdr("academicLevel").ToString()
                        enableFields(False)
                    End Using
                    con.Close()
                End Using
            End Using


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        Dim strCon As String = "Data Source=.;Initial Catalog=SMS-Db;Integrated Security=True"
        Dim strSQL As String = "select courseCode, courseTitle, creditHours, score, grade  from Transcript_ResultSlip where studID='" & txtStuID.Text & "' "
        Dim dataAdapter As New SqlClient.SqlDataAdapter(strSQL, strCon)
        Dim table As New DataTable
        dataAdapter.Fill(table)
        dgvGradeEntry.DataSource = table
    End Sub

    Private Sub enableFields(status As Boolean)
        txtStuID.Enabled = status
        txtFN.Enabled = status
        txtLev.Enabled = status
        txtLN.Enabled = status
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim cancelOption = MessageBox.Show("Do you want to go back to the Main Menu?", "Student Registration", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)

        If cancelOption = DialogResult.Yes Then
            frmLecturerMenu.Show()
            Me.Close()

        Else
            Me.Show()
        End If
    End Sub
End Class