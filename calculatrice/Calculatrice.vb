Module Calculatrice
        ' Déclaration des variables
        Dim nombre1 As Double
        Dim nombre2 As Double
        Dim resultat As Double
        Dim operation As String
        
        Function Calculer(operation As String) As Double
            Console.Writeline("Entrez le premier nombre: ")
            nombre1 = Double.Parse(Console.ReadLine())

            Console.Writeline("Entrez le deuxième nombre: ")
            nombre2 = Double.Parse(Console.ReadLine())

    
            ' Utilisation de la structure de contrôle Select Case pour choisir l'opération à effectuer
            
    
            if operation = "+" then
              resultat = nombre1 + nombre2

            elseif operation ="-" then
              resultat = nombre1 - nombre2

            elseif operation ="*" then
               resultat= nombre1 * nombre2

            elseif operation ="/" then
               resultat = nombre1 / nombre2
            
            end if 'et puis on affiche non?

    
            ' Select Case operation
            '     Case "+"
      
            '         resultat = nombre1 + nombre2
            '     Case "-"
            '         resultat = nombre1 - nombre2
            '     Case "*"
            '         resultat = nombre1 * nombre2
            '     Case "/"
            '         resultat = nombre1 / nombre2
            ' End Select

            ' Retourne le résultat de l'opération
            Return resultat
        End Function

    Sub Main()
    
        ' Programme principal
        Console.WriteLine("Calculatrice de base")
        Console.WriteLine("--------------------------------")
        Console.WriteLine("Opérations disponibles : +, -, *, /")

        ' Demande à l'utilisateur de choisir une opération
        Console.Write("Entrez une opération : ")
        operation = Console.ReadLine()

        ' Calculer le résultat
        resultat = Calculer(operation)

        ' Affiche le résultat
        Console.WriteLine("Le résultat est : " & resultat)
        Console.ReadLine()
    End Sub
End Module


