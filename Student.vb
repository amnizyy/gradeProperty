Public Class Student
    Private Name As String
    Private Regnum As String
    Private Mark As Integer


    Public Sub New()
        Name = String.Empty
        Regnum = String.Empty
        Mark = 0
    End Sub


    Public Property Nama() As String
        Get
            Return Name
        End Get
        Set(ByVal value As String)
            Name = value
        End Set
    End Property

    Public Property Nummatrik() As String
        Get
            Return Regnum
        End Get
        Set(ByVal value As String)
            Regnum = value
        End Set
    End Property

    Public Property Markah() As Integer
        Get
            Return Mark
        End Get
        Set(ByVal value As Integer)

            If value >= 0 And value <= 100 Then
                Mark = value

            Else
                MessageBox.Show("Invalid value", "Answer Value", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End Set
    End Property

    Public ReadOnly Property checkgrade() As Char
        Get
            Dim Grade As Char
            If Mark >= 80 Then
                Grade = "A"

            ElseIf Mark >= 70 Then
                Grade = "B"

            ElseIf Mark >= 60 Then
                Grade = "C"

            ElseIf Mark >= 50 Then
                Grade = "D"

            Else
                Grade = "E"

            End If
            Return Grade

        End Get
    End Property
End Class
