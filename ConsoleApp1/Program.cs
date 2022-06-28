using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FirstApp
{
    class Program
    {
        static void PrintName(string _Name, string _Order)
        {
            if (_Order == "-")
            {
                for (int i = _Name.Length - 1; i >= 0; i--)
                {
                    Console.WriteLine(_Name[i]);
                }
            }
            else
            {
                for (int i = 0; i < _Name.Length; i++)
                {
                    Console.WriteLine(_Name[i]);
                }
            }
        }
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Введите имя");
                string _Name = Console.ReadLine();
                Console.WriteLine("Введите порядок вывода (\"-\" обратный)");
                string _Order = Console.ReadLine();
                PrintName(_Name, _Order);
            }
            else
            {
                if (args.Length == 1)
                {
                    Console.WriteLine("Введите порядок вывода (\"-\" обратный)");
                    string _Order = Console.ReadLine();
                    PrintName(args[0], _Order);
                }
            }





        }
    }
}
