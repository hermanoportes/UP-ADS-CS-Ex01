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
       
        public Aluno CadastrarAluno()
        {
            Aluno novoAluno = new Aluno();

            Console.WriteLine("Cadastrar novo Aluno:");
            Console.Write("Nome: ");
            novoAluno.Nome = Console.ReadLine(); //set Aluno.nome

            Console.Write("Matrícula: ");
            novoAluno.Matricula = int.Parse(Console.ReadLine()); //set Aluno.matricula

            return novoAluno;
        }

        public void InserirAluno(Aluno a)
        {
            tabelaAlunos.Add(a);
        }

        public void ImprimirDadosAlunos(Aluno aluno)
        {
            Console.WriteLine("");
            Console.WriteLine("Nome: " + aluno.Nome);
            Console.WriteLine("Matrícula: " + aluno.Matricula);
        }


        public List<Aluno> ListarAlunos()
        {
            return tabelaAlunos;
        }

    }
}
