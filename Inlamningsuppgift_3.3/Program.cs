using System;
using System.Net.NetworkInformation;

namespace Inlamning_3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur många timmar vill du hyra bilen. Svara i timmar. (Du kan bara hyra bilen mellan 1 och 11 timmar)");
            string timmar = (Console.ReadLine());

            switch (timmar)
            {
                case "1":
                    Console.WriteLine("Det kostar 80kr");
                    break;
                case "2":
                    Console.WriteLine("Det kostar 160kr");
                    break;
                case "3":
                    Console.WriteLine("Det kostar 240kr");
                    break;
                case "4":
                    Console.WriteLine("Det kostar 320kr");
                    break;
                case "5":
                    Console.WriteLine("Det kostar 400kr");
                    break;
                case "6":
                    Console.WriteLine("Det kostar 480kr");
                    break;
                case "7":
                    Console.WriteLine("Det kostar 560kr");
                    break;
                case "8":
                    Console.WriteLine("Det kostar 640kr");
                    break;
                case "9":
                    Console.WriteLine("Det kostar 720kr");
                    break;
                case "10":
                    Console.WriteLine("Det kostar 800kr");
                    break;
                case "11":
                    Console.WriteLine("Det kostar 880kr");
                    break;
            }
        }
    }
}