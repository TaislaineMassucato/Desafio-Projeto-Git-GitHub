Algoritmo "EXER (apto a dirigir)"

Var
    anoA,anoB,idade:inteiro


Inicio
      escreval("Qual ano atual?: ")
      leia(anoA)
      escreval("Qual ano de nascimento?: ")
      leia(anoB)
      
      idade<-anoA-anoB
      
      se (idade>=18)entao
         escreval("Sua idade é de ",idade," Você está apto a dirigir")
      senao
           escreval("Sua idade é ",idade," Você ñ está apto a dirigir")
      fimse
      


Fimalgoritmo