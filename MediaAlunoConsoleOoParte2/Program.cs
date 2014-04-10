using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaAlunoConsoleOoParte2
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
            Aluno aluno = new Aluno(nome);
            aluno.SetP1(p1);
            aluno.SetP2(p2);

            double media = aluno.CalculaMedia();
            bool passou = aluno.VocePassou();

            // Saídas:
            Console.WriteLine("O aluno {0} {2} com média {1}.", aluno.GetNome(), media,  passou ? "passou" : "não passou");
        }
    }
}
