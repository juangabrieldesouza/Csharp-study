algoritmo "CRIANÇA ESPERANÇA"
var
   A: INTEIRO
   V: real
inicio
      Escreval("---------------------------")
      Escreval("    CRIANÇA ESPERANÇA      ")
      Escreval(" Muito obrigado por ajudar ")
      Escreval("---------------------------")
      Escreval(" [1] para doar R$10 ")
      Escreval(" [2] para doar R$25 ")
      Escreval(" [3] para doar R$50 ")
      Escreval(" [4] para doar outros valores ")
      Escreval(" [5] para cancelar ")
      Leia(A)
      Escolha A
          Caso 1
               V <- 10
          Caso 2
               V <- 25
          Caso 3
               V <- 50
          Caso 4
               Escreva ("Qual o valor da doação? R$")
               Leia(V)
          Caso 5
               V <- 0
      FimEscolha
      Escreval("---------------------------")
      Escreval(" SUA DOAÇÃO FOI DE R$", V)
      Escreval(" MUITO OBRIGADO! ")
      Escreval("---------------------------")
fimalgoritmo