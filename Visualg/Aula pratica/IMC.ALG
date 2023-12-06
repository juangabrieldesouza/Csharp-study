algoritmo "IMC"
var
    A, P, M: real
inicio
   Escreval("Calculo de peso ideal")
   Escreva("Digite a sua altura em (m): ")
   Leia(A)
   Escreva("Digite o seu peso em (Klg): ")
   Leia(P)
   M <- P/(A ^ 2)
   Escreval("O IMC ideal está entre 18.5 a 25")
   Escreval(" O seu IMC é de ", M:5:2)
   se(M < 18.5) e (M >= 25)entao
        Escreva("Parabéns! Você está no seu peso ideal")
   senao
        Escreva("Infelizmente você não está no seu peso ideal")
   FimSe
fimalgoritmo