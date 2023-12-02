algoritmo "ATIVIDADE 27"
var
   a, b, c: real
inicio
      // 4.9 reporvado / 5.0 e 6.9 recuperaçaão / > 7 aprovado
      Escreval("----------------")
      Escreval("Escola militar")
      Escreval("----------------")
      Escreval("Digite a nota do aluno")
      Escreva("Primeira Nota: ")
      Leia(a)
      Escreva("Digite a segunda nota: ")
      Leia(b)
      c <- (b+a)/2
      Escreval("-----------------")
      Escreval("CALCULANDO")
      Escreval("-----------------")
      se (c <= 4.9) entao
         Escreval("Aluno REPROVADO")
      senao
           se (c <= 6.9) e (c >= 5) entao
              Escreval("Aluno em RECUPERAÇÃO")
           senao
              Escreval("Aluno APROVADO")
           fimse
      Fimse
fimalgoritmo