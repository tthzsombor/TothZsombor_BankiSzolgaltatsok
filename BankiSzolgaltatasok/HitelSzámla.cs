using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankiSzolgaltatasok
{
    internal class HitelSzámla : Számla
    {

        private int hitelkeret;
        public HitelSzámla(Tulajdonos tulajdonos, int hitelkeret) : base(tulajdonos)
        {
            this.hitelkeret = hitelkeret;
        }

        public bool Kivesz(int osszeg)
        {
            bool sikerult = true;
            if(osszeg>hitelkeret)
            {
                sikerult= false;
            }
            else
            {
                this.aktualisegyenleg -= osszeg;
                sikerult = true;
            }
            return sikerult;
        }
    }
}
