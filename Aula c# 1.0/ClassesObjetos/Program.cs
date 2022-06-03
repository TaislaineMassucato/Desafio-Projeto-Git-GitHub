using System;
  //se nao usar nada na frente de class é public automatica
     public class Jogador{
         public int energia=100;
         public bool vivo=true;



     }
     class aula28{
         static void Main(){
             Jogador j1=new Jogador();
             Jogador j2=new Jogador();
             Jogador j3=new Jogador();

             j1.energia=50;
             Console.WriteLine("A energia do jogador 1 : {0}",j1.energia);
             Console.WriteLine("A energia do jogador 2 : {0}",j2.energia);
         }
     }