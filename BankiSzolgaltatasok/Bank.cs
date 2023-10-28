using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankiSzolgaltatasok
{
    internal class Bank
    {
        private List<Számla> szamlaLista;
        private int listaMeret;
        private int osszHitelKeret;

        public Bank()
        {
            this.szamlaLista = new List<Számla>(this.listaMeret);
        }

        public Számla szamlanyitas(int hitelKeret, Tulajdonos tulajdonos)
        {
            Számla szamlaHelyettesito;
            if (hitelKeret == 0)
            {
                szamlaHelyettesito = new MegtakarításiSzámla(tulajdonos);
            }
            else
            {
                szamlaHelyettesito = new HitelSzámla(tulajdonos, hitelKeret);
                this.osszHitelKeret += hitelKeret;
            }
            this.szamlaLista.Add(szamlaHelyettesito);
            return szamlaHelyettesito;
        }

        public int GetÖsszEgyenleg(Tulajdonos tulajdonos)
        {
            int osszEgyenleg = 0;
            for (int i = 0; i < this.szamlaLista.Count; ++i)
            {
                if (this.szamlaLista[i].getTulajdonos() == tulajdonos)
                {
                    osszEgyenleg += this.szamlaLista[i].AktualisEgyenleg();
                }
            }
            return osszEgyenleg;
        }

        public Számla GetLegnagyobbEgyenlegűSzámla(Tulajdonos tulajdonos)
        {
             Számla maxSzamla = new Számla(tulajdonos);
            for (int i = 0; i < this.szamlaLista.Count; ++i)
            {
                if (maxSzamla.getAktualisEgyenleg() < this.szamlaLista[i].getAktualisEgyenleg())
                {
                    maxSzamla.aktualisEgyenleg = this.szamlaLista[i].getAktualisEgyenleg();
                }
            }
            return maxSzamla;
        }

        public long ÖsszHitelkeret()
        {
            return this.osszHitelKeret;
        }


        //nem végleges
    }
}

   
    
    

