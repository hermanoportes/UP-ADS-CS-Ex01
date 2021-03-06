﻿using Model;
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
        public enum MenuPrincipal
        {
            Sair,
            Alunos,
            Professores,
            Disciplinas
        }
        public enum MenuUsuarios
        {
            Voltar,
            Cadastrar,
            Alterar,
            Exluir,
            Listar
        }

        static void Main(string[] args)
        {
            var opcao = 0;
            do
            {
                opcao = MostrarMenuPrincipal();

                Console.WriteLine();
                Console.Write("Pressione qualquer tecla para continuar");
                Console.ReadKey();
            } while (opcao != 0);
        }

        public static int MostrarMenuPrincipal()
        {
            Console.Clear();

            Console.WriteLine("\n=======MENU============== \n 1- Alunos \n 2- Professores \n 3- Disciplinas \n 0- Sair");
            var opcao = (MenuPrincipal)EscolherOpcao();

            switch (opcao)
            {
                case MenuPrincipal.Sair:
                    break;
                case MenuPrincipal.Alunos:
                    ConsoleView.MenuAlunos.MostrarMenuAlunos();
                    break;
                case MenuPrincipal.Professores:
                    ConsoleView.MenuProfessores.MostrarMenuProfessores();
                    break;
                case MenuPrincipal.Disciplinas:
                    ConsoleView.MenuDisciplinas.MostrarMenuDisciplinas();
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
            return (int)opcao;
        }

        static int EscolherOpcao()
        {
            Console.Write("Escolha uma opção: ");
            return int.Parse(Console.ReadLine());
        }
    }
}
