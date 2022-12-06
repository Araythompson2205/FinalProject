Public Class StudentForm
    Private Obj(20) As Student
    Private num As Integer
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Mainform.Show()
        Me.Close()
    End Sub

    Private Sub CourseForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If My.Computer.FileSystem.FileExists("StudentsTXTSV.csv") Then
            loadFromFile()
            reload()

        Else
            Obj(0) = New Student("2146729", "Andrew", "Thompson", "ThisDude1234@mail.net")
        studentbox.Text = Obj.Length
            reload()
        End If

    End Sub
    Private Sub loadFromFile()

        num = 0
        Dim query = From line In IO.File.ReadAllLines("StudentsTXTSV.csv")
                    Let data = line.Split(",")
                    Let firstN = data(0)
                    Let lastn = data(1)
                    Let email = data(2)
                    Let stunum = data(3)
                    Select firstN, lastn, email, stunum
        For Each item In query
            Obj(num) = New Student(item.stunum, item.firstN, item.lastn, item.email)
            num = num + 1
        Next

    End Sub
    Private Sub reload()
        ListBox1.Items.Clear()
        Dim n = 0
        ListBox1.Items.Clear()
        For i As Integer = 0 To num - 1
            ListBox1.Items.Add("Student number: " & Obj(i).StudentNumber & ", Name: " & Obj(i).FirstN & " " & Obj(i).LastN & ", Email: " & Obj(i).Email())

        Next
        studentbox.Text = num

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim holder As New Student

        holder.FirstN = InputBox("Enter the new First name: ")
        holder.LastN = InputBox("Enter the new last name: ")
        holder.StudentNumber = InputBox("Enter students id number")
        holder.Email = InputBox("Enter the Student's email: ")
        Obj(num) = holder
        num = num + 1

        reload()
    End Sub
    Function saveStudents() As String
        Dim file As System.IO.StreamWriter
        file = My.Computer.FileSystem.OpenTextFileWriter("StudentsTXTSV.csv", False)
        Dim n = 0
        For i As Integer = 0 To num - 1
            file.WriteLine(Obj(i).CSV())

        Next
        file.Close()
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        saveStudents()
        MessageBox.Show("File saved!")
    End Sub
End Class