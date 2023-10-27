using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankiSzolgaltatasok
{
    internal class Kártya : BankiSzolgáltatás
    {
        private Számla szamla;
        private string kartyaSzam;

        public Kártya(Tulajdonos tulajdonos, Számla szamla, string kartyaSzam) : base(tulajdonos)
        {
            
            this.szamla = szamla;
            this.kartyaSzam = kartyaSzam;
        }

        public bool Vasarlas(int osszeg)
        {
            return true;
        }
    }
}
