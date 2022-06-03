Algoritmo "exer Notas media"

Var
   nl,n,media:real


Inicio
   escreval("Digite sua primeira nota: ")
   leia(nl)
   escreval("Digite segunta nota: ")
   leia(n)

   media<-(nl+n)/2

   se (media>=7)entao
      escreval("A média é de: ",media," voce foi aprovad(o/a)")
   senao
      escreval("A média é de: ",media," voce foi reprovad(o/a)")
   fimse


Fimalgoritmo