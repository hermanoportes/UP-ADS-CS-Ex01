using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class Aluno : Usuario
    {
        public static List<Aluno> listaAlunos = new List<Aluno>();

        private int matricula;

        public int Matricula { get => matricula; set => matricula = value; }
                
        public static void Inserir(Aluno aluno)
        {
            listaAlunos.Add(aluno);            
        }

        public static void Excluir(Aluno aluno)
        {
            listaAlunos.Remove(aluno);
        }
        
        public static Aluno GetAluno(int matricula)
        {
            return listaAlunos.FirstOrDefault(a => a.Matricula == matricula);
        }
    }
}
