using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sınıf_Oluşturma_ve_Nesne_Kavramı
{
    internal class Araba : ArabaDetay
    {
        public string renk;
        public int hiz;
        public double motor;
        public string durum;
        public int fiyat;
        private int yil;
        private string Marka;

        public int YIL
        {
            get { return yil; }
            set { yil = Math.Abs(value); }
        }

        public string MARKA
        {
            get { return Marka; }
            set { Marka = value.ToUpper(); }
        }
    }
}
