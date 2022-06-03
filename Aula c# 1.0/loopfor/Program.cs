using System;
namespace LOOP{
    class FORLOOP{
        static void Main(){

            int[]  num=new int[12]; 

            for (int i=0;i<12;i+=1)
                            //i<12 (array int[12])
                            //para nao ter problema de errar quantidade de array 
                            //pode usar..(nome do array +lengh) pex: num.length.pois puxa jaotamanho dele
            {
                num[i]=0;
            }
                  for (int i=0;i<num.Length;i+=1){

        Console.WriteLine("Valor na posição {0}:  {1}",i,num[i]);
                  }
            
        }
    }
}