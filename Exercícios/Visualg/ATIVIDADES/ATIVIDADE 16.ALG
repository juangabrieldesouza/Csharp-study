algoritmo "ATIVIDADE 16"
var
    total, dia, cigarros, vida, anos: real
inicio
   Escreva("Digite a quantidade de cigarros fumados por dia: ")
   Leia(cigarros)
   Escreva("Digite quantos anos já fuma: ")
   Leia(anos)
   total <- cigarros*(365*anos)
   vida <- ((total*10)/60)/24
   Escreval("Quantidade de cigarros ja fumado aproximadamente: ", total)
   Escreval("Quantidade de dias de vida perdidos: ", vida)
fimalgoritmo