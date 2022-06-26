Public Class Dog : Inherits Pet

    Private training As Boolean

    Public Sub New(idPet As Integer, namePet As String, racePet As String, genderPet As Char, agePet As Integer, personPet As Person, training As Boolean)
        MyBase.New(idPet,
                   namePet,
                   racePet,
                   genderPet,
                   agePet,
                   personPet,
                   training)
        Me.training = training
    End Sub

    Public Property Training1 As Boolean
        Get
            Return training
        End Get
        Set(value As Boolean)
            training = value
        End Set
    End Property
End Class
