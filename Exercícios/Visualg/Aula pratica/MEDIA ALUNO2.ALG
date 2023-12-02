algoritmo "MEDIA ALUNO2"
var
      B, A, C: real
inicio
      Escreval("}--------------------{")
      Escreval(" ESCOLA DOS TOP DEVS ")
      Escreval("}--------------------{")
      Escreva("Primeira nota: ")
      Leia(A)
      Escreva("Segunda nota: ")
      Leia(B)
      C <- (A+B)/2
      Escreval("------------------")
      Escreval("MEDIA: ", C:4:2)
      Se(C >= 7) entao
           Escreval("ALUNO APROVADO!")
           Escreval("------------------")
      Senao
           Se(C >= 5) e (C < 7)entao
                Escreval("AlUNO EM RECUPERAÇÃO")
                Escreval("---------------------")
           senao
                Escreval("ALUNO REPROVADO")
                Escreval("------------------")
           FimSe
      FimSe
fimalgoritmo