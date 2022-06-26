Module Module1

    Dim myPerson As Person

    Sub Main()
        Dim person1 As Person = createPerson()
        createPet(person1)
        Console.ReadLine()
    End Sub


    Private Function createPerson() As Person
        Console.WriteLine("---- Ingresar Usuario ----")
        Console.WriteLine("--Por favor digita tu(s) nombre(s): ")
        Dim namesPerson As String = Console.ReadLine()
        Console.WriteLine("--Por favor digita tu(s) apellido(s): ")
        Dim lastNamesPerson As String = Console.ReadLine()
        Console.WriteLine("--Por favor digita tu documento: ")
        Dim documentPerson As Long = Console.ReadLine()
        Console.WriteLine("--Por favor digita tu número de teléfono: ")
        Dim phoneNumberPerson As String = Console.ReadLine()
        myPerson = New Person(namesPerson, lastNamesPerson, documentPerson, phoneNumberPerson)
        Console.WriteLine("--- Usuario creado con exito ---")
        Return myPerson
    End Function


    Private Sub createPet(myPerson As Person)
        Dim idPet As Integer = 1
        Dim menuNumber As Integer
        Dim validationText As String
        Dim flagTraining As Boolean

        Do
            Console.WriteLine("----  Por favor, selecciona el tipo de mascota que tienes: ----")
            Console.WriteLine("1. Gato. ")
            Console.WriteLine("2. Perro. ")
            Console.WriteLine("3. Ninguno de los dos. ")
            menuNumber = Console.ReadLine()
            Select Case menuNumber
                Case 1
                    Console.WriteLine("--Por favor ingresa el nombre de tu gato: ")
                    Dim nameCat As String = Console.ReadLine()
                    Console.WriteLine("--Por favor ingresa la raza de tu gato: ")
                    Dim raceCat As String = Console.ReadLine()
                    Console.WriteLine("--Por favor ingresa el género de tu gato (M - Masculino/F - Femenino): ")
                    Dim genreCat As Char = Console.ReadLine()
                    Console.WriteLine("--Por favor ingresa la edad de tu gato: ")
                    Dim ageCat As Integer = Console.ReadLine()
                    Console.WriteLine("--Por favor ingresa el número de vidas de tu gato: ")
                    Dim numberLifesCat As Integer = Console.ReadLine()
                    Dim myPetCat As Cat = New Cat(idPet, nameCat, raceCat, genreCat, ageCat, myPerson, numberLifesCat)
                    Console.WriteLine("Mascota {0} registrada con exito.", myPetCat.NamePet1())
                Case 2
                    Console.WriteLine("--Por favor ingresa el nombre de tu perro: ")
                    Dim nameDog As String = Console.ReadLine()
                    Console.WriteLine("--Por favor ingresa la raza de tu perro: ")
                    Dim raceDog As String = Console.ReadLine()
                    Console.WriteLine("--Por favor ingresa el género de tu perro solo un caracter (M - Masculino/F - Femenino): ")
                    Dim genreDog As Char = Console.ReadLine()
                    Console.WriteLine("--Por favor ingresa la edad de tu perro: ")
                    Dim ageDog As Integer = Console.ReadLine()
                    Console.WriteLine("--Tú perro ya está entrenado o no ?: ")
                    Dim traningDog As String = Console.ReadLine()
                    If traningDog = "Si" Or traningDog = "SI" Or traningDog = "si" Or traningDog = "Sí" Then
                        flagTraining = True
                    Else
                        flagTraining = False
                    End If
                    Dim myPetDog As Dog = New Dog(idPet, nameDog, raceDog, genreDog, ageDog, myPerson, flagTraining)
                    Console.WriteLine("Mascota {0} registrada con exito.", myPetDog.NamePet1())
                Case 3
                    Console.WriteLine("Gracias, vuelva pronto")
                Case Else
                    Console.WriteLine("Menú de opción no valida")
            End Select
            idPet += 1
            Console.WriteLine("¿Desea volver a visualizar el menú?")
            validationText = Console.ReadLine()
        Loop While validationText = "Si" Or validationText = "Sí" Or validationText = "SI" Or validationText = "si"
        Console.WriteLine("---- Fin del programa ----")
    End Sub

End Module
