algoritmo "ATIVIDADE 25"
var
   L1, L2, L3: inteiro
inicio
      Escreval("------------------------")
      Escreval(" Calculo dos triangulos")
      Escreval("------------------------")
      Escreva("Digite o primeiro lado: ")
      Leia(L1)
      Escreva("Digite o segundo lado: ")
      Leia(L2)
      Escreva("Digite o terceiro lado: ")
      Leia(L3)
      se ((L1 <= L2 + L3) e (L3 <= L1 + L2) e (L2 <= L1 + L3))entao
         Escreval("Um triangulo pode ser formado")
      senao
         Escreval("Não se pode formar um triangulo")
      fimse

fimalgoritmo