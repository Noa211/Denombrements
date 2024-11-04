using System;

namespace Denombrements
{
    class Program
    {
        /// <summary>
        /// contrôle de saisie
        /// </summary>
        /// <param name="message">le message à afficher</param>
        /// <returns>la saisie</returns>
        static int Saisie(string message)
        {
            bool correct = false;
            int rep = 1;
            while (!correct)
            {
                try
                {
                    Console.Write(message);
                    rep = int.Parse(Console.ReadLine());
                    correct = true;
                }
                catch
                {
                    Console.WriteLine("Erreur de saisie: veuillez entrer un entier.");
                }
            }
            return rep;
        }

        /// <summary>
        /// calcul de factorielle d'un nombre
        /// </summary>
        /// <param name="nb">nombre à calculer</param>
        /// <returns>le résultat</returns>
        static long Factorielle(int nb)
        {
            long resultat = 1;
            for (int k = 1; k <= nb; k++)
            {
                resultat *= k;
            }
            return resultat;
        }

        /// <summary>
        /// calcul d'une factorielle délimitée
        /// </summary>
        /// <param name="total">total de nb à gérer</param>
        /// <param name="nb">nb dans le sous ensemble</param>
        /// <returns>le résultat</returns>
        static long FactorielleLimite(int total, int nb)
        {
            long resultat = 1;
            for (int k = (total - nb + 1); k <= total; k++)
            {
                resultat *= k;
            }
            return resultat;
        }

        static void Main(string[] args)
        {
            // boucle générale pour répéter le programme
            int choix = 1;
            while (choix != 0)
            {
                // saisie du choix
                Console.WriteLine("Permutation ...................... 1");
                Console.WriteLine("Arrangement ...................... 2");
                Console.WriteLine("Combinaison ...................... 3");
                Console.WriteLine("Quitter .......................... 0");
                do
                {
                    choix = Saisie("Choix :                            ");
                } 
                while (choix != 0 && choix != 1 && choix != 2 && choix != 3);
                // calculs à effectuer selon le choix
                switch (choix)
                {
                    // calcul de permutation
                    case 1:
                        int nb = Saisie("nombre total d'éléments à gérer = ");
                        long result = Factorielle(nb);
                        Console.WriteLine(nb + "! = " + result);
                        break;
                    // calcul d'arrangement
                    case 2:
                        int total = Saisie("nombre total d'éléments à gérer = ");
                        nb = Saisie("nombre d'éléments dans le sous ensemble = ");
                        result = FactorielleLimite(total, nb);
                        Console.WriteLine("A(" + total + "/" + nb + ") = " + result);
                        break;
                    // calcul de combinaison
                    case 3:
                        total = Saisie("nombre total d'éléments à gérer = ");
                        nb = Saisie("nombre d'éléments dans le sous ensemble = ");
                        long result1 = FactorielleLimite(total, nb);
                        long result2 = Factorielle(nb);
                        Console.WriteLine("C(" + total + "/" + nb + ") = " + (result1 / result2));
                        break;
                }
            }
            Console.ReadLine();
        }
    }
}
