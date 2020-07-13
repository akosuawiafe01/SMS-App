Public Class rptHall
    Private Sub rptHall_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SMS_DataSet.rptHall' table. You can move, or remove it, as needed.
        Me.RptHallTableAdapter.Fill(Me.SMS_DataSet.rptHall)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cancelOption = MessageBox.Show("Do you want to stop the registration process?", "Hall Regstration", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)

        If cancelOption = DialogResult.Yes Then
            frmLecturerMenu.Show()

            Me.Close()
        Else
            Me.Show()
        End If
    End Sub
End Class