using System;

namespace EditorHtml
{
    public static class Menu
    {
        public static void Mostrar()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Green;

            DesenhandoTela();
            EscreverMenu();

            var opcao = short.Parse(Console.ReadLine());
            OpcoesMenu(opcao);
        }

        public static void DesenhandoTela()
        {
            Console.Write("+");
            for (int i = 0; i <= 30; i++)
            {
                Console.Write("-");
            }
            Console.Write("+");
            Console.Write("\n");

            for (int linha = 0; linha <= 10; linha++)
            {
                Console.Write("|");
                for (int i = 0; i <= 30; i++)
                {
                    Console.Write(" ");
                }
                Console.Write("|");
                Console.Write("\n");
            }

            Console.Write("+");
            for (int i = 0; i <= 30; i++)
            {
                Console.Write("-");
            }
            Console.Write("+");
            Console.Write("\n");
        }

        public static void EscreverMenu()
        {
            Console.SetCursorPosition(3, 1);
            Console.Write("Editor de HTML");
            Console.SetCursorPosition(3, 2);
            Console.Write("================");
            Console.SetCursorPosition(3, 3);
            Console.Write("Selecione um opção abaixo");
            Console.SetCursorPosition(3, 5);
            Console.Write("1 - Novo Arquivo");
            Console.SetCursorPosition(3, 6);
            Console.Write("2 - Abrir");
            Console.SetCursorPosition(3, 7);
            Console.Write("0 - Sair");
            Console.SetCursorPosition(3, 8);
            Console.Write("Opção:");
            Console.SetCursorPosition(3, 9);
        }

        public static void OpcoesMenu(short opcao)
        {
            switch (opcao)
            {
                case 1: Editor.Mostrar();
                    break;

                case 2: Console.WriteLine("Visualizador");
                    break;

                case 0: Console.Clear();
                        Environment.Exit(0);
                    break;

                default: Mostrar();
                    break;
            }
        }
    }
}