Public Class Driver
    'Fields
    Public Name As String
    Public Surname As String
    Public BirthDate As String
    Public MemberGender As String
    Public MemberID As String
    Public DateJoined As String
    Public MembershipFee As String
    Public EventCompeted As String
    Public DriverPos As String


    'Default constructor
    Public Sub New()

    End Sub

    'Custom constructor
    Public Sub New(dName As String, dSurname As String, dFee As String,
                   dBirthDate As String, dGender As String,
                   dDateJoined As String, sEvent As String, dPosition As String)
        Me.Name = dName
        Me.Surname = dSurname
        Me.MembershipFee = dFee
        Me.BirthDate = dBirthDate
        Me.MemberGender = dGender
        Me.DateJoined = dDateJoined
        Me.MemberID = driverID()
        Me.EventCompeted = sEvent
        Me.DriverPos = dPosition


    End Sub

    'Function to generate driver's membership number
    Private Function driverID()

        'declare variables and assign values

        'Dim driverBirthDate As String
        'driverBirthDate = BirthDate.ToString("yyyyMMdd")
        Dim dJoined As String
        dJoined = Year(DateJoined).ToString
        dJoined = dJoined.Remove(0, 2)
        Dim sumIdDigits As Integer = 0
        Dim joinIdElements As String
        Dim randomNumber As String
        Dim idCheckDigit As Integer
        Dim drId As String

        'Generate random number
        Randomize()
        Dim rdnValue As Integer = CInt(Int((999 * Rnd()) + 0))
        randomNumber = CStr(rdnValue)

        'Make sure that membership number has 13 digits
        Dim rdNumCheck As Integer = randomNumber.Count

        If rdNumCheck < 3 Then

            randomNumber = randomNumber.Insert(0, "0")
            rdNumCheck += 1

        End If

        joinIdElements = dJoined & BirthDate & randomNumber

        'Make sure that membership number has 13 digits
        If joinIdElements.Count < 13 Then

        End If

        'Sum the first 13 digits in the driver ID 

        Dim z As String
        For y As Integer = 0 To joinIdElements.Count - 1

            z = joinIdElements.Substring(y, 1)

            sumIdDigits += CInt(z)

        Next

        'Get the ID check value
        idCheckDigit = sumIdDigits Mod 10

        'Get driver ID number 

        If idCheckDigit = 0 Then
            idCheckDigit = 0
            drId = joinIdElements & CStr(idCheckDigit)
        Else
            idCheckDigit = 10 - idCheckDigit
            drId = joinIdElements & CStr(idCheckDigit)
        End If

        Return drId

    End Function

    'Function to validate a membership number
    Public Function membershipIdValidator()
        Dim validator As Integer
        Dim x As String
        Dim msg As String

        For i As Integer = 0 To MemberID.Count - 1

            x = MemberID.Substring(i, 1)
            validator += CInt(x)

        Next

        If validator Mod 10 = 0 Then
            msg = MemberID & " is a valid Id! "
        Else
            msg = MemberID & " is an invalid Id! "
        End If

        Return msg
    End Function

    Public Function DisplayDrivers()

        Dim driverRecord As String = Name & (vbTab) & Surname & (vbTab) &
            BirthDate & (vbTab) & MemberGender & (vbTab) &
            MemberID & (vbTab) & DateJoined & (vbTab) & MembershipFee &
            EventCompeted & (vbTab) & DriverPos

        Return driverRecord
    End Function
End Class
