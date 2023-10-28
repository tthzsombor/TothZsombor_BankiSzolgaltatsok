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
            if (hitelKeret < 0)
            {
                HitelSzámla h = new HitelSzámla(tulajdonos, hitelKeret);
                szamlaLista.Add(h);
                return h;
            }
            else
            {
                MegtakarításiSzámla m_sz = new MegtakarításiSzámla(tulajdonos, hitelKeret);
                szamlaLista.Add(m_sz);
                return m_sz;
            }
        }

        public int GetÖsszEgyenleg(Tulajdonos tulajdonos)
        {
            int ossz = 0;
          

            for (int i = 0; i <szamlaLista.Count ; i++)
            {
                if (szamlaLista[i].getTulajdonos() == tulajdonos)
                {
                    ossz += szamlaLista[i].getAktualisEgyenleg();
                }
            }
            return ossz;
        }

        public Számla GetLegnagyobbEgyenlegűSzámla(Tulajdonos tulajdonos)
        {
            Számla m_szamla = null;
            for (int i = 0; i < szamlaLista.Count; i++)
            {
                if (szamlaLista[i].getTulajdonos() == tulajdonos)
                {
                    m_szamla = szamlaLista[i];
                }
            }

            for (int i = 0; i < szamlaLista.Count; i++)
            {
                if (szamlaLista[i].getTulajdonos()==tulajdonos && szamlaLista[i].getAktualisEgyenleg()>m_szamla.getAktualisEgyenleg())
                {
                    m_szamla = szamlaLista[i];
                }
            }

            return m_szamla;
        }

        public long ÖsszHitelkeret()
        {
            return this.osszHitelKeret;
        }


        
    }
}

   
    
    

