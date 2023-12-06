algoritmo "ATIVIDADE 21"
var
   ano: inteiro
inicio
      Escreva("Digite qual ano para saber se é bissexto ou não: ")
      Leia(ano)
      se (ano%4=0) e ((ano%400=0) ou (ano%100<>0))entao
         Escreval("É um ano bissexto")
      senao
         Escreval("Não é um ano bissexto")
      fimse
fimalgoritmo