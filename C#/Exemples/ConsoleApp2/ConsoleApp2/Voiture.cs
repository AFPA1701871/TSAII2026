using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Voiture
    {
        private String marque;
        private int nbKm;

        public Voiture(string marq, int nbKm)
        {
            this.setMarque( marq);
            this.setNbKm (nbKm);
        }

        public Voiture() { }
        public String getMarque()
        {
            return marque;
        }
        public int getNbKm()
        {
            return nbKm;
        }
        public void setMarque(String m)
        {
            this.marque = m.ToUpper();
        }
        public void setNbKm(int nbKm)
        { this.nbKm = nbKm; }


    }
}
