Module 
  Sub Main()
    dim ql as integer = 0
    dim qs as  integer = 50

    console.WriteLn("entrer la quantité lot que vous voulez ")
    qe = console.Readline()

    if (ql=>1 and ql<=100) and (ql > qs)  then 
      if
      ql =ql + 100
      qs = qs -50
    end if
    
    console.Writeline("la quantité en stock est: " &qs)
    console.Writeline("la quantité de lot est: ", &qe)
  end Sub
End Module

' a partir de la saisie d'un prix unitaire et de la quantité demandé affiché le prix à payé en détaillant les fraît des ports et la remise sachant que: 
' le port est gratuit si le prix des produits (total ) est supérieur à 5000.000fr 
' dans le cas contraire le port est de 2% du total 
' la remise est de 5% si total est compris entre 200.000 et 1.000.000 et 10% au délà 
' ecrire le programme en vb 
'