Algoritmo "IMC aninhado"


Var
   a,m,imc:real


Inicio
      escreval("Informe sua massa(kg) corporal: ")
      leia(m)
      escreval("Informe sua altura(M): ")
      leia(a)

      imc<- m/(a^2)

      se(imc<17) entao
                escreval(" Muito abaixo do peso",imc)

      senao
           se(imc>=17)e (imc<18.5)entao
                        escreval(" Abaixo do peso",imc)

           senao
                se(imc>=18.5)e (imc<25)entao
                               escreval(" Peso ideal",imc)

                senao
                     se(imc>=25)e(imc<30)entao
                                               escreval(" Sobrepeso",imc)

                     senao
                          se(imc>=30)e(<35)entao
                                                 escreval(" Obesidade",imc)

                          senao
                               se(imc>=35)e(imc<=40)entao
                                                         escreval(" Obesidade Severa",imc)
                               fimse
                          fimse
                      fimse
                 fimse
            fimse
       fimse





Fimalgoritmo