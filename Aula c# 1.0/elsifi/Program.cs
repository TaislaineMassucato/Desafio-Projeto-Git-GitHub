﻿using System;
        namespace elfi{
            class elfy{
                static void Main(){

                    int n1,n2,n3,res;
                    string resultado="Reprovado";
                    string nome;

                    Console.WriteLine("Digite seu nome:  ");
                    nome=Console.ReadLine();
                    Console.WriteLine("Digite a nota da primeira prova: ");
                    n1=int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite a nota da segunda prova: ");
                    n2=int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite a nota da terceira prova: ");
                    n3=int.Parse(Console.ReadLine());

                    res=(n1+n2+n3);
                    
                        //>=60 APROVADO
                        //59 E 40 RECUPERACAO
                        //<40 REPROVADO

                    if(res<40){
                        resultado="Reprovado";
                    }else if(res<60){
                        resultado="Recuperação";
                    }else {
                        resultado="Aprovado";
                    }
                    
                                      
                          
                                 
                    Console.WriteLine("{0} você foi {1} ",nome,resultado); 
                    
                }
            }
        }