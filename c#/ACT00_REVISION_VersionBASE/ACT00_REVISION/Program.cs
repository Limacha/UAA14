using System;

namespace ACT00_REVISION
{
    class Program
    {
        static void Main(string[] args)
        {
            // déclaration des variables.... COMPLETER AVEC CE QUI MANQUE

            string rep;
            MethodesDuProjet func = new MethodesDuProjet();
            double c1 = 0;
            double c2 = 0;
            double c3 = 0;
            bool ok = false;

            Console.WriteLine("Testez les polygones !");
            //On recommence tant que désiré
            do
            {
                //lecture des 3 côtés
                c1 = lireDouble(1);
                c2 = lireDouble(2);
                c3 = lireDouble(3);

                // ordonner les côtés => APPEL ORDONNECOTES
                func.OrdonneCotes(ref c1, ref c2, ref c3);
                // série de test (voir consignes)
                if (func.Triangle(c1, c2, c3))
                {
                    // préparation et affichage du résultat du test 'triangle' avec la procédure 'Affiche'
                    func.Affiche(out rep, "triangle", true);
                    Console.WriteLine(rep);

                    // vérification équilatéral
                    if (func.Equi(c1, c2, c3))
                    {
                        // préparation et affichage du résultat du test 'equilateral' avec la procédure 'Affiche'
                        func.Affiche(out rep, "equilateral", true);
                        Console.WriteLine(rep);

                    }
                    else
                    {
                        // vérification triangle rectangle
                        if (func.Equi(c1, c2, c3))
                        {
                            // préparation et affichage du résultat positif du test 'rectangle' avec la procédure 'Affiche'
                            func.Affiche(out rep, "rectangle", true);
                            Console.WriteLine(rep);

                        }
                        else
                        {
                            // préparation et affichage du résultat négatif du test 'rectangle' avec la procédure 'Affiche'
                            func.Affiche(out rep, "rectangle", false);
                            Console.WriteLine(rep);

                        }
                        // vérification du cas isocèle et affichage dans le cas positif
                        func.Isocele(c1, c2, c3, out ok);
                        func.Affiche(out rep, "isocele", ok);
                        Console.WriteLine(rep);

                        //... A vous de voir en combien de lignes...
                    }
                }
                else // si ce n'est pas un triangle
                {
                    // préparation et affichage du résultat négataif du test 'triangle' avec la procédure 'Affiche'
                    func.Affiche(out rep, "triangle", false);
                    Console.WriteLine(rep);

                }
                // reprise ?
                Console.WriteLine("Voulez-vous tester un autre polygône ? (Tapez espace)");
                rep = Console.ReadLine();
            } while (rep == " ");
        }
        //Récupération d'une donnée fournie par l'utilisateur en 'double' : on suppose qu'il ne se trompe pas !
        static double lireDouble(int numeroCote)
        {
            double cote;
            Console.Write("Tapez la valeur du côté " + numeroCote + " : ");
            cote = double.Parse(Console.ReadLine());
            return cote;
        }
    }
}
