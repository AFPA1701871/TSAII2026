using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Personne martine = new Personne();
            martine.setPrenom("martine");
            Console.WriteLine(martine.getPrenom());
            Personne alex = new Personne("Tytgat","Alex","ici",new DateTime(2026,06,04));
            Console.WriteLine(alex.getPrenom());
            Voiture v = new Voiture("ds",1000);
            Console.WriteLine(v.getMarque());
            alex.setVehicule(v);
            Console.WriteLine(alex.getVehicule().getNbKm());

            Personne toto = new Personne("toto", "t", "ici", new DateTime(2025, 2, 4));
            toto.setVehicule(new Voiture("audi", 5000));
            Personne titi = new Personne("titi", "t", "ici", new DateTime(2025, 2, 4),new Voiture("audi", 5000));
        }
    }
}
