algoritmo "ATIVIDADE 24"
var
   distancia, preco: real
inicio
      Escreval("-----------------")
      Escreval("pajal transportes")
      Escreval("-----------------")
      Escreva("Digite a distancia que deseja percorrer em km's: ")
      Leia(distancia)
      se (distancia <=200) entao
         preco <- 0.5
         Escreval("O valor da viajem é de: R$", (distancia*0.5):5:2)
      senao
         preco <- 0.45
         Escreval("O valor da viajem é de: R$", (distancia*0.45):5:2)
      fimse


fimalgoritmo