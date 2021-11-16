using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vmyo
{
    class Ogrenci2
    {
        protected string ad;
        protected string soyad;
        protected string ogrno;
        public Ogrenci2(string ad,string soyad,string ogrno)
        {
            this.ad = ad;
            this.soyad = soyad;
            this.ogrno = ogrno;
        }
        public virtual void BilgiYaz()
        {
            Console.WriteLine("{0} {1} {2}", this.ogrno, this.ad, this.soyad);
        }


    }

    class OnLisans : Ogrenci2 
    {
        string bolum;

        public OnLisans(string ad,string soyad,string ogrno, string bolum)
            :base(ad,soyad,ogrno)
        {
            this.bolum = bolum;
        }

        public override void BilgiYaz()
        {
            Console.WriteLine("{0} {1} {2} {3}", this.ogrno, this.ad, this.soyad, this.bolum);
        }
        
        //public void BilgiYaz()
        //{
        //    base.BilgiYaz();
        //    Console.WriteLine(this.bolum);
        //}

    }
}
