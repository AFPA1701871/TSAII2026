using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceOrienteObjet
{
    class Agence
    {
        private string nom;
        private string adresse;
        private string codePostal;
        private string ville;
        private string moderesto;
        //getter /setter
        public string Nom
        {
            get
            {
                return nom;
            }

            set
            {
                nom = value;
            }
        }
        public string Adresse
        {
            get
            {
                return adresse;
            }

            set
            {
                adresse = value;
            }
        }
        public string CodePostal
        {
            get
            {
                return codePostal;
            }

            set
            {
                codePostal = value;
            }
        }
        public string Ville
        {
            get
            {
                return ville;
            }

            set
            {
                ville = value;
            }
        }
        public string Moderesto
        {
            get
            {
                return moderesto;
            }

            set
            {
                moderesto = value;
            }
        }

        //constructeur
        public Agence() { }
        public Agence(string no, string ad, string cp, string vi, string moderest)
        {
            this.nom = no;
            this.adresse = ad;
            this.codePostal = cp;
            this.ville = vi;
            this.moderesto = moderest;
        }
        //autres methodes
        public string ModeRestaurationAgence()
        {
            return moderesto;
        }

    }
}
