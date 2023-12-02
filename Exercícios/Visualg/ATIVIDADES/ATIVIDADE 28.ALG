algoritmo "ATIVIDADE 28"
var
   L, C, B: Real
inicio
      // < 100 TERRENO POPULAR/ 100-500 MASTER / >500 VIP
      Escreval("--------------")
      Escreval(" IMP TERRENOS ")
      Escreval("--------------")
      Escreva("Digite a largura do terreno em metros: ")
      Leia(L)
      Escreva("Digite o cumprimento do terreno em metros: ")
      Leia(C)
      Escreval("------------")
      Escreval(" CALCULANDO ")
      Escreval("------------")
      se(L*C <= 100)entao
           Escreval("O TERRENO POSSUI: ", L*C, "m²")
           Escreval("STATUS: TERRENO POPULAR")
      senao
           se(L*C > 100) e (L*C < 500) entao
                Escreval("O TERRENO POSSUI: ", L*C, "m²")
                Escreval("STATUS: TERRENO MASTER")
           senao
                Escreval("O TERRENO POSSUI: ", L*C, "m²")
                Escreval("STATUS: TERRENO VIP")
           Fimse
      fimse

fimalgoritmo