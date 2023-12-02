algoritmo "ATIVIDADE 15"
var
   Dias, hora, total: real
inicio
      Escreva("Digite o número de dias trabalhados do funcionário: ")
      Leia(Dias)
      hora <- 8*Dias
      total <- hora*25
      Escreval("Horas trabalhadas: ", hora, "h")
      Escreval("Salário: ", total)
fimalgoritmo