using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class AlunoController
    {
        List<Aluno> tabelaAlunos = new List<Aluno>();

        public void InserirAluno(Aluno a)
        {
            tabelaAlunos.Add(a);
        }

        public List<Aluno> ListarAlunos()
        {
            return tabelaAlunos;
        }

    }
}
