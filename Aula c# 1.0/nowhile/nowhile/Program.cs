using System;
     namespace dowhile{
         class dowhilee{
             static void Main(){

                string senha="123";
                string senhauser;
                int tentativas=0;

                do  {
                    Console.Clear();
                     Console.WriteLine("Digite sua senha");
                     senhauser=Console.ReadLine();
                     tentativas++;
                    }while(senha != senhauser);

                    Console.WriteLine("Sua senha está correta!!! numero de Tentativas: {0}",tentativas);
             }
         }
     }