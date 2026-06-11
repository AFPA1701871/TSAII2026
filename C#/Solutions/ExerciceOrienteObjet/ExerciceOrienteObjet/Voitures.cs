using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceOrienteObjet
{
    class Voitures
    {
        //declaration
        private string couleur;
        private string marque;
        private string modele;
        private string motorisation;
        private int nbKilometres;
        //getter / setter
        public string Couleur
        {
            get
            {
                return couleur;
            }

            set
            {
                couleur = value;
            }
        }
        public string Marque
        {
            get
            {
                return marque;
            }

            set
            {
                marque = value;
            }
        }
        public string Modele
        {
            get
            {
                return modele;
            }

            set
            {
                modele = value;
            }
        }
        public string Motorisation
        {
            get
            {
                return motorisation;
            }

            set
            {
                motorisation = value;
            }
        }
        public int NbKilometres
        {
            get
            {
                return nbKilometres;
            }

            set
            {
                nbKilometres = value;
            }
        }
        // Constructeurs
        public Voitures(string cou, string mar, string mod, string mot, int nbK)
        {
            this.couleur = cou;
            this.marque = mar;
            this.modele = mod;
            this.motorisation = mot;
            this.nbKilometres = nbK;
        }
        public Voitures( string mar, string mod)
        {
            this.marque = mar;
            this.modele = mod;
        }
        //Autres methodes
        public string ToString()
        {
            string resultat;
            resultat = "Cette voiture est une " + this.Modele + " de la marque " + this.marque + " ,de couleur " + this.couleur + "de motorisation " + this.motorisation + ", avec " + nbKilometres + " Kilomètres";
            return resultat;
        }
        public void Rouler(int nbKm)
        {
            this.nbKilometres += nbKm;
        }
    }
}
