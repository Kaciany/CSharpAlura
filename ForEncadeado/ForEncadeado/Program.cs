using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForEncadeado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Projeto 13- Laço FOR encadeado.
            //*
            //**
            //***
            //****
            //*****
            //******
            //*******
            //********
            //*********
            //********** 

            // escrevendo asteriscos com o BREAK
            //for (int contadorLinha = 0; contadorLinha < 10; contadorLinha++)
            //{
            //    for (int contadorColuna = 0; contadorColuna < 10; contadorColuna++)
            //    {
            //        Console.Write("*");
            //        if (contadorColuna >= contadorLinha)
            //            break;
            //    }
            //}
            // Console.WriteLine();
            //}
                  
                // Uma forma diferente de fazer o desenho de asteriscos

                for (int contadorLinhaa = 0; contadorLinhaa < 10; contadorLinhaa++)
                {
                    for (int contadorColunaa = 0; contadorColunaa <= contadorLinhaa; contadorColunaa++)
                    {
                        Console.Write("*");


                    }
                    Console.WriteLine();
                }

                Console.ReadLine();
                #endregion
            }
}
}
