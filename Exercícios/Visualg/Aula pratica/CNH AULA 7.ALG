algoritmo "CNH"
var
   ano_atual, ano_nasc, m: inteiro
inicio
      Escreval("=================================")
      Escreval("    DEPARTAMENTO DE TRANSITO  ")
      Escreval("=================================")
      Escreva("Ano atual: ")
      Leia(ano_atual)
      Escreva("Ano de nascimento yyyyy: ")
      Leia(ano_nasc)
      m <- ano_atual - ano_nasc
      se(m >= 18) entao
           EscrevaL("}========STATUS========={")
           EscrevaL("Idade: ", m)
           EscrevaL("APTO para tirar carteira de motorista!")
      senao
          EscrevaL("}========STATUS========={")
          EscrevaL("Idade: ", m)
          EscrevaL("INAPTO para tirar carteira de motorista!")
      Fimse
fimalgoritmo