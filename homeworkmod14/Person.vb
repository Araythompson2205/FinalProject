MustInherit Class Person

    Private firstname As String
    Private lastname As String
    Private mail As String
    Public Sub New()

        FirstN() = "John"
        LastN() = "Doe"
        Email() = "@mail.net"

    End Sub
    Public Property FirstN() As String
        Get
            Return firstname
        End Get
        Set(value As String)
            firstname = value
        End Set
    End Property
    public Property LastN() As String
        Get
            Return lastname
        End Get
        Set(value As String)
            lastname = value
        End Set
    End Property
    Property Email() As String
        Get
            Return mail
        End Get
        Set(value As String)
            mail = value
        End Set
    End Property

End Class
