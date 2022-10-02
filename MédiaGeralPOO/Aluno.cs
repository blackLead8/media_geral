using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MédiaGeralPOO
{
    class Aluno
    {
        public string Nome { get; set; }
        private double[] _notas;
        public double Media
        {
            get 
            {
                return CalcularMedia();
            }
        
        }

        public Aluno(string nome, int provas)
        {
            Nome = nome;
            //O tamanho da array notas será igual ao numero escrito no parametro provas
            _notas = new double[provas];
        }

        public void InserirNotas()
        { 
            for(int i = 0; i < _notas.Length; i++)
            {
                Console.WriteLine("Nota # " + (i + 1) + ": ");
                _notas[i] = double.Parse(Console.ReadLine());
            }
        }

        private double CalcularMedia()
        {
            double total = 0;
            for(int i = 0; i < _notas.Length; i++)
            {
                total += _notas[i];
            }
            return total / _notas.Length;
        }

    }
}
