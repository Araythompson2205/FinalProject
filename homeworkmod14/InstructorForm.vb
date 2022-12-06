Public Class InstructorForm
    Dim Obj As Instructor


    Private Sub CourseForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Computer.FileSystem.FileExists("instructorTXTSV.csv") Then
            loadFromFile()
            reload()

        Else
            Obj = New Instructor
            ListBox1.Items.Add("First name: " & Obj.FirstN)
            ListBox1.Items.Add("Last name: " & Obj.LastN)
            ListBox1.Items.Add("office number: " & Obj.OfficeNumber)
            ListBox1.Items.Add("Email: " & Obj.Email)
        End If

    End Sub

    Private Sub reload()
        ListBox1.Items.Clear()
        ListBox1.Items.Add("First name: " & Obj.FirstN)
        ListBox1.Items.Add("Last name: " & Obj.LastN)
        ListBox1.Items.Add("office number: " & Obj.OfficeNumber)
        ListBox1.Items.Add("Email: " & Obj.Email)
    End Sub
    Private Sub loadFromFile()


        Dim query = From line In IO.File.ReadAllLines("instructorTXTSV.csv")
                    Let data = line.Split(",")
                    Let first = data(0)
                    Let last = data(1)
                    Let email = data(2)
                    Let officenum = data(3)
                    Select first, last, email, officenum
        For Each item In query
            Obj = New Instructor(item.first, item.last, item.email, item.officenum)
        Next


    End Sub
    Function saveInstructor() As String
        Dim file As System.IO.StreamWriter
        file = My.Computer.FileSystem.OpenTextFileWriter("instructorTXTSV.csv", False)
        file.WriteLine(Obj.CSV())
        file.Close()

    End Function

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Obj.FirstN = InputBox("Enter the new First name: ")
        Obj.LastN = InputBox("Enter the new last name: ")
        Obj.OfficeNumber = InputBox("Enter Instructors office number")
        Obj.Email = InputBox("Enter the instructor's email: ")
        reload()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        saveInstructor()
        MessageBox.Show("File saved!")
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        Mainform.Show()
        Me.Close()
    End Sub
End Class