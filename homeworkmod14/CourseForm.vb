Public Class CourseForm
    Dim Obj As Course
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Mainform.Show()
        Me.Close()
    End Sub

    Private Sub CourseForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Computer.FileSystem.FileExists("courseTXTSV.csv") Then
            loadFromFile()
            reload()
        Else
            Obj = New Course
            ListBox1.Items.Add("Course name: " & Obj.CourseName)
            ListBox1.Items.Add("Course number: " & Obj.CourseNumber)
            ListBox1.Items.Add("Room Number: " & Obj.RoomNumber)
            ListBox1.Items.Add("Units: " & Obj.Units)
        End If

    End Sub
    Private Sub loadFromFile()


        Dim query = From line In IO.File.ReadAllLines("courseTXTSV.csv")
                    Let data = line.Split(",")
                    Let coursenum = data(0)
                    Let courseN = data(1)
                    Let units = data(2)
                    Let roomnum = data(3)
                    Select courseN, coursenum, roomnum, units
        For Each item In query
            Obj = New Course(item.coursenum, item.courseN,item.units,item.roomnum)
        Next


    End Sub
    Private Sub reload()
        ListBox1.Items.Clear()
        ListBox1.Items.Add("Course name: " & Obj.CourseName)
        ListBox1.Items.Add("Course number: " & Obj.CourseNumber)
        ListBox1.Items.Add("Room Number: " & Obj.RoomNumber)
        ListBox1.Items.Add("Units: " & Obj.Units)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Obj.CourseName = InputBox("Enter the new course name: ")
        Obj.CourseNumber = InputBox("Enter the course's ID number: ")
        Obj.RoomNumber = InputBox("Enter the course's room number")
        Obj.Units = CInt(InputBox("Enter the number of units the course may be: "))
        reload()
    End Sub
    Function saveCourse() As String
        Dim file As System.IO.StreamWriter
        file = My.Computer.FileSystem.OpenTextFileWriter("courseTXTSV.csv", False)
        file.WriteLine(Obj.CSV())
        file.Close()

    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        saveCourse()
        MessageBox.Show("File saved!")
    End Sub
End Class