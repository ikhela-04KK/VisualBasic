Module yoyo 

    Sub Main()
    
        Dim prixUnitaire As integer
        Dim n As Integer
        Dim total As Double
        Dim fraisPort As Double
        Dim remise As Double

        Console.WriteLine("Entrez le prix unitaire : ")
        prixUnitaire =Console.ReadLine()

        Console.WriteLine("Entrez la quantité demandée : ")
        n =Console.ReadLine()

        total = prixUnitaire * n

        If total > 500000 Then
            fraisPort = 0
        Else
            fraisPort = total * 0.02
        End If

        If total >= 200000 And total <= 1000000 Then
            remise = total * 0.05
        ElseIf total > 1000000 Then
            remise = total * 0.1
        Else
            remise = 0
        End If

        Console.WriteLine("Le prix total à payer est : " & total)
        Console.WriteLine("Les frais de port sont de : " & fraisPort)
        Console.WriteLine("La remise est de : " & remise)
        Console.WriteLine("Le prix à payer après remise et frais de port est de : " & total + fraisPort -             remise)

        Console.ReadLine()
    End Sub

End Module
