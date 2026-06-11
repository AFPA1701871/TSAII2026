using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceOrienteObjet
{
    class Enfant
    {
        private string nomEnfant;
        private string prenomEnfant;
        private int anneeNaissance;
        //getter /setter
        public string NomEnfant
        {
            get
            {
                return nomEnfant;
            }

            set
            {
                nomEnfant = value;
            }
        }
        public string PrenomEnfant
        {
            get
            {
                return prenomEnfant;
            }

            set
            {
                prenomEnfant = value;
            }
        }
        public int AnneeNaissance
        {
            get
            {
                return anneeNaissance;
            }

            set
            {
                anneeNaissance = value;
            }
        }
        //constructeur
        public Enfant() { }
        public Enfant(string nom, string prenom, int annee)
        {
            this.nomEnfant = nom;
            this.prenomEnfant = prenom;
            this.anneeNaissance = annee;
        }
        //autre methodes
        public int age()
        { // pour test
            return DateTime.Now.Year - this.anneeNaissance;
        }
    }
}
