algoritmo "ATIVIDADE 18"
var
   n: inteiro
inicio
      Escreval("--------------------------------")
      Escreval(" VERIFICAÇÃO DE IDADE PARA VOTO ")
      Escreval("--------------------------------")
      Escreva("Digite seu ano de nascimento: ")
      Leia(n)
      Escreval("------------------------------")
      Escreval("     CALCULANDO RESULTADO     ")
      Escreval("------------------------------")
      n <- 2023 - n
      se (n >= 18) entao
         Escreva("Você tem idade o suficiente para votar")
      senao
         Escreva("Você ainda não pode votar")
      Fimse

      
fimalgoritmo