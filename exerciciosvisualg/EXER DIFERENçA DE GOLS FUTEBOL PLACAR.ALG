Algoritmo "Exer diferença de gols Futebol placar"

Var
   pal,co,dir:real


Inicio
      escreval("Jogo Pal VS Coringa")
      escreval("Digite valor dos gols de Pal...")
      leia(pal)
      escreval("Quantos gols Coringa fez...")
      leia(co)
      
      dir<-pal-co
      
      se(pal>co)entao
                     escreval("Goleada do pal meu chapa",dir)
      senao
           se(pal<co)entao
                                  escreval("goleada co meu chapa",dir)
           senao
                escreval("é isso")
           fimse
      fimse
      
      


Fimalgoritmo