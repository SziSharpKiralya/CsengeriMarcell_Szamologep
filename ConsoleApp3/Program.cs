using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {

        static float num0 = 0;
        static float num1 = 0;
        static string operation = "";

        static void Osszeadas()
        {
            Console.WriteLine($"{num0} + {num1} = {num0+num1}");
            Indit();
        }

        static void Kivonas()
        {
            Console.WriteLine($"{num0} - {num1} = {num0 - num1}");
            Indit();
        }

        static void Osztas()
        {
            Console.WriteLine($"{num0} / {num1} = {num0 / num1}");
            Indit();
        }

        static void Szorzas()
        {
            Console.WriteLine($"{num0} * {num1} = {num0 * num1}");
            Indit();
        }

        static void Szazalek()
        {
            Console.WriteLine($"{num0} % --> {num1} = {(num0 / num1)*100}");
            Indit();
        }

        static void Sugo()
        {
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Műveletek jelei:");
            Console.WriteLine("Összeadás: +");
            Console.WriteLine("Kivonas: -");
            Console.WriteLine("Osztas: / vagy :");
            Console.WriteLine("Szorzás: * vagy x");
            Console.WriteLine("Százalék: %");
            Indit();
        }

        static void Indit()
        {
            Console.WriteLine("---------------------------------");
            Console.Write("Kérem adja meg az első számot: ");
            num0 = float.Parse(Console.ReadLine());
            Console.Write("Kérem adja meg a második számot: ");
            num1 = float.Parse(Console.ReadLine());
            Console.Write("Az elvégzendő művelet jele: ");
            operation = Console.ReadLine();
            Console.WriteLine($"{num0}, {num1}, {operation}");

            switch (operation)
            {
                case "+": Osszeadas(); break;
                case "-": Kivonas(); break;
                case "/": Osztas(); break;
                case ":": Osztas(); break;
                case "*": Szorzas(); break;
                case "x": Szorzas(); break;
                case "%": Szazalek(); break;
                case "?": Sugo(); break;
            }
        }

        static void Main(string[] args)
        {
            Indit();
        }
    }
}
