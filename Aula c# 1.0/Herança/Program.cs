using System;
    namespace heranca{

     public class veiculo{
            public int velmax;
            private bool ligado;
            public int rodas;        
        public void ligar(){
            ligado=true;
        }
        public void desligar(){
            ligado=false;
        }

        public string getLigado(){
            if(ligado){
                return "sim";
            }else{
                return "Não";
            }

        }
        class Carro:veiculo{
             public string nome;
            public string cor;
        
        public Carro(string nome, string cor){
            ligar();
            velmax=120;
            rodas=4;
            this.nome=nome;
            this.cor=cor;

        }
        }
        class aula34{
            static void Main(){

           Carro car=new Carro("trovão","vermelho");

           
           Console.WriteLine("Numero de rodas: {0}",car.rodas);
           Console.WriteLine("Ligado?: {0}",car.getLigado());
           Console.WriteLine("Velocidade Máxima: {0}",car.velmax);
              Console.WriteLine("Nome car: {0}",car.nome);
                 Console.WriteLine("cor do car: {0}",car.cor);     
            
                
            }
        }}}
    

        