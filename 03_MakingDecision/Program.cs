using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region if

            //Console.Write("Lutfen Sifreyi giriniz: ");
            //string password;
            //password= Console.ReadLine();
            //if (password == "ABCD")
            //{
            //    Console.WriteLine("Sifre Dogru");
            //}
            //else
            //{
            //    Console.WriteLine("Sifre Yanlis");
            //}

            //string capital, country;
            //Console.Write("Baskenti Giriniz: ");
            //capital = Console.ReadLine();

            //Console.Write("Ulke Giriniz: ");
            //country = Console.ReadLine();

            //if(capital=="ankara" & country == "turkiye")
            //{
            //    Console.Write("veriler dogrulandi");
            //}
            //else
            //{
            //    Console.Write("veriler yanlis");
            //}

            //int sayi;
            //Console.Write("Sayiyi Giriniz: ");
            //sayi =int.Parse(Console.ReadLine());
            //if(sayi == 5) 
            //{
            //    Console.WriteLine("Sayi Dogru");

            //}
            //else
            //{
            //    Console.WriteLine("Sayi Hatali");
            //}

            //int exam1, exam2, exam3, average;
            //string result= "Girilen Notlar 0-100 arasinda olmali";

            //Console.Write("Sinav1: ");
            //exam1 = int.Parse(Console.ReadLine());
            //Console.Write("Sinav2: ");
            //exam2 = int.Parse(Console.ReadLine());
            //Console.Write("Sinav3: ");
            //exam3 = int.Parse(Console.ReadLine());

            //average = (exam1+exam2+exam3)/3;
            //Console.WriteLine("Sinavin ortalamasi: " + average);

            //if(average >0 & average <=50)
            //{
            //    result= "sonuc vasat";
            //}
            //if(average >50 & average<=70)
            //{
            //    result = "sonuc orta";
            //}
            //if(average> 70 & average <= 84)
            //{
            //    result = "Sonuc iyi";
            //}
            //if (average > 85)
            //{
            //    result = "Sonuc Cok iyi";
            //}

            //Console.WriteLine(result);

            //string city;
            //Console.Write("Lutfen Sehir Girisi Yapiniz: ");
            //city= Console.ReadLine();

            //if(city=="adana"| city=="bursa" | city=="ankara" | city == "trabzon")
            //{

            //    Console.WriteLine("sehir mevcut");
            //}
            //else
            //{
            //    Console.WriteLine("sehir mevcut degil");
            //}

            //Console.WriteLine("Lutfen Kullanici Adi Giriniz");
            //string username = Console.ReadLine();
            //if (username != "admin") 
            //{
            //    Console.Write("bu kullanici kabul edilemez");

            //}
            //else
            //{
            //    Console.Write("hosgeldinz!");
            //}


            //Console.Read();

            #endregion

            #region Mod Islemleri

            //Console.Write("Lutfen 1. Sayiyi Giriniz: ");
            //int number1=int.Parse(Console.ReadLine());

            //Console.Write("Lutfen 2. Sayiyi Giriniz: ");
            //int number2 =int.Parse(Console.ReadLine());

            //int result = number1 % number2;
            //Console.Write("iki sayinin bolumunden kalan: "+ result);

            //Console.Write("Lutfen Sayiyi Giriniz: ");
            //int number=int.Parse(Console.ReadLine());
            //if (number %2 == 0 )
            //{
            //    Console.Write("Sayi Cift Sayidir");

            //}
            //else
            //{

            //    Console.Write("Sayi Tek Sayidir.");

            //}

            //char team;
            //Console.Write("lutfen takim sembolunuzu giriniz: ");
            //team=char.Parse(Console.ReadLine());

            //if(team == 'g' | team == 'G')
            //{
            //    Console.Write("Galatasaray");
            //}

            //if(team == 'f' | team=='F')
            //{
            //    Console.Write("Fenerbahce");
            //}
            //if(team=='b' | team == 'B')
            //{
            //    Console.Write("Besiktas");
            //}







            #endregion

            #region Ornek Uygulama

            //Console.WriteLine("****** C# Egitim Kampi Restoran ******");
            //Console.WriteLine();
            //Console.WriteLine("------------------------------");
            //Console.WriteLine("1-Ana Yemekler");
            //Console.WriteLine("2-Corbalar");
            //Console.WriteLine("3-Pizzalar");
            //Console.WriteLine("4-Icecekler");
            //Console.WriteLine("5-Tatlilar");
            //Console.WriteLine("------------------------------");

            //string menuItem;

            //Console.WriteLine("Detayini gormek istediginiz menuyu secin: ");

            //menuItem = Console.ReadLine();

            //if (menuItem =="1")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("---------Ana Yemekler---------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Kori Soslu Tavuk");
            //    Console.WriteLine("2-Kizartma Tabagi");
            //    Console.WriteLine("3-Fasulye Pilav");
            //    Console.WriteLine("4-Firinda Somon");
            //    Console.WriteLine("5-Patlican Musakka");
            //    Console.WriteLine("---------Ana Yemekler---------");

            //    Console.WriteLine();

            //}
            //if (menuItem == "2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("---------Corbalar---------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Mercimek");
            //    Console.WriteLine("2-Ezogelin");
            //    Console.WriteLine("3-Kelle-Paca");
            //    Console.WriteLine("4-Iskembe");
            //    Console.WriteLine("5-Tavuk Suyu");
            //    Console.WriteLine("---------Corbalar---------");

            //    Console.WriteLine();

            //}
            //if (menuItem == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("---------Pizzalar---------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Margarita");
            //    Console.WriteLine("2-Italyan Karisik");
            //    Console.WriteLine("3-Super Karisik");
            //    Console.WriteLine("4-Dort Peynirli");
            //    Console.WriteLine("---------Pizzalar---------");

            //    Console.WriteLine();

            //}
            //if (menuItem == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("---------Icecekler---------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Kola");
            //    Console.WriteLine("2-Ayran");
            //    Console.WriteLine("3-Salgam");
            //    Console.WriteLine("4-Soda");
            //    Console.WriteLine("5-Su");
            //    Console.WriteLine("---------Icecekler---------");

            //    Console.WriteLine();

            //}
            //if (menuItem == "5")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("---------Tatlilar---------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Kazandibi");
            //    Console.WriteLine("2-Trilece");
            //    Console.WriteLine("3-Berlinger");
            //    Console.WriteLine("4-Magnoilia");
            //    Console.WriteLine("5-Dondurma");
            //    Console.WriteLine("---------Tatlilar---------");

            //    Console.WriteLine();

            //}
            #endregion

            #region Switch Case

            //Console.Write("Lutfen Ay Girisi Yapiniz: ");
            //int monthNumber= int.Parse(Console.ReadLine());

            //switch (monthNumber)
            //{
            //    case 1: Console.Write("Ocak"); break;
            //    case 2: Console.Write("Subat"); break;
            //    case 3: Console.Write("Mart"); break;
            //    case 4: Console.Write("Nisan"); break;
            //    case 5: Console.Write("Mayis"); break;
            //    case 6: Console.Write("Haziran"); break;
            //    case 7: Console.Write("Temmuz"); break;
            //    case 8: Console.Write("Agustos"); break;
            //    case 9: Console.Write("Eylul"); break;
            //    case 10: Console.Write("Ekim"); break;
            //    case 11: Console.Write("Kasim"); break;
            //    case 12: Console.Write("Aralik"); break;
            //    default: Console.Write("Hatali Veri Girisi"); break;
            //}



            #endregion

            #region Switch Case Hesap Makinesi
            
            //int number1, number2, result;
            //char symbol;

            //Console.Write("1.Sayiyi Giriniz: ");
            //number1=int.Parse(Console.ReadLine());

            //Console.Write("2.Sayiyi Giriniz: ");
            //number2=int.Parse(Console.ReadLine());

            //Console.Write("Lutfen yapmak istediginiz islemi giriniz: ");
            //symbol=char.Parse(Console.ReadLine());

            //switch (symbol)
            //{
            //    case '+':
            //        result = number1+number2;
            //        Console.WriteLine("Toplam: " + result);
            //        break;
            //    case '-':
            //        result = number1-number2;
            //        Console.WriteLine("Fark: " + result);
            //        break;
            //    case '*':
            //        result = number1*number2;
            //        Console.WriteLine("Carpim: " + result);
            //        break; 
            //    case '/':
            //        result = number1/number2;
            //        Console.WriteLine("Bolum: " + result);
            //        break;


            //}


            #endregion


            Console.Read();

        }
    }
}
