Module ikhela
  Sub Main()
    dim ql as integer = 0
    dim qs as  integer = 50

    console.WriteLine("entrer la quantité lot que vous voulez ")
    ql = console.Readline()

    If ((ql>1 and ql<100) and (ql > qs) ) then 
      ql =ql + 100
      qs = qs -50
    end if
    
    console.Writeline("la quantité en stock est: " &qs)
    console.Writeline("la quantité de lot est: " &qs)
  end Sub
End Module

