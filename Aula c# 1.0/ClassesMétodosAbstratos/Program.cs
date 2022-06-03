using System;

    abstract class Carro{
        protected int velMax;
        protected int velAtual;
        protected bool ligado;
        public Carro(){
            ligado=false;
            velAtual=0;
        }
        public void setLigado(bool ligado){
            this.ligado=ligado;
        }
        public int getVelAtual(){
            return velAtual;
        }
        abstract public void aceleração(int mult);
        
    }
    class automovel:Carro{
        public automovel(){
            velMax=120;}
            override public void aceleração(int mult){
                velAtual+=10*mult;
            }
        
        }
        class abs{
        static void Main(){
            automovel auto1=new automovel();

            auto1.aceleração(1);
    Console.WriteLine(auto1.getVelAtual());
            
            

        }
    }