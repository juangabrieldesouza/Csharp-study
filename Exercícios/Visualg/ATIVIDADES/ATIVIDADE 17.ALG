algoritmo "ATIVIDADE 17"
var
   km, m, mm: real
inicio
      Escreval("-------------------------------")
      Escreval("   POLICIA RODOVIARIA FEDERAL  ")
      Escreval("-------------------------------")
      Escreva("Digite os Km/h do veículo: ")
      Leia(km)
      Escreval("'''''''''''''''''''''''''''''''")
         Escreval("     CALCULANDO RESULTADO    ")
         Escreval("'''''''''''''''''''''''''''''''")
      se (km > 80) entao
         m <- km - 80
         mm <- m*5
         EscrevaL("Limite de velocidade ultrapassado!")
         Escreval("Valor da multa é de: ", mm, "R$")
      senao
           Escreva("Está dentro do limite de velocidade"
      Fimse
fimalgoritmo