Algoritmo "Passagem por referencia"

Var
   x,y:inteiro
Procedimento Soma(var A,B:INTEIRO)
INICIO
 A <- A+1
 B<- B+2
 ESCREVAL("vALOR DE A : ",A)
 ESCREVAL("vALOR DE b: ",B)
 ESCREVAL("A soma de é de : " ,A+B)
 FIMPROCEDIMENTO
Inicio
 x <- 4
 y<- 8
 
 Soma(x,y)
 
 escreval("Valor de x passou a ser: ",x)
 escreval("Valor de y passou a ser: ",y)

Fimalgoritmo