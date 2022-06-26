Public Class Cat : Inherits Pet

    Private numberLifes As Integer

    Public Sub New(idPet As Integer, namePet As String, racePet As String, genderPet As Char, agePet As Integer, personPet As Person, numberLifes As Integer)
        MyBase.New(idPet,
                   namePet,
                   racePet,
                   genderPet,
                   agePet,
                   personPet,
                   numberLifes)
        Me.numberLifes = numberLifes
    End Sub

    Public Property NumberLifes1 As Integer
        Get
            Return numberLifes
        End Get
        Set(value As Integer)
            numberLifes = value
        End Set
    End Property

End Class
