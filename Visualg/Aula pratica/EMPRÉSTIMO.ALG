algoritmo "EMPRÉSTIMO"
var
   Empres, dinheiro: real
   Parcel: inteiro
inicio
      Escreva("Quantos de empréstimo você quer pegar? R$")
      Leia(dinheiro)
      Escreval("Quantas parcelas?")
      Leia(Parcel)
      Empres <- ((((dinheiro*20)/100)+dinheiro)/Parcel)
      Escreva("Então será R$", Empres, " por mês, em ", Parcel, " Vezes" )
      
fimalgoritmo