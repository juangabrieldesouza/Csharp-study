algoritmo "MEDIA ALUNO"
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
      Escreval("MEDIA: ", C)
      Se(C >= 7) entao
           Escreval("ALUNO APROVADO!")
           Escreval("------------------")
      Senao
      Escreval("ALUNO REPROVADO")
      Escreval("------------------")
      FimSe
fimalgoritmo