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
            #region Executando projeto 10 - Calculando poupança

            Console.WriteLine("Calcula poupança");
             int contaMes = 1;
             double  valorInvestido = 1000;
            // 0.36% = 0.0036
            valorInvestido = valorInvestido * valorInvestido * 0.0036;

            while (contaMes <= 12)
             {

                    valorInvestido = valorInvestido + valorInvestido * 0.0036;
                    Console.WriteLine("Após "+ contaMes+" meses,"+" você terá R$ "+valorInvestido);
                // contaMes = contaMes + 1;
                // contaMes += 1;

                contaMes++;
            }



            Console.Read();
            #endregion
        }
    }
}
