Public Class RaceEvent
    Public Title As String
    Public Location As String
    Public RegistrationFee As String
    Public NumLap As String
    Public EventDate As String

    'Default constructor
    Public Sub New()

    End Sub

    'Custom constructor
    Public Sub New(eTitle As String, eLocation As String, eRegistrationFee As String,
                   eNumLap As String, eEventDate As String)

        Me.Title = eTitle
        Me.Location = eLocation
        Me.RegistrationFee = eRegistrationFee
        Me.NumLap = eNumLap
        Me.EventDate = eEventDate

    End Sub

    'Display event details

    Public Function DisplayEvents()

        Dim eventRecord As String = Title & (vbTab) & Location & (vbTab) &
            EventDate & (vbTab) & RegistrationFee & (vbTab) & NumLap

        Return eventRecord
    End Function

    Public Function EventList()

        Dim eventTitle As String = Title
        Return eventTitle

    End Function


End Class
