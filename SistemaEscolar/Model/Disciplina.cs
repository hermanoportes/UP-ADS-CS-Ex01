using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Disciplina
    {
        private int id;
        private string nome;
        private string curso;
        private string turma;
        private int iDProfessor;
        private List<int> iDAluno;

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Curso { get => curso; set => curso = value; }
        public string Turma { get => turma; set => turma = value; }
        public int IDProfessor { get => iDProfessor; set => iDProfessor = value; }
        public List<int> IDAluno { get => iDAluno; set => iDAluno = value; }
    }
}
