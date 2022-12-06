Class Instructor
    Inherits Person
    Private officenum As String
    Public Sub New()
        OfficeNumber() = "101A"
        FirstN() = "John"
        LastN() = "Doe"
        Email() = "@mail.net"

    End Sub
    Public Sub New(office As String, firstnam As String, lasnam As String, mail As String)
        OfficeNumber() = office
        FirstN() = firstnam
        LastN() = lasnam
        Email() = mail

    End Sub
    Public Property OfficeNumber() As String
        Get
            Return officenum
        End Get
        Set(value As String)
            officenum = value
        End Set
    End Property
    Function CSV() As String
        Return FirstN() & "," & LastN() & "," & Email() & "," & OfficeNumber()
    End Function
End Class