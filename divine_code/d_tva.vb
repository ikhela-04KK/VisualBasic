Imports System

Module Program
    Sub Main(args As String())  ' si tu veux compiler pour verifier tape cd divine_code/ && dotnet run
        Dim nombreA As Integer
        Dim prixU!
        Dim port!
        Dim prixT!
        Dim remise!
        Dim prixtotal!
        port = 0
        Console.WriteLine("entrer le nombre d'article”)
        nombreA = Console.ReadLine()
        Console.WriteLine("entrer le prix de l'article”)
        prixU = Console.ReadLine()
        prixT = nombreA * prixU

        If prixT > 500000 Then  'le problème est que tu as mal imbriqué les if
            port = 0  
        End If
        If prixT < 500000 Then
            port = (prixT * 2) / 100
        End 
      
        If prixT >= 200000 And prixT <= 1000000 Then 
            remise = (prixT * 5) / 100
        End If
        If prixT > 1000000 Then
            remise = (prixT * 10) / 100
        End If

        prixtotal = prixT + port - remise

        Console.WriteLine(”Le prix total est :” & prixtotal)
        Console.WriteLine(”Le prix brute est :” & prixT)
        Console.WriteLine(”frais de port :” & port)
        Console.WriteLine(”La remise est de :” & remise)
        Console.ReadLine()
    End Sub
End Module
