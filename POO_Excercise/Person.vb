Public Class Person

    Private names As String
    Private lastNames As String
    Private docoment As Long
    Private phoneNumber As String

    '------ Constructor -----'
    Public Sub New(names As String, lastNames As String, docoment As Long, phoneNumber As String)
        Me.names = names
        Me.lastNames = lastNames
        Me.docoment = docoment
        Me.phoneNumber = phoneNumber
    End Sub

    Public Sub New()
    End Sub

    'Getters & Setters'
    Public Property Names1 As String
        Get
            Return names
        End Get
        Set(value As String)
            names = value
        End Set
    End Property

    Public Property LastNames1 As String
        Get
            Return lastNames
        End Get
        Set(value As String)
            lastNames = value
        End Set
    End Property

    Public Property Docoment1 As Long
        Get
            Return docoment
        End Get
        Set(value As Long)
            docoment = value
        End Set
    End Property

    Public Property PhoneNumber1 As String
        Get
            Return phoneNumber
        End Get
        Set(value As String)
            phoneNumber = value
        End Set
    End Property

    Private Sub register()
        Console.WriteLine("User Register :)")
    End Sub


End Class
