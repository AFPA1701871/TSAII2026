using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Personne
    {
        // attributs
        private String nom;
        private String prenom;
        private String adresse;
        private DateTime ddn;
        private Voiture vehicule;



        // constructeurs
        public Personne()
        {
        }

        public Personne(string n, string prenom, string adresse, DateTime ddn)
        {
            this.nom = n;
            this.prenom = prenom;
            this.adresse = adresse;
            this.ddn = ddn;
        }
        public Personne(string n, string prenom, string adresse, DateTime ddn , Voiture v)
        {
            this.nom = n;
            this.prenom = prenom;
            this.adresse = adresse;
            this.ddn = ddn;
            this.setVehicule(v);
        }
        // assesseurs
        public String getNom()
        {
            return nom;
        }
        public String getPrenom()
        {
            return prenom;
        }
        public void setNom(String nom)
        {
            this.nom=nom;
        }
        public void setPrenom(String prenom)
        {
            this.prenom = prenom;
        }
        public void setVehicule(Voiture v)
        {
            this.vehicule = v;
        }
        public Voiture getVehicule()
        {
            return vehicule;
        }
    }
}
