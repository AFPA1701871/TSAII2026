using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceOrienteObjet
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //string nomSalarie;
            //ClsSalarie s = new ClsSalarie();
            //Console.WriteLine("Quel est le nom du 1er salarié");
            //nomSalarie= Console.ReadLine();
            //s.SetNom(nomSalarie);
            //s.SetSalaire(50);
            //s.Categorie=12;
            //Console.WriteLine(s.Categorie);
            //Console.WriteLine("le salarie s'appelle " + s.GetNom() + " il est payé " + s.GetSalaire());
            //ClsSalarie s2 = new ClsSalarie(12, 1, 1, "Titi", 20);
            //Console.WriteLine("le salarie s'appelle " + s2.GetNom() + " il est payé " + s2.GetSalaire());
            //Point p = new Point();
            //Console.WriteLine("Point de la classe " + Point.NbPoint);
            //Console.WriteLine("Point de la variable p " + p.Z);
            //Point p1 = new Point();
            //Console.WriteLine("Point de la classe " + Point.NbPoint);
            //Console.WriteLine("Point de la variable p " + p.Z);
            //Console.WriteLine("Point de la variable p1 " + p1.Z);
            //Point p2 = new Point();
            //Console.WriteLine("Point de la classe " + Point.NbPoint);
            //Console.WriteLine("Point de la variable p " + p.Z);
            //Console.WriteLine("Point de la variable p1 " + p1.Z);
            //Console.WriteLine("Point de la variable p2 " + p2.Z);

            //Voitures v = new Voitures("Citroen","C4");
            //v.NbKilometres = 10000;
            //Console.WriteLine(v.ToString());
            //Voitures v2 = new Voitures("rouge", "Renault", "Kadjar", "",0);
            //Console.WriteLine(v2.ToString());
            //v.Rouler(10);
            //Console.WriteLine(v.ToString());
            //v.Rouler(50);
            //Console.WriteLine(v.ToString());
            double masseSalariale=0;
            Employe e1 = new Employe("toto", "t", new DateTime(2014, 1, 2), "employe", 10000, "compta");
            Employe e2 = new Employe("tata", "t", new DateTime(2015, 1, 2), "employe", 15000, "rh");
            Employe e3 = new Employe("tutu", "t", new DateTime(2013, 1, 2), "employe", 12000, "informatique");
            //Console.WriteLine("nb annee " + e.NbAnnee());
            //Console.WriteLine("prime " + e.Prime());
            List<Employe> liste = new List<Employe>();
            liste.Add(e3);
            liste.Add(e1);
            liste.Add(e2);
            //Console.WriteLine("Nombre d'employe" + liste.Count);
            //liste.Sort((x, y) => x.Nom.CompareTo(y.Nom));
            //foreach (Employe emp in liste)
            //{
            //    Console.WriteLine(emp.ToString());
            //}
            //liste.Sort((x, y) => x.Service.CompareTo(y.Service));
            //foreach (Employe emp in liste)
            //{
            //    Console.WriteLine(emp.ToString());
            //}
            //foreach (Employe emp in liste)
            //{
            //    masseSalariale += emp.Salaire + emp.Prime();
            //}
            //Console.WriteLine("Masse salariale :" + masseSalariale);
            Agence a1 = new Agence("Resto", "4 rue truc", "12121", "Dk","Ticket Resto");
            Agence a2 = new Agence("Cuisine", "3 rue truc", "12121", "Dk","Cantine");
            e1.AgenceEmploye = a1;
            e2.AgenceEmploye = a2;
            e3.AgenceEmploye = a1;
            Employe e4 = new Employe("Cesar","Jules",new DateTime (1989,2,12),"empereur",12500,"direction",new Agence("guerre","rome","12201","rome","Cantine"));
           // Console.WriteLine(e4.ToString());
            liste.Add(e4);
            //Console.WriteLine("mode resto empl " + e4.ModeRestaurationEmploye() + "\nmode resto agence " + e4.AgenceEmploye.ModeRestaurationAgence());
            //Console.WriteLine("mode resto " + e4.AgenceEmploye.Moderesto);
            //foreach(Employe emp in liste)
            //{
            //   Console.WriteLine( emp.ModeRestaurationEmploye());
            //}
            Enfant f1 = new Enfant("Dupont", "Chris", 2001);
            Enfant f2 = new Enfant("Dupont", "Rémi", 2005);
            Enfant f3 = new Enfant("Durand", "Hamed", 2008);
     
            e1.ListeEnfant.Add(f1);
            e1.ajouterEnfant(f2);
            e2.ajouterEnfant(f1);
            e2.ajouterEnfant(f2);
            e3.ajouterEnfant(f3);
            Console.WriteLine(e1.ToString());
            Console.WriteLine(e2.ToString());
            Console.WriteLine(e3.ToString());
            */
            Chien toto = new Chien(4, "toto", "long");
            Console.WriteLine(toto.Afficher() + " il s'appelle "+toto.Nom);
            Console.WriteLine(toto.cri());
            Oiseau titi = new Oiseau(2,"titi","jaune");
            Console.WriteLine(titi.Afficher());
            Console.WriteLine(titi.cri());
        }
    }
}
