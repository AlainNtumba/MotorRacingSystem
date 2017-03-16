Imports System.IO

Public Class DriverDB
    Private Const Dir As String = "C:\VB 2017\Files\"
    Private Const Path As String = Dir & "Drivers.txt"

    Public Shared Function GetDrivers() As List(Of Driver)

        If Not Directory.Exists(Dir) Then
            Directory.CreateDirectory(Dir)
        End If

        Dim textIn As New StreamReader(New FileStream(Path, FileMode.OpenOrCreate, FileAccess.Read))
        Dim drivers As New List(Of Driver)

        Do While textIn.Peek <> -1
            Dim row As String = textIn.ReadLine
            Dim columns() As String = row.Split(CChar("|"))
            Dim driver As New Driver
            driver.Name = columns(0)
            driver.Surname = columns(1)
            driver.MemberID = columns(2)
            driver.BirthDate = columns(3)
            driver.MemberGender = columns(4)
            driver.MembershipFee = columns(5)
            driver.DateJoined = columns(6)
        Loop

        textIn.Close()

        Return drivers
    End Function

    Public Shared Sub SaveDrivers(drivers As List(Of Driver))

        Dim textOut As New StreamWriter(New FileStream(Path, FileMode.Create, FileAccess.Write))

        For Each driver As Driver In drivers
            textOut.Write(driver.Name & "|")
            textOut.Write(driver.Surname & "|")
            textOut.Write(driver.MemberID & "|")
            textOut.Write(driver.BirthDate & "|")
            textOut.Write(driver.MemberGender & "|")
            textOut.Write(driver.MembershipFee & "|")
            textOut.Write(driver.DateJoined)
        Next

        textOut.Close()
    End Sub

End Class
