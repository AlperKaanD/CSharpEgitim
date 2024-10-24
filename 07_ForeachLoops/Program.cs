using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach Dongusu

            //    string[] cities = { "milano", "roma", "budapeste", "ankara", "istanbul", "varsova" };

            //   foreach (string x in cities)
            //    {
            //       Console.WriteLine(x);
            //   }

            //int[] numbers = { 45, 78, 985, 635, 74, 11, 22, 33, 41, 205, 6578, 10394 };

            //foreach (int number in numbers)
            //{
            //    if (number%2 == 0)
            //    {
            //        Console.WriteLine(number);
            //    }
            //}
            //int[] numbers = { 45, 78, 985, 635, 74, 11, 22, 33, 41, 205, 6578, 10394 };

            //int total = 0;
            //foreach (int i in numbers)
            //{
            //    total += i;

            //}
            //Console.WriteLine(total);

            // List<int> numbers = new List<int>()
            // {
            //     1, 2, 3, 4, 5, 6, 7, 8
            // };
            //foreach (int i in numbers)
            // {
            //     Console.WriteLine(i);
            // }

            //string word = "Merhaba";

            //foreach (char s in word)
            //{
            //    Console.WriteLine(s);
            //}


            #endregion

            #region Ornek Sinav Sistemi Uygulamasi
            Console.WriteLine("******* C# Egitim Kampi Ogrenci Uygulamasi ******");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            //siniftaki ogrenci sayisini alma
            Console.WriteLine("===============================");
            Console.Write("Sinifinizda kac tane ogrenci var: ");
            int studentCount=int.Parse (Console.ReadLine());
            Console.WriteLine("===============================");
            //oogrenci isimlerini not ortalamalarini saklayacak diziler
            string[] studentNames = new string[studentCount];
            double[] studentExamAvg = new double[studentCount];

            for (int i = 0; i < studentCount; i++)
            {
                Console.Write($"{i + 1}. ogrencinin ismini giriniz: ");
                studentNames[i] = Console.ReadLine();

                double totalExamResult = 0;

                //her ogrenci icin 3 sinav notu girisi

                for(int j = 0; j < 3; j++) 
                {
                    Console.Write($"{studentNames[i]} isimli ogrencinin {j + 1}. sinav notunu giriniz: ");
                    double value= double.Parse( Console.ReadLine() );
                    totalExamResult += value;//notlari topluyoruz
                }
                Console.WriteLine();
                studentExamAvg[i] = totalExamResult / 3;
            }

            //sinav ortalamalri
            for(int i = 0;i < studentCount;i++)
            {
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine($"{studentNames[i]} adli ogrencinin ortlamasi: {studentExamAvg[i]}");

                if (studentExamAvg[i] >= 50)
                {
                    Console.WriteLine($"{studentNames[i]} adli ogrenci dersi gecti");

                }
               else
                {
                    Console.WriteLine($"{studentNames[i]} adli ogrenci dersten kaldi");

                }

            }
            Console.WriteLine("--------------------------------------------------");

            

            #endregion

            Console.Read();
        }
    }
}
