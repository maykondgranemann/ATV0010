using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
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

            List<Cidade> cidades = new List<Cidade>();

            bool continua = true;
            int n_cidade = 1;

            while (continua) 
            {
                Cidade cidade = new Cidade(); //Instanciando um objeto
                Console.WriteLine("Digite os dados da Cidade "+ n_cidade);
                Console.Write("Digite o nome da cidade:");
                cidade.nome = Console.ReadLine();

                Console.Write("Digite o estado:");
                cidade.estado = Console.ReadLine();

                Console.Write("Digite a população:");
                cidade.populacao = Convert.ToInt32(Console.ReadLine());

                Console.Write("Digite PIB:");
                cidade.pib = Convert.ToSingle(Console.ReadLine());

                cidade.pibPerCapta = cidade.pib / cidade.populacao;

                cidades.Add(cidade);

                Console.Write("Deseja inserir mais uma cidade? (s/n): ");
                char resposta = Convert.ToChar( Console.ReadLine() );
                if(resposta == 'n')
                {
                    continua = false;
                }
                else
                {
                    Console.WriteLine();
                    n_cidade++;
                }
            }

            Console.WriteLine("\n======== Imprimindo todas as cidades =========");
            n_cidade = 1;
            foreach (var c in cidades)
            {
                Console.WriteLine($"Cidade {n_cidade}: {c.nome}; {c.estado}; {c.populacao}; {c.pib}; {c.pibPerCapta}");
                n_cidade++;
            }
            
        }
    }
}
