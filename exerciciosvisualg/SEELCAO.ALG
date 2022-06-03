Algoritmo "Seelcao"
Var
idade:inteiro
res,sexo:caracter
cor:caracter
D:inteiro

Inicio
res <- "s"

repita

Escreval("Qual seu sexo ? [F/M]")
leia(sexo)
Escreval("Qual sua idade? ")
leia(idade)
  escreval("[1]Cor Preto")
  escreval("[2]Cor Azul")
  escreval("[3]Cor Roxo")
  escreval("[4]Cor Rosa")
  escreval("[5]Para cancelar")
    leia(D)
          Escolha D
      caso 1
          cor<- 10
      caso 2
           cor<- 40
      caso 3
            cor<- 60
      caso 4
          escreval("Digite a cor: ")
          leia(cor)

      caso 5
             valor<-0


             fimEscolha


escreval("Quer continuar? [s/n]")
leia(res)

ate(res="n")
Fimalgoritmo