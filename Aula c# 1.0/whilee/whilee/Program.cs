using System;
namespace wii{
    class whii{
        static void Main(){

            int[]  num=new int[12]; 

               int i=11; 
               //pois de 0 a 12 tenho 13 numeros, entao diminui um para chegar ao array 

            while(i>num.Length-1){
                num[i]=0;
                    i--;
                Console.WriteLine(" array com indice {0} recebe {1}", i,num[i]);
                


            }
            Console.Write ("Fim do loop");
            
        }
    }
}