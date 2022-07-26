using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaracteresETextos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 5 - Caracteres e textos");

         

            char letra = 'a';
            Console.WriteLine(letra);

            char valor = (char)65;  // Compila!
            Console.WriteLine(valor);

            valor = (char)(valor + 1);          // Compila!
            Console.WriteLine(valor);

            valor = (char)(valor + 1);         // Compila!
            Console.WriteLine(valor);

            string palavra = "alura cursos online de tecnologia ";
            Console.WriteLine(palavra);
            palavra = palavra + 2020;
            Console.WriteLine(palavra);

            Console.WriteLine("Aperte enter para parar a execução.....");
            Console.ReadLine();
        }
    }
}
