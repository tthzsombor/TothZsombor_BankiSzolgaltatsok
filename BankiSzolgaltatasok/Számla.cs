using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankiSzolgaltatasok
{
    internal abstract class Számla : BankiSzolgáltatás
    {

        protected int aktualisegyenleg;
        public Számla(Tulajdonos tulajdonos) : base(tulajdonos)
        {
           
        }

        public int getAktualisEgyenleg()
        {
            return this.aktualisegyenleg;
        }

        public void Befizet(int osszeg)
        {
            this.aktualisegyenleg += osszeg;
        }

        public abstract bool Kivesz(int osszeg);
      

        public Kártya ÚjKártya(string kartyaszam)
        {
            Kártya k = new Kártya(this.getTulajdonos(), this, kartyaszam);
            return k;

        }
    }
}
