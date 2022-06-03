using System;
    namespace PublicPrivat{

         class Jogador{
            private int energia;
            private string nome;

             public Jogador(string nome){
                this.nome=nome;
                energia=100;

            }
            public int getEnergia(){
                return energia;

            }
            public string getNome(){
                return nome;

            }
            public void setEnergia(int e){
                if(e<0){
                    if(energia+e < 0){
                        energia=0;
                    }else{
                        energia+=e;
                    }
                }else if(e>0){
                    if(energia+e > 100){
                        energia=100;
                    }else{
                        energia+=e;
                    }

                }
            }
        }
        class AULA33{
            static void Main(){
                 Jogador j1=new Jogador("eu");
j1.setEnergia(-150);
                 Console.WriteLine("Nome jogador 1 {0}",j1.getNome());
                 Console.WriteLine("Energia jogador 1 {0}",j1.getEnergia());
            }
        }
    }