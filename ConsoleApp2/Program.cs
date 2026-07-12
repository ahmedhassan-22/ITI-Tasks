using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;


namespace Day1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');

            int i = int.Parse(input[0]);
            long l = long.Parse(input[1]);
            char c = char.Parse(input[2]);
            float f = float.Parse(input[3]);
            double d = double.Parse(input[4]);

            Console.WriteLine(i);
            Console.WriteLine(l);
            Console.WriteLine(c);
            Console.WriteLine(f);
            Console.WriteLine(d);
        }
    }
}
