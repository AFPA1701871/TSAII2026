using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /***** Exercice 6.1 *****/
            /*
            int[] tableau = new int[7];

            // Utilisation de Array.Fill pour initialiser les valeurs à zéro
            //Array.Fill(tableau, 0);

            // Initialisation avec une boucle
            for (int i = 0; i < tableau.Length; i++)
            {
                tableau[i] = 0; // Remplir chaque élément avec 0
            }
            AfficherTableau(tableau);
            */

            /***** Exercice 6.2 *****/
            /*
            char[] tablo = { 'a', 'e', 'i', 'o', 'u' };
            AfficherTableau(tablo);
            */

            /***** Exercice 6.3 *****/
            /*
            int[] notes = new int[9];
            RemplirTableau(notes);
            AfficherTableau(notes);
            */

            /***** Exercice 6.4 *****/
            /*
            int[] nb = new int[6];
            int i;
            String affichage = "";
            for (i = 0;i<6;i++)
            {
                nb[i] = i*i;
                affichage += nb[i] + " | ";
            }
            affichage = affichage.Substring(0,affichage.Length-2);
            Console.WriteLine(affichage + "\n");
            */


            /***** Exercice 6.5 *****/
            /*
            int[] nb = new int[7];
            int i;
            nb[0] = 1;
            Console.Write(nb[0] + " | ");
            for (i = 1; i < 7; i++)
            {
                nb[i] = nb[i-1] + 2;
                Console.Write(nb[i] + " | ");
            }
            Console.WriteLine("\n");
            */


            /***** Exercice 6.6 *****/
            /*
            int[] nb = new int[8];
            int i;
            nb[0] = 1;
            nb[1] = 1;
            Console.Write(nb[0] + " | ");
            Console.Write(nb[1] + " | ");
            for (i = 2; i < 8; i++)
            {
                nb[i] = nb[i-1] + nb[i-2];
                Console.Write(nb[i] + " | ");
            }
            Console.WriteLine("\n");
            */

            /***** Exercice 6.7  *****/
            /*
            int[] notes = new int[9];
            int total = 0;
            Double moyenne;
            RemplirTableau(notes);
            AfficherTableau(notes);

            // Calcul de la moyenne
            for (int i = 0; i < notes.Length; i++)
            {
                total += notes[i];
            }
            //moyenne = total / notes.Length;  // la division d'un entier par un entier donne un entier => pas vraiment la moyenne
            //moyenne = Convert.ToDouble(total) / Convert.ToDouble(notes.Length);
            //moyenne = total / Convert.ToDouble(notes.Length);
            moyenne = (total / (Double)notes.Length);


            // Affichage de la moyenne
            Console.WriteLine($"La moyenne est : {moyenne:F2}");
            */


            /***** Exercice 6.7 variante avec average *****/
            /*
            int[] notes = new int[9];
            Double moyenne ;

            RemplirTableau(notes);
            AfficherTableau(notes);

            // Calcul de la moyenne
            moyenne = notes.Average();

            // Affichage de la moyenne
            Console.WriteLine($"La moyenne est : {moyenne:F2}");
            */

            /***** Exercice 6.8 *****/
            /*
            int[] notes = CreerTableau();
            int positif = 0, negatif = 0, zero = 0;

            foreach (var note in notes)  // ATTENTION différence entre notes et note
            {
                if (note == 0)
                    zero++;
                else if (note > 0)
                    positif++;
                else
                    negatif++;
            }
            Console.WriteLine("\n");
            Console.WriteLine($"il y a \t{positif} nombre positif \n\t{negatif} nombre négatif\n\t{zero} nombre null");
            */

            /***** Exercice 6.9 *****/
            /*
            int[] tablo = CreerTableau();
            int total = 0;
            foreach (var item in tablo)
            {
                total += item;
            }
            Console.WriteLine($"La somme des éléments est {total}");
            //total = tablo.Sum();
            //Console.WriteLine($"La somme des éléments est {total}");
            */


            /***** Exercice 6.10 *****/
            /*
            int[] tablo1 = CreerTableau();
            int[] tablo2 = CreerTableau(tablo1.Length);
            int[] tablo3 = CreerTableau(tablo1.Length, false);

            for (int i = 0; i < tablo1.Length; i++)
            {
                tablo3[i] = tablo1[i] + tablo2[i];
            }
            AfficherTableau(tablo1);
            AfficherTableau(tablo2);
            AfficherTableau(tablo3);
            */


            /***** Exercice 6.11 *****/
            /*
            int[] tablo1 = CreerTableau();
            int[] tablo2 = CreerTableau();
            int schtroumpf = 0;

            for (int i = 0;i<tablo1.Length;i++)
            {
                for (int j = 0;j<tablo2.Length;j++)
                {
                    schtroumpf += tablo1[i] * tablo2[j];
                }
            }
            Console.WriteLine($"le schtroumpf est de : {schtroumpf}");
            */

            /***** Exercice 6.12 *****/
            /*
            int[] tablo = CreerTableau();
            int[] tablo2 = new int[tablo.Length]; // CreerTableau(tablo.Length,false);
            for (int i = 0; i < tablo.Length; i++)
            {
                tablo2[i] = tablo[i] + 1;
            }
            AfficherTableau(tablo);
            AfficherTableau(tablo2);
            */

            /***** Exercice 6.13 *****/
            /*
            int[] tablo = CreerTableau();
            int max = tablo[0], position=0;
            for (int i = 0;i<tablo.Length;i++)
            {
                if (tablo[i] > max)
                {
                    max = tablo[i];
                    position = i;
                }
            }
            Console.WriteLine($"La plus grande valeur est {max}, elle est à la position {position + 1}");  // on affiche position +1 pour ne pas mettre 0 pour la 1ère case
            */


            /***** Exercice 6.13 avec les fonction max et IndexOf *****/
            /*
            int[] tablo = CreerTableau();
            int max, position;
            max = tablo.Max();
            position = Array.IndexOf(tablo, max);
            Console.WriteLine($"La plus grande valeur est {max}, elle est à la position {position+1}");  
            */

            /***** Exercice 6.14 *****/
            /*
            int nbNotesSuperieures=0;
            int[] notes = CreerTableau();
            Double moyenne = notes.Average();
            foreach (int element in notes)
            {
                if (element >= moyenne)
                {
                    nbNotesSuperieures++;
                }
            }
            Console.WriteLine($"Il y a {nbNotesSuperieures} notes supérieures à la moyenne qui est de {moyenne}");
            */

            /***** Exercice 6.14 avec utilisation de Count conditionnel *****/
            /*
            int nbNotesSuperieures=0;
            int[] notes = CreerTableau();
            Double moyenne = notes.Average();
            nbNotesSuperieures = notes.Count(x => x >= moyenne);  // compter les x tel que x >= moyenne
            int nbPositif = notes.Count(note => note > 0);  
            Console.WriteLine($"Il y a {nbNotesSuperieures} notes supérieures à la moyenne qui est de {moyenne}");
            */
        }


        /// <summary>
        /// Affiche un tableau d'entier
        /// </summary>
        /// <param name="tab">le tableau à afficher</param> 
        public static void AfficherTableau(int[] tab)
        {
            for (int i = 0; i < tab.Length; i++)
            {
                Console.Write(tab[i] + " \t| ");
            }
            Console.WriteLine("\n");
        }

        /// <summary>
        /// Affiche un tableau de caractères
        /// </summary>
        /// <param name="tab">le tableau à afficher</param> 
        public static void AfficherTableau(char[] tab)
        {
            for (int i = 0; i < tab.Length; i++)
            {
                Console.Write(tab[i] + " | ");
            }
            Console.WriteLine("\n");
        }
        /// <summary>
        /// Demande un entier à l'utilisateur jusqu'à ce que la valeur convienne
        /// </summary>
        /// <param name="prompt">Invite pour demander le nombre à l'utilisateur</param>
        /// <returns></returns>
        public static int SaisieEntier(String prompt = "Entrer un nombre : ") //on gère une valeur par defaut, comme ca, pas la peine d'avoir 2 fonctions
        {
            int nb;
            String reponse;
            Boolean reussi;

            do
            {
                Console.Write(prompt);
                reponse = Console.ReadLine();
                reussi = Int32.TryParse(reponse, out nb);
            }
            while (!reussi);
            return nb;
        }


        /// <summary>
        /// Remplir un tableau d'entier en demandant les valeurs à l'utilisateur
        /// </summary>
        /// <param name="tab"></param>
        public static void RemplirTableau(int[] tab)
        {
            for (int i = 0; i < tab.Length; i++)
            {
                //tab[i] = SaisieEntier();
                tab[i] = SaisieEntier($"Entrer la note n°{i + 1} : ");
            }
            Console.WriteLine("\n");
        }

        /*
        /// <summary>
        /// Crée un tableau d'entier et demande à l'utilisateur le nombre de cases puis les valeurs
        /// </summary>
        /// <param name="tab"></param>
        public static int[] CreerTableau()
        {
            int[] tab = new int[SaisieEntier("Entrer la taille du tableau : ")];
            RemplirTableau(tab);
            return tab;
        }
        */

        /// <summary>
        /// Créer un tableau en precisant ou pas la taille
        /// Demande à l'utilisateur de remplir le tableau ou pas en fonction du boolean
        /// puis demander à l'utilisateur les valeurs
        /// </summary>
        /// <param name="taille"></param>
        /// <returns></returns>
        public static int[] CreerTableau(int taille = 0, Boolean remplir = true)
        {
            if (taille == 0) taille = SaisieEntier("Entrer la taille du tableau : ");
            int[] tab = new int[taille];
            if (remplir) RemplirTableau(tab);
            return tab;
        }


    }
}
