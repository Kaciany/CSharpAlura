using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condicionais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Executando projeto 7- Condicionais
            Console.WriteLine("Digite sua idade: ");

            int idade = int.Parse(Console.ReadLine());
            int quantidadePessoas = 1;

            if (idade >= 18)
            {
                Console.WriteLine("Você possui mais de 18 anos, Pode entrar!!");
            }
            else
            {
                Console.WriteLine("Você precisa de um acompanhante maior de idade para poder entrar!!!! ");
                Console.WriteLine("Digite o numero de acompanhante(s): ");
                quantidadePessoas = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite a idade do acompanhante(s): ");
                quantidadePessoas=int.Parse(Console.ReadLine());

                if (quantidadePessoas>= 2 && quantidadePessoas >= 18)
                {
                    Console.WriteLine("Você está acompanhado de um resposável maior de idade, pode entrar!! ");
                }
                else
                {
                    Console.WriteLine("Você(s) não possuem idade permitida para entrar!!");
                }
                
            }
            Console.ReadLine();

            #endregion
        }
    }
}
