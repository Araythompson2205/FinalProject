Class Student
    Inherits Person
    Private studentNum As String
    Public Sub New()
        studentNum = "00000"
        FirstN() = "John"
        LastN() = "Doe"
        Email() = "@mail.net"

    End Sub
    Public Sub New(studNum As String, firstnam As String, secondname As String, mail As String)
        studentNum = studNum
        FirstN() = firstnam
        LastN() = secondname
        Email() = mail

    End Sub
    Public Property StudentNumber() As Integer
        Get
            Return studentNum
        End Get
        Set(value As Integer)
            studentNum = value
        End Set
    End Property
    Function CSV() As String
        Return FirstN() & "," & LastN() & "," & Email() & "," & StudentNumber
    End Function
End Class
