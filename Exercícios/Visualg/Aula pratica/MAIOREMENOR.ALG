algoritmo "maiorEmenor"
var
   cont, s, n, maior, menor: inteiro
inicio
      cont <- 1
      Enquanto (cont <= 5) faca
               Escreva("Digite o ", cont, "º valor: ")
               Leia(n)
               se (n > maior) entao
                  maior <- n
               fimse
               se (n < n) entao
                  menor <- n
               fimse
               s <- s + n
               cont <- cont + 1
      FimEnquanto
      Escreval("------------------")
      EscrevaL("A soma foi de ", s)
      EscrevaL("E o maior número é ", maior)
fimalgoritmo