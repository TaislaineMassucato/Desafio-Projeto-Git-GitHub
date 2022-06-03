Algoritmo "Exer aula 10"

Var
Cont,Conti:inteiro
resp:caracter


Inicio
 Cont <- 1
 Conti <- 10
 
     escreval("a - Contar de 1  a 10")
     escreval("b - Contar de 10 a 1 ")
     escreval("c- Sair")
             escreval ("Digite sua opção: [a],[b],[c]")
             leia(resp)
             
 se (resp="b")entao
 //10 até 1
 repita
   escreval(Conti)
 Conti <- Conti - 1
 ate(Conti < 1)
 senao
 se(resp="a")entao
 //1 até 10
 repita
 escreval(Cont)
 Cont <- Cont + 1
  ate (Cont>10)
  fimse
  fimse

Fimalgoritmo