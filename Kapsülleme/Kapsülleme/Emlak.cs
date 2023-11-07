using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kapsülleme
{
    internal class Emlak
    {
        private string semt;
        private string renk;
        private int odasayisi;
        private int katsayisi;
        private int alan;


        public string SEMT
        {
            get { return semt; }
            set { semt = value.ToUpper(); }
        }

        public string RENK
        {
            get { return renk; }
            set { renk = value.ToLower(); }
        }

        public int ODASAYISI
        {
            get { return odasayisi; }
            set { odasayisi = Math.Abs(value); }
        }

        public int KATSAYISI
        {
            get { return katsayisi; }
            set { katsayisi = Math.Abs(value); }
        }

        public int ALAN
        {
            get { return alan; }
            set { alan = Math.Abs(value); }
        }
    }
}
