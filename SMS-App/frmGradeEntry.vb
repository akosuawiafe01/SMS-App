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
        Dim strCon As String = "Data Source=.;Initial Catalog=SMS-Db;Integrated Security=True"
        Dim strSQL As String = "select courseCode, courseTitle, creditHours, score, grade  from Transcript_ResultSlip where studID='" & txtStuID.Text & "' "
        Dim dataAdapter As New SqlClient.SqlDataAdapter(strSQL, strCon)
        Dim table As New DataTable
        dataAdapter.Fill(table)
        dgvGradeEntry.DataSource = table

    End Sub
End Class