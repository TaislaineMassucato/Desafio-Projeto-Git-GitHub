﻿using System;
    namespace arguarms{
        class arguarm{
            static void Main(){
                soma(6);
            }
            static void soma (params int[]n){
                int res =0;

                if(n.Length<1){
                    Console.WriteLine("Nao existe valores a serem somados");
                }else if(n.Length<2){
                    Console.WriteLine("Valores insuficientes para soma: {0}",n[0]);
                }else{
                    for(int i=0;i<n.Length;i++){
                        res+=n[i];
                    }
                    Console.WriteLine("A soma dos valores é : {0}",res);
                }
                
            }
        }
    }