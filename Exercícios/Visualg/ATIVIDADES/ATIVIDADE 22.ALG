algoritmo "ATIVIDADE 22"
var
   ano, x: inteiro
inicio
      Escreva("Digite o ano do seu nascimento: ")
      Leia(ano)
      x <- 2023 - ano
        se (x < 18) entao
           x <- 18 - x
           Escreval("Falta ", x, " anos para se alistar")
         senao
           x <- x - 18
           Escreval("ja pode se alitar, passou", x, " anos para o seu alistamento")
         fimse
fimalgoritmo