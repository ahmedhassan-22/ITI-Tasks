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
    class Program
    {
        static void PrintArray(int[] number)
        {

            for (int i = 1 ; i <= number.Length ; i++)
            {
                Console.WriteLine(i);
            }
        }
        static void CalucateAverage(int[] number)
        {
            int sum = 0;
            foreach (int numbers in number)
                sum += numbers;
            double Avraege = sum / number.Length;
            Console.WriteLine($"Average = {Avraege}");
        }
        static void Main(string[] args)
        {
            int[] number = { 1, 2, 3, 4, 5 };
            PrintArray(number);
            number = new int[] { 10, 20, 30, 40, 50 };
            CalucateAverage(number);
        }
    }
}
