algoritmo "Idade exercito"
var
   N, A, I: INTEIRO
inicio
      Escreva("Em que ano nós estamos? ")
      Leia(A)
      Escreval("Qual é o seu ano de nascimento? ")
      Leia(N)
      I <- A - N
      Escreval("Em ", A, " você tem ", I, " anos de idade!")
      se(I>=18)entao
                    Escreval("Boh pro exercito meu chapa? ja ta na horaKKK")
      senao
      Escreva("Ainda um bebe")
      Fimse
fimalgoritmo