Algoritmo "IMC"


Var
   a,m,imc:real


Inicio
      escreval("Informe sua massa(kg) corporal: ")
      leia(m)
      escreval("Informe sua altura(M): ")
      leia(a)
      
      imc<- m/(a^2)
      
      se(imc>=18.5) E (IMC<=25)entao
                escreval("Peso ideal")
      senao
           escreval("Procure um médico")
      fimse

      
      escreval("Seu IMC é de: ",imc:5:2)


Fimalgoritmo                          //massa/altura^2
                                      //peso ideal é de 18.5 a 25