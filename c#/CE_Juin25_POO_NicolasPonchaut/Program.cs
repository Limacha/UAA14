using static CE_Juin25_POO_NicolasPonchaut.Fonction;
namespace CE_Juin25_POO_NicolasPonchaut
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programme de calcul de performances dans une Pool d'escrime");
            Console.WriteLine("-----------------------------------------------------------");
            do
            {
                if(InitPool(LireInt("Quelle pool désirez-vous traiter ? (entre 1 et 3)", true, 1, 3), out Pool pool))
                {
                    Console.Clear();
                    Console.WriteLine(pool.AfficherParticipantsPool());
                    Console.WriteLine(pool.AfficherPreformancesTireurs());
                    Console.WriteLine(pool.AfficherRecapitulatifCompletMatchs());

                    Console.WriteLine("Voulez-vous enregistrer ces données dans la bdd ? oui = espace, non = autre touche");
                    if (Console.ReadKey().Key == ConsoleKey.Spacebar)
                    {
                        if (SavePerformance(pool))
                        {
                            Console.WriteLine("sauvegarde reussit.");
                        }
                        else
                        {
                            Console.WriteLine("une erreur est survenu lors de la sauvegarde de la pool.");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("une erreur est survenu lors de la création de la pool.");
                }

                Console.WriteLine("Calculer les performances dans une autre Pool? (continuer en appuyant sur espace, autre touche pour quitter)");
            } while (Console.ReadKey().Key == ConsoleKey.Spacebar);
        }
    }
}
