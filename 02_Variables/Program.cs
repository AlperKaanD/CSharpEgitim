using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Double Degiskenler
            //double number;

            //number = 4.85;

            //Console.WriteLine(number);

            //double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;

            //applePrice = 14.85;
            //orangePrice = 20.95;
            //strawberryPrice = 45;
            //potatoPrice = 9.74;
            //tomatoPrice = 6.88;

            //Console.WriteLine("----Elma Birim Fiyati:"+applePrice+" TL");
            //Console.WriteLine("----Portakal Birim Fiyati:"+orangePrice + " TL");
            //Console.WriteLine("----Cilek Birim Fiyati:"+strawberryPrice + " TL");
            //Console.WriteLine("----Patates Birim Fiyati:"+potatoPrice + " TL");
            //Console.WriteLine("----Domates Birim Fiyati:"+tomatoPrice + "  TL");

            //Console.WriteLine();
            //Console.WriteLine();

            //double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram;

            //appleGram = 1.245;
            //orangeGram = 2.650;
            //strawberryGram = 0.750;
            //potatoGram = 4.859;
            //tomatoGram = 3.745;

            //double appleTotalPrice = appleGram * applePrice;
            //double orangeTotalPrice = orangeGram * orangePrice;
            //double strawberryTotalPrice = strawberryGram * strawberryPrice;
            //double potatoTotalPrice = potatoGram * potatoPrice;
            //double tomatoTotalPrice = tomatoGram * tomatoPrice;

            //Console.WriteLine("Alinan Urun: Elma - " + "Birim Fiyat: " + applePrice + "-Gramaj: " +
            //    appleGram + "-Toplam Tutar: " + appleTotalPrice);
            //Console.WriteLine("Alinan Urun: Portakal - " + "Birim Fiyat: " + orangePrice + "-Gramaj: " + 
            //    orangeGram + "-Toplam Tutar: " + orangeTotalPrice);
            //Console.WriteLine("Alinan Urun: Cilek - " + "Birim Fiyat: " + strawberryPrice + "-Gramaj: " +
            //    strawberryGram + "-Toplam Tutar: " + strawberryTotalPrice);
            //Console.WriteLine("Alinan Urun: Patates - " + "Birim Fiyat: " + potatoPrice + "-Gramaj: " +
            //    potatoGram + "-Toplam Tutar: " + potatoTotalPrice);
            //Console.WriteLine("Alinan Urun: Domates - " + "Birim Fiyat: " + tomatoPrice + "-Gramaj: " + 
            //    tomatoGram + "-Toplam Tutar: " + tomatoTotalPrice);

            //double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + tomatoTotalPrice + potatoTotalPrice;

            //Console.WriteLine();
            //Console.WriteLine();

            //Console.WriteLine("Alisveris Toplam Tutar: " + shoppingTotalPrice + " Tl");

            #endregion

            #region Char Degiskenler
            //char symbol = 'A';

            //Console.WriteLine(symbol);

            #endregion

            #region Klavyeden Veri Girisleri String Degiskenler

            //Console.WriteLine("***** CSharp Hava Yollari Yolcu Bilgisi*****");
            //Console.WriteLine();

            //string passengerName, passengerSurnema, passengerDistrict, passengerCity, passengerAge, passengerIdentityNumber;

            //Console.Write("Yolcu Adi: ");
            //passengerName= Console.ReadLine();

            //Console.Write("Yolcu Soyadi: ");
            //passengerSurnema= Console.ReadLine();

            //Console.Write("Ilce Bilgisi: ");
            //passengerDistrict= Console.ReadLine();

            //Console.Write("SEhir Bilgisi: ");
            //passengerCity= Console.ReadLine();

            //Console.Write("Yolcu Yasi: ");
            //passengerAge= Console.ReadLine();

            //Console.Write("Yolcu TC Kimlik No:  ");
            //passengerIdentityNumber= Console.ReadLine();

            //Console.WriteLine();

            //Console.WriteLine("---------------------");
            //Console.WriteLine("Yolcu: " + passengerName + " " + passengerSurnema + " " + passengerDistrict + "/" + passengerCity+
            //    " "+ passengerAge);



            #endregion

            #region Klavyeden Tam Sayi Girisleri ve Donusumler

            //ABC12D

            //int shoePrice, computerPrice, chairPrice, tvPrice;
            //shoePrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 12000;

            //int shoesCount, computerCount, chairCount, tvCount;

            //Console.Write("Lutfen Aldiginiz Ayakkabi Sayisini Giriniz: ");
            //shoesCount = int.Parse(Console.ReadLine());//parse donusturme metodu

            //Console.Write("Lutfen aldiginiz bilgisayar sayisini giriniz: ");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.Write("Lutfen aldiginiz sandalye sayisini giriniz: ");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.Write("Lutfen aldiginiz tv sayisini giriniz: ");
            //tvCount = int.Parse(Console.ReadLine());

            //int totalPrice= shoePrice* shoesCount+ computerPrice* computerCount+ chairPrice* chairCount+ tvPrice* tvCount;

            //Console.WriteLine();
            //Console.WriteLine("Toplam Odemeniz Gereken Tutar: "+ totalPrice);


            #endregion

            #region Klavyeden Ondalikli Sayi Islemleri
            //double exam1, exam2, exam3, result;

            //Console.Write("Lutfen 1.Sinav Notunu Giriniz: ");
            //exam1=double.Parse(Console.ReadLine());

            //Console.Write("Lutfen 2.Sinav Notunu Giriniz: ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("Lutfen 3.Sinavi Notunu Giriniz: ");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;

            //Console.WriteLine();
            //Console.WriteLine("Sinav ortamasi: "+result);

            #endregion

            #region Klavyeden Karakter Girisleri

            char gender;
            Console.Write("Lutfen Cinsiyet Seciniz: K/E ");
            gender=char.Parse(Console.ReadLine());
            Console.WriteLine("Sectiginiz Cinsiyet: " + gender);

            #endregion

            Console.Read();
        }
    }
}
