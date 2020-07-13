Public Class rptStudent
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cancelOption = MessageBox.Show("Do you want to stop the registration process?", "Student Registration", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)

        If cancelOption = DialogResult.Yes Then
            frmLecturerMenu.Show()
            Me.Close()

        Else
            Me.Show()
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub rptStudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SMS_DataSet.Student_List' table. You can move, or remove it, as needed.
        Me.Student_ListTableAdapter.Fill(Me.SMS_DataSet.Student_List)

    End Sub
End Class