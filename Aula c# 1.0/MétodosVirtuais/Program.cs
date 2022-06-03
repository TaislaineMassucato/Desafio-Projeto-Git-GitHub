using System;

        class Base{
            public Base(){
                Console.WriteLine("Construtor Classe Base");
            }
             virtual public void info(){}
        }
        class derivada1:Base{
            public derivada1(){
            Console.WriteLine("Construtor Derivada1");
            }
            override public void info(){
                Console.WriteLine("Info da derivada 1");
            }
        }
        class derivada2:derivada1{
            public derivada2(){
                Console.WriteLine("Construtor derivada 2 ");
            }
            override public void info(){
                Console.WriteLine("Info da derivada 2");
            }
        }



    class vir{
        static void Main(){

                Base Ref;
            derivada1 der1=new derivada1();
            derivada2 der2=new derivada2();

            Ref=der2;
            Ref.info();
            



            


        }
    }