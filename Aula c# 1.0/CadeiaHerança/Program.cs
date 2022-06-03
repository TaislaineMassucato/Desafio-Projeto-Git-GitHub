namespace HERANCA{

        class veiculo {//classe base

        private int Rodas;
        public int velmax;
        protected bool ligado;

//classe criada para rodas privsate
      public veiculo (int rodas){
           this.Rodas=rodas;
}
        public void ligar(){
            ligado=true;
            
        }
        public void desligar(){
            ligado=false;

        }
        public string getLigado(){
         return (ligado?"sim":"não");
                      //if ternario: ? consicional ternario 
               }
        public int getRodas(){
            return Rodas;
        }
        public void setRodas(int rodas){
            if(Rodas<0){
               this.Rodas=0;
            }else if(Rodas>40){
                this.Rodas=40;
            }else{
                this.Rodas=rodas;
            }
        }
         
        }
           class carro:veiculo{
               public string cor,nome;
                                                      // :base()..Usar construtor 
                                                      //de rodasja q eça é privada.. (4)
                                                      //numero de rodas.                 
               public carro(string nome,string cor):base(4){
                
                   velmax=120;
                   this.nome=nome;
                   this.cor=cor;
               }}
              class CarroCombate:carro{
                  public int municao;
                  public CarroCombate():base("carro de combate", "verde"){
                      municao=100;
                      setRodas(10);
                  }

              }

         
       
    

       

        class AULA34{
            static void Main(){
                carro c1=new carro("rapidao","vermelho");
                CarroCombate c2=new CarroCombate(); 
                c1.desligar(); 
                 Console.WriteLine("cor: {0}",c1.cor);
                 Console.WriteLine("nome: {0}",c1.nome);
                 Console.WriteLine("rodas: {0}",c1.getRodas());
                  Console.WriteLine("velocidade: {0}",c1.velmax);
                   Console.WriteLine("ligado: {0}",c1.getLigado());

                  Console.WriteLine("........................................");

                 Console.WriteLine("nome: {0}",c2.nome);
                 Console.WriteLine("rodas: {0}",c2.getRodas());
                  Console.WriteLine("velocidade: {0}",c2.velmax);
                   Console.WriteLine("ligado: {0}",c2.getLigado());
                  Console.WriteLine("municao: {0}",c2.municao);
                  

            }
        }
}