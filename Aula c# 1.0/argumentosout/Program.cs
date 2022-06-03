using System;
    namespace argumenout{
        class outt{
            static void Main(){
                
                int divid,divis,quoci,rest;
                divid=10;
                divis=3;
                quoci=dividit(divid,divis,out rest);

                Console.WriteLine("{0}/{1}: quociente= {2} e resto= {3}",divid,divis,quoci,rest);

            }
            static int dividit(int dividendo,int divisor, out int resto){
                int quociente;
                quociente=dividendo/divisor;
                resto=dividendo%divisor;
                return quociente;
                


            }
        }
    }
        

            
        