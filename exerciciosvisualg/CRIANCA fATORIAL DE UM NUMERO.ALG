Algoritmo "semnome"

Var
N,Cont,F:INTEIRO
  R: CARACTER
Inicio

       Repita
      Escreva("Numero que quer fatoria: ")
        leia(N)
         Cont <- N
         F <- 1
        
      Repita
        escreval(Cont)
        F <- F * Cont
        Cont <- Cont -1
        ate(Cont < 1)
        escreval ("O fatoriald e", N, "é",F)
         escreval("Quer continuar?[s/n] ")
         leia(R)
         ate(R="n")

Fimalgoritmo