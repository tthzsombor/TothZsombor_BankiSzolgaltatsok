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

        public override bool Kivesz(int osszeg)
        {
            bool sikerult;
            if (osszeg > hitelkeret+getAktualisEgyenleg())
            {
                sikerult = false;
            }
            else
            {
                getAktualisEgyenleg() -= osszeg;
                sikerult = true;
            }
            return sikerult;
        }
    }
}
