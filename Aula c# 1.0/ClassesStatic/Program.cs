using System;
    namespace ConsDes{
        static public class Jogador{
            static public int energia;
            static public bool vivo;
            static public string nome;

           static public void iniciar(string n){
                energia=100;
                vivo=true;
                nome=n;    
            }
                
            static public void  info(){
                    Console.WriteLine("Nome do jogador é: {0}",nome);
                    Console.WriteLine("Energia do jogador é: {0}",energia);
                    Console.WriteLine("Status do jogador é: {0}",vivo);

                                }
            class inimigo{
                static public bool alerta;
                public string nome;

                public inimigo(string n){
                    alerta=false;
                    nome=n;
                }
                public void Infoo(){
                    Console.WriteLine(nome);
                      Console.WriteLine(alerta);
                        
                }
            }

            class aulaDesCon{
                static void Main(){
                    Jogador.iniciar("bruno");
                    Jogador.info();

                 inimigo i1=new inimigo("Doido");
                 inimigo i2=new inimigo("raspa");
                 inimigo i3=new inimigo("pirado");

                    inimigo.alerta=true;
                    
                i1.Infoo();
                i2.Infoo();
                i3.Infoo();
                        }
            }
        }
    }
        

       
    



