

Partial Public Class SMS_DataSet
    Partial Public Class HallDataTable
        Private Sub HallDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.hall_TutorColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class
End Class

Namespace SMS_DataSetTableAdapters

    Partial Public Class StudentTableAdapter
    End Class
End Namespace
