using System;
namespace swic{
    class sc{
        static void Main(){


                inicio:

            Console.Clear();

                char curso;
                int nomecu;

            Console.WriteLine("Seja bem vindo ao estudio TH!!Mnesalidades abaico de 700");
            
            Console.WriteLine("Informe o curso de interesse | [a]Info  [b]ds  [c]mk");

        curso=char.Parse(Console.ReadLine());

            switch(curso){
                case'a':
                    nomecu=350 ;
                    break;
                case'b':
                    nomecu=400;
                    break;
                case'c':
                    nomecu=100 ;
                    break;

                default:
                    nomecu=700;
                    break;
                    



            }
            if (nomecu>=700){
                Console.WriteLine("Preço acima do limite padrão");
            }else{
                Console.WriteLine("O valor do curso é de:  {0}",nomecu);
            }
            Console.WriteLine("Muito obrigad(o/a) pela presença");
            Console.WriteLine("Gostaria de ver outros cursos ?  [s/n]");
               curso=char.Parse(Console.ReadLine());

               if(curso=='s'){
                   goto inicio;
               }else{
                   Console.WriteLine("paga em outro mais caro, tchau brigado");
                   Console.Clear();
               }
        }
    }
}
