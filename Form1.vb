Public Class Form1
    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        Dim gradestudent As Student

        gradestudent = New Student

        GetData(gradestudent)

        gradeTxt.Text = gradestudent.checkgrade
    End Sub

    Private Sub GetData(ByVal gradestudent As Student)

        gradestudent.Nama = nameTxt.Text
        gradestudent.Nummatrik = numTxt.Text
        gradestudent.Markah = markTxt.Text

    End Sub

    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        Me.Close()
    End Sub
End Class
