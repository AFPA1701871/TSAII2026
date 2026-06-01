using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PENDU
{
    class Program
    {
        static void Main(string[] args)
        {
            string reponse;
            do
            {
                LancerPartie();
                Console.WriteLine("Voulez vous rejouer? ");
                reponse = Console.ReadLine();
            } while (reponse == "N");
            Console.ReadLine();
        }

        //methode qui lance et gère une partie
        static void LancerPartie()
        {
            char lettre;
            string motATrouver = null;
            char[] tabMasque = null;
            char[] tabReste = null;
            int nbErreur = 0;
            int resultat;
            List<int> listeDesPositions = new List<int>();
            List<char> listeMauvaisesLettres = new List<char>();

            CentrerLeTexte("--- Bienvenue dans le jeu du pendu ---");
            motATrouver = MotHasard();
            Console.WriteLine("mot a trouver " + motATrouver); //Affiche le mot à trouver
            tabReste = new char[motATrouver.Length]; // on définit le tableau reste qui prend la longueur du mot à trouver
            tabReste = motATrouver.ToCharArray(); // TabReste contient le mot à trouver convertit en caractère
            tabMasque = new char[motATrouver.Length];// on définit le tableau masque qui prend la longueur du mot à trouver
            tabMasque = coderMot(motATrouver);
            do 
            {
                Console.WriteLine(" Voici votre progression: " + TabEnString(tabMasque, true));
                lettre = DemanderLettre(); //Utilise la méthode demanderLettre dans la classe Affichage pour demander une lettre à l'utilisateur que l'on stocke dans Lettre 
                listeDesPositions = testerLettre(lettre, tabReste); //Utilise la méthode positLettreDTableau qui a besoin du reste du tableau et d'une lettre pour être dans la liste de positions
                if (listeDesPositions.Count == 0)
                {
                    listeMauvaisesLettres.Add(lettre);
                    nbErreur++;
                }
                else
                {
                    tabMasque=ajouterLesLettres(lettre, tabMasque, listeDesPositions);
                    tabReste=retirerLesLettres(tabReste, listeDesPositions);
                }
                Console.Clear();
                afficherMauvaisesLettres(listeMauvaisesLettres);
                DessinerPendu(nbErreur);
                resultat = TesterGagner(nbErreur, tabMasque);
                switch (resultat)
                {
                    case 1: Console.WriteLine("Vous avez gagné, le mot à trouver était : " + motATrouver); break;
                    case -1: Console.WriteLine("Vous avez perdu, le mot à trouver était : " + motATrouver); break;
                    default: break;
                }
            }
            while (resultat == 0); // pas gagné et pas perdu

        }

        private static void CentrerLeTexte(string texte)
        // Permet d'afficher un texte centré sur la console
        {
            int nbEspaces = (Console.WindowWidth - texte.Length) / 2;
            Console.SetCursorPosition(nbEspaces, Console.CursorTop);
            Console.WriteLine(texte);
        }


        // méthode qui permet de transformer un tableau de caractères passé en paramètre en une chaine de caractères. Chaque lettre sera séparée d'un espace si le 2eme paramètre contient vrai.
        public static string TabEnString(char[] tab, bool avecEspace)
        {
            string resultat = "";

            for (int i = 0; i < tab.Length; i++) // on parcours le tableau
            {
                if (avecEspace)// si on doit ajouter un espace
                {
                    resultat = resultat + tab[i] + " "; // on ajoute la lettre puis un espace
                }
                else
                {
                    resultat = resultat + tab[i];// on ajoute uniquement la lettre
                }
            }
            return resultat;
        }



        // méthode qui prend un mot en paramètre d'entrée et qui renvoi un tableau de caractères contenant autant de case que de lettres dans le mot. Chacune de ces cases contient un _
        static public char[] coderMot(string mot)
        {
            char[] tab = new char[mot.Length]; //: on crée un tableau de caractères à la taille du mot
            for (int i = 0; i < mot.Length; i++)
            {
                tab[i] = '_'; //on remplit chaque case de _           
            }
            return tab;
        }

        // méthode qui permet d'afficher le tableau passé en paramètre
        static void afficherTableau(char[] tab)
        {//on utilise la mèthode qui transforme un tableau en chaine, sans mettre d'espace, puis on l'affiche

            Console.WriteLine(TabEnString(tab, false));
        }



        // méthode qui renvoi un mot en le choisissant au hasard parmi une liste de mots
        static string MotHasard()
        {

            List<string> listeMots = new List<string>();
            string motAChercher;
            Random alea = new Random(DateTime.Now.Millisecond);

            listeMots.Add("aeroport"); listeMots.Add("cerceau"); listeMots.Add("deuxieme"); listeMots.Add("flotter"); listeMots.Add("maitre"); listeMots.Add("plage"); listeMots.Add("sale"); listeMots.Add("trompette"); listeMots.Add("affaire"); listeMots.Add("chaine"); listeMots.Add("devant"); listeMots.Add("fois"); listeMots.Add("maitresse"); listeMots.Add("planche"); listeMots.Add("salle"); listeMots.Add("trop"); listeMots.Add("album"); listeMots.Add("chaise"); listeMots.Add("dictionnaire"); listeMots.Add("fonce"); listeMots.Add("mal"); listeMots.Add("plâtre"); listeMots.Add("saut"); listeMots.Add("trouer"); listeMots.Add("alphabet"); listeMots.Add("chaises"); listeMots.Add("difference"); listeMots.Add("fond"); listeMots.Add("maladroit"); listeMots.Add("pleuvoir"); listeMots.Add("sauter"); listeMots.Add("trous"); listeMots.Add("amener"); listeMots.Add("chanson"); listeMots.Add("different"); listeMots.Add("football"); listeMots.Add("manche"); listeMots.Add("pli"); listeMots.Add("savon"); listeMots.Add("trousse"); listeMots.Add("ampoule"); listeMots.Add("chapeau"); listeMots.Add("difficile"); listeMots.Add("fort"); listeMots.Add("manquer"); listeMots.Add("pliage"); listeMots.Add("scie"); listeMots.Add("tunnel"); listeMots.Add("ancien"); listeMots.Add("charger"); listeMots.Add("dire"); listeMots.Add("fouiller"); listeMots.Add("manteau"); listeMots.Add("plier"); listeMots.Add("seau"); listeMots.Add("un"); listeMots.Add("anorak"); listeMots.Add("chat"); listeMots.Add("directeur"); listeMots.Add("frapper"); listeMots.Add("marche"); listeMots.Add("plongeoir"); listeMots.Add("sec"); listeMots.Add("uniforme"); listeMots.Add("antenne"); listeMots.Add("chaud"); listeMots.Add("directrice"); listeMots.Add("frein"); listeMots.Add("marionnette"); listeMots.Add("plonger"); listeMots.Add("secher"); listeMots.Add("use"); listeMots.Add("appareil"); listeMots.Add("chaussette"); listeMots.Add("discuter"); listeMots.Add("froid"); listeMots.Add("marteau"); listeMots.Add("pluie"); listeMots.Add("semelle"); listeMots.Add("vache"); listeMots.Add("apporter"); listeMots.Add("chausson"); listeMots.Add("disparaitre"); listeMots.Add("fusee"); listeMots.Add("matelas"); listeMots.Add("plus"); listeMots.Add("sens"); listeMots.Add("valise"); listeMots.Add("appuyer"); listeMots.Add("chaussure"); listeMots.Add("distribuer"); listeMots.Add("fusil"); listeMots.Add("maternelle"); listeMots.Add("pneu"); listeMots.Add("sentir"); listeMots.Add("vase"); listeMots.Add("apres"); listeMots.Add("chemise"); listeMots.Add("dix"); listeMots.Add("gagner"); listeMots.Add("melanger"); listeMots.Add("poche"); listeMots.Add("separer"); listeMots.Add("vehicule"); listeMots.Add("arc"); listeMots.Add("chercher"); listeMots.Add("doigt"); listeMots.Add("gant"); listeMots.Add("meme"); listeMots.Add("poignet"); listeMots.Add("sept"); listeMots.Add("venir"); listeMots.Add("armoire"); listeMots.Add("cheville"); listeMots.Add("doigts"); listeMots.Add("garage"); listeMots.Add("mensonge"); listeMots.Add("poing"); listeMots.Add("serieux"); listeMots.Add("ventre"); listeMots.Add("arret"); listeMots.Add("chiffre"); listeMots.Add("domino"); listeMots.Add("garçon"); listeMots.Add("mesurer"); listeMots.Add("point"); listeMots.Add("serpent"); listeMots.Add("verre"); listeMots.Add("arriere"); listeMots.Add("choisir"); listeMots.Add("donner"); listeMots.Add("garder"); listeMots.Add("metal"); listeMots.Add("pointe"); listeMots.Add("serre"); listeMots.Add("vers"); listeMots.Add("arriver"); listeMots.Add("chose"); listeMots.Add("dormir"); listeMots.Add("gardien"); listeMots.Add("metre"); listeMots.Add("pointu"); listeMots.Add("serrer"); listeMots.Add("verser"); listeMots.Add("arroser"); listeMots.Add("chuchoter"); listeMots.Add("dos"); listeMots.Add("gare"); listeMots.Add("mettre"); listeMots.Add("poisson"); listeMots.Add("serrure"); listeMots.Add("vert"); listeMots.Add("assiette"); listeMots.Add("chute"); listeMots.Add("dossier"); listeMots.Add("gauche"); listeMots.Add("meuble"); listeMots.Add("poli"); listeMots.Add("serviette"); listeMots.Add("veste"); listeMots.Add("assis"); listeMots.Add("cigarette"); listeMots.Add("douche"); listeMots.Add("gener"); listeMots.Add("micro"); listeMots.Add("pompiers"); listeMots.Add("servir"); listeMots.Add("vetement"); listeMots.Add("attacher"); listeMots.Add("cinq"); listeMots.Add("doucher"); listeMots.Add("genou"); listeMots.Add("mieux"); listeMots.Add("pont"); listeMots.Add("seul"); listeMots.Add("vider"); listeMots.Add("attendre"); listeMots.Add("ciseaux"); listeMots.Add("doux"); listeMots.Add("gentil"); listeMots.Add("milieu"); listeMots.Add("porte"); listeMots.Add("siege"); listeMots.Add("virage");
            listeMots.Add("attention"); listeMots.Add("classe"); listeMots.Add("droit"); listeMots.Add("glisser"); listeMots.Add("mine"); listeMots.Add("portemanteau"); listeMots.Add("sieste"); listeMots.Add("vis"); listeMots.Add("atterrir"); listeMots.Add("clavier"); listeMots.Add("du"); listeMots.Add("golf"); listeMots.Add("modele"); listeMots.Add("porter"); listeMots.Add("silence"); listeMots.Add("vite"); listeMots.Add("attraper"); listeMots.Add("cle"); listeMots.Add("dur"); listeMots.Add("gomme"); listeMots.Add("moins"); listeMots.Add("poser"); listeMots.Add("six"); listeMots.Add("vitesse"); listeMots.Add("au"); listeMots.Add("clou"); listeMots.Add("eau"); listeMots.Add("gonfler"); listeMots.Add("montagne"); listeMots.Add("poster"); listeMots.Add("sol"); listeMots.Add("vitre"); listeMots.Add("autant"); listeMots.Add("cœur"); listeMots.Add("ecarter"); listeMots.Add("gouter"); listeMots.Add("monter"); listeMots.Add("pot"); listeMots.Add("soldat"); listeMots.Add("voiture");
            listeMots.Add("auto"); listeMots.Add("coin"); listeMots.Add("echanger"); listeMots.Add("gouttes"); listeMots.Add("montrer"); listeMots.Add("poubelle"); listeMots.Add("solide"); listeMots.Add("voix"); listeMots.Add("automobiliste"); listeMots.Add("col"); listeMots.Add("echarpe"); listeMots.Add("grand"); listeMots.Add("morceau"); listeMots.Add("pouce"); listeMots.Add("sommeil"); listeMots.Add("voler"); listeMots.Add("autoradio"); listeMots.Add("colere"); listeMots.Add("echasses"); listeMots.Add("grimper"); listeMots.Add("mot"); listeMots.Add("pousser"); listeMots.Add("sonner"); listeMots.Add("vouloir"); listeMots.Add("autour"); listeMots.Add("collant"); listeMots.Add("echelle"); listeMots.Add("gris"); listeMots.Add("moteur"); listeMots.Add("pouvoir"); listeMots.Add("sonnette"); listeMots.Add("voyage"); listeMots.Add("avancer"); listeMots.Add("colle"); listeMots.Add("eclabousser"); listeMots.Add("gronder"); listeMots.Add("moto"); listeMots.Add("premier"); listeMots.Add("sorciere"); listeMots.Add("wagon");
            listeMots.Add("avant"); listeMots.Add("coller"); listeMots.Add("eclairer"); listeMots.Add("gros"); listeMots.Add("mouchoir"); listeMots.Add("prendre"); listeMots.Add("sortie"); listeMots.Add("xylophone"); listeMots.Add("avec"); listeMots.Add("coloriage"); listeMots.Add("ecole"); listeMots.Add("groupe"); listeMots.Add("moufle"); listeMots.Add("prenom"); listeMots.Add("sortir"); listeMots.Add("zero"); listeMots.Add("avion"); listeMots.Add("colorier"); listeMots.Add("ecouter"); listeMots.Add("grue"); listeMots.Add("mouille"); listeMots.Add("preparer"); listeMots.Add("souffler"); listeMots.Add("zigzag"); listeMots.Add("bagage"); listeMots.Add("commencer"); listeMots.Add("ecran"); listeMots.Add("gymnastique"); listeMots.Add("mouiller"); listeMots.Add("pres"); listeMots.Add("soulever"); listeMots.Add("baguette"); listeMots.Add("comparer"); listeMots.Add("ecraser"); listeMots.Add("habit"); listeMots.Add("moulin"); listeMots.Add("present"); listeMots.Add("souligner"); listeMots.Add("baigner"); listeMots.Add("compter"); listeMots.Add("ecrire"); listeMots.Add("hanche"); listeMots.Add("mousse"); listeMots.Add("presque"); listeMots.Add("souple"); listeMots.Add("bâiller"); listeMots.Add("conduire"); listeMots.Add("ecriture"); listeMots.Add("handicape"); listeMots.Add("moyen"); listeMots.Add("presser"); listeMots.Add("sourd"); listeMots.Add("balle"); listeMots.Add("construire"); listeMots.Add("effacer"); listeMots.Add("haut"); listeMots.Add("muet"); listeMots.Add("preter"); listeMots.Add("sourire"); listeMots.Add("banc"); listeMots.Add("conte"); listeMots.Add("effort"); listeMots.Add("helicoptere"); listeMots.Add("multicolore"); listeMots.Add("prince"); listeMots.Add("sous"); listeMots.Add("barbe"); listeMots.Add("continuer"); listeMots.Add("elastique"); listeMots.Add("hexagone"); listeMots.Add("mur"); listeMots.Add("prises"); listeMots.Add("spaghetti"); listeMots.Add("barboter"); listeMots.Add("contraire"); listeMots.Add("electricite"); listeMots.Add("histoire"); listeMots.Add("muscle"); listeMots.Add("priver"); listeMots.Add("sport");
            listeMots.Add("barque"); listeMots.Add("contre"); listeMots.Add("eleve"); listeMots.Add("horloge"); listeMots.Add("musique"); listeMots.Add("promettre"); listeMots.Add("stylo"); listeMots.Add("barre"); listeMots.Add("copain"); listeMots.Add("emmener"); listeMots.Add("huit"); listeMots.Add("nager"); listeMots.Add("propre"); listeMots.Add("suivant"); listeMots.Add("barreau"); listeMots.Add("copier"); listeMots.Add("emporter"); listeMots.Add("humide"); listeMots.Add("nenuphar"); listeMots.Add("punaise"); listeMots.Add("suivre"); listeMots.Add("bas"); listeMots.Add("coquillage"); listeMots.Add("encore"); listeMots.Add("idee"); listeMots.Add("neuf"); listeMots.Add("punir"); listeMots.Add("sur"); listeMots.Add("bateau"); listeMots.Add("coquillette"); listeMots.Add("enerve"); listeMots.Add("ile"); listeMots.Add("nœud"); listeMots.Add("puzzle"); listeMots.Add("surfeur");
            listeMots.Add("beaucoup"); listeMots.Add("coquin"); listeMots.Add("enfant"); listeMots.Add("image"); listeMots.Add("noir"); listeMots.Add("pyjama"); listeMots.Add("table"); listeMots.Add("bibliotheque"); listeMots.Add("corde"); listeMots.Add("enfiler"); listeMots.Add("imiter"); listeMots.Add("nom"); listeMots.Add("pyramide"); listeMots.Add("tableau"); listeMots.Add("blanc"); listeMots.Add("corps"); listeMots.Add("enfoncer"); listeMots.Add("immeuble"); listeMots.Add("nombre"); listeMots.Add("quai"); listeMots.Add("tablier"); listeMots.Add("bleu"); listeMots.Add("cote"); listeMots.Add("engin"); listeMots.Add("immobile"); listeMots.Add("nouveau"); listeMots.Add("quatre"); listeMots.Add("tabouret"); listeMots.Add("bois"); listeMots.Add("cou"); listeMots.Add("enlever"); listeMots.Add("inonder"); listeMots.Add("nu"); listeMots.Add("question"); listeMots.Add("tache");
            listeMots.Add("boite"); listeMots.Add("couche"); listeMots.Add("entendre"); listeMots.Add("inseparable"); listeMots.Add("numero"); listeMots.Add("raconter"); listeMots.Add("taille"); listeMots.Add("bondir"); listeMots.Add("coude"); listeMots.Add("entonnoir"); listeMots.Add("instrument"); listeMots.Add("obeir"); listeMots.Add("radiateur"); listeMots.Add("tailler"); listeMots.Add("bonnet"); listeMots.Add("coudre"); listeMots.Add("entourer"); listeMots.Add("interessant"); listeMots.Add("objet"); listeMots.Add("radio"); listeMots.Add("talon"); listeMots.Add("bord"); listeMots.Add("couleur"); listeMots.Add("entree"); listeMots.Add("interieur"); listeMots.Add("obliger"); listeMots.Add("rame"); listeMots.Add("tambour"); listeMots.Add("bosser"); listeMots.Add("couloir"); listeMots.Add("entrer"); listeMots.Add("intrus"); listeMots.Add("ongle"); listeMots.Add("rampe"); listeMots.Add("tampon"); listeMots.Add("botte"); listeMots.Add("couper"); listeMots.Add("enveloppe"); listeMots.Add("jaloux"); listeMots.Add("orchestre"); listeMots.Add("ramper"); listeMots.Add("taper"); listeMots.Add("boucher"); listeMots.Add("courir"); listeMots.Add("envoyer"); listeMots.Add("jambes"); listeMots.Add("ordinateur"); listeMots.Add("ranger"); listeMots.Add("tapis"); listeMots.Add("bouchon"); listeMots.Add("couronne"); listeMots.Add("epais"); listeMots.Add("jaune"); listeMots.Add("ordre"); listeMots.Add("rater"); listeMots.Add("tard"); listeMots.Add("bouder"); listeMots.Add("court"); listeMots.Add("epaule"); listeMots.Add("jean"); listeMots.Add("ours"); listeMots.Add("rayure"); listeMots.Add("tasse"); listeMots.Add("bouger"); listeMots.Add("craie"); listeMots.Add("epee"); listeMots.Add("jeu"); listeMots.Add("outil"); listeMots.Add("recevoir"); listeMots.Add("telecommande"); listeMots.Add("bousculer"); listeMots.Add("cravate"); listeMots.Add("equipe"); listeMots.Add("joli"); listeMots.Add("ouvrir"); listeMots.Add("reciter"); listeMots.Add("telephone"); listeMots.Add("bout"); listeMots.Add("crochet"); listeMots.Add("escabeau"); listeMots.Add("jouer"); listeMots.Add("page"); listeMots.Add("recommencer"); listeMots.Add("television"); listeMots.Add("bouteille"); listeMots.Add("cube"); listeMots.Add("escalader"); listeMots.Add("jouet"); listeMots.Add("paire"); listeMots.Add("recreation"); listeMots.Add("tendre"); listeMots.Add("bouton"); listeMots.Add("cuillere"); listeMots.Add("escalier"); listeMots.Add("jupe"); listeMots.Add("panne"); listeMots.Add("reculer"); listeMots.Add("tenir"); listeMots.Add("bras"); listeMots.Add("cuisse"); listeMots.Add("escargot"); listeMots.Add("lac"); listeMots.Add("pantalon"); listeMots.Add("refuser"); listeMots.Add("tennis"); listeMots.Add("bretelle"); listeMots.Add("culotte"); listeMots.Add("escarpin"); listeMots.Add("lacer"); listeMots.Add("papier"); listeMots.Add("regarder"); listeMots.Add("terminer"); listeMots.Add("bricolage"); listeMots.Add("curieux"); listeMots.Add("essuyer"); listeMots.Add("lacet"); listeMots.Add("parachute"); listeMots.Add("reine"); listeMots.Add("tete"); listeMots.Add("bruit"); listeMots.Add("cuvette"); listeMots.Add("etagere"); listeMots.Add("laine"); listeMots.Add("parcours"); listeMots.Add("remettre"); listeMots.Add("tirer"); listeMots.Add("brun"); listeMots.Add("dame"); listeMots.Add("etang"); listeMots.Add("laisser"); listeMots.Add("pareil"); listeMots.Add("remplacer"); listeMots.Add("tiroir"); listeMots.Add("bulles"); listeMots.Add("danger"); listeMots.Add("etiquette"); listeMots.Add("large"); listeMots.Add("parking"); listeMots.Add("remplir"); listeMots.Add("tissu"); listeMots.Add("bureau"); listeMots.Add("dans"); listeMots.Add("etroit"); listeMots.Add("lavabo"); listeMots.Add("parler"); listeMots.Add("rentree"); listeMots.Add("titre"); listeMots.Add("cabane"); listeMots.Add("danser"); listeMots.Add("etude"); listeMots.Add("laver"); listeMots.Add("partager"); listeMots.Add("rentrer"); listeMots.Add("toboggan"); listeMots.Add("cabinet"); listeMots.Add("de"); listeMots.Add("etudier"); listeMots.Add("lecture"); listeMots.Add("partir"); listeMots.Add("renverser"); listeMots.Add("toilette"); listeMots.Add("cagoule"); listeMots.Add("deborder"); listeMots.Add("expliquer"); listeMots.Add("lettre"); listeMots.Add("pas"); listeMots.Add("reparer"); listeMots.Add("tomber"); listeMots.Add("cahier"); listeMots.Add("debout"); listeMots.Add("exterieur"); listeMots.Add("lierre"); listeMots.Add("passerelle"); listeMots.Add("repeter"); listeMots.Add("tordu"); listeMots.Add("caisse"); listeMots.Add("dechirer"); listeMots.Add("fabriquer"); listeMots.Add("ligne"); listeMots.Add("patauger"); listeMots.Add("repondre"); listeMots.Add("tot"); listeMots.Add("calme"); listeMots.Add("decoller"); listeMots.Add("facile"); listeMots.Add("linge"); listeMots.Add("pedalo"); listeMots.Add("respirer"); listeMots.Add("toucher"); listeMots.Add("camarade"); listeMots.Add("decorer"); listeMots.Add("faire"); listeMots.Add("lire"); listeMots.Add("peindre"); listeMots.Add("ressembler"); listeMots.Add("tour"); listeMots.Add("camescope"); listeMots.Add("decoupage"); listeMots.Add("fatigue"); listeMots.Add("lisse"); listeMots.Add("peinture"); listeMots.Add("rester"); listeMots.Add("tourner"); listeMots.Add("camion"); listeMots.Add("decouper"); listeMots.Add("faute"); listeMots.Add("liste"); listeMots.Add("peluche"); listeMots.Add("retard"); listeMots.Add("tournevis"); listeMots.Add("canard"); listeMots.Add("dedans"); listeMots.Add("fauteuil"); listeMots.Add("lit"); listeMots.Add("pente"); listeMots.Add("reussir"); listeMots.Add("train"); listeMots.Add("carnet"); listeMots.Add("defendre"); listeMots.Add("fee"); listeMots.Add("litre"); listeMots.Add("percer"); listeMots.Add("revenir"); listeMots.Add("trait"); listeMots.Add("carreau"); listeMots.Add("dehors"); listeMots.Add("fenetre"); listeMots.Add("livre"); listeMots.Add("perdre"); listeMots.Add("rideau"); listeMots.Add("trampoline"); listeMots.Add("cartable"); listeMots.Add("deltaplane"); listeMots.Add("fermer"); listeMots.Add("loin"); listeMots.Add("perle"); listeMots.Add("robe"); listeMots.Add("tranquille"); listeMots.Add("carton"); listeMots.Add("demander"); listeMots.Add("fesse"); listeMots.Add("long"); listeMots.Add("personne"); listeMots.Add("robinet"); listeMots.Add("transparent"); listeMots.Add("casier"); listeMots.Add("demarrer"); listeMots.Add("feu"); listeMots.Add("lumiere"); listeMots.Add("petit"); listeMots.Add("roi"); listeMots.Add("transpirer"); listeMots.Add("casque"); listeMots.Add("demolir"); listeMots.Add("feuille"); listeMots.Add("lunettes"); listeMots.Add("peu"); listeMots.Add("rond"); listeMots.Add("transporter"); listeMots.Add("casquette"); listeMots.Add("depasser"); listeMots.Add("feutre"); listeMots.Add("madame"); listeMots.Add("peur"); listeMots.Add("roue"); listeMots.Add("travail"); listeMots.Add("casse"); listeMots.Add("dernier"); listeMots.Add("ficelle"); listeMots.Add("magazine"); listeMots.Add("photo"); listeMots.Add("rouge"); listeMots.Add("travailler"); listeMots.Add("casser"); listeMots.Add("derriere"); listeMots.Add("fil"); listeMots.Add("magicien"); listeMots.Add("pied"); listeMots.Add("roulade"); listeMots.Add("traverser"); listeMots.Add("casserole"); listeMots.Add("descendre"); listeMots.Add("filet"); listeMots.Add("magie"); listeMots.Add("pieds"); listeMots.Add("rouler"); listeMots.Add("tremper"); listeMots.Add("cassette"); listeMots.Add("desobeir"); listeMots.Add("fille"); listeMots.Add("magnetoscope"); listeMots.Add("pilote"); listeMots.Add("roux"); listeMots.Add("tricher"); listeMots.Add("catalogue"); listeMots.Add("dessin"); listeMots.Add("film"); listeMots.Add("maillot"); listeMots.Add("pinceau"); listeMots.Add("ruban"); listeMots.Add("tricot"); listeMots.Add("cede"); listeMots.Add("dessiner"); listeMots.Add("finir"); listeMots.Add("main"); listeMots.Add("pion"); listeMots.Add("rugueux"); listeMots.Add("trier"); listeMots.Add("cederom"); listeMots.Add("detruire"); listeMots.Add("fleche"); listeMots.Add("mains"); listeMots.Add("placard"); listeMots.Add("sage"); listeMots.Add("trois"); listeMots.Add("ceinture"); listeMots.Add("deux"); listeMots.Add("fleur"); listeMots.Add("maison"); listeMots.Add("plafond"); listeMots.Add("saladier"); listeMots.Add("troisieme");

            motAChercher = listeMots.ElementAt(alea.Next(0, listeMots.Count));
            return motAChercher.ToUpper();
        }

        
        // méthode qui cherche toutes les occurrences d'une lettre passée en paramètre dans un tableau de caractères passé aussi en paramètre. Cette méthode retourne toutes les positions dans une liste
        static List<int> testerLettre(char lettre, char[] tab)
        // méthode qui chercher toutes les occurrences d'une lettre passée en paramètre dans un tableau de caractères passé en paramètre. Cette méthode retourne toutes les positions dans une liste
        {
            List<int> liste = new List<int>();
            for (int i = 0; i < tab.Length; i++) // on parcours le tableau de caractères 
            {
                if (tab[i] == lettre) // si le caractère correspond à la lettre cherchée, on ajoute un élément à la liste
                {
                    liste.Add(i);
                }
            }
            return liste;
        }

        static char[] ajouterUneLettre(char lettre, char[] tab, int position)
        //méthode qui modifie le tableau de caractères passé en paramètre en affectant la lettre à la position passée en paramètre
        {
            tab[position] = lettre; // on affecte la lettre à la position du tableau 
            return tab;
        }

        static char[] ajouterLesLettres(char lettre, char[] tab, List<int> listePosition)
        //méthode qui appelle la méthode ajouterUneLettre pour toutes les valeurs contenues dans la liste en paramètre
        {
            foreach (int l in listePosition) // pour chacune des positions de la liste, on appele la méthode qui place une lettre
            {
                tab = ajouterUneLettre(lettre, tab, l);
            }
            return tab;
        }
        static char[] retirerUneLettre(char[] tab, int position)
        //méthode qui modifie le tableau de caractères passé en paramètre en affectant la lettre à la position passée en paramètre
        {
            tab[position] = '_'; // on affecte la lettre à la position du tableau 
            return tab;
        }

        static char[] retirerLesLettres(char[] tab, List<int> listePosition)
        //méthode qui appelle la méthode ajouterUneLettre pour toutes les valeurs contenues dans la liste en paramètre
        {
            foreach (int l in listePosition) // pour chacune des positions de la liste, on appele la méthode qui place une lettre
            {
                tab = retirerUneLettre(tab, l);
            }
            return tab;
        }

        static void afficherMauvaisesLettres(List<char> listeLettres)
        // méthode qui permet d'afficher les caractères contenus dans la liste passée en paramètre à l'écran
        {
            string resultat = "";
            int taille;
            foreach (char lettre in listeLettres)
            {
                resultat += lettre + ",";
            }


            taille = resultat.Length;
            if (taille > 0)
            {
                resultat = resultat.Substring(0, taille - 1);
                Console.WriteLine("Les lettres non présentes sont " + resultat);
            }
        }

        // méthode qui demande une lettre à l’utilisateur, elle vérifie que le caractère saisi est une lettre et le renvoi en majuscule.
        public static char DemanderLettre()
        // méthode qui demande une lettre à l’utilisateur, elle vérifie que le caractère saisi est une lettre et le renvoi en majuscule
        {
            string lecture;
            bool saisieOK = false;
            do
            {
                Console.WriteLine("Veuillez saisir une lettre :");
                lecture = Console.ReadLine(); // on lit une chaine de caractère saisie par l'utilisateur
                if (Char.IsLetter(lecture[0])) //on teste si la 1ere lettre saisie par l'utilisateur est un caractère
                {
                    saisieOK = true;
                }
            } while (!saisieOK);
            return char.ToUpper(lecture[0]); //on renvoi le 1er caractère de la saisie
        }


        //méthode qui permet de dessiner le pendu en fonction du nombre d’erreur
        static void DessinerPendu(int nbErreur)
        // Dessine le pendu en fonction du nombre d'erreur
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.BackgroundColor = ConsoleColor.Yellow;
            // permet d'ecrire en bleu foncé
            switch (nbErreur)
            {
                case 0:
                    Console.WriteLine("                      ");
                    Console.WriteLine("                      ");
                    Console.WriteLine("                      ");
                    Console.WriteLine("                      ");
                    Console.WriteLine("                      ");
                    Console.WriteLine("                      ");
                    Console.WriteLine("                      ");
                    Console.WriteLine("                      ");
                    break;
                case 1:
                    Console.WriteLine("                      ");
                    Console.WriteLine("                      ");
                    Console.WriteLine("                      ");
                    Console.WriteLine("                      ");
                    Console.WriteLine("                      ");
                    Console.WriteLine("                      ");
                    Console.WriteLine("                      ");
                    Console.WriteLine("     ________         ");
                    break;
                case 2:
                    Console.WriteLine("                       ");
                    Console.WriteLine("      |                ");
                    Console.WriteLine("      |                ");
                    Console.WriteLine("      |                ");
                    Console.WriteLine("      |                ");
                    Console.WriteLine("      |                ");
                    Console.WriteLine("      |                ");
                    Console.WriteLine("     _|_______         ");
                    break;
                case 3:
                    Console.WriteLine("     ________          ");
                    Console.WriteLine("      |                ");
                    Console.WriteLine("      |                ");
                    Console.WriteLine("      |                ");
                    Console.WriteLine("      |                ");
                    Console.WriteLine("      |                ");
                    Console.WriteLine("      |                ");
                    Console.WriteLine("     _|_______         ");
                    break;
                case 4:
                    Console.WriteLine("     ________          ");
                    Console.WriteLine("      |     |          ");
                    Console.WriteLine("      |                ");
                    Console.WriteLine("      |                ");
                    Console.WriteLine("      |                ");
                    Console.WriteLine("      |                ");
                    Console.WriteLine("      |                ");
                    Console.WriteLine("     _|_______         ");
                    break;
                case 5:
                    Console.WriteLine("     ________          ");
                    Console.WriteLine("      |     |          ");
                    Console.WriteLine("      |     O          ");
                    Console.WriteLine("      |                ");
                    Console.WriteLine("      |                ");
                    Console.WriteLine("      |                ");
                    Console.WriteLine("      |                ");
                    Console.WriteLine("     _|_______         ");
                    break;
                case 6:
                    Console.WriteLine("     ________          ");
                    Console.WriteLine("      |     |          ");
                    Console.WriteLine("      |     O          ");
                    Console.WriteLine("      |     |          ");
                    Console.WriteLine("      |     |          ");
                    Console.WriteLine("      |                ");
                    Console.WriteLine("      |                ");
                    Console.WriteLine("     _|_______         ");
                    break;
                case 7:
                    Console.WriteLine("     ________          ");
                    Console.WriteLine("      |     |          ");
                    Console.WriteLine("      |     O          ");
                    Console.WriteLine("      |    /|\\         ");
                    Console.WriteLine("      |     |          ");
                    Console.WriteLine("      |                ");
                    Console.WriteLine("      |                ");
                    Console.WriteLine("     _|_______         ");
                    break;
                case 8:
                    Console.WriteLine("     ________          ");
                    Console.WriteLine("      |     |          ");
                    Console.WriteLine("      |     O          ");
                    Console.WriteLine("      |    /|\\         ");
                    Console.WriteLine("      |     |          ");
                    Console.WriteLine("      |    / \\         ");
                    Console.WriteLine("      |                ");
                    Console.WriteLine("     _|_______         ");
                    break;
                default:
                    break;

            }
            Console.ResetColor();
        }

        //méthode qui renvoi 1 si la partie est gagné, -1 si la partie est perdu, 0 si la partie continue. Elle reçoit en paramètre le nombre d’erreurs et le tableau contenant le mot composé
        static int TesterGagner(int nberreur, char[] tab)
        {
            int res = 0;
            if (nberreur > 7)
            {
                res = -1;
            }
            else if (Array.IndexOf(tab, '_') == -1)
            {
                res = 1;
            }
            return res;
        }
    }
}
