Algoritmo "semnome"

Var
matri:vetor [1..3,1..3] de inteiro
l,c,SomaLinha3:inteiro


Inicio
// Seção de Comandos, procedimento, funções, operadores, etc... 
para l <- 1 ate 3 faca
     para c <- 1 ate 3 faca
       leia(matri[l,c])
     fimpara
      escreval()
fimpara


     para c <- 1 ate 3 faca
     
      SomaLinha3 <- SomaLinha3 + matri[l,c]
     fimpara
      escreval()
fimpara

Fimalgoritmo