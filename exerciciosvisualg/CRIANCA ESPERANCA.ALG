Algoritmo "Crianca esperanca"

Var
     D:inteiro
     valor:real


Inicio
      escreval("[1]Para doar $10")
      escreval("[2]Para doar $40")
      escreval("[3]Para doar $60")
      escreval("[4]Outros valores")
      escreval("[5]Para cancelar")
      leia(D)
          Escolha D
      caso 1
          valor<- 10
      caso 2
           valor<- 40
      caso 3
            valor<- 60
      caso 4
          escreval("Digite o valor: R$")
          leia(valor)

      caso 5
             valor<-0
             

             fimEscolha
             escreval("Sua doação foi de: ",valor)



Fimalgoritmo