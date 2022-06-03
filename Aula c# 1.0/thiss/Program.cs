using System;
    namespace thiss{


        class Calcular{
            public int v1;
            public int v2;

    public Calcular(int v1, int v2){
        this.v1=v1;
        this.v2=v2;

    }
            public int soma(){
                return v1+v2;

                
            }
        }
        class aula32{
            static void Main(){
                    Calcular c=new Calcular(10,2);
                    c.soma();

                    Console.WriteLine(c.soma());
            }
        }
    }