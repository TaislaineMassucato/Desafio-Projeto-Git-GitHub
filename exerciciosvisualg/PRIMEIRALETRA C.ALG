Algoritmo "PrimeiraLetra C"

Var
nome:caracter
soC:vetor[1..10] de caracter
totalC,c:INTEIRO



Inicio
totalC<-0

para c <- 1 ate 10 faca
 escreval("Digite seu nome: ")
 leia(nome)
   se (copia(maiusc(nome),1,1)="C")entao
    totalC <- totalC + 1
    soC[totalC] <- nome
   fimse
fimpara
para c <- 1 ate totalC faca
     escreval(soC[totalC])
     FIMPARA

Fimalgoritmo