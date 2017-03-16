Public Class DriverMaintForm

    Public Driver As Driver
    Dim gender As String

    'Function to update the comboBox with event titles from the events text file
    Private Sub UpdateEventCbBox()

        Me.cbEventList.Items.Clear()
        For Each raceE As RaceEvent In Form1.raceEvents
            Me.cbEventList.Items.Add(raceE.EventList)
        Next
    End Sub


    'Driver validator function
    Private Function IsValidData() As Boolean
        Return DataValidator.IsPresent(txtName) AndAlso
            DataValidator.IsPresent(txtSurname) AndAlso
            DataValidator.IsPresent(txtFee) AndAlso
            DataValidator.IsDecimal(txtFee)
    End Function

    Private Sub btnSaveDriver_Click(sender As Object, e As EventArgs) Handles btnSaveDriver.Click

        If IsValidData() Then

            Driver = New Driver(txtName.Text, txtSurname.Text, txtFee.Text,
                            dtBirthDate.Value.ToString("yyyyMMdd"),
                                gender, dtDateJoined.Value.ToShortDateString, cbEventList.SelectedItem, txtPosition.Text)

            Me.Close()
        End If
    End Sub

    Private Sub rdMale_CheckedChanged(sender As Object, e As EventArgs) Handles rdMale.CheckedChanged
        gender = "Male"
    End Sub

    Private Sub rdFemale_CheckedChanged(sender As Object, e As EventArgs) Handles rdFemale.CheckedChanged
        gender = "Female"
    End Sub

    Private Sub btnCancelDriver_Click(sender As Object, e As EventArgs) Handles btnCancelDriver.Click
        Me.Close()
    End Sub

    Private Sub cbEventList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbEventList.SelectedIndexChanged

    End Sub

    Private Sub DriverMaintForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.UpdateEventCbBox()
    End Sub

End Class