using System;

class Carro{
    private int velMax;
    //métodos usam ()pois tem valor de entradas.
    //propriedades só usam {} pois nao tem valores de entrada
    public int vm{
        get{
            return velMax;
        }
        set{
            if( value < 0){
            velMax=0;
        }else if(value>=300){
            velMax=300;
        }else{
            velMax=value;
        }

        }

    }
    public Carro(){
        vm=-1;
    }
}

 class gs{
     static void Main(){
  
         Carro c1=new Carro();
         c1.vm=200;
         Console.WriteLine(c1.vm);
       
     }
 }