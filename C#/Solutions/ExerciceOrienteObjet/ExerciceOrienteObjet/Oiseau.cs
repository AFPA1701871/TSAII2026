using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceOrienteObjet
{
    class Oiseau:Animal
    {
        private string plumes;

        public string Plumes
        {
            get
            {
                return plumes;
            }

            set
            {
                plumes = value;
            }
        }
        public Oiseau(int leNombredePattes, string LeNom, string TypeDePlumes) : base(leNombredePattes, LeNom)
        {
            this.plumes = TypeDePlumes;
        }
    }
}
