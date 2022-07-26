using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriandoVariaveis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 2 - Criando Variaveis");
            int idade;
            idade = 32;
            idade = 10 + 5;
            Console.WriteLine(idade);

            idade = 10 + 5 * 2;  // primeiro vai realizar a multiplicação depois a soma
            Console.WriteLine(idade);

            idade = (10 + 5) * 2; // primeiro realiza a soma e depois a multiplicação, prioridade para os parenteses
            Console.WriteLine("Sua idade é: " + idade + "!");

            
            Console.WriteLine("Execução finalizada tecle enter para sair.....");
            Console.ReadLine();
        }
    }
}
