using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Escola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero:");
            int numeroum = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o sinal:");
            string sinal = Console.ReadLine();
            Console.Write("Digite outro numero:");
            int numerodois = int.Parse(Console.ReadLine());
            Console.WriteLine(capturar(numeroum, sinal, numerodois));
            Console.ReadLine();
        }
        static int capturar(int num1, string sinal, int num2)
        {
            int resultado;
            if (sinal == "+")
            {
                resultado = num1 + num2;
                return resultado;
            }
            else if (sinal == "-")
            {
                resultado = num1 - num2;
                return resultado;
            }
            else if (sinal == "*")
            {
                resultado = num1 * num2;
                return resultado;
            }
            else if (sinal == "/")
            {
                resultado = num1 / num2;
                return resultado;
            }
            else { return 0; }
        }  
    }
}
