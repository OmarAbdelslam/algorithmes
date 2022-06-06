using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {

        //private static int m;

        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Value The First Array \t");
            int a, b;
            int[,] FirstArray = new int[3, 3];
            for (int r = 0; r < FirstArray.Length; r++)
            {
                a = int.Parse(Console.ReadLine());
                FirstArray[0, 0] = a;
                FirstArray[0, 1] = a;
                FirstArray[0, 2] = a;

            }

            foreach (int n in FirstArray)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("Enter The Value The Second Array /t");

            int[,] SecondArray = new int[3, 3];
            for (int e = 0; e < FirstArray.Length; e++)
            {
                b = int.Parse(Console.ReadLine());
                SecondArray[0, 0] = b;
            }

            int[,] ArtimaticArray = new int[3, 3];
            for (int q = 0; q < FirstArray.Length; q++)
            {
                b = int.Parse(Console.ReadLine());
                SecondArray[0, 0] = b;
            }




            //int sum = FirstArray * SecondArray;
            //int m;

            //int[] A = new int[m];










        }
    }
}
//Console.WriteLine("Enter The Value The First Array \t");
//            int a, b;
//int[,] FirstArray = new int[3, 3];
//a = int.Parse(Console.ReadLine());
//            FirstArray[0, 0] = a;
//            a = int.Parse(Console.ReadLine());
//            FirstArray[0, 1] = a;
//            a = int.Parse(Console.ReadLine());
//            FirstArray[0, 2] = a;
//            a = int.Parse(Console.ReadLine());
//            FirstArray[1, 0] = a;
//            a = int.Parse(Console.ReadLine());
//            FirstArray[1, 1] = a;
//            a = int.Parse(Console.ReadLine());
//            FirstArray[1, 2] = a;
//            a = int.Parse(Console.ReadLine());
//            FirstArray[2, 0] = a;
//            a = int.Parse(Console.ReadLine());
//            FirstArray[2, 1] = a;
//            a = int.Parse(Console.ReadLine());
//            FirstArray[2, 2] = a;

//           foreach (int n in FirstArray)
//            {
//                Console.WriteLine(n);
//            }

//            Console.WriteLine("Enter The Value The Second Array \t");
            
//            int[,] SecondArray = new int[3, 3];
//b = int.Parse(Console.ReadLine());
//            SecondArray[0, 0] = b;
//            b = int.Parse(Console.ReadLine());
//            SecondArray[0, 1] = b;
//            b = int.Parse(Console.ReadLine());
//            SecondArray[0, 2] = b;
//            b = int.Parse(Console.ReadLine());
//            SecondArray[1, 0] = b;
//            b = int.Parse(Console.ReadLine());
//            SecondArray[1, 1] = b;
//            b = int.Parse(Console.ReadLine());
//            SecondArray[1, 2] = b;
//            b = int.Parse(Console.ReadLine());
//            SecondArray[2, 0] = b;
//            b = int.Parse(Console.ReadLine());
//            SecondArray[2, 1] = b;
//            b = int.Parse(Console.ReadLine());
//            SecondArray[2, 2] = b;
