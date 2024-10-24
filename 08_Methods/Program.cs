using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region void Metotlar 

            //void CustomerList()
            //{
            //    Console.WriteLine("Ali Yildiz");
            //    Console.WriteLine("Ayse Yildiz");
            //    Console.WriteLine("Hakan Ozturk");
            //    Console.WriteLine("Merve Cinar");

            //}

            //CustomerList();

            //void Sum()
            //{
            //    int x = 1; 
            //    int y =2;
            //    int z =x+y;

            //    Console.WriteLine(z);

            //}
            //Sum();

            #endregion

            #region Geriye Deger Dondurmeyen String Parametreli Methodlar

            //void WriteMethod(string name)
            //{
            //    Console.WriteLine(name);
            //}
            //WriteMethod("Mehmet Yildirim");

            //void CustomerCard(string name, string surname)
            //{
            //    Console.WriteLine("Musteri: " + name + " "+ surname);

            //}

            //CustomerCard("Mehmet", "Yildiz");
            //CustomerCard("Aysegul", "Yildiz");




            #endregion

            #region Geriye Deger Dondurmeyen Int Parametreli Metotlar

            //void Sum(int number1, int number2, int number3) 
            //{
            //    int result= number1+number2+number3;
            //    Console.WriteLine(result);
            //}

            //Sum(4, 5, 6);


            #endregion

            #region Geriye deger donduren metotlar

            //string CustomerName()
            //{
            //    return "Buse Yildiz";
            //}

            //CustomerName();\

            //string StudentCard()
            //{
            //    string name = "Ali";
            //    string surname = "Yildiz";

            //    return name + " " + surname;


            //}
            //Console.WriteLine(StudentCard());

            #endregion

            #region Geriye Deger Donduren String Parametreli Mdetotlar

            //string CountryCard(string countryName, string capital, string flagColor)
            //{
            //    string cardInfo= "Ulke: " + countryName+"-Baskent: " + capital+ "-Bayrak Rengi: "+ flagColor;

            //    return cardInfo;
            //}
            //string x, y, z;
            //Console.Write("Ulke Adini Giriniz: ");
            //x=Console.ReadLine();

            //Console.Write("Baskenti Giriniz: ");
            //y = Console.ReadLine();

            //Console.Write("Bayrak Rengini Giriniz: ");
            //z = Console.ReadLine();

            //Console.WriteLine(CountryCard(x, y, z));

            //Console.WriteLine(CountryCard("Turkiye", "Ankara", "Kirmizi-Beyaz"));

            #endregion

            #region Geriye Deger Donduren Int Parametreli Metotlar

            // int Sum(int number1, int number2, int number3) 
            // {
            //    int result= number1+number2+number3;
            //    return result;
            // }

            //Console.WriteLine(Sum(12,24,35));
            // Console.WriteLine(Sum(16,29,14));
            // Console.WriteLine(Sum(21,62,85));
            // Console.WriteLine(Sum(41,25,76));



            #endregion

            #region Ornek Uygulama

            //string ExamResult(string student, int exam1, int exam2, int exam3)
            //{
            //    int result = (exam1+exam2+exam3)/3;

            //    if (result >= 50)
            //    {
            //        return(student + " adli ogrneci " + result + " ortalama puanla basarili ");
            //    }
            //    else
            //    {
            //        return(student + " adli ogrneci " + result + "ortalama puanla basarisiz ");
            //    }

                

            //}
            //Console.WriteLine(ExamResult("Ali", 25, 66, 54));
            //Console.WriteLine(ExamResult("Ayse", 25, 66, 54));

            #endregion

            Console.Read();
        }
    }
}
