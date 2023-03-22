Imports System

public class Form1

  'declaration des variables néccessaures pour les opérations 

  Dim x as double = 0
  Dim y as double =0 
  Dim operation as string =""
  
  'ajouter des nombres aux textBox lorsque les bouttons sont cliqués: 
    private Sub btn1_Click(sender as object, e as EventArgs) handles btn1.Click, btn2.Click,btn3.Click,btn4.Click, btn5.Click, btn6.Click, btn7.Click, btn8.Click, btn9.Click, btn0.Click, btnPlus.Click, btnMoins.Cclick, btnMult.Click, btnDiv.Click

    'recupération du boutton cliqué 
    Dim bouton as Button = DirectCast(sender, Button)
  
    'Ajout du texte du bouton cliqué au texBox1
    if bouton.Name.StartsWith("btn") Then 
        TextBox1.Text += bouton.Text
    End if 
  
    'Selection de l'opération et stockage du premier nombre 
      if bouton.Name ="btnPlus" then 
        operation ="+"
        x = cdbl(TextBox1.Text)
        x.Clear()
      elseif bouton.Name = "btnMult" Then
        operation ="-"
        x = cdbl(TextBox1.Text)
        TextBox1.Clear()
      elseif bouton.Name = "BtnDiv" then 
        operation = "/"
        x = cdbL(TextBox1.Text)
        TextBox1.Clear()
      else 
        console.writeline("il n' y a pas cette opération ici")
      End if 
    End Sub
 



      Private Sub btnPlus_Click(sender as object , e as EventArgs) handles btnClear.Click
          'effacer le conenur du textBox1  
           TextBox1.Clear()
          'Reinitialiser les variables 
           x=0
           y=0
           operation=""
      End Sub
      

'le resultat de l'opération 
      Private  Sub btnEquals_Click(sender as object , e as EventArgs) handles btnEquals.Click
        'Stockage du y 
          
        y = cdbl(TextBox1.Text)
          
        if operation = "+" then 
          resultat = x + y
        elseif operation ="-" then 
          resultat = x - y 
        elseif operation = "*" then 
            TextBox1.Text = x*y
        elseif operation = "/" then
            if y = 0 then 
              TextBox1.Text = "Erreur"
            else
              TextBox1.Text = x / y 
            End if
        else 
          console.writeline("il n' y a pas cette opération ici")
        End if
      End Sub 
End class