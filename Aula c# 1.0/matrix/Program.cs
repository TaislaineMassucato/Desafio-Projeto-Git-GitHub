﻿using System;
    namespace matrix{
        class bidi{
            static void Main(){

                  //  ARRAYYY
              //  string[] carro=new string[3];

                //carro[0]="ford";
                //carro[1]="gol";
                //carro[2]="fiat";

                //Console.WriteLine(carro[0]);

                    //Matrix
            int[,]       num=new       int[3,4];  
        //bidimensional             3 linhas 4 coluna
                 
                 //exemplo abaixo
        //          0(C) 1(C) 2(C) 3(C)
        // |   0 L   1    2    3    4
        // |   1 L   5    6    7    8
        // |   2 L   9    10   11  12 

            num[0,0]=1;
            num[0,1]=2;
            num[0,2]=3;
            num[0,3]=4;
            num[1,0]=5;
            num[1,1]=6;
            num[1,2]=7;
            num[1,3]=8;
            num[2,0]=9;
            num[2,1]=10;
            num[2,2]=11;
            num[2,3]=12;
            
        Console.WriteLine(num[2,2]);
            }
        }
    }