using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /***** Exercice 4.1 *****/
            /*
            //Déclaration
            int tutu, toto;
            String tata, reponse;
            Boolean reussi;

            //Initialisation
            Console.Write("Entrer la valeur de tutu : ");
            reponse = Console.ReadLine();
            reussi = Int32.TryParse(reponse, out tutu);

            Console.Write("Entrer la valeur de toto : ");
            reponse = Console.ReadLine();
            reussi = Int32.TryParse(reponse, out toto);

            Console.Write("Entrer la valeur de tata : ");
            tata = Console.ReadLine();
            tata = tata.ToUpper(); // transformation en majuscule

            //Calcul
            if (tutu > toto + 4 || tata == "OK")
            {
                tutu++; // Equivalent à tutu = tutu +1
            }
            else
            {
                tutu--; // Equivalent à tutu = tutu -1
            }

            // Condition inversée
            if (tutu <= toto + 4 && tata != "OK")
            {
                tutu--; // Equivalent à tutu = tutu -1
            }
            else
            {
                tutu++; // Equivalent à tutu = tutu +1
            }
            */


            /***** Exercice 4.2 *****/
            /*
            //Déclaration
            int heure, minute;
            String reponse;
            Boolean reussi;

            //Initialisation
            Console.Write("Entrer la valeur de heure : ");
            reponse = Console.ReadLine();
            reussi = Int32.TryParse(reponse, out heure);

            Console.Write("Entrer la valeur de minute : ");
            reponse = Console.ReadLine();
            reussi = Int32.TryParse(reponse, out minute);


            // Calcul
            minute++;
            if (minute == 60)
            {
                minute = 0;
                heure++;
                if (heure == 24) // seul cas ou l'heure est égal à 24 c'est parce que je viens d'ajouter une heure
                {
                    heure = 0;
                }
            }

            Console.WriteLine($"Dans une minute, il sera {heure} heure(s) {minute} minute(s) ");
            */

            /***** Exercice 4.3 *****/
            /*
            //Déclaration
            int heure, minute, seconde;
            String reponse;
            Boolean reussi;

            //Initialisation
            Console.Write("Entrer la valeur de heure : ");
            reponse = Console.ReadLine();
            reussi = Int32.TryParse(reponse, out heure);

            Console.Write("Entrer la valeur de minute : ");
            reponse = Console.ReadLine();
            reussi = Int32.TryParse(reponse, out minute);

            Console.Write("Entrer la valeur de seconde : ");
            reponse = Console.ReadLine();
            reussi = Int32.TryParse(reponse, out seconde);


            seconde++;
            if (seconde == 60)
            {
                seconde = 0;
                minute++;
                if (minute == 60)
                {
                    minute = 0;
                    heure++;
                    if (heure == 24)
                    {
                        heure = 0;
                    }
                }
            }
            Console.WriteLine($"Dans une seconde, il sera {heure} heure(s) {minute} minute(s) et {seconde} seconde(s)");
            */


            /***** Exercice 4.4 *****/
            /*
            // Déclaration
            int nbCopies;
            String reponse;
            Boolean reussi;

            //Initialisation
            Console.Write("Entrer le nombre de copies : ");
            reponse = Console.ReadLine();
            reussi = Int32.TryParse(reponse, out nbCopies);

            if (nbCopies<=10)
            {
                Console.WriteLine($"La facture s'élève à {nbCopies *0.1} euros");
            }
            else if (nbCopies<=30)
            {
                Console.WriteLine($"La facture s'élève à {10 * 0.1 + (nbCopies-10)*0.09} euros");
            }
            else { 
                Console.WriteLine($"La facture s'élève à {10 * 0.1 + (30-10)*0.09 + (nbCopies - 30) * 0.08} euros"); 
            }
            */


            // Variante plus maintenable
            /*
            // Déclaration
            const int SEUIL1 = 10, SEUIL2 = 30;
            const Double TARIF1 = 0.1, TARIF2 = 0.09, TARIF3 = 0.008;
            int nbCopies;
            String reponse;
            Boolean reussi;

            //Initialisation
            Console.Write("Entrer le nombre de copies : ");
            reponse = Console.ReadLine();
            reussi = Int32.TryParse(reponse, out nbCopies);

            if (nbCopies <= SEUIL1)
            {
                Console.WriteLine($"La facture s'élève à {nbCopies * TARIF1} euros");
            }
            else if (nbCopies <= SEUIL2)
            {
                Console.WriteLine($"La facture s'élève à {SEUIL1 * TARIF1 + (nbCopies - SEUIL1) * TARIF2} euros");
            }
            else
            {
                Console.WriteLine($"La facture s'élève à {SEUIL1 * TARIF1 + (SEUIL2 - SEUIL1) * TARIF2 + (nbCopies - SEUIL2) * TARIF3} euros");
            }
            */


            /***** Exercice 4.5 *****/
            /*
            //Déclaration
            int age;
            String reponse,genre;
            Boolean reussi;


            //Initialisation
            Console.Write("Entrer votre age : ");
            reponse = Console.ReadLine();
            reussi = Int32.TryParse(reponse, out age);

            Console.Write("Entrer votre genre (M ou F) : ");
            genre = Console.ReadLine();
            genre = genre.ToUpper(); // transformation de la reponse en majuscule

            // Calcul
            if ((genre=="M" && age >20) || (genre=="F" && age>18 && age<35))
            {
                Console.WriteLine("Vous devez payer l'impôt");
            }
            else
            {
                Console.WriteLine("Vous NE devez PAS payer l'impôt");
            }
            */

            /***** Exercice 4.6 *****/
            /*
            //Déclaration
            int voixA, voixB, voixC, voixD, total;
            Double pourcentA, pourcentB, pourcentC, pourcentD;
            String reponse;
            Boolean reussi;

            //Initialisation
            Console.Write("Entrer le nombre de voix de A : ");
            reponse = Console.ReadLine();
            reussi = Int32.TryParse(reponse, out voixA);

            Console.Write("Entrer le nombre de voix de B : ");
            reponse = Console.ReadLine();
            reussi = Int32.TryParse(reponse, out voixB);

            Console.Write("Entrer le nombre de voix de C : ");
            reponse = Console.ReadLine();
            reussi = Int32.TryParse(reponse, out voixC);

            Console.Write("Entrer le nombre de voix de D : ");
            reponse = Console.ReadLine();
            reussi = Int32.TryParse(reponse, out voixD);

            // Calcul des pourcentages
            total = voixA + voixB + voixC + voixD;
            pourcentA = voixA / total * 100;
            pourcentB = voixB / total * 100;
            pourcentC = voixC / total * 100;
            pourcentD = voixD / total * 100;

            // Calcul
            if (pourcentA > 50)
            {
                Console.WriteLine($"Le candidat A a gagné avec {pourcentA} voix");
            }
            else if (pourcentA < 12.5 || pourcentB > 50 || pourcentC > 50 || pourcentD > 50)
            { // Il perd s'il a moins de 12.5 ou si un autre gagne
                Console.WriteLine($"Le candidat A a perdu avec {pourcentA} voix");
            }
            else if (pourcentA > pourcentB && pourcentA > pourcentC && pourcentA > pourcentD)
            {
                Console.WriteLine($"Le candidat A est en ballotage favorable avec {pourcentA} voix");
            }
            else Console.WriteLine($"Le candidat A est en ballotage défavorable avec {pourcentA} voix");
            */


            /***** Exercice 4.7 ****/
            /*
            //Déclaration
            int age, permis, accident, fidelite, point = 0;
            String reponse;
            Boolean reussi;

            //Initialisation
            Console.Write("Entrer votre age : ");
            reponse = Console.ReadLine();
            reussi = Int32.TryParse(reponse, out age);

            Console.Write("Entrer le nombre d'année de permis : ");
            reponse = Console.ReadLine();
            reussi = Int32.TryParse(reponse, out permis);

            Console.Write("Entrer le nombre d'accident : ");
            reponse = Console.ReadLine();
            reussi = Int32.TryParse(reponse, out accident);

            Console.Write("Entrer le nombre d'année dans notre agence : ");
            reponse = Console.ReadLine();
            reussi = Int32.TryParse(reponse, out fidelite);

            // Calcul
            if (age > 25) point++;
            if (permis > 2) point++;
            point -= accident; // équivalent à point = point - accident
            if (point >= 0 && fidelite > 1) point++;
            switch (point)
            {
                case 0:
                    Console.WriteLine("Vous beneficié du tarif rouge");
                    break;
                case 1:
                    Console.WriteLine("Vous beneficié du tarif orange");
                    break;
                case 2:
                    Console.WriteLine("Vous beneficié du tarif vert");
                    break;
                case 3:
                    Console.WriteLine("Vous beneficié du tarif bleu");
                    break;
                default:
                    Console.WriteLine("Vous ne pouvez pas être assuré");
                    break;
            }
            */
        }
    }
}
