using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Aluno
    {
        private int matricula;
        private string nome;

        public int Matricula { get => matricula; set => matricula = value; }
        public string Nome { get => nome; set => nome = value; }
    }
}
