algoritmo "ATIVIDADE 26"
var
   N1, N2: real
inicio
      Escreva("Digite um número: ")
      Leia(N1)
      Escreva("Digite outro número: ")
      Leia(N2)
      se(N1 < N2) entao
            Escreval("O número ", N2, " é maior")
      senao
           se(N1 > N2)entao
                 Escreval("O número ", N1, " é maior")
           senao
                 Escreval("Não tem um número maior, os dois são iguais")
           fimse
      fimse

fimalgoritmo