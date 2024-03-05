using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTrabalho
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual é o seu salário bruto?");
            double bruto = double.Parse (Console.ReadLine());

            Console.WriteLine("Qual é o valor do seu vale alimentação?");
            double alimentacao = double.Parse (Console.ReadLine());

            Console.WriteLine("Quantos filhos você tem?");
            int NFilhos =int.Parse (Console.ReadLine());

            Console.WriteLine("Quanto a empresa disponibiliza de acréscimo por filho?");
            int VaFilho = int.Parse (Console.ReadLine());

            Console.WriteLine("Quantas horas extras você fez?");
            double  hora = double.Parse (Console.ReadLine());

            Console.WriteLine("Quanto você ganha por hora extra?");
            int vlrhora = int.Parse (Console.ReadLine());

            Console.WriteLine("Digite o valor do inss");
            double Inss = double.Parse (Console.ReadLine());

            Console.WriteLine("Digite o valor do irpf");
            double Irpf = double.Parse (Console.ReadLine());

            double liquido = bruto = alimentacao + (NFilhos * VaFilho) +
                              (hora * vlrhora) - Inss - Irpf;

            Console.WriteLine("Salário líquido: " + liquido.ToString());

            Console.ReadKey();
        }
    }
}
