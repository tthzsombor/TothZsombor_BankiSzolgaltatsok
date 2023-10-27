using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankiSzolgaltatasok
{
    internal class MegtakarításiSzámla : Számla
    {

        private double kamat;
        private static double alapkamat;

        public double Kamat { get => kamat; set => kamat = value; }
        public static double Alapkamat { get => alapkamat; set => alapkamat = 1.1; }

        public MegtakarításiSzámla(Tulajdonos tulajdonos, HitelSzámla hitelkeret) : base(tulajdonos)
        {
            
        }

        public bool Kivesz(int osszeg)
        {
            bool sikerult=false;
            if(this.aktualisegyenleg-osszeg<=0)
            {
                Console.WriteLine("Nem mehet az egyenleg 0 alá");
            }
            else
            {
                aktualisegyenleg-=osszeg;
                sikerult=true;
            }
            return sikerult;
        }

        public void KamatJóváírás()
        {
            this.aktualisegyenleg += (int)(this.aktualisegyenleg * (this.kamat / 100.0));
        }
    }
}
