Algoritmo "semnome"

Var
Cont,N,NumPrimo: INTEIRO
       R:CARACTER

Inicio

 Cont <- 1
 NumPrimo <- 0
 R <-"S"

  escreval ("Digite um número: ")
 leia (N)

 repita
  escreva(Cont)

  se (N % Cont = 0)entao
    NumPrimo <- NumPrimo  + 1
  fimse
   Cont <- Cont + 1
  ate(Cont > N)
    se (NumPrimo > 2 )   ENTAO
    escreval(" O valor ",N, " nao É primo")
    senao
    escreval(" O VALOR ",N," É primo")
    fimse
     escreval(" Ao todo esxiste " ,NumPrimo, " Numeros Divisiveis")

Fimalgoritmo