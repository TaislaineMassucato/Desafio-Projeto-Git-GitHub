Algoritmo "Identidficar se é par"

Var
  v:vetor[1..7] de inteiro
  c,totalpar:inteiro

Inicio
totalpar <-0
para c <- 1 ate 7 faca
escreval("Digite o ",c,"° valor")
leia(v[c])
fimpara

para c<- 1 ate 7 faca
se(v[c]%2=0)entao
totalpar <- totalpar+1
escreval("Valor par na posicao : ",c)
fimse
fimpara
escreval("Total de pares: ",totalpar)





Fimalgoritmo