using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Get_ve_Set_Kullanıımı
{
    class Ogrenci
    {
        private string ad;
        private string soyad;
        private int yas;
        private string alan;

        public string ADI
        {
            get { return ad; }
            set { ad = value; }
        }

        public string SOYAD
        {
            get { return soyad; }
            set { soyad = value; }
        }

        public int YAS
        {
            get { return yas; }
            set
            {
                if (value < 18)
                {
                    yas = 18;
                }
                else
                {
                    yas = value;
                }
            }
        }

        public string ALAN
        {
            get { return alan; }
            set { alan = value; }
        }


    }
}
