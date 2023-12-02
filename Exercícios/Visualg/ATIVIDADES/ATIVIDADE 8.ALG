algoritmo "ATIVIDADE 8"
var
   M: real
inicio
      Escreva("Digite uma distância em metros: ")
      Leia(M)
      Escreval((((M/10)/10)/10):5:2, "Km          ", ((M/10)/10):5:2, "Hm")
      Escreval((M/10):4:2, "Dam          ", (M*10):6:2, "Dm")
      Escreval(((M*10)*10):6:2, "Cm          ", (((M*10)*10)*10):6:2, "mm")
fimalgoritmo