using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class ProfessorController
    {
        List<Professor> tabelaProfessor = new List<Professor>();

        public Professor CadastrarProfessor()
        {
            Professor novoProfessor = new Professor();

            Console.WriteLine("Cadastrar Professor.");
            Console.Write("Id: ");
            novoProfessor.ID = int.Parse(Console.ReadLine());
                                    Console.Write("Nome: ");
            novoProfessor.Nome = Console.ReadLine();

            return novoProfessor;
        }

        public void InserirProfessor(Professor p)
        {
            tabelaProfessor.Add(p);
        }

        public void ImprimirDadosProfessor(Professor professor)
        {
            Console.WriteLine("");
            Console.WriteLine("ID: " + professor.ID);
            Console.WriteLine("Nome: " + professor.Nome);
        }


        public List<Professor> ListarProfessores()
        {
            return tabelaProfessor;
        }
    }
}
