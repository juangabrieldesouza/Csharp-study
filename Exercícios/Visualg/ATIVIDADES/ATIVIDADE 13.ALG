algoritmo "ATIVIDADE 13"
var
   S, NS: REAL
   N: caractere
inicio
      Escreva("Digite o nome do funcionario: ")
      Leia(N)
      Escreva("Digite o salário atual do funcionario: ")
      Leia(S)
      NS <- S + ((S*15)/100)
      Escreval("----------------------------")
      Escreval("Nome: ", N)
      Escreval("Novo Salário: ", NS)
fimalgoritmo