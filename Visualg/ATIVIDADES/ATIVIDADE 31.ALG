algoritmo "ATIVIDADE 31"
var
   p1, p2: inteiro
inicio
    Escreval("-----------")
    Escreval("JO-KEN-PO")
    Escreval("-----------")
    Escreval("Digite o número da sua escolha: ")
    Escreval("1 - Pedra")
    Escreval("2 - Papel")
    Escreval("3 - tesoura")
    Escreval("--------------")
    Escreva("Jogador 1: ")
    Leia(p1)
    Escreva("Jogador 2: ")
    Leia(p2)
    Escreval("--------------")
    se (((p1 e p2) > 3) e ((p1 e p2) < 1)) entao
       Escreval("Ocorreu um erro, escolha incorreta, tente novamente")
    senao
         se (p1 = p2) entao
            Escreval("STATUS: EMPATE")
         senao
              se (p1 - p2 = 2) entao
                 Escreval("STATUS: Jogador 1 ganhou")
              senao
                   se (p1 - p2 = 1) entao
                      Escreval("STATUS: Jogador 1 ganhou")
                   senao
                        se (p2 - p1 = 2) entao
                           Escreval("STATUS: Jogador 2 ganhou")
                        senao
                             se (p2 - p1 = 1) entao
                                Escreval("STATUS: Jogador 2 ganhou")
                             fimse
                        fimse
                   fimse
              fimse
         fimse
    fimse

fimalgoritmo