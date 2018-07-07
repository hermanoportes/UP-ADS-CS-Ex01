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
        public void Cadastrar(Aluno aluno)
        {
            Console.Clear();
            
            Console.WriteLine();
            Console.WriteLine("====== CADASTRAR ALUNO ======");
           
            aluno.Nome = Pergunta(" Nome: ");
           
            aluno.Matricula = PerguntaInt(" Matrícula: ");

            Console.WriteLine();
            Console.WriteLine("Aluno inserido com sucesso.");
            
            Console.Write("Pressione qualquer tecla para continuar.");
            Console.ReadKey();

            Aluno.Inserir(aluno);            
        }

        string Pergunta(string questao)
        {
            Console.Write(questao);            
            return Console.ReadLine();
        }

        int PerguntaInt(string questao)
        {
            Console.Write(questao);
            return int.Parse(Console.ReadLine());
        }
        
        public void ListarAlunos() // Listar todos Alunos
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("====== ALUNOS ======");            
            Console.WriteLine("Matrícula \tNome");
            foreach (Aluno novoAluno in Aluno.listaAlunos)
            {
                Console.WriteLine(novoAluno.Matricula + "\t\t" + novoAluno.Nome);
            }            
        }

        public void AlterarAluno()
        {
            ListarAlunos();

            Console.WriteLine("");
            Console.WriteLine("Alterar Dados");           
            Console.Write("Matrícula: ");
            int matricula = int.Parse(Console.ReadLine());

            Aluno aluno = Aluno.GetAluno(matricula);
           
            if (aluno != null)
            {
                Console.Clear();
                Console.WriteLine("");
                Console.WriteLine("Alterar Dados do Aluno:");
                Console.WriteLine("============================================");
                Console.WriteLine("Matrícula \tNome");
                Console.WriteLine(aluno.Matricula + "\t\t" + aluno.Nome);
                Console.WriteLine("============================================");

                Console.Write("Novo nome: ");
                aluno.Nome = Console.ReadLine();
            } else
            {
                Console.WriteLine("Matrícula não encontrada.");
                Console.WriteLine("");                
            }
            Console.Write("Pressione qualquer tecla para continuar");
            Console.ReadKey();

        }

        //=========================================================================================
        public void ExcluirAluno()
        {
            ListarAlunos();

            Console.WriteLine("");
            Console.WriteLine("Excluir Aluno");            
            Console.Write("Matrícula: ");
            int matricula = int.Parse(Console.ReadLine());         

            Aluno aluno = Aluno.GetAluno(matricula);

            if (aluno != null)
            {
                Console.Clear();
                Console.WriteLine("");
                Console.WriteLine("Excluir Aluno");
                Console.WriteLine("============================================");
                Console.WriteLine("Matrícula \tNome");
                Console.WriteLine(aluno.Matricula + "\t\t" + aluno.Nome);
                Console.WriteLine("============================================");

                char confirma;
                do
                {
                    Console.Write("Voce deseja excluir esse aluno(S/N)? ");
                    string simOuNao = Console.ReadLine();
                    confirma = Char.Parse(simOuNao);

                    if (Char.ToUpper(confirma) == 'S')
                    {
                        Console.WriteLine("Aluno excluido com sucesso.");
                        Aluno.Excluir(aluno);
                    }
                    else if (Char.ToUpper(confirma) == 'N')
                    {
                        break;
                    }
                    else
                    {
                        Console.Write("Digite 'S' ou 'N'");
                    }
                } while (Char.ToUpper(confirma) != 'S' && Char.ToUpper(confirma) == 'N');
            }
            else
            {
                Console.WriteLine("Matrícula não encontrada.");
            }                
            Console.WriteLine("");
            Console.Write("Pressione qualquer tecla para continuar");
            Console.ReadKey();
        }
    }
}
