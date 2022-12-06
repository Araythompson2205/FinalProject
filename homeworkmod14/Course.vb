Class Course
    Private coursenum As Integer
    Private coursen As String
    Private unit As Integer
    Private roomnum As String

    Public Sub New()
        coursenum = 1
        coursen = "default class"
        unit = 3
        roomnum = "101a"
    End Sub
    Public Sub New(coursenumb As Integer, name As String, unt As Integer, roomnumb As String)
        coursenum = coursenumb
        coursen = name
        unit = unt
        roomnum = roomnumb
    End Sub
    Public Property CourseNumber
        Get
            Return coursenum
        End Get
        Set(value)
            coursenum = value
        End Set
    End Property
    Public Property CourseName
        Get
            Return coursen
        End Get
        Set(value)
            coursen = value
        End Set
    End Property
    Public Property Units
        Get
            Return unit
        End Get
        Set(value)
            unit = value
        End Set
    End Property
    Public Property RoomNumber
        Get
            Return roomnum
        End Get
        Set(value)
            roomnum = value
        End Set
    End Property
    Function CSV() As String
        Return CourseNumber() & "," & CourseName() & "," & Units() & "," & RoomNumber()
    End Function
End Class
