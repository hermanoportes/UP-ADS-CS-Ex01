using Model;
using Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleView
{
    class Program
    {
        static void Main(string[] args)
        {
            AlunoController alunoController = new AlunoController();
            ProfessorController professorController = new ProfessorController();
            DisciplinaController disciplinaController = new DisciplinaController();

            int operacao = 0;
            do
            {
                Console.WriteLine("");
                Console.WriteLine("=======MENU=======");
                Console.WriteLine("1- Cadastrar Aluno");
                Console.WriteLine("2- Listar Alunos");
                Console.WriteLine("3- Cadastrar Professor");
                Console.WriteLine("4- Listar Professores");
                Console.WriteLine("5- Cadastrar Disciplina");
                Console.WriteLine("6- Listar Disciplina");
                Console.WriteLine("0- Sair");
                            
                Console.Write("Escolha uma opção: ");
                operacao = int.Parse(Console.ReadLine());
            
                Console.WriteLine("");

                switch (operacao)
                {
                    case 0:
                        //Sair
                        break;
                    case 1:
                    {
                        //Cadastrar alunos
                        Aluno a = alunoController.CadastrarAluno();
                        alunoController.InserirAluno(a);
                    }
                        break;
                    case 2:
                    {
                        //Listar alunos
                        foreach (Aluno aluno in alunoController.ListarAlunos())
                        {
                            alunoController.ImprimirDadosAlunos(aluno);
                        }
                    }
                        break;
                    case 3:
                        {
                            //Cadastrar professores
                            Professor p = professorController.CadastrarProfessor();
                            professorController.InserirProfessor(p);
                        }
                        break;
                    case 4:
                        {
                            //Listar professores
                            foreach (Professor professor in professorController.ListarProfessores())
                            {
                                professorController.ImprimirDadosProfessor(professor);
                            }
                        }
                        break;
                    case 5:
                        {
                            //Cadastrar Disciplinas
                            Disciplina novaDisciplina = disciplinaController.CadastrarDisciplina();
                            disciplinaController.InserirDisciplina(novaDisciplina);
                        }
                        break;
                    case 6:
                        {
                            //Listar disciplina
                            foreach (Disciplina disciplina in disciplinaController.ListarDisciplinas())
                            {
                                disciplinaController.ImprimirDadosDisciplina(disciplina);
                            }
                            break;
                        }


                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }
            } while (operacao != 0);
            Console.ReadKey();
        }        
    }
}
