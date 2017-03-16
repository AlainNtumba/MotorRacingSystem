Public Class EventMaintForm
    Public RaceEvent As RaceEvent
    Dim getTitle As String

    'Driver validator function
    Private Function EventCheckData() As Boolean
        Return DataValidator.IsPresent(txtTitle) AndAlso
            DataValidator.IsMatchingTitle(txtTitle) AndAlso
            DataValidator.IsPresent(txtLocation) AndAlso
            DataValidator.IsDecimal(txtRegFee) AndAlso
            DataValidator.IsInteger(txtLapNum)

    End Function


    Private Sub btnSaveEvent_Click(sender As Object, e As EventArgs) Handles btnSaveEvent.Click

        If EventCheckData() Then
            getTitle = txtTitle.Text
            RaceEvent = New RaceEvent(txtTitle.Text, txtLocation.Text, txtRegFee.Text,
                                      txtLapNum.Text, dtEventDate.Value.ToShortDateString)
            Me.Close()
        End If
    End Sub

    Private Sub btnCancelEvent_Click(sender As Object, e As EventArgs) Handles btnCancelEvent.Click
        Me.Close()
    End Sub
End Class