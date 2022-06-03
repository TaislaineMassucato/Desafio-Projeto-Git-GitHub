Algoritmo "exer aulas condicoes.. Media f b d"

Var
   nota1,nota2,media:real
   nome:caractere


Inicio
      escreval("Digite seu nome: ")
      leia(nome)
      escreval ("Digite sua nota: ")
      leia(nota1)
      escreval("Digite sua nota: ")
      leia(nota2)
      
      media<-(nota1+nota2 )/2
      
      se (media<=9)e(media<10)entao
         escreval("Média",media," A")
         senao
              se(media>=8)e (media>9)entao
                            escreval("Média",media," B")
                senao
                     se(media>=7)e (media>8)entao
                                   escreval("Média",media," C")
                     senao
                          se(media>=6)e(media<7)entao
                                                     escreval("Média",media,"D")
                          senao
                               se(media>=5)e(media<6)entao
                                                          escreval("Média",media,"E")
                               senao
                                    se(media<5)entao
                                                    escreval("Média",media,"F")
                                    fimse
                               fimse
                          fimse
                     fimse
              fimse
      fimse


Fimalgoritmo