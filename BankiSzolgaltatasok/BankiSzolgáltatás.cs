using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankiSzolgaltatasok
{
    internal class BankiSzolgáltatás
    {
        private Tulajdonos tulajdonos;

        public BankiSzolgaltatas( Tulajdonos tulajdonos)
        {
            this.tulajdonos = tulajdonos;
        }

        public Tulajdonos getTulajdonos()
        {
            return this.tulajdonos;
        }


        public override string ToString()
        {
            return $"Tulajdonos: {this.getTulajdonos().getNev()}";

        }

    }
}
