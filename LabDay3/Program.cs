using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;


namespace Day1
{
    class program
    {
        static void FillArray(int[,] arr, int row, int col)
              {
                    //int NumOfRow = arr.GetLength(0), NumOfCol = arr.GetLength(1),r , c;
                    for (int r = 0; r < row; r++)
                    {
                        //Console.WriteLine($"Student ID: {r+ 1}");
                        for (int c = 0; c < col; c++)
                        {

                            Console.Write($"Enter Value for [{r},{c}] : ");
                            arr[r, c] = int.Parse(Console.ReadLine());
                        }
                    }
                }
                static void PrintArray(int[,] arr, int row, int col)
                {
                    Console.WriteLine("\nMatrix:");
                    for (int r = 0; r < row; r++)
                    {
                        //Console.WriteLine($"Student ID {r + 1}");
                        for (int c = 0; c < col; c++)
                            Console.Write($"Course  {arr[r, c]} \t");

                    }
                    Console.WriteLine();
             }                    
        public void SumDegree(int[,] arr)
        {
            int i, j, rows = arr.GetLength(0), cols = arr.GetLength(1), sum;
            int[] SumDegree = new int[rows];
            for (i = 0; i < rows; i++)
            {
                sum = 0;
                for (j = 0; j < cols; j++)
                    sum += arr[i, j];
                SumDegree[i] = sum;
            }
            for (i = 0; i < SumDegree.Length; i++)
                Console.WriteLine($"Student {i + 1} Total Degree= {SumDegree[i]}");
        }
        public void Add(int[,] arr, int cnt)
        {

            int NumOfRow = arr.GetLength(0), NumOfCol = arr.GetLength(1), j;
            Console.WriteLine($"Student ID: {cnt + 1}");
            for (j = 0; j < NumOfCol; j++)
            {
                Console.Write($"ADD Degree Course {j + 1} : ");
                arr[cnt, j] = Convert.ToInt32(Console.ReadLine());
            }
        }
        public void Edit(int[,] arr, int StudentId)
        {
            int NumOfRow = arr.GetLength(0), NumOfCol = arr.GetLength(1), j;
            for (j = 0; j < NumOfCol; j++)
            {
                Console.Write($"Enter New Degree Course {j + 1} : ");
                arr[StudentId, j] = Convert.ToInt32(Console.ReadLine());
            }
        }
        public void Delete(int[,] arr, int StudentId)
        {
            int NumOfRow = arr.GetLength(0), NumOfCol = arr.GetLength(1), i, j;
            bool found = false;
            for (i = 0; i < NumOfRow - 1; i++)
                if (i == (StudentId - 1) || found)
                    for (j = 0; j < NumOfCol; j++)
                    {
                        found = true;
                        arr[i, j] = arr[i + 1, j];
                    }
        }
        public void Display(int[,] arr, int cnt)
        {
            int i, j, rows = arr.GetLength(0), cols = arr.GetLength(1);

            for (i = 0; i < cnt; i++)
            {
                Console.WriteLine($"Student ID {i + 1}");
                for (j = 0; j < cols; j++)
                    Console.Write($"Course {j + 1} = {arr[i, j]} \t");
                Console.WriteLine("\n");
            }
        }
        static void Main()
        {
                        int[,] arr = new int[3, 3];
                        FillArray(arr, 3, 3);
                        PrintArray(arr, 3, 3);
           
        }
    }
}

