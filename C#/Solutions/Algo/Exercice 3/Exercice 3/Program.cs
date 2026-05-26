using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /****** Exercice 3.1  ******/
            /*
            //Déclaration
            int valeur;
            String reponse;
            Boolean reussi;

            //Initialisation
            Console.Write("Entrer une valeur : ");
            reponse = Console.ReadLine();
            reussi = Int32.TryParse(reponse, out valeur);


            //Affichage
            if (valeur < 0)
            {
                Console.WriteLine($"{valeur} est négatif");
            }
            else
            {
                Console.WriteLine($"{valeur} est positif");
            }
            // Equivalent seulement s'il n'y a qu'une instruction si vrai et si faux
            // if (valeur < 0) Console.WriteLine($"{valeur} est négatif");
            // else Console.WriteLine($"{valeur} est positif");

            // Equivalent condition condensée
            //Console.WriteLine(valeur<0?"négatif":"positif");
            */


            /****** Exercice 3.4  ******/
            /*
            //Déclaration
            int valeur;
            String reponse;
            Boolean reussi;

            //Initialisation
            Console.Write("Entrer une valeur : ");
            reponse = Console.ReadLine();
            reussi = Int32.TryParse(reponse, out valeur);


            //Affichage
            if (valeur < 0)
            {
                Console.WriteLine($"{valeur} est négatif");
            }
            else if(valeur > 0) 
            {
                Console.WriteLine($"{valeur} est positif");
            }
            else // si la valeur est ni positive, ni négative, elle est forcément nulle
            {
                Console.WriteLine($"{valeur} est null");
            }
            */


            /****** Exercice 3.2  ******/
            /*
            //Déclaration
            int valeur1, valeur2;
            String reponse;
            Boolean reussi;

            //Initialisation
            Console.Write("Entrer la première valeur : ");
            reponse = Console.ReadLine();
            reussi = Int32.TryParse(reponse, out valeur1);

            Console.Write("Entrer la deuxième valeur : ");
            reponse = Console.ReadLine();
            reussi = Int32.TryParse(reponse, out valeur2);


            //Affichage
            if ((valeur1 < 0 && valeur2<0) ||(valeur1>0 && valeur2>0))  // traduction : (valeur1 < 0 ET valeur2<0) OU (valeur1>0 ET valeur2>0)
            {
                Console.WriteLine($"Le produit de {valeur1} par {valeur2} est positif");
            }
            else
            {
                Console.WriteLine($"Le produit de {valeur1} par {valeur2} est négatif");
            }
            */

            /****** Exercice 3.5  ******/
            /*
            //Déclaration
            int valeur1, valeur2;
            String reponse;
            Boolean reussi;

            //Initialisation
            Console.Write("Entrer la première valeur : ");
            reponse = Console.ReadLine();
            reussi = Int32.TryParse(reponse, out valeur1);

            Console.Write("Entrer la deuxième valeur : ");
            reponse = Console.ReadLine();
            reussi = Int32.TryParse(reponse, out valeur2);


            //Affichage
            if (valeur1 == 0 || valeur2 == 0)
            {
                Console.WriteLine($"Le produit de {valeur1} par {valeur2} est null");
            }
            else if ((valeur1 < 0 && valeur2 < 0) || (valeur1 > 0 && valeur2 > 0))

            {
                Console.WriteLine($"Le produit de {valeur1} par {valeur2} est positif");
            }
            else
            {
                Console.WriteLine($"Le produit de {valeur1} par {valeur2} est négatif");
            };

            // Variante : Utilisation du ou exclusif
            // Le produit de 2 nombres est négatif si l'un des 2 est négatif mais pas les 2
            if (valeur1 == 0 || valeur2 == 0)
            {
                Console.WriteLine($"Le produit de {valeur1} par {valeur2} est null");
            }
            else if (valeur1 < 0 ^ valeur2 < 0) // utilisation de Ou exclusif
            {
                Console.WriteLine($"Le produit de {valeur1} par {valeur2} est négatif");
            }
            else
            {
                Console.WriteLine($"Le produit de {valeur1} par {valeur2} est positif");
            }
            */



            /****** Exercice 3.3  ******/
            /*
            //Déclaration
            String valeur1, valeur2, valeur3;

            //Initialisation
            Console.Write("Entrer la première valeur : ");
            valeur1 = Console.ReadLine();

            Console.Write("Entrer la deuxième valeur : ");
            valeur2 = Console.ReadLine();

            Console.Write("Entrer la troisième valeur : ");
            valeur3 = Console.ReadLine();

            //Affichage
            // String.Compare permet de comparer 2 chaines de caractères entre elles.
            // Elle renvoi une valeur négative si le 1er est avant le 2eme, 0 si les 2 sont égaux, une valeur positive sinon
            // Mettre le curseur sur la fonction et appuyer sur F12 pour voir la documentation de la fonction
            if (String.Compare(valeur1, valeur2) <= 0 && String.Compare(valeur2, valeur3) <= 0)
            {
                Console.WriteLine($"{valeur1}, {valeur2} et {valeur3} sont dans l'ordre alphabétique");
            }
            else
            {
                Console.WriteLine($"{valeur1}, {valeur2} et {valeur3} NE SONT PAS dans l'ordre alphabétique");
            }
            */


            /****** Exercice 3.6  ******/
            /*
            //Déclaration
            int age;
            String reponse;
            Boolean reussi;

            //Initialisation
            Console.Write("Entrer l'age de l'enfant : ");
            reponse = Console.ReadLine();
            reussi = Int32.TryParse(reponse, out age);

            //Affichage
            if (age < 6)  // On élimine les cas où il n'y a pas de catégorie
            {
                Console.WriteLine("Trop petit");
            }
            else if (age < 8) // Pas besoin de tester que l'age est >=6 c'est obligé, sinon il serait passé dans la partie alors au dessus
            {
                Console.WriteLine("Poussin");
            }
            else if (age < 10)
            {
                Console.WriteLine("Pupille");
            }
            else if (age < 12)
            {
                Console.WriteLine("Minime");
            }
            else // forcément suérieur ou égal à 12
            {
                Console.WriteLine("Cadet");
            }
            */

            /****** Exercice complémentaire ******/

            //Déclaration
            string strStatut, reponse;
            int a;

            // saisie utilisateur
            Console.WriteLine("Saisissez le statut :");
            strStatut = Console.ReadLine();
            strStatut = strStatut.ToUpper();

            //Test Version 1
            if (strStatut == "C")
            {
                Console.WriteLine("Célibataire !");
            }
            else if (strStatut == "M")
            {
                Console.WriteLine("Marié !");
            }
            else if (strStatut == "V")
            {
                Console.WriteLine("Veuf !");
            }
            else if (strStatut == "D")
            {
                Console.WriteLine("Divorcé !");
            }
            else
            {
                Console.WriteLine("Saisie incorrecte !");
            }

            // test version 2
            switch (strStatut)
            {
                case "C":
                    Console.WriteLine("Célibataire !");
                    break;
                case "M":
                    Console.WriteLine("Marié !");
                    break;
                case "V":
                    Console.WriteLine("Veuf !");
                    break;
                case "D":
                    Console.WriteLine("Divorcé !");
                    break;
                default:
                    Console.WriteLine("Saisie incorrecte !");
                    break;
            }

            Console.Write("Entrer l'age de l'enfant : ");
            reponse = Console.ReadLine();
             Int32.TryParse(reponse, out a);
            switch (a)
            {
                case 1: Console.WriteLine("c'est le 1");break;
                case 2: Console.WriteLine("c'est le 2");break;
                case 3: Console.WriteLine("c'est le 3");break;

                default:
                    break;
            }
        }
    }
}
