' A partir de la saisie d'un prix unitaire et de la quantité demandé 
' Affiché le prix à payé en détaillant les fraît des ports et la remiseise sachant que: 
' le port est gratuit si le prix des produits (total ) est supérieur à 5000.000fr 
' dans le cas contraire le port est de 2% du total 
' la remiseise est de 5% si total est compris entre 200.000 et 1.000.000 et 10% au délà 
' ecrire le programme en vb 
'

Module Vbnet
  Sub main()
    'prix unitaire / quantité demandé --->
    dim prixU as integer
    dim prixProd as integer  
    dim n as integer 
    dim remise as integer 
    dim fraisPort as integer 
    
    console.WriteLine("entrer le prix Unitaire du produit: ")
    prixU = console.Readline()

    console.WriteLine("entrer la quantité n du produit: ")
    n = console.ReadLine()
    prixProd = n*prixU
    fraisPort = 0
    if (prixProd >=200000) then
      if (prixProd > 500000) 
        console.Writeline("le port est gratuit")
        if (prixProd <= 1000000 ) then '-->
          remise = 5
        elseif (prixProd >= 1000000 ) then
          remise = 10
        end if
      end if
    else
      if (prixProd < 500000) then  '--->
        fraisPort = prixProd * 2/100 '-->
      end if '-->
    end if
    prixProd = prixProd -((prixProd * remise)/100) + fraisPort
    console.WriteLine("les frais de port ont été de: " &fraisPort & "fr")
    console.WriteLine("le prix du produit est: " &prixProd & "fr")
    console.WriteLine("la remise a été de : " &remise & "%")
  End Sub '-->
End Module '-->