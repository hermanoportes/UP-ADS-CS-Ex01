using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleView
{
    public class MenuDisciplinas
    {
        public static int MostrarMenuDisciplinas()
        {
            int opcao = 0;

            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("=======DISCIPLINAS=======");
            Console.WriteLine("1- Cadastrar");
            Console.WriteLine("2- Alterar");
            Console.WriteLine("3- Excluir");
            Console.WriteLine("4- Listar");
            Console.WriteLine("0- Voltar");

            Console.Write("Escolha uma opção: ");
            opcao = int.Parse(Console.ReadLine());

            return opcao;
        }
    }
}
