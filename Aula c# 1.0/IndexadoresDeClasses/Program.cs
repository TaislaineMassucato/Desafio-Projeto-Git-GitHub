using System;


 class veiculo {
    private int[] velMax=new int[6]{21,32,43,54,65,76};

    public int this[int i]{
        get{
            return velMax[i];

        }
        set{
            if(value<0){
                velMax[i]=0;
            }else if(value>=300){
                velMax[i]=300;
            }else{
                velMax[i]=value;
            }
            
        }
    }
}
    class aula41{
        static void Main(){

                using(veiculo carro1=new veiculo());
                Console.WriteLine("Valor dentro do índice 4 é: {0}",carro1[4]);
        }
    }