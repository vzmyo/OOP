using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vmyo
{
    class Car
    {
        public string color;

        public Car() // Constructor Yapıcı Kurucu method 
        {
            color = "red";
        }

        public void Hello()
        {
            Console.WriteLine("Hello");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {


            OnLisans onlisans = new OnLisans("Zeynep", "Tekin", "343333", "Bilgisyar");
           // Ogrenci2 o2 = new Ogrenci2("Zeynep", "Tekin", "343333");
           // Ogrenci o1 = new Ogrenci("Ahmet", "Tekin", "12121211");
            onlisans.BilgiYaz();
           // ArrayMetod();
            Console.ReadKey();

        }

        private static void ArrayMetod()
        {
            int a = 10;
            int b = a;
            a = 20;

            string[] sehirler = new string[] { "Samsun", "Amasya", "Tokat" };
            string[] yeniSehirler;

            yeniSehirler = sehirler;
            sehirler[0] = "Ankara";
            Console.WriteLine(yeniSehirler[0]);

            Console.Write(b);
        }
    }
}
