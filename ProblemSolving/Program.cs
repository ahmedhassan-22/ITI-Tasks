using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LabDay2
{
    class Program
    {
        static void Main(string[] args)
        {
            //    string Name = Console.ReadLine();
            //    Console.WriteLine($"Hello, {Name}");

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

            //long X = 0, Y = 0;
            //string input = Console.ReadLine();
            //string[] inputs= input.Split(' ', 2, StringSplitOptions.None);
            //X = long.Parse((inputs[0]));
            //Y = long.Parse((inputs[1]));
            //Console.WriteLine($"{X} + {Y} = {X + Y}");
            //Console.WriteLine($"{X} * {Y} = {X * Y}");
            //Console.WriteLine($"{X} - {Y} = {X - Y}");

            //string car = Console.ReadLine();
            //string[] cars = car.Split(' ');
            //for (int i = 0; i < cars.Length; i++)
            //{
            //    Console.WriteLine(cars[i]);
            //}
            //int i = 0;
            //while (i < cars.Length)
            //{
            //    Console.WriteLine(cars[i]);
            //    i++;

            //}

            //int i = 0;
            //do
            //{
            //    Console.WriteLine(cars[i]);
            //    i++;
            //} while (i < cars.Length);

            //                        Given four numbers A, B, C and D. Print the result of the following equation:      X = (A * B) - (C * D).

            //double A = 0, B = 0, C = 0, D = 0;
            //string chars = Console.ReadLine();
            //string[] chaar = chars.Split(' ');
            //A = double.Parse((chaar[0]));
            //B = double.Parse((chaar[1]));
            //C = double.Parse((chaar[2]));
            //D = double.Parse((chaar[3]));
            //Console.WriteLine($"Difference = {A*B - C*D}");

            //                         Given a number R calculate the area of a circle using the following formula:

            //const double PI = 3.141592653;
            //double R = double.Parse(Console.ReadLine());
            //double area = PI * R * R;
            //Console.WriteLine($"{area:F9}");

            //                          Given two numbers N and M. Print the summation of their last digits.

            //    long X =0, Y = 0;
            //  string num= Console.ReadLine();
            //string[] Number = num.Split(' ');
            //X = long.Parse(Number[0]);
            //Y = long.Parse(Number[1]);
            //long lastdigit= X % 10;
            //long lastdigitt = Y % 10;
            //Console.WriteLine($"{lastdigit + lastdigitt}");

            //                        Given a number N Print the summation of the numbers that is between 1 and N(inclusive).
            //long N =0;
            //N = long.Parse(Console.ReadLine());
            //long sum = 0;
            //for (long i = 1; i <= N; i++)  
            //{
            //    sum += i;
            //}           
            //    Console.WriteLine($"{sum}");

            //decimal x = 0, y = 0;
            //string num = Console.ReadLine();
            //string[] nums = num.Split(' ');
            //x = long.Parse(nums[0]);
            //y = long.Parse(nums[1]);
            //Console.WriteLine($"floor {x} / {y} = {Math.Floor(x / y)}");
            //Console.WriteLine($"ceil {x} / {y} = {Math.Ceiling(x / y)}");
            //Console.WriteLine($"round {x} / {y} = {Math.Round(x / y , MidpointRounding.AwayFromZero)}");

            //long x = 0, y = 0;
            //string input = Console.ReadLine();
            //string[] inputs = input.Split(' ');
            //x = long.Parse(inputs[0]);
            //y = long.Parse(inputs[1]);
            //if(x>=y)
            //{
            //    Console.WriteLine("Yes");
            //}
            //else
            //{ Console.WriteLine("No"); }

            //int A = 0, B = 0;
            //string input = Console.ReadLine();
            //string[] inputs = input.Split(' ');
            //A = int.Parse(inputs[0]);
            //B = int.Parse(inputs[1]);
            // long X = A % B;
            // long Y = B % A;
            //if (X ==0 || Y==0)
            //{
            //    Console.WriteLine("Multiples");
            //}
            //else
            //{ Console.WriteLine("NO Multiples"); }

            //int X = 0, Y = 0;
            //string inp=Console.ReadLine();
            //string[] inpus = inp.Split(' ');
            //X = int.Parse(inpus[0]);
            //Y = int.Parse(inpus[1]);
            //int G = Math.Max(X,Y);
            //int H = Math.Min(Y,X);
            //int result = G % H;
            //if(result==0)
            //{
            //    Console.WriteLine("Multiples");
            //}
            //else 
            //{ Console.WriteLine("No Multiples"); }

            //int A = 0, B = 0, C = 0;
            //string input=Console.ReadLine();
            //string[] inputs = input.Split(' ');
            //A=int.Parse(inputs[0]);
            //B = int.Parse(inputs[1]);
            //C = int.Parse(inputs[2]);
            //Console.WriteLine(Math.Min(A, Math.Min(B, C))  +" "+ Math.Max(A, Math.Max(B, C)));


            //string Name = Console.ReadLine();
            //string name = Console.ReadLine();

            //string[] person1 = Name.Split(' ');
            //string[] person2 = name.Split(' ');
            //if (person1[1] == person2[1])
            //{
            //    Console.WriteLine("ARE Brothers");
            //}
            //else
            //{
            //    Console.WriteLine("NOT");
            //}


            //char X = char.Parse(Console.ReadLine());
            ////int ascii = (int)X;
            //int ascii = Convert.ToInt32(X);
            //if (ascii >= 65 && ascii <= 90)
            //{
            //    Console.WriteLine("ALPHA");
            //    Console.WriteLine("IS CAPITAL");
            //}
            //else if (ascii >= 48 && ascii <= 57)
            //{
            //    Console.WriteLine("IS DIGIT");
            //}
            //else
            //{
            //    Console.WriteLine("ALPHA");
            //    Console.WriteLine("IS SMALL");
            //}

            //char x =char.Parse(Console.ReadLine());
            //if (char.IsLower(x))
            //    Console.WriteLine((char)(x - 32));
            //else
            //    Console.WriteLine((char)(x + 32));

            #region O_ Calculator
            //string input = Console.ReadLine();
            //char[] ops = { '+', '-', '*', '/' };
            //char S;
            //foreach (char op in ops)
            //{
            //    if (input.Contains(op))
            //    {
            //        S = op;
            //        break;
            //    }
            //}

            //string[] parts = input.Split(ops);
            //int A = int.Parse(parts[0]);
            //int B = int.Parse(parts[1]);
            //  int lenA= parts[0].Length;
            //     S = input[lenA];
            //  if (S == '+')
            //      Console.WriteLine(A + B);
            //  else if (S == '-')
            //      Console.WriteLine(A - B);
            //  else if (S == '*')
            //      Console.WriteLine(A * B);
            //  else if (S == '/')
            //      Console.WriteLine(A / B);
            #endregion

            //long x = int.Parse(Console.ReadLine());
            //long firstDigit = x / 10000000;
            //if (firstDigit % 2== 0)
            //{
            //    Console.WriteLine("EVEN");
            //}
            //else
            //    Console.WriteLine("ODD");

            //string[] parts = Console.ReadLine().Split(' ');
            //double x = double.Parse(parts[0]);
            //double y = double.Parse(parts[1]);
            //if (x == 0 && y == 0)
            //    Console.WriteLine("Origem");
            //else if (x == 0)
            //    Console.WriteLine("Eixo Y");
            //else if (y == 0)
            //    Console.WriteLine("Eixo X");
            //else if (x > 0 && y > 0)
            //    Console.WriteLine("Q1");
            //else if (x < 0 && y > 0)
            //    Console.WriteLine("Q2");
            //else if (x < 0 && y < 0)
            //    Console.WriteLine("Q3");
            //else
            //    Console.WriteLine("Q4");

            //int n = int.Parse(Console.ReadLine());
            //int years = n / 365;
            //int x = n % 365;
            //int months = x / 30;
            //int days = x % 30;
            //Console.WriteLine(years + " years");
            //Console.WriteLine(months + " months");
            //Console.WriteLine(days + " days");

            //double X = double.Parse(Console.ReadLine());
            //if(X >= 0 && X <= 25)
            //{
            //    Console.WriteLine("Interval [0,25]");
            //}
            //else if(X > 25 && X <= 50)
            //{
            //    Console.WriteLine("Interval (25,50]");
            //}
            //else if(X > 50 && X <= 75)
            //{
            //    Console.WriteLine("Interval (50,75]");
            //}                                                                                                                                                                       
            //else if(X > 75 && X <= 100)
            //{
            //    Console.WriteLine("Interval (75,100]");
            //}
            //else
            //    Console.WriteLine("Out of Intervals");

            //string[] input = Console.ReadLine().Split(' ');
            //int a = int.Parse(input[0]);
            //int b = int.Parse(input[1]);
            //int c = int.Parse(input[2]);

            //int[] inputs = { a, b, c };
            //Array.Sort(inputs);

            //Console.WriteLine(inputs[0]);
            //Console.WriteLine(inputs[1]);
            //Console.WriteLine(inputs[2]);
            //Console.WriteLine();
            //Console.WriteLine(a);
            //Console.WriteLine(b);
            //Console.WriteLine(c);

            //string[] inputs = Console.ReadLine().Split(' ');
            //int A = int.Parse(inputs[0]);
            //string S =inputs[1];
            //int B = int.Parse(inputs[2]);
            //if ((S == "<" && A < B) || (S == ">" && A > B) || (S == "=" && A == B))
            //{
            //    Console.WriteLine("Right"); 
            //}
            //else 
            //{
            //    Console.WriteLine("Wrong");
            //}
            #region     W  Mathematical Expression
            //string[] parts = Console.ReadLine().Split(' ');
            //int A = int.Parse(parts[0]);
            //char S = parts[1][0];
            //int B = int.Parse(parts[2]);
            //int C = int.Parse(parts[4]);
            //int result;
            //if (S == '+')
            //{
            //    result = A + B;
            //}
            //else if (S == '-')
            //{
            //    result = A - B;
            //}
            //else
            //{
            //    result = A * B;
            //}
            //if (result == C)
            //{
            //    Console.WriteLine("Yes");
            //}
            //else
            //{
            //    Console.WriteLine(result);
            //}
            #endregion

            //string[] input = Console.ReadLine().Split(new char[] { ',',',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            //long l1 = long.Parse(input[0]);
            //long r1 = long.Parse(input[1]);
            //long l2 = long.Parse(input[2]);
            //long r2 = long.Parse(input[3]);

            //long l = Math.Max(l1, l2);
            //long r = Math.Min(r1, r2);

            //if (l <= r)
            //    Console.WriteLine(l + " " + r);
            //else
            //    Console.WriteLine(-1);

            //string[] input = Console.ReadLine().Split(' ');
            //long A = long.Parse(input[0]);
            //long B = long.Parse(input[1]);
            //long C = long.Parse(input[2]);
            //long D = long.Parse(input[3]);
            //long result = ((A % 100) % 100 * (B % 100) % 100 * (C % 100) % 100 * (D % 100) % 100);
            //long last2digit = result % 100;
            //Console.WriteLine(result.ToString("D2"));
            //long last2digit = result % 100;
            //Console.WriteLine(result);

            #region Y hard
            string[] input = Console.ReadLine().Split(' ');
            long A = long.Parse(input[0]);
            long B = long.Parse(input[1]);
            long C = long.Parse(input[2]);
            long D = long.Parse(input[3]);
            //long resAPowB = (long)Math.Pow(A,B);
            //long resCPowD = (long)Math.Pow(C,D);
            BigInteger resAPowB = BigInteger.Pow(A, (int)B);
            BigInteger resCPowD = BigInteger.Pow(C, (int)D);
            if (resAPowB  <= resCPowD )
            {
                Console.WriteLine("NO");
            }
            else
            {
                Console.WriteLine("YES");
            }
            #endregion

            #region A 1 to N
            //int X = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= X;i++)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion

            #region  B Even Numbers
            //long X = long.Parse(Console.ReadLine());
            //bool input = false;
            //for(long i =2; i <= X; i = i+2)
            //{
            //    Console.WriteLine(i);
            //    input = true;
            //}
            //if (!input)
            //    Console.WriteLine("-1");
            #endregion

            #region C.Even, Odd, Positive and Negative

            //int n = int.Parse(Console.ReadLine());
            //string[] input = Console.ReadLine().Split(' ');
            //int even = 0, odd = 0, positive = 0, negative = 0;
            //for (int i = 0; i < n; i++)
            //{
            //    int x = int.Parse(input[i]);
            //    if (x % 2 == 0)
            //        even++;
            //    else 
            //        odd++;

            //    if (x > 0)
            //        positive++;
            //    else if (x < 0) 
            //        negative++;
            //}
            //Console.WriteLine($"Even: {even}");
            //Console.WriteLine($"Odd: {odd}");
            //Console.WriteLine($"Positive: {positive}");
            //Console.WriteLine($"Negative: {negative}");
            #endregion

            #region F Passowrd
            //string line;
            //while ((line = Console.ReadLine()) != null)
            //{
            //    int x = int.Parse(line.Trim());
            //    if (x == 1999)
            //    {
            //        Console.WriteLine("Correct");
            //        return;
            //    }
            //    Console.WriteLine("Wrong");
            //}
            #endregion

            #region E MAX
            //int N = int.Parse(Console.ReadLine());
            //int[] input = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            //Console.WriteLine(input.Max());
            #endregion

            #region D 
            //int X = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= 12; i++)
            //{
            //    Console.WriteLine($"{X} * {i} = {X * i}");
            //}

            //int x = int.Parse(Console.ReadLine());
            //while (x-- > 0)
            //{
            //    int n = int.Parse(Console.ReadLine());
            //    long result = 1;
            //    for (int i = 2; i <= n; i++)
            //        result *= i;
            //    Console.WriteLine(result);
            //}
            #endregion

            //int[] arr1;
            //arr1 = [1, 2, 3, 4, 5, 6];
            //for (int i = 0; i < arr1.Length; i++)
            //{
            //    //Console.WriteLine(arr1[i]);
            //    if (arr1[i] == 5)
            //    {
            //        Console.WriteLine(arr1[i]);
            //        Console.WriteLine("YES");
            //    }
            //    else
            //        Console.WriteLine("NO");
            //}
            //string str = "Ahmed Hassan";
            //Console.WriteLine(str[4]);
            //for(int i=0; i< str.Length; i++)
            //{
            //    //Console.WriteLine(str[i]);
            //    if (str[i] == 'd')
            //        Console.WriteLine(str[i]);
            //}
        }
    }
}