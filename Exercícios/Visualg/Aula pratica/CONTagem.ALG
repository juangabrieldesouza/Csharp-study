algoritmo "contador"
var
   contador, valor, salto: inteiro
inicio
      EscrevaL("Até quantos quer contar?")
      Leia(valor)
      EscrevaL("Quanto o valor do salto?")
      Leia(salto)
      contador <- 0
      enquanto (contador <= valor) faca
               Escreval(contador)
               contador <- contador + salto
      fimenquanto
fimalgoritmo