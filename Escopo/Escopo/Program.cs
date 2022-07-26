using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escopo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Executando projeto 8 - Condicionais2
            Console.WriteLine("Digite sua idade: ");

            int idade = int.Parse(Console.ReadLine());
            int quantidadePessoas = 1;
            bool acompanhante = true;
            

            if (idade >= 18 || quantidadePessoas >= 18)
            {
                Console.WriteLine("Pode entrar!!");
            }
            else
            {
                Console.WriteLine("Você precisa de um acompanhante maior de idade para poder entrar!!!! ");

                Console.WriteLine("Você está acompanhado? ");
                acompanhante = bool.Parse(Console.ReadLine());


                if (idade > 18 || acompanhante == false)
                {
                    Console.WriteLine("Você não pode entrar! ");


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

