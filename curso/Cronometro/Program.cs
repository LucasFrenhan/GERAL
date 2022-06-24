using System;
using System.Threading;

namespace Cronometro
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
            Console.WriteLine("S = segundo");
            Console.WriteLine("M = minuto");
            Console.WriteLine("0 = sair");
            Console.WriteLine("Quanto tempo deseja contar?");

            string dado = Console.ReadLine().ToLower();
            char tipo = char.Parse(dado.Substring(dado.Length - 1, 1));
            int tempo = int.Parse(dado.Substring(0, dado.Length - 1));
            int multiplicador = 1;

            if (tipo == 'm')
                multiplicador = 60;

            if (tempo == 0)
                System.Environment.Exit(0);


            PreInicio(tempo * multiplicador);

        }

        static void PreInicio(int tempo)
        {
            Console.Clear();
            Console.WriteLine("Preparar...");
            Thread.Sleep(800);
            Console.Clear();
            Console.WriteLine("Apontar...");
            Thread.Sleep(800);
            Console.Clear();
            Console.WriteLine("Valendo!");
            Thread.Sleep(800);

            Inicio(tempo);
        }
        static void Inicio(int tempo)
        {
            int tempoAtual = 0;

            while (tempoAtual != tempo)
            {
                Console.Clear();
                tempoAtual++;
                Console.WriteLine(tempoAtual + "s");
                Thread.Sleep(1000);
            }
            Console.Clear();
            Console.WriteLine("Cronometro finalizado");
            Thread.Sleep(1000);
            Menu();
        }
    }
}