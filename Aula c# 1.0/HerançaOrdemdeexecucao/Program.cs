using System;

class Base:IDisposable{
    public Base(){
        Console.WriteLine("Construtor da classe Base");
    }
}
class Derivada1:Base{
    public Derivada1(){
        Console.WriteLine("Construtor da classe Derivada1");
    }
}
class Derivada2:Derivada1{
    public Derivada2(){
        Console.WriteLine("Construtor da classe Derivada2");
    }
public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
}

     class aula37{
         static void Main(){

using(Derivada2 derivada2=new Derivada2());
         }
     }