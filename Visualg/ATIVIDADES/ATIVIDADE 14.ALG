algoritmo "ATIVIDADE 14"
var
   kms, km, dia, total: real
   
inicio
      // KM X 0,20 | DIA X 90 - TOTAL
      Escreval("--------------------------")
      Escreval("CARROS ALUGADOS FREDERICO")
      Escreval("--------------------------")
      Escreva("Digite o número de dias: ")
      Leia(dia)
      dia <- dia*90
      Escreva("Digite os Kms percorridos: ")
      Leia(km)
      kms <- km*0,20
      Total <- km + dia
      Escreval("----------------------------")
      Escreval("      CALCULANDO PREÇO  ")
      Escreval("----------------------------")
      Escreval("Total a pagar: ", total)
fimalgoritmo