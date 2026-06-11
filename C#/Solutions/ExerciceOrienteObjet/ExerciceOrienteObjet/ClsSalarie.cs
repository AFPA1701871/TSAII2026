using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceOrienteObjet
{
    class ClsSalarie
    {
        private int matricule { get; set; }
        private int categorie;
        private int service;
        private string nom;
        private double salaire;

        //Getter Setter
        public int Categorie
        {
            get
            {
                return categorie;
            }

            set
            {
                categorie = value+1;
            }
        }
        public void SetMatricule(int value)
        {
            this.matricule = value;
        }
        public int GetMatricule()
        {
            return this.matricule;
        }
        public void SetService(int value)
        {
            this.service = value;
        }
        public int GetService()
        {
            return this.service;
        }
        public void SetNom(string value)
        {
            this.nom = value;
        }
        public string GetNom()
        {
            return this.nom;
        }
        public void SetSalaire(double value)
        {
            this.salaire = value;
        }
        public double GetSalaire()
        {
            return this.salaire;
        }

        //Constructeur
        public ClsSalarie() { }
        public ClsSalarie(int mat, int cat, int ser, string nom, double sal)
        {
            this.matricule = mat;
            this.categorie = cat;
            this.service = ser;
            this.nom = nom;
            this.salaire = sal;

        }
    }
}
