using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace _05_LoopsWithStars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Alt Alta 10 Tane Yildiz Olusturma\

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine("*");
            //}

            #endregion

            #region yan yana 10 Tane Yildiz Olusturma\

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.Write("*");
            //}

            #endregion

            #region Alt Alta 10 Tane Yildiz Olusturma\ her satirtda 20 tane yildiz olsun

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine("**********");
            //}

            #endregion

            #region Dik ucgen

            //for (int i = 1; i <=5; i++)
            //{
            //    for(int j = 1; j <=i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region Dik ve Ters Dik ucgen

            //for (int i = 1; i <= 5; i++)
            //{
            //    for(int j = 1;j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            //for(int k = 4; k >= 1; k--)
            //{
            //    for (int l = 1; l <= k; l++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}


            #endregion

            #region Baklava Dilimi
            //ust kisim
            // int n=5;
            //for(int i = 1;i <= n;i++)
            //{
            //    for (int j = n - 1; j > 0; j--)
            //    {
            //        Console.Write(" ");
            //    }

            //    for(int k = 1; k <= 2 * i-1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            ////alt kisim
            //for(int i = n-1; i>=1; i--)
            //{
            //    for (int j = n - 1; j > 0; j--) 
            //    {
            //        Console.Write(" ");
            //    }
            //    for(int k = 1; k <= 2 * i - 1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();

            //}


            #endregion

            #region Piramit

            //int n= 5;
            //for(int i = 1;i<=n;i++)
            //{
            //    //bosluklar
            //    for(int j = n - i; j > 0; j--)
            //    {
            //        Console.Write(" ");
            //    }   

            //    //yildizlar
            //    for(int k = 1;k<= 2 * i - 1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();

            //}

            #endregion

            #region Ters Piramit

            //int n = 5;
            //for(int i = n; i >= 1; i--)
            //{
            //    //bosluklar
            //    for(int j = n-i; j > 0; j--)
            //    {
            //        Console.Write(" ");
            //    }

            //    //yildizlar

            //    for(int k =1; k<= 2 * i - 1; k++)
            //    {
            //        Console.Write("*"); 
            //    }
            //    Console.WriteLine();
            //}

            #endregion
            Console.Read();
        }
    }
}
