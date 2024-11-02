﻿using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_DatabaseCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****** Menu Siparis Islem Paneli");
            Console.WriteLine();

            Console.WriteLine("------------------------");
            #region Kategori Ekleme Islemi
            //Console.Write("Eklemek Istediginiz Kategori Adi: ");
            //string categoryName= Console.ReadLine();

            //SqlConnection connection= new SqlConnection("Data Source=AKD\\SQLEXPRESS;initial Catalog=EgitimKampiDb;integrated security=true");

            //connection.Open();
            //SqlCommand command = new SqlCommand("insert into TblCategory (CategoryName) values (@p1)", connection);
            //command.Parameters.AddWithValue("@p1", categoryName);
            //command.ExecuteNonQuery();
            //connection.Close();

            #endregion

            #region Urun Ekleme Islemi
            // string productName;
            // decimal productPrice;
            //// bool productStatus;

            // Console.Write("Urun Adi: ");
            // productName =Console.ReadLine();
            // Console.Write("Urunun Fiyati: ");
            // productPrice=decimal.Parse(Console.ReadLine());

            // SqlConnection connection = new SqlConnection("Data Source=AKD\\SQLEXPRESS;initial Catalog=EgitimKampiDb;integrated security=true");
            // connection.Open();
            // SqlCommand command=new SqlCommand("insert into TblProduct (ProductName, ProductPrice, ProductStatus) values (@productName, @productPrice, @productStatus)", connection);
            // command.Parameters.AddWithValue("@productName", productName);
            // command.Parameters.AddWithValue("@productPrice", productPrice);
            // command.Parameters.AddWithValue("@productStatus", true);
            // command.ExecuteNonQuery();
            // connection.Close();
            // Console.WriteLine("Urun Eklemesi Basarili!");
            #endregion
            #region Urun Listeleme

            //SqlConnection connection = new SqlConnection("Data Source=AKD\\SQLEXPRESS;initial Catalog=EgitimKampiDb;integrated security=true");

            //connection.Open();
            //SqlCommand command = new SqlCommand("Select * From TblProduct", connection);
            //SqlDataAdapter adapter = new SqlDataAdapter(command);
            //DataTable dataTable = new DataTable();
            //adapter.Fill(dataTable);

            //foreach(DataRow row in dataTable.Rows)
            //{
            //    foreach(var item in row.ItemArray)
            //    {
            //        Console.Write(item.ToString()+" ");

            //    }
            //    Console.WriteLine() ;

            //}
            //connection.Close();



            #endregion

            #region Urun Silme Islemi

            //Console.Write("Silinecek Urun Id: ");
            //int productId=int.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source=AKD\\SQLEXPRESS;initial Catalog=EgitimKampiDb;integrated security=true");

            //connection.Open();

            //SqlCommand command = new SqlCommand("Delete From TblProduct Where ProductId=@productId",connection);

            //command.Parameters.AddWithValue("@productId", productId);
            //command.ExecuteNonQuery();

            //connection.Close();

            //Console.WriteLine("Silme islemi yapildi");

            #endregion
            #region Urun Guncelleme Islemi

            //Console.Write("Guncellenecek Urun Id: ");
            //int productId = int.Parse(Console.ReadLine());


            //Console.Write("Guncellenecek Urun Adi: ");
            //string productName =Console.ReadLine();


            //Console.Write("Guncellenecek Urun Fiyati: ");
            //decimal productPrice = decimal.Parse(Console.ReadLine());


            //SqlConnection connection = new SqlConnection("Data Source=AKD\\SQLEXPRESS;initial Catalog=EgitimKampiDb;integrated security=true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("Update TblProduct Set ProductName=@productName, ProductPrice=@productPrice where ProductId=@productId", connection);
            //command.Parameters.AddWithValue("@productName", productName);
            //command.Parameters.AddWithValue("@productPrice", productPrice);
            //command.Parameters.AddWithValue("@productId", productId);
            //command.ExecuteNonQuery();

            //connection.Close();

            #endregion



            Console.Read();
        }
    }
}
