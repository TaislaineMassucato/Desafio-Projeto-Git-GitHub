using System;

    namespace calcula
    {
        class calculando
        {
            static void Main()
            {
                string nome;
                int N1,N2,soma;
                int peso;
                 int altura;
                int IMC;
                int imc2;
            

            Console.WriteLine("\nEscreva seu nome:  \t");
                nome=Console.ReadLine();

                Console.WriteLine("\nNOME DELA É: \t{0}", nome );

                  

            Console.WriteLine("\nDigite N1: \t");
                N1=int.Parse (Console.ReadLine());
            Console.WriteLine("\nDigite N2:  \t");
                N2=Convert.ToInt32(Console.ReadLine());

                        soma = N1+N2 ;

                Console.WriteLine("\n {0} A soma de {1} mais {2} é :  \t{3}",nome,N1, N2,soma);

                 Console.WriteLine("\n{0}Vamos calcular seu IMC ");
                    Console.Write("Qual seu peso ? ");
                        peso=int.Parse(Console.ReadLine());
                     Console.Write("Qual sua altura ? ");
                        altura=int.Parse(Console.ReadLine());

                        IMC=(altura*altura);
                        imc2= (peso/IMC);
                    
                    Console.WriteLine("\n"+nome+"Seu imc é igual a :\t"+imc2);
                            
                            
                        
            }
        }
    }
