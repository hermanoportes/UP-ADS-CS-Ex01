using Model;
using Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleView
{
    public class MenuAlunos
    {   
        public enum MenuUsuarios
        {
            Voltar,
            Cadastrar,
            Alterar,
            Exluir,
            Listar
        }
        public static void MostrarMenuAlunos()
        {
            AlunoController alunoController = new AlunoController();
            Console.Clear();

            do
            {
                Console.WriteLine("\n=======ALUNOS============== \n 1- Cadastrar \n 2- Alterar \n 3- Excluir \n 4- Listar Alunos \n 0- Sair");
                var opcao = (MenuUsuarios)EscolherOpcao();

                switch (opcao)
                {
                    case MenuUsuarios.Cadastrar:
                        alunoController.Cadastrar();
                        break;
                    case MenuUsuarios.Alterar:                  
                        alunoController.Alterar();                       
                        break;
                    case MenuUsuarios.Exluir:
                        alunoController.Excluir();
                        break;
                    case MenuUsuarios.Listar:
                    {
                        alunoController.Listar();
                        Console.Write("Pressione qualquer tecla para continuar");
                        Console.ReadKey();
                    }
                        break;
                }
            } while ((int)opcao != 0);
        }
    }
}
