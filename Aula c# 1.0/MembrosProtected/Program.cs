using System;
    namespace prote{
class veiculo{
 public int velAtual;
 private int velMax;
 protected bool Ligado;

 public veiculo(int velMax){
     velAtual=0;
     this.velMax=velMax;
     Ligado=false;
 } 
 public bool getLigado(){
     return Ligado;
 }
 public int getVelmax(){
     return velMax;
 }
}
class carro:veiculo{
    public string nome;

    public carro(string nome,int vm):base(vm){
        this.nome=nome;
        Ligado=false;
    }
}
class aula36{
            static void Main(){
    carro car1=new carro("carrao",120);

    Console.WriteLine("nome: {0}",car1.nome);
    Console.WriteLine("velo atual: {0}",car1.velAtual);
    Console.WriteLine("carro : {0}",car1.getLigado());
    Console.WriteLine("velo maxima: {0}",car1.getVelmax());                
            }
}
        }