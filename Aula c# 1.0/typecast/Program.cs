using System;
    namespace cast{
        class type{
            static void Main(){

                    //conversao implicita (segura)
                int n1=10;
                float n2=n1;

                float n1 = 10.5f;
                int n2 = n1; //dará erro,pois float nao se torna int

                float n1 = 10.5f;
                int n2 =(int) n1 // n1(é float), e quando coloquei, (int) na frente n1 
                //                 converti float para int. tornando rodavel ao programa.(typecast).


                Console.WriteLine(n2);
            }
        }
    }