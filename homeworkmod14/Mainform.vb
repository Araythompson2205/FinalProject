Public Class Mainform
    Dim Obj As CourseEnrollments

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click 'course infor
        CourseForm.Show()
        Me.Hide()
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click  'student info
        StudentForm.Show()
        Me.Hide()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click 'instructor infor
        InstructorForm.Show()
        Me.Hide()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click 'save course
        Obj.saveCourse()
        Obj.saveInstructor()
        Obj.saveInstructor()

    End Sub

    Private Sub Mainform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Computer.FileSystem.FileExists(".txt") Then

        End If
        Obj = New CourseEnrollments
    End Sub
End Class
