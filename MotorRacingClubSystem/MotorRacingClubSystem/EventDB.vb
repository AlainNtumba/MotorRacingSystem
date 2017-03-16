Imports System.IO

Public Class EventDB
    Private Const Dir As String = "C:\VB 2017\Files\"
    Private Const Path As String = Dir & "Events.txt"

    Public Shared Function GetEvents() As List(Of RaceEvent)

        If Not Directory.Exists(Dir) Then
            Directory.CreateDirectory(Dir)
        End If

        Dim textIn As New StreamReader(New FileStream(Path, FileMode.OpenOrCreate, FileAccess.Read))
        Dim events As New List(Of RaceEvent)

        Do While textIn.Peek <> -1
            Dim row As String = textIn.ReadLine
            Dim columns() As String = row.Split(CChar("|"))
            Dim raceEvent As New RaceEvent
            raceEvent.Title = columns(0)
            raceEvent.Location = columns(1)
            raceEvent.RegistrationFee = columns(2)
            raceEvent.NumLap = columns(3)
            raceEvent.EventDate = columns(4)
        Loop

        textIn.Close()

        Return events
    End Function

    Public Shared Sub SaveEvents(events As List(Of RaceEvent))

        Dim textOut As New StreamWriter(New FileStream(Path, FileMode.Create, FileAccess.Write))

        For Each raceEvent As RaceEvent In events
            textOut.Write(raceEvent.Title & "|")
            textOut.Write(raceEvent.Location & "|")
            textOut.Write(raceEvent.RegistrationFee & "|")
            textOut.Write(raceEvent.NumLap & "|")
            textOut.Write(raceEvent.EventDate & "|")
        Next

        textOut.Close()
    End Sub

End Class
