using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaAlunoConsoleOoParte2
{
    class Aluno
    {
        // Atributos

        private string nome;
        private double p1, p2;

        // Construtores

        public Aluno(string nome, double p1, double p2)
        {
            SetNome(nome);
            SetP1(p1);
            SetP2(p2);
        }

        public Aluno(string nome) : this(nome, 0, 0)
        {
        }

        // Métodos Modificadores

        public void SetNome(string nome)
        {
            this.nome = nome;
        }

        public void SetP1(double p1)
        {
            if (p1 >= 0 && p1 <= 10)
            {
                this.p1 = p1;
            }
            else
            {
                throw new ArgumentException();
            }
        }

        public void SetP2(double p2)
        {
            if (p2 >= 0 && p2 <= 10)
            {
                this.p2 = p2;
            }
            else
            {
                throw new ArgumentException();
            }
        }

        // Métodos Acessores

        public string GetNome()
        {
            return nome;
        }

        public double GetP1()
        {
            return p1;
        }

        public double GetP2()
        {
            return p2;
        }

        // Métodos de Negócio

        public double CalculaMedia()
        {
            double media = (p1 + p2) / 2;
            return media;
        }

        public bool VocePassou()
        {
            return VocePassou(6);
        }

        public bool VocePassou(double mediaMinima)
        {
            double media = CalculaMedia();
            return media >= mediaMinima;
        }

    }
}
