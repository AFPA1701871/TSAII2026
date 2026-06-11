using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceOrienteObjet
{
    class Animal
    {
        private int nbpattes;
        private string nom;

        public int Nbpattes
        {
            get
            {
                return nbpattes;
            }

            set
            {
                nbpattes = value;
            }
        }
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
        public Animal() { }
        public Animal(int nb, string no)
        {
            this.nbpattes = nb;
            this.nom = no;
        }
        public string Afficher()
        {
            return "L'animal a " + this.nbpattes + " pattes";
        }
         public virtual string cri()
        {
            return "L'animal a un cri";
        }
    }
}
