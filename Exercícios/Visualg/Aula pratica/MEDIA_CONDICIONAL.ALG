algoritmo "MEDIA2"
var
   a, b, c: real
inicio
      Escreval("}---------------------------{")
      Escreval("    ESCOLA DOS TOP DEV´S     ")
      Escreval("}---------------------------{")
      Escreval("=============================")
      Escreva("Primeira Nota: ")
      Leia(a)
      Escreva("Seguda Nota: ")
      Leia(b)
      Escreval("=============================")
      c <- (a + b)/2
      Escreval("MEDIA: ", c)
      se (c >= 9) entao
         Escreval("STATUS: Aproveitamento A")
      senao
           se (c < 9) e ( c >= 8)entao
              Escreval("STATUS: Aproveitamento B")
           senao
                se ( c < 8) e ( c >=7)entao
                   Escreval("STATUS: Aproveitamento C",
                senao
                     se(c < 7) e (c >= 6)entao
                          Escreval("STATUS: Aproveitamento D")
                     senao
                          se(C < 6) e (c >= 5)entao
                               Escreval("STATUS: Aproveitamento E")
                          senao
                               Escreval("STATUS: Aproveitamento F")
                          fimse
                     fimse
                Fimse
           fimSe
      fimSe
      Escreval("=============================")
fimalgoritmo