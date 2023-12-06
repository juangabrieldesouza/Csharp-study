algoritmo "ATIVIDADE 19"
var
    n: caractere
    n1, n2, m: real
inicio
      Escreval("----------------------|")
      Escreval(" ESCOLA VITORIA REGIA |")
      Escreval("----------------------|")
      Escreva("Digite o nome do aluno: ")
      Leia(n)
      Escreva("Digite a PRIMEIRA nota: ")
      leia(n1)
      Escreva("Digite a SEGUNDA nota: ")
      Leia(n2)
      m <- (n2+n1)/2
      Escreval("------------")
      Escreval(" CALCULANDO ")
      Escreval("------------")
      se (m >= 7) entao
         Escreval("Nome do aluno: ", n)
         Escreval("Média: ", m)
         Escreval("Alun@ ", n, " teve um bom aproveitamento")
      senao
         Escreval("Nome do aluno: ", n)
         Escreval("Média: ", m)
         Escreval("Alun@ ", n, " não teve um bom aproveitamento")
      fimse
fimalgoritmo