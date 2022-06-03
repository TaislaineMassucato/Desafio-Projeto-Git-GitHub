Algoritmo "condicional Se,entao,senao,fimse"


Var
   ano,anoD,idade:inteiro
   m:caractere


Inicio
      escreval("Digite o ano que queres saber sua idade: ")
      leia(ano)
      escreval("Digite o ano que nasceu")
      leia(anoD)
      
      idade<- ano-anoD
      
      se (idade>18)entao
      m<-(" Voce é de maior")
      senao
      m<-(" Você é de menor")
      fimse
      
      escreval("sua idade é de: ",idade,m)


Fimalgoritmo