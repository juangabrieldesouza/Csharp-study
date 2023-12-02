algoritmo "JOGO FUTBOL"
var
   a, b, c: inteiro
inicio
      Escreval("====================")
      Escreval("   JOGO DE FUTBOL   ")
      Escreval("====================")
      Escreval("  Rockets X Sharks  ")
      Escreval("--------------------------------")
      Escreva("Quantos gols fez o time Rockets? ")
      Leia(a)
      Escreva("Quantos gols fez o time Sharks? ")
      Leia(b)
      Escreval("================================")
      se b > a entao
         c <- b - a
      senao
           se b < a entao
              c <- a - b
           senao
                se b=a entao
                   c <- 0
                fimse
           fimse
      fimse
      Escreval("Diferença de Gols: ", c)
      Escolha c
              caso 1,2,3,4
                   Escreva("STATUS: Partida Normal")
              caso 5, 6, 7, 8, 9, 10
                   Escreva("STATUS: GOLEADA")
              caso 0
                   Escreva("STATUS: empate")
              outrocaso
                   Escreva("STATUS: ocorreu um erro")
                   Escreva("digite novamente?!")
      fimescolha

fimalgoritmo