algoritmo "ATIVIDADE 29"
var
   nome: caractere
   salario, ano, novo: real
inicio
      Escreval("----------------")
      Escreval("Motors S.A")
      Escreval("----------------")
      Escreva("Digite o nome do funcionário: ")
      Leia(nome)
      Escreva("Digite o salário atual do funcionário: ")
      Leia(salario)
      Escreva("Digite quantos anos o funcionário trabalha na empresa: ")
      Leia(ano)
      Escreval("------------------")
      Escreval("CALCULANDO")
      Escreval("------------------")
      se(ano < 3) entao
             novo <- salario + salario*(3/100)
             Escreval("Nome: ", nome)
             Escreval("Salário atual: ", salario)
             Escreval("NOVO SALÁRIO: ", novo)
      senao
           se((ano >= 3) e (ano <= 10))entao
                  novo <- salario + salario*(12.5/100)
                  Escreval("Nome: ", nome)
                  Escreval("Salário atual: ", salario)
                  Escreval("NOVO SALÁRIO: ", novo)
           senao
                  novo <- salario + salario*(20/100)
                  Escreval("Nome: ", nome)
                  Escreval("Salário atual: ", salario)
                  Escreval("NOVO SALÁRIO: ", novo)
           fimse
      fimse
fimalgoritmo