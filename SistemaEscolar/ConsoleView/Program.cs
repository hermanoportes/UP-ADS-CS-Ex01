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
            //Menu            
            Console.WriteLine("1 - Inserir Aluno");
            Console.WriteLine("2 - Excluir Aluno");
            Console.WriteLine("3 - Listar Alunos");
            do
            {
                Console.Write("Digite uma Opção: ");
                int operacao = int.Parse(Console.ReadLine());
            }while()
            

            switch (operacao)
            {
                case 1:
                    {
                        Console.WriteLine("Inserir Aluno:");
                    }
                    break;
                case 2:
                    {
                        Console.WriteLine("Excluir Aluno:");
                    }
                    break;
                case 3:
                    {
                        Console.WriteLine("Listar Aluno:");
                    }
                    break;
                default:
                    break;            
            }

            Console.ReadKey();

            Aluno novoAluno = new Aluno();

            /*Console.WriteLine("Cadastrar novo Aluno:");
            Console.Write("Nome: ");
            novoAluno.Nome = Console.ReadLine(); //set Aluno.nome

            Console.Write("Matrícula: ");
            novoAluno.Matricula = int.Parse(Console.ReadLine()); //set Aluno.matricula

            Console.WriteLine("Nome: " + novoAluno.Nome);
            Console.WriteLine("Matrícula: " + novoAluno.Matricula);

            Console.ReadKey();*/

            //========================================================================


            //Aluno novoAluno = CadastrarAluno();

            /* while (novoAluno.Nome != "")
             {
                 AlunoController.InserirAluno(a);
             }


             Aluno b = CadastrarAluno();
             AlunoController.InserirAluno(b);

             Aluno c = CadastrarAluno();
             AlunoController.InserirAluno(c);

             foreach (Aluno aluno in AlunoController.ListarAlunos())
             {
                 AlunoController.ImprimirDadosAluno(aluno);
             }
             Console.ReadKey();*/


        }
    }
}
