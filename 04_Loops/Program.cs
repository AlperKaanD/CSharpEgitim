using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region For Dongusu

            //int i;

            //for(i = 1; i <= 30; i++) 
            //{
            //    Console.WriteLine(i);
            //}

            //for(int i = 3;  i <= 51; i+=3)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.WriteLine("Lutfen Ekrana Yazilmasi Istediginiz Degeri Giriniz: ");
            //int finishValue = int.Parse(Console.ReadLine());

            //for (int i = 1; i < finishValue; i++) 
            //{
            //    Console.WriteLine("Yasasin Cumhuriyet");

            //}



            #endregion

            #region For Dongusu ile karar yapilari
            //for(int i = 0; i <=100; i++) 
            //{
            //    if (i%5 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            //int totalValue= 0;

            //for(int i = 1;i<= 10;i++) 
            //{
            //    totalValue += i;
            //}
            //Console.WriteLine(totalValue);

            //int totalValue = 0;

            //for (int i = 0; i <=20; i++)
            //{
            //   if(i%2 == 0)
            //    {
            //        totalValue += i;
            //        Console.WriteLine(i);
            //    } 
            //}
            //Console.WriteLine("----------");
            //Console.WriteLine(totalValue);

            // 1-50 arasinda 7 ye tam bolunen kac tane sayi vardir.

            //int count = 0;

            //for(int i = 1; i <= 50; i++)
            //{

            //    if(i % 7 == 0)
            //    {
            //        count++;
            //    }

            //}
            //Console.WriteLine(count);

            //int bacterium = 1;

            //for(int i = 1; i <= 24; i++)
            //{
            //    bacterium *= 2;
            //    Console.WriteLine(i + ".Saat Sonunda: " + bacterium);
            //}
            #endregion

            #region While dongusu

            //int i = 1;
            //while (i <= 10)
            //{
            //    Console.WriteLine("Merhaba Donguler");
            //    i++;
            //}

            //int i = 1;

            //while (i <= 10)
            //{
            //    if(i %3 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    i++;
            //}

            //int i = 1;
            //int sum = 0;

            //while (i <= 10) 
            //{
            //    sum+= i;
            //    i++;
            //}
            //Console.WriteLine(sum);



            #endregion

            #region Ornek sinav sorusu

            //Klavyeden girilen 3 basamakli sayinin basamaklari toplamini hesaplayan kodu yaziniz

           // Console.WriteLine("Sayi Giriniz: ");
           // int number= int.Parse(Console.ReadLine());

           // int ones, tens, hundreds;
           // int sum;

           //ones = number % 10;
           //tens =( number % 100 )/ 10;
           //hundreds = number / 100;

           // Console.WriteLine(ones + "-" + tens +"-" + hundreds);

           // sum = ones+tens+hundreds;

           // Console.WriteLine(sum);

            #endregion

            Console.Read();
        }
    }
}
