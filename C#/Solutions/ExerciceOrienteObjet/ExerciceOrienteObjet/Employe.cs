using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceOrienteObjet
{
    class Employe
    {
        //attributs
        private string nom;
        private string prenom;
        private DateTime dateEmbauche;
        private string fonction;
        private int salaire;
        private string service;
        private Agence agenceEmploye;
        private bool chequeVacances;
        private List<Enfant> listeEnfant = new List<Enfant>();
        //constructeur
        public Employe() { }
        public Employe(string nom, string prenom, DateTime dateEmbauche, string fonction, int salaire, string service)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.dateEmbauche = dateEmbauche;
            this.fonction = fonction;
            this.salaire = salaire;
            this.service = service;
            chequeVacances = NbAnnee() >= 1;
            /* equivaut à    
               if (NbAnnee() >= 1) {
                   chequeVacances = true; }
               else {
                   chequeVacances = false; }*/
        }
        public Employe(string nom, string prenom, DateTime dateEmbauche, string fonction, int salaire, string service, Agence ag)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.dateEmbauche = dateEmbauche;
            this.fonction = fonction;
            this.salaire = salaire;
            this.service = service;
            this.agenceEmploye = ag;
            chequeVacances = NbAnnee() >= 1;
        }
        //getter / setter
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
        public string Prenom
        {
            get
            {
                return prenom;
            }

            set
            {
                prenom = value;
            }
        }
        public DateTime DateEmbauche
        {
            get
            {
                return dateEmbauche;
            }

            set
            {
                dateEmbauche = value;
            }
        }
        public string Fonction
        {
            get
            {
                return fonction;
            }

            set
            {
                fonction = value;
            }
        }
        public int Salaire
        {
            get
            {
                return salaire;
            }

            set
            {
                salaire = value;
            }
        }
        public string Service
        {
            get
            {
                return service;
            }

            set
            {
                service = value;
            }
        }
        internal Agence AgenceEmploye
        {
            get
            {
                return agenceEmploye;
            }

            set
            {
                agenceEmploye = value;
            }
        }
        public bool ChequeVacances
        {
            get
            {
                return chequeVacances;
            }

            set
            {
                chequeVacances = value;
            }
        }
        public void setChequeVacances()
        {
            chequeVacances = NbAnnee() >= 1;
        }
        internal List<Enfant> ListeEnfant
        {
            get
            {
                return listeEnfant;
            }

            set
            {
                listeEnfant = value;
            }
        }
        //autres methodes
        public int NbAnnee()
        {
            //TimeSpan t;
            //t= DateTime.Now - this.dateEmbauche;
            //return t.Days / 365;
            return (DateTime.Now - this.dateEmbauche).Days / 365;
        }
        public double Prime()
        {
            double laprime;
            laprime = salaire * 0.05;
            laprime += salaire * 0.02 * NbAnnee();
            return laprime;
            // return salaire * 0.05 + salaire * 0.02 * NbAnnee();
        }
        public void ajouterEnfant(Enfant enf)
        {
            listeEnfant.Add(enf);
        }
        public string ToString()
        {
            string res;
            res = "L'employe s'appele " + this.nom + "  " + this.prenom + ". \nIl a été embauché le " + this.dateEmbauche.ToString("dd/MM/yyyy") + " dans le service " + this.service + ". \nIl est payé " + this.salaire;
            res += ". \nIl est dans l'agence " + agenceEmploye.Nom + " situé " + agenceEmploye.Adresse + " " + agenceEmploye.CodePostal + " " + agenceEmploye.Ville;
            if (chequeVacances)
            {
                res += ". \nIl peut bénéficier des cheques vacances";
            }
            else
            {
                res += ". \nIl ne peut pas bénéficier des cheques vacances";
            }
            if (listeEnfant.Count > 0)
            {
                res += "\nSes enfants sont ";

                foreach (Enfant enf in listeEnfant)
                {
                    res += enf.NomEnfant + " " + enf.PrenomEnfant + "  ";
                }
            }
            res += "\n" + chequeNoel();
            return res;
        }
        public string ModeRestaurationEmploye()
        {
            return "Employe" + this.nom + " " + this.prenom + " " + agenceEmploye.Moderesto;
        }
        public string chequeNoel()
        {
            string res = "";
            int cheque20 = 0, cheque30 = 0, cheque50 = 0; // contient le nombre de cheque de chaque type
            foreach (Enfant enf in listeEnfant)
            {
                if (enf.age() <= 10)
                {
                    cheque20++;
                }
                else if (enf.age() < 15)
                {
                    cheque30++;
                }
                else if (enf.age() < 18)
                {
                    cheque50++;
                }
            }
            if (cheque20 + cheque30 + cheque50 > 0)
            {
                res += "L'employé bénéficie de chèque de Noël ";

                if (cheque20 > 0)
                {
                    res += cheque20 + "chèque de 20  ";
                }
                if (cheque30 > 0)
                {
                    res += cheque30 + "chèque de 30  ";
                }
                if (cheque50 > 0)
                {
                    res += cheque50 + "chèque de 50  ";
                }
            }
            return res;
        }
    }
}
