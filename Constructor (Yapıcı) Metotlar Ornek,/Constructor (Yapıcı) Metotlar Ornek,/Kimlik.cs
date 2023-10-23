using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor__Yapıcı__Metotlar_Ornek_
{
    internal class Kimlik
    {
        
            string ad;
            string soyad;
            string memleket;
            int yas;
            char cinsiyet;

            public string AD
            {
                get { return ad; }
                set { ad = value.ToUpper(); }
            }

            public string SOYAD
            {
                get { return soyad; }
                set { soyad = value.ToUpper(); }
            }

            public string MEMLEKET
            {
                get { return memleket; }
                set { memleket = value.ToUpper(); }
            }

            public int YAS
            {
                get { return yas; }
                set { yas = Math.Abs(value); }

            }

            public char CINSIYET
            {
                get { return cinsiyet; }
                set { cinsiyet = value; }
            }

            public Kimlik()
            {
               ad = "";
               soyad = "";
               memleket = "SAMSUN";
               yas = 18;
               cinsiyet = 'K';
            }

        
        

    }
}
