using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            for (int j = 1; j < 11; j++)
                i += j * j;
            Console.WriteLine(i);
            Console.ReadLine();
        }
    }
}
