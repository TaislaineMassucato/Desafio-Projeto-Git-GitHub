Algoritmo "Seelcao"
Var
idade,QuantidadeHomens:inteiro
res,sexo:caracter
cor:caracter
D:inteiro

Inicio
res <- "s"
QuantidadeHomens <- 0

repita

Escreval("Qual seu sexo ? [F/M]")
leia(sexo)
Escreval("Qual sua idade? ")
leia(idade)
  escreval("[1]Cor Preto")
  escreval("[2]Cor Azul")
  escreval("[3]Cor Roxo")
  escreval("[4]Nenhuma das opções,Cor :  ")
  escreval("[5]Para cancelar")
    leia(D)
          Escolha D
      caso 1
          cor <- "Preto"
      caso 2
           cor <- "Azul"
      caso 3
            cor <- "Roxo"
      caso 4
          escreval("Digite a cor: ")
          leia(cor)

      caso 5
             cor<-"Transparente"

             fimEscolha
             //Quantos homens de cabelo castanho
    se (cor="Preto")e (sexo="M")entao
     QuantidadeHomens <- QuantidadeHomens + 1
     fimse
escreval("Quer continuar? [s/n]")
leia(res)

ate(res="n")
Escreval("A quantidade de homens com cabelo Preto é de : ",QuantidadeHomens)


Fimalgoritmo