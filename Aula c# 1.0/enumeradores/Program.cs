using System;
    namespace num{
        class enumerador{
           //enun tipo criado por mim
           //
            enum DiasSemana{Domingo, Segunda,Terça,Quarta,Quinta,Sexta,Sábado};
            static void Main(){

                
                
                DiasSemana ds= DiasSemana.Domingo;
                //pode trabalhar com índicE {0,1,2,}
                    // NORMAL SERIA : DiasSemana ds= {0}; NÃOOO
                    //               DiasSemana ds= (DiasSemana)0; simmm 


                //TRANSFORMAR DIA DA SEMANA EM INDICE
                    //Int ds=(Int) DiasSemana.Domingo;
                    //RETORNARÁ {0},POIS INDICE DE DOMINGO É 0
                Console.WriteLine(ds);
            }
        }
    }