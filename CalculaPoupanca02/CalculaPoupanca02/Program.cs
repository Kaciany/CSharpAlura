using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculaPoupanca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Executando projeto 11 - Calculando poupança 02 (Laço FOR)

            Console.WriteLine("Calcula poupança 02");

            double valorInvestido = 1000;


            for (int  contadorMes = 1; contadorMes <= 12; contadorMes++ )
            {
                valorInvestido = valorInvestido * 1.0036;
                Console.WriteLine("Após " + contadorMes + " meses, " + " você terá R$ " + valorInvestido);
            }


            Console.Read();
            #endregion
        }
    }
}
