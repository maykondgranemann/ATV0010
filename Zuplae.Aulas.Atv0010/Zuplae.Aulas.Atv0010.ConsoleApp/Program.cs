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
            int populacao = Convert.ToInt32( Console.ReadLine() );

            Console.Write("Digite PIB:");
            float pib = Convert.ToSingle(Console.ReadLine());
           

            float pibPerCapta = pib / populacao;

            Console.WriteLine($"Os dados digitados foram: {cidade}-{estado}-{populacao}-{pib}-{pibPerCapta}");
        }
    }
}
