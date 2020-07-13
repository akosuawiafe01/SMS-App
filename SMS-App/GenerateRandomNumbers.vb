Public Module GenerateRandomNumbers

    'Generating Random Numbers
    Public Function randomInteger(ByVal rLength As Integer) As String
            Dim rdm As New Random()
            rLength = 5
            Dim allowChrs() As Char = "01234".ToCharArray()
            Dim str As String = ""

            'For i As Integer = 0 To rLength - 1
            For i As Integer = 0 To rLength - 1
                str += allowChrs(rdm.Next(0, allowChrs.Length))
            Next

            Return str
        End Function




End Module
