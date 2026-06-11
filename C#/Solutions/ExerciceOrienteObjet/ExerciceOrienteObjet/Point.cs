using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceOrienteObjet
{
    class Point
    {
        private int x;
        private int y;
        private int z;
        static int nbPoint;


        //getter/setter
        

        public int Y
        {
            get
            {
                return y;
            }

            set
            {
                y = value;
            }
        }

        public int Z
        {
            get
            {
                return z;
            }

            set
            {
                z = value;
            }
        }

        public static int NbPoint
        {
            get
            {
                return nbPoint;
            }

            set
            {
                nbPoint = value;
            }
        }

        public int X
        {
            get
            {
                return x;
            }

            set
            {
                x = value;
            }
        }

        public Point()
        {
            nbPoint++;
            z = nbPoint;
        }
    }
}
