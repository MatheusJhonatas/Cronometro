using System;
using System.Threading;

namespace StopWatch
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Menu();

        }
        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("----------Quanto tempo você quer cronômetrar?----------");
            Console.WriteLine("S = Segundo");
            Console.WriteLine("M = Minuto");
            Console.WriteLine("0 PARA SAIR");
            Console.WriteLine("Se você digitar 10s por exemplo, ele vai contar 10 segundos");
            Console.WriteLine("E consequentemente, se digitar 10m, será contado minutos.");
            Console.WriteLine("DIGITE O TEMPO : ");
            Console.WriteLine("-----------------------------------------------------------");
            string data = Console.ReadLine().ToLower();
            char type = char.Parse(data.Substring(data.Length - 1, 1));
            int time = int.Parse(data.Substring(0, data.Length - 1));
            int multiplicador = 1;

            if (type == 'm')
                multiplicador = 60;

            if (time == 0)
                System.Environment.Exit(0);
            PreStart();
            Start(time * multiplicador);

        }

        static void PreStart()
        {
            Console.Clear();
            Console.WriteLine("Preparar ...");
            Thread.Sleep(1000);
            Console.WriteLine("Apontar...");
            Thread.Sleep(1000);
            Console.WriteLine("GO...");
            Thread.Sleep(1800);

        }
        static void Start(int time)
        {

            int currentTime = 0;

            while (currentTime != time)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);
            }
            Console.Clear();
            Console.WriteLine("Cronômetro Finalizado");
            Thread.Sleep(1000);
            Menu();
        }
    }
}