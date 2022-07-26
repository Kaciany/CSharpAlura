using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriandoVariaveisPontoFlutuante
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Projeto 3 -  Criando variaveis ponto flutuante.");

            Console.WriteLine("Exemplos de operações utilizando pontos flutuantes: ");

            //double salario;
            //salario = 1200.70;

            //double idade;
            //idade = 15.0 / 2;

            double idade;
            idade = 5 / 3;

            Console.WriteLine("5/3 = "+idade);

            idade = 5.0 / 3;

            Console.WriteLine("5.0/3 = " + idade);



            Console.WriteLine("A execução acabou. Tecle enter para sair .....");
            Console.ReadLine();
        }
    }
}
