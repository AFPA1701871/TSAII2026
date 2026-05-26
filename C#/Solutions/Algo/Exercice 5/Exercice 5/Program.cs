using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /***** Exercice 5.1 *****/
            /*
            // Déclaration
            int valeur;
            String reponse;
            Boolean reussi;

            //Boucle

            do
            {
                Console.Write("Entrer un nombre entre 1 et 3");
                reponse = Console.ReadLine();
                reussi = Int32.TryParse(reponse, out valeur);

                if (valeur < 1 || valeur > 3)
                    Console.WriteLine("Saisie Incorrecte \n\n");
            }
            while (valeur < 1 || valeur > 3);
            //while (!reussi || valeur < 1 || valeur > 3);
            */

            /***** Exercice 5.2 *****/
            /*
            // Déclaration
            int valeur;
            String reponse;
            Boolean reussi;

            //Boucle
            do
            {
                Console.Write("Entrer un nombre entre 10 et 20");
                reponse = Console.ReadLine();
                reussi = Int32.TryParse(reponse, out valeur);

                if (valeur < 10 ) Console.WriteLine("Plus Grand");
                else if (valeur > 20)
                    Console.WriteLine("Plus Petit");
            }
            while (!reussi || valeur < 10 || valeur > 20);
            */

            /***** Exercice 5.3 *****/
            /*
            // Déclaration
            int valeur;
            String reponse;
            Boolean reussi;

            //Boucle
            do
            {
                Console.Write("Entrer un nombre : ");
                reponse = Console.ReadLine();
                reussi = Int32.TryParse(reponse, out valeur);
            }
            while (!reussi );
            for (int i = 1;i<11;i++)
            {

                Console.WriteLine($"{valeur + i}");
            }
            */
            /***** Exercice 5.3 variante while *****/
            /*
            // Déclaration
            int valeur,i=1;
            String reponse;
            Boolean reussi;

            //Boucle
            do
            {
                Console.Write("Entrer un nombre : ");
                reponse = Console.ReadLine();
                reussi = Int32.TryParse(reponse, out valeur);
            }
            while (!reussi);
            while (i < 11)
            {
                Console.WriteLine($"{valeur + i}");
                i++;
            }
            */
            /***** Exercice 5.3 variante do while *****/
            /*
            // Déclaration
            int valeur, i = 1;
            String reponse;
            Boolean reussi;

            //Boucle
            do
            {
                Console.Write("Entrer un nombre : ");
                reponse = Console.ReadLine();
                reussi = Int32.TryParse(reponse, out valeur);
            }
            while (!reussi);
            do
            {
                Console.WriteLine($"{valeur + i}");
                i++;
            }
            while (i < 11);
            */

            /***** Exercice 5.4 *****/
            /*
            // Déclaration
            int valeur;
            String reponse;
            Boolean reussi;

            //Boucle
            do
            {
                Console.Write("Entrer un nombre : ");
                reponse = Console.ReadLine();
                reussi = Int32.TryParse(reponse, out valeur);
            }
            while (!reussi );
            for (int i = 1;i<11;i++)
            {
                Console.WriteLine($"{valeur} x {i} = {valeur * i}");
            }
            */
            /***** Exercice 5.4 variante while *****/
            /*
            // Déclaration
            int valeur,i=1;
            String reponse;
            Boolean reussi;

            //Boucle
            do
            {
                Console.Write("Entrer un nombre : ");
                reponse = Console.ReadLine();
                reussi = Int32.TryParse(reponse, out valeur);
            }
            while (!reussi);
            while (i < 11)
            {
                Console.WriteLine($"{valeur} x {i} = {valeur * i}");
                i++;
            }
            */
            /***** Exercice 5.4 variante do while *****/
            /*
            // Déclaration
            int valeur, i = 1;
            String reponse;
            Boolean reussi;

            //Boucle
            do
            {
                Console.Write("Entrer un nombre : ");
                reponse = Console.ReadLine();
                reussi = Int32.TryParse(reponse, out valeur);
            }
            while (!reussi);
            do
            {
                Console.WriteLine($"{valeur} x {i} = {valeur * i}");
                i++;
            }
            while (i < 11);
            */

            /***** Exercice 5.5 *****/
            /*
            // Déclaration
            int valeur, total = 0;
            String reponse;
            Boolean reussi;

            //Boucle
            do
            {
                Console.Write("Entrer un nombre : ");
                reponse = Console.ReadLine();
                reussi = Int32.TryParse(reponse, out valeur);
            }
            while (!reussi);
            for (int i = 1; i <= valeur; i++)
            {
                total += i;
            }
            Console.WriteLine($"{total}");
            */
            /***** Exercice 5.5 variante avec affichage *****/
            /*
            // Déclaration
            int valeur, total = 0;
            String reponse, affichage = "";
            Boolean reussi;

            //Boucle
            do
            {
                Console.Write("Entrer un nombre : ");
                reponse = Console.ReadLine();
                reussi = Int32.TryParse(reponse, out valeur);
            }
            while (!reussi);
            for (int i = 1; i <= valeur; i++)
            {
                total += i;
                affichage += i + "+";
            }
            affichage = affichage.Substring(0, affichage.Length - 1);
            affichage += "=" + total;
            Console.WriteLine(affichage);
            */
            /***** Exercice 5.6 *****/
            /*
            // Déclaration
            int valeur, facto = 1;
            String reponse;
            Boolean reussi;

            //Boucle
            do
            {
                Console.Write("Entrer un nombre : ");
                reponse = Console.ReadLine();
                reussi = Int32.TryParse(reponse, out valeur);
            }
            while (!reussi);
            for (int i = 1; i <= valeur; i++)
            {
                facto *= i;
            }
            Console.WriteLine($"{facto}");
            */
            /***** Exercice 5.6 variante avec affichage *****/
            /*
            // Déclaration
            int valeur, facto = 1;
            String reponse, affichage = "";
            Boolean reussi;

            //Boucle
            do
            {
                Console.Write("Entrer un nombre : ");
                reponse = Console.ReadLine();
                reussi = Int32.TryParse(reponse, out valeur);
            }
            while (!reussi);
            for (int i = 1; i <= valeur; i++)
            {
                facto *= i;
                affichage += i + "*";
            }
            affichage = affichage.Substring(0, affichage.Length - 1);
            affichage += "=" + facto;
            Console.WriteLine(affichage);
            */

            /***** Exercice 5.7 *****/
            /*
            // Déclaration
            int valeur, max = 0, position = 1;
            String reponse;
            Boolean reussi;

            //Boucle
            for (int i = 1; i < 6; i++)
            {
                do
                {
                    Console.Write($"Entrer un nombre n°{i}: ");
                    reponse = Console.ReadLine();
                    reussi = Int32.TryParse(reponse, out valeur);
                }
                while (!reussi);
                if (valeur > max)
                {
                    max = valeur;
                    position = i;
                }
            }
            Console.WriteLine($"Le plus grand nombre est {max}, il était à la position {position}");
            */

            /***** Exercice 5.7 Variante avec gestion des négatifs *****/
            /*
            // Déclaration
            int valeur, max , position = 1;
            String reponse;
            Boolean reussi;

            // on initialise le max avec la première valeur saisie
            do
            {
                Console.Write("Entrer un nombre n°1: ");
                reponse = Console.ReadLine();
                reussi = Int32.TryParse(reponse, out max);
            }
            while (!reussi);

            //Boucle
            for (int i = 2; i < 21; i++)
            {
                do
                {
                    Console.Write($"Entrer un nombre n°{i}: ");
                    reponse = Console.ReadLine();
                    reussi = Int32.TryParse(reponse, out valeur);
                }
                while (!reussi);
                if (valeur > max)
                {
                    max = valeur;
                    position = i;
                }
            }
            Console.WriteLine($"Le plus grand nombre est {max}, il était à la position {position}");
            */

            /***** Exercice 5.8 avec gestion des négatifs *****/
            /*
            // Déclaration
            int valeur, max, position = 1,i=2;
            String reponse;
            Boolean reussi;
            // on initialise le max avec la première valeur saisie
            do
            {
                Console.Write("Entrer un nombre n°1: ");
                reponse = Console.ReadLine();
                reussi = Int32.TryParse(reponse, out max);
            }
            while (!reussi);

            //Boucle
            do
            {
                do
                {
                    Console.Write($"Entrer un nombre n°{i}: ");
                    reponse = Console.ReadLine();
                    reussi = Int32.TryParse(reponse, out valeur);
                }
                while (!reussi);
                if (valeur !=0 && valeur > max) // on ne prend pas le 0 en compte
                {
                    max = valeur;
                    position = i;
                }
                i++;
            }
            while (valeur != 0);
            Console.WriteLine($"Le plus grand nombre est {max}, il était à la position {position}");
            */

            /***** Exercice 5.9 *****/
            /*
            // Déclaration
            int prix, total=0, sommeVersee, aRendre;
            String reponse;
            Boolean reussi, insuffisant=false;
            

            //On collecte les prix. On les additionne au fur et à mesure
            do
            {
                do
                {
                    Console.Write($"Entrer un prix : ");
                    reponse = Console.ReadLine();
                    reussi = Int32.TryParse(reponse, out prix);
                }
                while (!reussi);
                total += prix;
            }
            while (prix != 0);

            // On demande le paiement
            Console.WriteLine($"Le total à payer est de : {total} euros");
            do
            {
                if (insuffisant) // on gère l'affichage pour que l'utilisateur comprenne son erreur
                {
                    Console.WriteLine($"C'est insuffisant, vous devez payer {total} euros");
                    insuffisant = false;
                }
                Console.Write($"Entrer la somme versée : ");
                reponse = Console.ReadLine();
                reussi = Int32.TryParse(reponse, out sommeVersee);
                if (sommeVersee<total) insuffisant = true;
            }
            while (!reussi || insuffisant);

            // On gère le rendu de monnaie
            aRendre = sommeVersee - total;
            Console.WriteLine($"Vous allez percevoir {aRendre} euros");
            
            // Gestion comme un automate qui libère un billet à la fois
            // On rend des billets de 10 tant que c'est possible
            while (aRendre >= 10)
            {
                Console.WriteLine("Billet de 10 euros");
                aRendre -= 10;
            } 
            // il ne peut y avoir qu'un billet de 5
            if (aRendre >= 5)
            {
                Console.WriteLine("Billet de 5 euros");
                aRendre -= 5;
            }
            //On rend les pièces de 1 tant que c'est possible
            while (aRendre >= 1)
            {
                Console.WriteLine("Pièce de 1 euros");
                aRendre -= 1;
            } 
            */

            /***** Exercice 5.10 *****/
            /*
            // Déclaration
            int nbPartant, nbJoue, factoPartant=1, factoJoue=1, factoPartantMoinsJoue = 1,x, y;
            String reponse;
            Boolean reussi;
            
            // Initialisation
            do
            {
                Console.Write($"Entrer un nombre de chevaux partants: ");
                reponse = Console.ReadLine();
                reussi = Int32.TryParse(reponse, out nbPartant);

            }
            while (!reussi);
            do
            {
                Console.Write($"Entrer un nombre chevaux de joués: ");
                reponse = Console.ReadLine();
                reussi = Int32.TryParse(reponse, out nbJoue);

            }
            while (!reussi || nbJoue>nbPartant);

            // Calcul des factorielles
            for (int i = 1; i <= nbPartant; i++)
            {
                factoPartant *= i;
            }
            for (int i = 1; i <= nbJoue; i++)
            {
                factoJoue *= i;
            }
            for (int i = 1; i <= (nbPartant-nbJoue); i++)
            {
                factoPartantMoinsJoue *= i;
            }


            // Calcul de X
            x = factoPartant / factoPartantMoinsJoue;
            y = factoPartant / (factoJoue * factoPartantMoinsJoue);

            // Affichage
            Console.WriteLine($"Vous avez 1 chance sur {x} d'avoir les chevaux dans l'ordre");
            Console.WriteLine($"Vous avez 1 chance sur {y} d'avoir les chevaux dans le désordre");
            */
        }
    }
}
