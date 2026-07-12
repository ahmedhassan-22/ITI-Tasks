using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Xml.Linq;

namespace LabDay2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region C - Simple Calculator
            //            long X = 0, Y = 0;
            //            string input = Console.ReadLine();
            //            // Console.WriteLine(input);
            //            string[] inputs = input.Split(' ', 2, StringSplitOptions.None);

            //            //   Console.WriteLine(inputs[0]);
            //            //   Console.WriteLine(inputs[1]);

            //            X = long.Parse((inputs[0]));
            //            Y = long.Parse((inputs[1]));
            //            Console.WriteLine($"{X} + {Y} = {X + Y}");
            //            Console.WriteLine($"{X} * {Y} = {X * Y}");
            //            Console.WriteLine($"{X} - {Y} = {X - Y}");

            #endregion

            #region Hello https://codeforces.com/group/MWSDmqGsZm/contest/219158/my

            //            string Name = Console.ReadLine();
            //            Console.WriteLine($"Hello,{Name} ");
            #endregion
            #region B. Basic Data Types
            //string[] input = Console.ReadLine().Split(' ');

            //int i = int.Parse(input[0]);
            //long l = long.Parse(input[1]);
            //char c = char.Parse(input[2]);
            //float f = float.Parse(input[3]);
            //double d = double.Parse(input[4]);

            //Console.WriteLine(i);
            //Console.WriteLine(l);
            //Console.WriteLine(c);
            //Console.WriteLine(f);
            //Console.WriteLine(d);
            #endregion


            //1. Print Multiples of num 4 from 0 to 100 [for loop] مضاعفات الرقم 4   
            //int num = 4;
            //for (int i = 0; i <= 100; i++)
            //{
            //    Console.WriteLine($"{i} * {num} = {i * num}");
            //}

            //2. Calculate multiplication of 10 numbers givin by user [for loop].
            //for (int i=0;i<=10;i++ )
            //{
            //    int x, y;
            //    Console.WriteLine("Enter First Num:");
            //    x = int.Parse(Console.ReadLine());
            //    Console.WriteLine("Enter Last Num:");
            //    y = int.Parse(Console.ReadLine());
            //    Console.WriteLine($"{x} * {y} = {x * y}");
            //}

            //3. Print ASCII code for all char from 0-255 [for loop] 
            //for (int i = 0; i <= 255; i++)
            //{
            //    //Console.WriteLine("ASCII " + i + " = " + (char)i);
            //    Console.WriteLine((char)i);
            //}

            //4. Get numbers from user until total reaches 100 [while]  3  50 37 20

            //int num = 0;
            //int sum = 0;
            //while (sum >= 100)
            //{
            //    Console.Write("Enter Num: ");
            //    num = int.Parse(Console.ReadLine());
            //     sum+= num;
            //if (sum >= 100)
            //{
            //    Console.WriteLine("Exite");
            //    break;
            //}       
            // }
            //5. Print ASCII code a char from user until user press x [do while] 
            //char a;
            //do
            //{
            //    Console.WriteLine("Enter char: ");
            //    a=char.Parse(Console.ReadLine());
            //    Console.WriteLine("ASCII " + a + " = " + (int)a);
            //}
            //while (a != 'x' && a != 'X');
            //6. Print simple menu again inside do while. 
            //int Num = 0;
            //string Name;
            //do
            //{
            //    Console.WriteLine("1-Add");
            //    Console.WriteLine("2-Edite");
            //    Console.WriteLine("3-Delete");
            //    Console.WriteLine("4-Exite");
            //    Console.WriteLine("Enter Num: ");
            //    Num = int.Parse(Console.ReadLine());
            //    switch (Num)
            //    {
            //        case 1:
            //            Console.WriteLine("Add Name: ");
            //            Name = Console.ReadLine();
            //            break;
            //        case 2:
            //            Console.WriteLine("Edite Name");
            //            Name = Console.ReadLine();
            //            break;
            //        case 3:
            //            Console.WriteLine("Delete Name");
            //            Name = Console.ReadLine();
            //            Console.WriteLine($"{Name} Deleted");
            //            break; 
            //    }
            //} while (Num != 4);
            //Console.WriteLine("Exite");

            //Arrays :
            //1- Write a program to get sum of 1 student grades and get average and Greatest num then print message if "Success" or "Fail" 
            //int n;
            //Console.Write("Enter number of subject: ");
            //n=int.Parse(Console.ReadLine());
            //int[] grades = new int[n];
            //int sum = 0;
            //int max;
            //for(int i = 0; i <  n; i++)
            //{
            //    Console.Write("Enter grade"+(i+1)+":");
            //    grades[i]=int.Parse(Console.ReadLine());
            //    sum += grades[i];
            //}
            //max = grades[0];
            //for (int i = 1; i < n; i++)
            //{
            //    if (grades[i] > max)
            //        max = grades[i];
            //}
            //int average = sum / n;
            //Console.WriteLine("\nsum = " + sum);
            //Console.WriteLine("average = " + average);
            //Console.WriteLine("Greatest grade = " + max);
            //if (average >= 50)
            //    Console.WriteLine("Result: Success");
            //else
            //    Console.WriteLine("Result: Fail");
            //2- For 1D array , Try Resize and Delete by Shifting 

            int[] _1Darr = new int[3];
            Console.WriteLine("Enter 3 Numbers To Store in Array !");
            for (int i = 0; i < _1Darr.Length; i++)
            {
                Console.Write($"Enter Number {i + 1}: ");
                _1Darr[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Enter Number Wanna Delete: ");
            int del = int.Parse(Console.ReadLine());
            bool found = false; 
            for (int i = 0; i < _1Darr.Length - 1; i++)
            {
                if (_1Darr[i] == del || found)
                {
                    found = true;
                    _1Darr[i] = _1Darr[i + 1];
                }
            }
            if (!found) Console.WriteLine($"{del} Not Found In Array!");
            else
            {
                Console.Write($"Numbers in Array After Delete{del}: ");
                for (int i = 0; i < _1Darr.Length - 1; i++)
                    Console.Write($"{_1Darr[i]} ");
                Console.WriteLine("\n");
            }
        }
    }
}

