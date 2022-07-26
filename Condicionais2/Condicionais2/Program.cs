using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condicionais2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Executando projeto 9- Condicionais2
            Console.WriteLine("Digite sua idade: ");

            int idade = int.Parse(Console.ReadLine());
            int quantidadePessoas = 1;
            bool acompanhante = true;
            string mensagemAdicional;

            if (idade >= 18 || quantidadePessoas >= 18)
            {
                Console.WriteLine("Pode entrar!!");
            }
            else
            {
                Console.WriteLine("Você precisa de um acompanhante maior de idade para poder entrar!!!! ");

                Console.WriteLine("Você está acompanhado? ");
                acompanhante = bool.Parse(Console.ReadLine());


                if (idade > 18 || acompanhante == false  )
                {
                 

                 }
                else
                    {
                        Console.WriteLine("Digite a idade do acompanhante: ");
                        quantidadePessoas = int.Parse(Console.ReadLine());
                    }


                    if (quantidadePessoas >= 1 && quantidadePessoas >= 18)
                    {
                        Console.WriteLine("Vocês podem entrar!! ");

                    }
                    else
                    {
                        Console.WriteLine("Entrada negada!");
                    }
                }
                Console.ReadLine();

                #endregion
            }
        }
    } 



