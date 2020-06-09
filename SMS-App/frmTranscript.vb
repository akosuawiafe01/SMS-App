Public Class frmTranscript
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click

    End Sub

    Private Sub txtTransProg_TextChanged(sender As Object, e As EventArgs) Handles txtTransProg.TextChanged

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub SMSDbDataSetBindingSource_CurrentChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub frmTranscript_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        enableFields(False)

    End Sub

    Private Sub clearFields()

        txtTransDepartment.Clear()
        txtTransDepartment.Clear()
    End Sub

    Private Sub enableFields(value As Boolean)
        txtTransDepartment.Enabled = value
        txtTransFN.Enabled = value
        txtTransLN.Enabled = value
        txtTransProg.Enabled = value
        txtTransHall.Enabled = value
        txtTransGPA.Enabled = value
        txtTransLevel.Enabled = value

    End Sub

    Private Sub txtTransGPA_TextChanged(sender As Object, e As EventArgs)

    End Sub
End Class