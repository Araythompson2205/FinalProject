'Due to how my final design ended up, with seperate forms and save functions for each part of the program, this class is unused.
Class CourseEnrollments
    Private Classes As Course
    Private Teacher As Instructor
    Private Students() As Student
    Private StuCount As Integer
    Public Sub New()

        Teacher = New Instructor
        Classes = New Course
        StuCount = 0

    End Sub

    Public Sub New(Classe As Course, teach As Instructor, stude() As Student)
        Classes = Classe
        Teacher = teach
        Dim n = 0
        For Each item In stude
            Students.Append(stude(n))
            n = n + 1
        Next
        StudentCount = Students.Length
    End Sub
    Property Courses As Course
        Get
            Return Classes
        End Get
        Set(value As Course)
            Classes = value
        End Set
    End Property
    Property Instructors As Instructor
        Get
            Return Teacher
        End Get
        Set(value As Instructor)
            Teacher = value
        End Set
    End Property
    Property Stu(n As Integer) As Student
        Get
            Return Students(n)
        End Get
        Set(value As Student)
            If n > -1 Then

                Students(n) = value
            Else
                Students.Append(value)
            End If

        End Set
    End Property
    Property StudentCount As Integer
        Get
            Return StuCount
        End Get
        Set(value As Integer)
            StuCount = value
        End Set
    End Property
    Function saveCourse() As String
        Dim file As System.IO.StreamWriter
        file = My.Computer.FileSystem.OpenTextFileWriter("courseTXTSV.csv", True)
        file.WriteLine(Courses().CSV())
    End Function
    Function saveInstructor() As String
        Dim file As System.IO.StreamWriter
        file = My.Computer.FileSystem.OpenTextFileWriter("instructorTXTSV.csv", True)
        file.WriteLine(Instructors().CSV())
    End Function
    Function saveStudents() As String
        Dim file As System.IO.StreamWriter
        file = My.Computer.FileSystem.OpenTextFileWriter("StudentsTXTSV.csv", True)
        Dim i = 0
        For Each item In Students

            file.WriteLine(Students(i).CSV())
            i = i + 1

        Next

    End Function

End Class
