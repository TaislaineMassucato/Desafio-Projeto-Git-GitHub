using System;
    namespace ConsDes{
        public class Jogador: IDisposable{
            public int energia;
            public bool vivo;
            public string nome;

            public Jogador(string n){
                energia=100;
                vivo=true;
                nome=n;

                
            }
            public void Dispose(){
      Console.WriteLine("jogador {0} morreu",nome);
      GC.SuppressFinalize(this);
  }

            }
            class aulaDesCon{
                static void Main(){
                        string n1;
                        Console.WriteLine("Digit enome do jogador");
                    n1=Console.ReadLine();
                  using(Jogador j1=new Jogador(n1)){
                       Console.WriteLine("A energia de 1 é {0}: e está {1}",j1.energia,j1.vivo);
                  }
                    using(Jogador j2=new Jogador("pal")){
                   
                    Console.WriteLine("A energia de 2 é : {0} e está {1}",j2.energia,j2.vivo);
                    }
                }
            }
        }
        

       
    