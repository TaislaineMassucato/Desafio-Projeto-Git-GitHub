using System;
    namespace ConsDes{
        public class Jogador{
            public int energia;
            public bool vivo;
            public string nome;
            public Jogador(){
                energia=100;
                vivo=true;
                nome="jogador";    
            }
            public Jogador(string n){
                energia=100;
                vivo=true;
                nome=n;    
            }
             public Jogador(string n,int e){
                energia=e;
                vivo=true;
                nome=n;
            }
                public Jogador(string n,int e, bool v){
                energia=e;
                vivo=v;
                nome=n;
            }
             public void info(){
                    Console.WriteLine("Nome do jogador é: {0}",nome);
                    Console.WriteLine("Energia do jogador é: {0}",energia);
                    Console.WriteLine("Status do jogador é: {0}",vivo);

                                }
            }

            class aulaDesCon{
                static void Main(){

                    Jogador j1=new Jogador();
                    Jogador j2=new Jogador("eu");
                    Jogador j3=new Jogador("oi",12);
                    Jogador j4=new Jogador("td",32,true);

                    j1.info();
                    j2.info();
                    j3.info();
                    j4.info();



                                       }
            }
        }
        

       
    



