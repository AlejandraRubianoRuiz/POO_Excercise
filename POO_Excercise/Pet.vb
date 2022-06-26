Public Class Pet
    Private idPet As Integer
    Private namePet As String
    Private racePet As String
    Private genderPet As Char
    Private agePet As Integer

    Private personPet As Person

    'Constructor'
    Public Sub New(idPet As Integer, namePet As String, racePet As String, genderPet As Char, agePet As Integer, personPet As Person, numberLifes As Integer)
        Me.idPet = idPet
        Me.namePet = namePet
        Me.racePet = racePet
        Me.genderPet = genderPet
        Me.agePet = agePet
        Me.personPet = personPet
    End Sub

    Public Sub New()
    End Sub

    'Getters and Setters'
    Public Property IdPet1 As Integer
        Get
            Return idPet
        End Get
        Set(value As Integer)
            idPet = value
        End Set
    End Property

    Public Property NamePet1 As String
        Get
            Return namePet
        End Get
        Set(value As String)
            namePet = value
        End Set
    End Property

    Public Property RacePet1 As String
        Get
            Return racePet
        End Get
        Set(value As String)
            racePet = value
        End Set
    End Property

    Public Property GenderPet1 As Char
        Get
            Return genderPet
        End Get
        Set(value As Char)
            genderPet = value
        End Set
    End Property

    Public Property AgePet1 As Integer
        Get
            Return agePet
        End Get
        Set(value As Integer)
            agePet = value
        End Set
    End Property


End Class
