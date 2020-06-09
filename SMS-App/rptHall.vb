Public Class rptHall
    Private Sub rptHall_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SMS_DataSet.Hall' table. You can move, or remove it, as needed.
        Me.HallTableAdapter.Fill(Me.SMS_DataSet.Hall)

    End Sub
End Class