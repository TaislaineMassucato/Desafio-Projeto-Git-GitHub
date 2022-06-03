Algoritmo "Uso de procedimentos"

Var
  I:Inteiro
  Mai,P:REAL
  N,Pesado:caracter
  
Procedimento Topo()
inicio
  
  LimpaTela
 Escreval("---------------")
 escreval("Detector de peso")
 escreval("Maior peso até agora" ,Mai, " kg")
 escreval("----------------")
 
fimprocedimento
Inicio
Topo()
 para I <- 1 ate 5 faca
 Escreval("Digite seu nome: ")
 leia(N)
 Escreval("Digite o peso : ")
 leia(P)

 se(P>Mai)entao
   Mai<-P
   Pesado<-N
 fimse
 Topo()
 fimpara
 Topo()
 escreval("A pessoa mais pesada foi " ,Pesado, "Com " ,Mai, "Kilos" )
 


Fimalgoritmo