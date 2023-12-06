algoritmo "IMC AVANC"
var
   A, M, IMC: real
inicio
      Escreva("Massa (Kg): ")
      Leia(M)
      Escreva("Altura (m): ")
      Leia(A)
      IMC <- M / (A ^ 2)
      Escreval("IMC: ", IMC:5:2)
      Se (IMC < 17) entao
         Escreval("Muito abaixo do peso")
      Senao
           Se (IMC >= 17) e (IMC <= 18.5) entao
              Escreval ("Abaixo do Peso")
           Senao
                Se (IMC >= 18.5) e (IMC < 25) ENTAO
                   Escreval ("Peso ideal")
                senao
                     Se (IMC >= 25) e (IMC < 30) entao
                        Escreval("Sobrepeso")
                     senao
                          Se (IMC >= 30) e (IMC < 35) entao
                             Escreval("Obesidade")
                          senao
                               Se(IMC >= 35) e (IMC < 40) entao
                                  Escreval("Obesidade severa")
                               senao
                                  Escreval("Obesidade Mórbida")
                               FimSe
                          FimSe
                     FimSe
                FimSe
           FimSe
      FimSe
fimalgoritmo