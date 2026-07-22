using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;


namespace Day1
{
    class Hamada
    {
      static  void AddNumber2()
        {


            string input = Console.ReadLine();
            string[] inputs = input.Split();
            int x = int.Parse((inputs[0]));
            int y = int.Parse((inputs[1]));
            int sum = x + y;
            Console.WriteLine(sum);
        }

         void Test()
        {
            AddNumber2();
        }

    }
    class Program
    {
        static void Sum()
        {
            string input = Console.ReadLine();
            string[] inputs = input.Split(' ');
                   int x = int.Parse((inputs[0]));
                   int y = int.Parse((inputs[1]));
            int sum = x + y;
            Console.WriteLine(sum);
        }
        static void printNumberByForLoop()
        {
            int n = int.Parse(Console.ReadLine());
           for(int i=1; i<= n; i++) 
            {
                if (i > 1)
                {
                    Console.Write(" ");
                }
                Console.Write(i);
               
            }

        }
        static void Main(string[] args)
        {

            Sum();
            printNumberByForLoop();
                
        }
    }
}
