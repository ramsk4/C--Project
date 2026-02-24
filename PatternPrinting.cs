using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class PatternPrinting
    {

        public static void Print1TO5Triangle()
        {
            for (int i = 1; i <= 5; i++) //Controll rows 
            {
                for(int j = 1; j <= i; j++)  //controll columns
                {
                    Console.Write(j);
                }

                Console.WriteLine();
            }
        }


        //Print from last like reverce

        public static void PrintTriangleStartingfromSpace()
        {

            int rows = 5;
            for(int i=1; i<= rows; i++)
            {

                for(int k= rows-i; k>0; k--)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j <= i; j++)  //controll columns
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }
          
        }

    
        public static void Reversepyramid()
        {
                Console.WriteLine("To Print half Pyramid Reverse-left  ");

                Console.WriteLine("Enter the Number:");
                int n = Convert.ToInt32(Console.ReadLine());

                for (int i = n; i >= 1; i--)
                {
                    for (int k = 0; k < n - i; k++)
                    {
                        Console.Write(" ");
                    }
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine(" ");
                }
        }

        public static void Reversenumtriangle()
        {
            Console.WriteLine("Reverse triangle of number pattern Print:-");

            Console.WriteLine("Enter the Number: ");
            int row = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= row; i++)
            {
                for (int k = 1; k < i; k++)
                {
                    Console.Write(" ");
                }
                for (int j = i; j <= row; j++)
                {
                    Console.Write(" " + j);
                }
                Console.WriteLine(" ");
            }
        }

        public static void ReverseHalfPyramidRight()
        {
            Console.WriteLine("To print Reverse Pyramid Right Half:");
            Console.WriteLine("Enter the Number:");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                for (int j = n; j >= i; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine(" ");
            }
        }

        public static void PrintHollowStars()
        {
            int row = 10;
            
        }

        public static void HolloSquarPrint()
        {

            Console.WriteLine("To Print Hollow Square Pattern");

            Console.WriteLine("Enter the number of rows:");
            int rows = Convert.ToInt32(Console.ReadLine());
    
            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= rows; j++)
                {
                    if (i == 1 || j == rows || j == 1 || i == rows)
                    {
                        Console.Write("* ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                Console.WriteLine();
            }

        }

        public static void Squarprint()
        {
            Console.WriteLine("To Print Square Fill Pattern");

            Console.WriteLine("Enter number :");
            int row = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= row; i++)
            {
                for (int j = 1; j <= row; j++)
                {

                    Console.Write("*");
                }
                Console.WriteLine(" ");
            }
        }
    }
}
