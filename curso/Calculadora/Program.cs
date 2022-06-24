using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Bem vindo a nossa calculdora");
            Console.WriteLine("Escolha uma das opções abaixo:");
            Console.WriteLine("1 - SOMA");
            Console.WriteLine("2 - SUBTRAÇÃO");
            Console.WriteLine("3 - MULTIPLICAÇÃO");
            Console.WriteLine("4 - DIVISÃO");
            Console.WriteLine("5 - SAIR");
            short opcao;
            opcao = short.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Soma();
                    break;

                case 2:
                    Subtracao();
                    break;

                case 3:
                    Multiplicacao();
                    break;

                case 4:
                    Divisao();
                    break;

                case 5:
                    Finalizador();
                    break;

                default:
                    Console.WriteLine("Você digitou uma opção inválida");
                    Menu();
                    break;
            }
        }
        static void Soma()
        {
            Console.Clear();
            Console.WriteLine("SOMA");
            Console.WriteLine("Digite o primeiro número");
            float numero1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número");
            float numero2 = float.Parse(Console.ReadLine());

            Console.WriteLine($"O resultado da soma dos dois números digitados é :{numero1 + numero2}");
            Console.ReadKey();
            Menu();
        }

        static void Subtracao()
        {
            Console.Clear();
            Console.WriteLine("SUBTRAÇÃO");
            Console.WriteLine("Digite o primeiro número");
            float numero1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número");
            float numero2 = float.Parse(Console.ReadLine());

            Console.WriteLine($"O resultado da subtração do primeiro pelo segundo número é :{numero1 - numero2}");
            Console.ReadKey();
            Menu();
        }

        static void Multiplicacao()
        {
            Console.Clear();
            Console.WriteLine("MULTIPLICAÇÃO");
            Console.WriteLine("Digite o primeiro número");
            float numero1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número");
            float numero2 = float.Parse(Console.ReadLine());

            Console.WriteLine($"O resultado da multiplicação dos dois números digitados é :{numero1 * numero2}");
            Console.ReadKey();
            Menu();
        }

        static void Divisao()

        {
            Console.Clear();
            Console.WriteLine("DIVISÃO");
            Console.WriteLine("Digite o primeiro número");
            float numero1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número");
            float numero2 = float.Parse(Console.ReadLine());

            Console.WriteLine($"O resultado da divisão do primeiro pelo segundo número é :{numero1 / numero2}");
            Console.ReadKey();
            Menu();
        }

        static void Finalizador()
        {
            Console.WriteLine("Obrigado por usar nosso sistema!");
            Console.WriteLine("Saindo...");
            System.Environment.Exit(0);
        }
    }
}