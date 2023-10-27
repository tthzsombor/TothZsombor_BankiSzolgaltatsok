using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankiSzolgaltatasok
{
    internal class Számla : BankiSzolgáltatás
    {

        protected int aktualisegyenleg;
        public Számla(Tulajdonos tulajdonos) : base(tulajdonos)
        {
           
        }

        public void Befizet(int osszeg)
        {
            this.aktualisegyenleg += osszeg;
        }

        public bool Kivesz(int osszeg)
        {
            this.aktualisegyenleg -= osszeg;
            return true;
        }

        public Kártya ÚjKártya(string kartyaszam)
        {
             Kártya k = new Kártya(this.getTulajdonos(), this, kartyaszam);
            return k;

        }
    }
}
