using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Temel dizi ornekleri

            //string[] colors = new string[4];
            //colors[0] = "Kirmizi";
            //colors[1] = "Sari";
            //colors[2] = "Beyaz";
            //colors[3] = "Mavi";

            //Console.WriteLine(colors[2]);

            //string[] cities = new string[5];
            //cities[0] = "Milano";
            //cities[1] = "Budapeste";
            //cities[2] = "Lyon";
            //cities[3] = "Kahire";
            //cities[4] = "Uskup";

            //Console.WriteLine(cities[3]);

            //int[] numbers = new int[10];
            //numbers[0] = 50;
            //numbers[1] = 47;
            //numbers[2] = 698;
            //numbers[3] = 25;
            //numbers[7] = 748;
            //Console.WriteLine(numbers[5]);//0

            //string[] cities = { "Prag", "Roma", "Atina", "Ankara","Bursa" };

            //Console.WriteLine(cities[4]);
            #endregion

            #region Dizideki Tum Elemanlari Listeleme

            //string[] colors = { "Sari", "kirmizi", "Beyaz", "Mavi", "Yesil", "Turuncu", "Pembe" };

            //for (int i = 0; i < colors.Length; i++) 
            //{
            //    Console.WriteLine(colors[i]);

            //}

            //int[] numbers = { 4, 65, 74, 77, 134, 690, 720, 1992, 2024 };

            //for(int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i]%3 == 0) 
            //    {
            //        Console.WriteLine(numbers[i]);

            //    }
            //}

            //char[] symbols = { 'a', 'b', 'c', '*', '/', '-' };//char sembolu kullanilirken tek tirnakla yazilir
            //for (int i = 0; i < symbols.Length; i++)
            //{

            //    Console.WriteLine(symbols[i]);
            //}

            //int[] myArray = { 47, 85, 95, 41, 23, 635, 789, 86, 100 };

            //int maxNumber = myArray[0];
            //for (int i = 0; i<myArray.Length; i++) 
            //{
            //    if (myArray[i] > maxNumber)
            //    {
            //        maxNumber = myArray[i];
            //    }
            //}
            //Console.WriteLine(maxNumber);

            //string[] persons = { "ali", "ahmet", "kaan" };
            //Console.WriteLine(persons.Length);

            //int[] numbers = { 45, 85, 52, 41, 86, 10, 22, 35 };
            //Array.Sort(numbers);//kucukten buyuge dogru siralar
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //int[] numbers = { 45, 85, 52, 41, 86, 10, 22, 35 };
            //Array.Reverse(numbers);//diziyi tersten siralar
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}



            #endregion

            #region Dizi Methotlari

            //string[] customers = { "ali", "veli", "buse", "aysegul", "merve" };
            //int index = Array.IndexOf(customers, "aysegul"); //aysegul kacinci dizinde
            //Console.WriteLine(index);

            //int[] numbers = { 45, 85, 96, 63, 74, 10, 25, 22, 36 };

            //Console.WriteLine("Dizini En Buyuk Elemani: " + numbers.Max()+ " Dizinin En kucuk Elemani: "+ numbers.Min());




            #endregion

            #region Kullanicidan Deger Alma

            //string[] cities = new string[5];

            //for(int i = 0; i < cities.Length; i++)
            //{
            //    Console.WriteLine($"Lutfen {i+1}. Sehri Giriniz: ");// $ parametresel ifade kullanmak icin kullaniriz.cift tirnak butunlugu bozulmaza
            //    cities[i] = Console.ReadLine();
            //}
            //Console.WriteLine();
            //Console.WriteLine("-----------------");

            //for(int i = 0;i < cities.Length;i++)
            //{
            //    Console.WriteLine(cities[i]);
            //}

            //int[] numbers = { 10, 20, 30, 40, 50 };

            //int sum = 0;    

            //for(int i = 0; i < numbers.Length; i++)
            //{
            //    sum += numbers[i];
            //}
            //Console.WriteLine(sum);

            //int[] numbers= { 21, 42, 33, 54, 55, 65, 748, 93, 220 };

            //Console.WriteLine("CS");
            
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i]%2 == 0) 
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}
            //Console.WriteLine("---------------");
            //Console.WriteLine("TS");
            //Console.WriteLine();

            //for(int i = 0;i < numbers.Length; i++)
            //{
            //    if (numbers[i]%2 == 1)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            #endregion



            Console.Read();

        }
    }
}
