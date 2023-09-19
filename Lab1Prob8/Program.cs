using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1Prob8
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Ex 8
Scrieti un program care interschimba valoarea a doua variabile intregi.
            */
            int x = 2;
            int y = 6;

            switch (x)
            {

                case 1:
                    Console.WriteLine("Numer 1 was found");
                    break;
                case 2:
                    Console.WriteLine("Numer 2 was found");
                    break;
                case 3:
                    Console.WriteLine("Numer 3 was found");
                    break;
                case 4:
                    Console.WriteLine("Numer 4 was found");
                    break;
                case 5:
                    Console.WriteLine("Numer 5 was found");
                    break;
                case 6:
                    Console.WriteLine("Numer 6 was found");
                    break;
                case 7:
                    Console.WriteLine("Numer 7 was found");
                    break;
                default:
                    Console.WriteLine("Number nor found");
                    break;
            }
        }
    }
}
