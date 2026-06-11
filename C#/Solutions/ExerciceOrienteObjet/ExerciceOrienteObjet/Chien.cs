using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceOrienteObjet
{
    class Chien : Animal
    {
        private string poil;

        public string Poil
        {
            get
            {
                return poil;
            }

            set
            {
                poil = value;
            }
        }
        public Chien(int le_nb, string le_nom, string poi) : base(le_nb, le_nom)
        {
            this.poil = poi;
        }
        public override string cri()
        {
            return "L'animal aboye";
        }
    }
}
