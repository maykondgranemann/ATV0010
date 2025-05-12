using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zuplae.Aulas.Atv0010.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("========================== ATV0010 ==========================");
            Console.Write("Digite o nome da cidade:");
            string cidade = Console.ReadLine();
            Console.Write("Digite o estado:");
            string estado = Console.ReadLine();
            Console.Write("Digite a população:");
            string populacao = Console.ReadLine();
            Console.Write("Digite PIB:");
            string pib = Console.ReadLine();

            Console.WriteLine($"Os dados digitados foram: {cidade}-{estado}-{populacao}-{pib}");
        }
    }
}
