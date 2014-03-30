using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaAlunoConsoleOo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Entradas:
            Console.Write("Nome do aluno: ");
            string nome = Console.ReadLine();

            Console.Write("Nota da P1: ");
            double p1 = double.Parse(Console.ReadLine());

            Console.Write("Nota da P2: ");
            double p2 = double.Parse(Console.ReadLine());

            // Processamento:
            Aluno aluno = new Aluno(nome, p1, p2);

            double media = aluno.CalculaMedia();

            // Saídas:
            Console.WriteLine("O aluno {0} teve média {1}.", aluno.GetNome(), media);
        }
    }
}
