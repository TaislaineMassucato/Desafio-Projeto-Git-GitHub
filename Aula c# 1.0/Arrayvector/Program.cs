using System;
    namespace arrayvect{
        class vectarray{
            static void Main(){

                //normal: int= n1,n2,n3
                
                //array|
            int[]    num=new         int[5];  //0 a 4 {pois os indice comeca do 0}
    //[]array      //nome do array      //numero de quantos array

            int[] num=new int[5]{55,66,77};
                                //atribuição direta ao array

            int[] num={55,66,77};
            //declaração direta, mas tem que lembrar quanto tem pex: int[3] os 55,66,77(3)

    //como declarar valor ao array nas posicoes indicadas

        num[0]=11;
        num[1]=22;
        num[2]=33;
        num[3]=44;
        num[4]=55;

        //como jogar para console

            Console.WriteLine(num[0]);

            }
        }
    }