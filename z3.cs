using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace номер_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double j = 0.1;
            while (j < 1)
            {
                Console.WriteLine("X = " + j + " F = " + j + 5);
                j += 0.2;
                Console.ReadLine();
            }
        }
    }
}1