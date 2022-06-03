Algoritmo "Listagem turma usando vetor(Nome,nota,media,)"

Var
 Nome: vetor[1..5] de caracter
 N1:vetor[1..5] de real
 N2: vetor[1..5] de real
 c:inteiro
 m:vetor[1..5] de real
 Sm,Mt,Tacimamedia:real
Inicio
Tacimamedia <-0
 para c <-1 ate 5 faca
   escreval("Aluno",c)
   escreval("Digte seu nome: ")
   leia(nome[c])
   escreval("Digte sua nota: ")
   leia(N1[c])
   escreval("Digte sua nota: ")
   leia(N2[c])
   m[c]<-(N1[c]+N2[c])/2
   Sm <- Sm + m[c]
 fimpara
        Mt <- Sm/4
 limpatela
 para c <- 1 ate 5 faca
  escreval(nome[c],m[c])
     se (m[c]> Mt)entao
     Tacimamedia<-Tacimamedia+1
     fimse
 fimpara
 escreval("Ao todo temos ",Tacimamedia," Alunos acimad da média media que é",Mt)

 



Fimalgoritmo