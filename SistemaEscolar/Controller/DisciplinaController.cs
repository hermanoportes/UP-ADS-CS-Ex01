using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class DisciplinaController
    {
        List<Disciplina> tabelaDisciplinas = new List<Disciplina>();

        public Disciplina CadastrarDisciplina()
        {
            Disciplina novaDisciplina = new Disciplina();

            Console.WriteLine("Cadastrar Disciplina.");
            Console.Write("Id: ");
            novaDisciplina.Id = int.Parse(Console.ReadLine());
            Console.Write("Nome: ");
            novaDisciplina.Nome = Console.ReadLine();
            Console.Write("Curso: ");
            novaDisciplina.Curso = Console.ReadLine();
            Console.Write("Turma: ");
            novaDisciplina.Turma = Console.ReadLine();
            Console.Write("ID Professor: ");
            novaDisciplina.IDProfessor = int.Parse(Console.ReadLine());

            return novaDisciplina;
        }

        public void InserirDisciplina(Disciplina d)
        {
            tabelaDisciplinas.Add(d);
        }

        public void ImprimirDadosDisciplina(Disciplina disciplina)
        {
            Console.WriteLine("");
            Console.WriteLine("ID: " + disciplina.Id);
            Console.WriteLine("Nome: " + disciplina.Nome);
            Console.WriteLine("Curso: " + disciplina.Curso);
            Console.WriteLine("Turma: " + disciplina.Turma);
            Console.WriteLine("ID Professor: " + disciplina.IDProfessor);            
        }


        public List<Disciplina> ListarDisciplinas()
        {
            return tabelaDisciplinas;
        }
    }
}
