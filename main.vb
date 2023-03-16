'On sait que l'eau gêle à zéro dégré ; l'eau salé gêle à moins 3 degré 
'le fiol a -5 dégré , l'ordilaire gële à -13 dégré , le super gêle à -23 dégrés 
' ecris un programme qui demande une température et donne sort la liste desliquides qui gêles à cette température 

Module projet
  Sub Main()
      dim temp as integer
      console.WriteLine("entrer la température: ")
      temp = console.ReadLine()
    
      if temp >= 0 then
        Console.WriteLine("L'eau gèle à cette température.") 
      End if
      if temp >= -3 then
        Console.WriteLine("L'eau salée gèle à cette température.")
      End if
      if temp >= -5 then
        Console.WriteLine("Le fioul gèle à cette température.")
      End if
      if temp >= -13 then
        Console.WriteLine("L'ordinaire gèle à cette température.")
      End if
      if temp >= -23 then
        Console.WriteLine("Le super gèle à cette température.")
      End if
  End Sub 
end Module 

