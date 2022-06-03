Algoritmo "Matriz linha redimencional"

Var
Mat: vetor [1..3,1..3] de inteiro
l,c:inteiro

Inicio
 para l <- 1 ate 3 faca
      para c <- 1 ate 3 faca
        se(l=c)entao
        Mat[l,c] <- 1
        senao
        Mat[l,c] <- 0
        fimse
      fimpara
 fimpara
 
 para  l <- 1 ate 3 faca
      para c <- 1 ate 3 faca
       escreval(Mat[l,c]:3)
      fimpara
      escreval()
 fimpara

Fimalgoritmo