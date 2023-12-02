algoritmo "ATIVIDADE 23"
var
   sexo, valor: real
    nome: caractere
inicio
      Escreval("--------------------")
      Escreval(" Lojas real roupas ")
      Escreval("--------------------")
      Escreva("Digite o nome do cliente: ")
      Leia(nome)
      Escreval("--------------------")
      Escreval("qual o sexo do cliente?")
      Escreval("1 - FEMININO")
      Escreval("2 - MASCULINO")
      Leia(sexo)
      Escreval("-------------------")
      Escreva("Digite o valor da compra: ")
      Leia(valor)
      se (sexo = 1) entao
         Escreval("valor do desconto: ", (valor*(13/100)), "R$")
         Escreval("Total da compra: ", valor - (valor*(13/100)), "R$")
      senao
         sexo <- 2
         Escreval("Valor do desconto: ", (valor*(5/100)), "R$")
         Escreval("Total da compra: ", valor - (valor*(5/100)), "R$")
         
      fimse
      

fimalgoritmo