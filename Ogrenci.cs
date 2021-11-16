using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vmyo
{
    public class Ogrenci
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string OgrNo { get; set; }
       
        public Ogrenci(string ad, string soyad, string ogno)
        {
            Ad = ad;
            Soyad = soyad;
            OgrNo = ogno;
        }

        public  void BilgiYaz()
        {
            Console.WriteLine("{0} {1} {2}", this.OgrNo, this.Ad, this.Soyad);
        }

    }
}
