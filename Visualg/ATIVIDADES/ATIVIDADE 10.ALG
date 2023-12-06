algoritmo "ATIVIDADE 10"
var
   L, A, area, litro: real
inicio
     //   (L * A = area, 1lt = 2area) - area e litro de tinta
     Escreva("Digite a LARGURA da parede: ")
     Leia(L)
     Escreva("Digite a ALTURA da parede: ")
     Leia(A)
     area <- (L * A)
     litro <- area/2
     Escreval("A área é ", area, " metros quadrados")
     Escreval("E vai precisar de ", litro, "L de tinta")
     
     
fimalgoritmo