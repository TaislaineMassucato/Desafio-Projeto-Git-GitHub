using System;
    namespace me4todo{
        class metod{
            static void Main(){
                
                int v2,v1,r;
                
                v1=int.Parse(Console.ReadLine());
                v2=int.Parse(Console.ReadLine());
                r=soma(v1,v2);
                Console.WriteLine("Asoma de {0} e {1 é: {2}",v1,v2,r);
            
            }
            static int soma(int v1,int v2){
                int res=v1+v2;
                return res;
            ;
            }
        }
    }