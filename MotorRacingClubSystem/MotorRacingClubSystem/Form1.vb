Public Class Form1
    Public drivers As List(Of Driver)
    Public raceEvents As List(Of RaceEvent)


    'Function to display drivers in the ListBox 
    Private Sub FillDriversList()
        lstDrivers.Items.Clear()
        For Each d As Driver In drivers
            lstDrivers.Items.Add(d.DisplayDrivers)
        Next
    End Sub

    'Function to display Event in the ListBox
    Private Sub FillEventsList()
        lstEvents.Items.Clear()
        For Each r As RaceEvent In raceEvents
            lstEvents.Items.Add(r.DisplayEvents)
        Next
    End Sub

    'Function to match driverID
    Private Sub MatchId(textBox As TextBox)


        'For Each Loop to match entered member ID with an exiciting ID then display member information
        For Each driver As Driver In drivers

            If String.Equals(textBox.Text, driver.MemberID) Then

                Dim editDriver As New DriverMaintForm
                editDriver.txtName.Text = driver.Name
                editDriver.txtSurname.Text = driver.Surname
                editDriver.txtFee.Text = driver.MembershipFee
                editDriver.lbDisplayId.Text = "ID: " & driver.MemberID
                If driver.MemberGender = "Female" Then
                    editDriver.rdFemale.Select()
                Else
                    editDriver.rdMale.Select()
                End If

                editDriver.ShowDialog()

                If editDriver.Driver IsNot Nothing Then
                    drivers.Remove(driver)
                    drivers.Add(editDriver.Driver)
                    DriverDB.SaveDrivers(drivers)
                    Me.FillDriversList()
                End If

                Exit For

            End If
        Next


    End Sub



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Get drivers from the text file then call a function to display them in the drivers ListBox
        drivers = DriverDB.GetDrivers
        Me.FillDriversList()

        'Get events from the text file then call a function to display them in the event ListBox
        raceEvents = EventDB.GetEvents
        Me.FillEventsList()
    End Sub

    Private Sub btnAddDriver_Click(sender As Object, e As EventArgs) Handles btnAddDriver.Click

        Dim newDriver As New DriverMaintForm
        newDriver.ShowDialog()

        If newDriver.Driver IsNot Nothing Then
            drivers.Add(newDriver.Driver)
            DriverDB.SaveDrivers(drivers)
            Me.FillDriversList()
        End If

    End Sub

    Private Sub btnDeleteDriver_Click(sender As Object, e As EventArgs) Handles btnDeleteDriver.Click

        Dim x As Integer = lstDrivers.SelectedIndex

        If x <> -1 Then
            Dim driver As Driver = drivers(x)

            If driver.EventCompeted Is Nothing Then

                Dim msg As String = "Do you want to delete " & driver.Name & "?"
                Dim button As DialogResult = MessageBox.Show(msg, "Confirm Delete", MessageBoxButtons.YesNo)

                If button = DialogResult.Yes Then
                    drivers.Remove(driver)
                    DriverDB.SaveDrivers(drivers)
                    Me.FillDriversList()
                End If

            Else
                MessageBox.Show("Driver's records cannot be deleted")
            End If

        Else

            MessageBox.Show("Select a driver to delete")

        End If
    End Sub

    Private Sub btnEditDriver_Click(sender As Object, e As EventArgs) Handles btnEditDriver.Click

        Dim x As Integer = lstDrivers.SelectedIndex

        If x <> -1 Then

            Dim driver As Driver = drivers(x)

            Dim editDriver As New DriverMaintForm
            editDriver.txtName.Text = driver.Name
            editDriver.txtSurname.Text = driver.Surname
            editDriver.txtFee.Text = driver.MembershipFee
            editDriver.lbDisplayId.Text = "ID: " & driver.MemberID
            If driver.MemberGender = "Female" Then
                editDriver.rdFemale.Select()
            Else
                editDriver.rdMale.Select()
            End If

            editDriver.ShowDialog()

            If editDriver.Driver IsNot Nothing Then
                drivers.Remove(driver)
                drivers.Add(editDriver.Driver)
                DriverDB.SaveDrivers(drivers)
                Me.FillDriversList()
            End If

        Else

            MessageBox.Show("Select a driver to be edited")

        End If
    End Sub

    Private Sub btnExitDriver_Click(sender As Object, e As EventArgs) Handles btnExitDriver.Click
        Me.Close()
    End Sub


    'Button add event
    Private Sub btnAddEvent_Click(sender As Object, e As EventArgs) Handles btnAddEvent.Click

        'Declare variable as EventMaintForm then open EventMaintForm as diaglog form
        Dim newEvent As New EventMaintForm
        newEvent.ShowDialog()

        'check if dialog form returns value then add value to the event list variable 
        'then save it to the text file 
        If newEvent.RaceEvent IsNot Nothing Then

            EventDB.SaveEvents(raceEvents)
            raceEvents.Add(newEvent.RaceEvent)
            Me.FillEventsList()

        End If
    End Sub


    'Button delete event
    Private Sub btnDeleteEvent_Click(sender As Object, e As EventArgs) Handles btnDeleteEvent.Click

        'Store the index of the selected event in a variable
        Dim y As Integer = lstEvents.SelectedIndex
        'Çheck the index of the selected event prompt use to confirm deletio 
        If y <> -1 Then
            Dim raceEvent As RaceEvent = raceEvents(y)
            Dim msg As String = "Do you want to delete " & raceEvent.Title & "?"
            Dim button As DialogResult = MessageBox.Show(msg, "Confirm Delete", MessageBoxButtons.YesNo)

            'delete the event from the ListBox and update the file text
            If button = DialogResult.Yes Then
                raceEvents.Remove(raceEvent)
                EventDB.SaveEvents(raceEvents)
                Me.FillEventsList()
            End If

        Else

            MessageBox.Show("Select an Event to delete")

        End If
    End Sub


    'Edit event button
    Private Sub btnEditEvent_Click(sender As Object, e As EventArgs) Handles btnEditEvent.Click

        Dim y As Integer = lstEvents.SelectedIndex

        If y <> -1 Then

            Dim raceEvent As RaceEvent = raceEvents(y)

            Dim editEvent As New EventMaintForm
            editEvent.txtTitle.Text = RaceEvent.Title
            editEvent.txtLocation.Text = raceEvent.Location
            editEvent.txtRegFee.Text = raceEvent.RegistrationFee
            editEvent.dtEventDate.Text = raceEvent.EventDate
            editEvent.txtLapNum.Text = raceEvent.NumLap
            editEvent.ShowDialog()

            If editEvent.RaceEvent IsNot Nothing Then
                raceEvents.Remove(raceEvent)
                raceEvents.Add(editEvent.RaceEvent)
                EventDB.SaveEvents(raceEvents)
                Me.FillEventsList()
            End If

        Else

            MessageBox.Show("Select an event to be edited")

        End If
    End Sub

    Private Sub btnExitEvent_Click(sender As Object, e As EventArgs) Handles btnExitEvent.Click
        Me.Close()
    End Sub

    Private Sub btnSearchId_Click(sender As Object, e As EventArgs) Handles btnSearchId.Click

        If DataValidator.IsPresent(txtEnterId) AndAlso
                DataValidator.IsMemberID(txtEnterId) Then

            MatchId(txtEnterId)

        End If

    End Sub
End Class
