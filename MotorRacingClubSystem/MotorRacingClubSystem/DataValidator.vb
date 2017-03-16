Public Class DataValidator

    Public Shared Property Title As String = "Entry Error"


    'Function to check entry in text box fields

    Public Shared Function IsPresent(textBox As TextBox) As Boolean

        If textBox.Text = "" Then
            MessageBox.Show(textBox.Tag.ToString & " is a required field.", Title)
            textBox.Select()
            Return False
        Else
            Return True
        End If

    End Function

    'Function to check if an Event Tilte is already recorded
    Public Shared Function IsMatchingTitle(textBox As TextBox) As Boolean

        Dim x As Integer = Form1.raceEvents.Count
        Dim sentinel As Boolean

        If x > 0 Then

            For Each e As RaceEvent In Form1.raceEvents

                If String.Equals(textBox.Text, e.EventList) Then

                    MessageBox.Show("The event """ & textBox.Text & """ is already recorded!", Title)
                    sentinel = False
                    textBox.Select()
                    Return sentinel

                Else

                    sentinel = True

                End If
            Next
        Else
            sentinel = True
            Return sentinel

        End If

        Return sentinel

    End Function


    Public Shared Function IsDecimal(textBox As TextBox) As Boolean

        Dim fee As Decimal = 0.00
        If Decimal.TryParse(textBox.Text, fee) Then
            Return True
        Else
            MessageBox.Show(textBox.Tag.ToString & " must be a decimal value.", Title)
            textBox.Select()
            textBox.SelectAll()
            Return False
        End If

    End Function


    Public Shared Function IsInteger(textBox As TextBox) As Boolean

        Dim x As Integer = 0
        If Integer.TryParse(textBox.Text, x) Then
            Return True
        Else
            MessageBox.Show(textBox.Tag.ToString & " must be a number value.", Title)
            textBox.Select()
            textBox.SelectAll()
            Return False
        End If

    End Function

    'Check if entered ID is valid
    Public Shared Function IsMemberID(textBox As TextBox) As Boolean
        Dim pass As Integer = 0
        Dim i As Integer = Form1.drivers.Count

        'Check if there is registered members
        If i <> 0 Then

            For Each driver As Driver In Form1.drivers

                If String.Equals(textBox.Text, driver.MemberID) Then
                    pass = 1
                    Return True

                End If

            Next

            If pass < 1 Then

                MessageBox.Show(textBox.Tag.ToString & " is not an existing ID!", Title)
                Return False

            End If

        Else
            MessageBox.Show("There is no registered member in the system", "No Registered Member")
            Return False
        End If

    End Function

End Class
