using System;
    namespace ifi{
        class aula12{
            static void Main(){
                string nome;
                int n1,n2,n3,res;
                string resultado ="Reprovado";

                Console.WriteLine("Digite seu nome  :  " );
                nome=Console.ReadLine();
    
                Console.WriteLine("Digite a nota 1 :  " );
                n1=int.Parse(Console.ReadLine());
                Console.WriteLine("Digite a nota 2 :  " );
                n2=int.Parse(Console.ReadLine());
                Console.WriteLine("Digite a nota 3 :  " );
                n3=int.Parse(Console.WriteLine());

            res=n1+n2+n3;
                if(res>=60){
                    resultado="Aprovado";
                }
                {if(resultado=="aprovado")
                    Console.WriteLine("{0} Parabéns Voce foi: {1}",nome,resultado);                
                }
                    Console.WriteLine("{0} Voce foi:  {1}",nome,resultado);            
            

            

                 
                    }

                 
            }
        }
    