using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtribuicoesDeVariaveis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int idade = 32;
            //int idadeGustavo = idade;
            //  int idade = 20; essa linha não compila pelo fato do valor da variavel já ter sido declarada
            string parcela_1 = "10";

            string parcela_2 = "20";

            Console.WriteLine(parcela_1+parcela_2);

            //Console.WriteLine(idade);
            //Console.WriteLine(idadeGustavo);
           
            Console.ReadLine();
               
        }
    }
}
