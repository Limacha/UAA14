namespace I2P624_PonchautNicolas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FeuDeSignalisation[] feuDeSignalisations = { new FeuDeSignalisation("carrefour polaris"), new FeuDeSignalisation("rue le trou") };
            do
            {
                Console.Clear();
                Console.WriteLine("A: afficher les feux instancier\n" +
                        "O: mettre a l'orange\n"+
                        "C: clignoter 5 fois un feu\n" +
                        "S: switch de couleur\n"
                    );
                switch(Console.ReadKey().Key){
                    case ConsoleKey.A:
                        Console.Clear();
                        Console.WriteLine("Etat de couleur des feux :");
                        Console.WriteLine("------------------------------------------------------------------");
                        for (int i = 0; i < feuDeSignalisations.Length; i++)
                        {
                            Console.WriteLine(feuDeSignalisations[i].AfficheInfo());
                        }
                        break;
                    case ConsoleKey.O:
                        Console.Clear();
                        Console.WriteLine("Faire passez le feux  carrefour polaris a l'orange:");
                        Console.WriteLine("------------------------------------------------------------------");
                        feuDeSignalisations[0].ChangerCouleur();
                        Console.WriteLine(feuDeSignalisations[0].AfficheInfo());
                        break;
                    case ConsoleKey.C:
                        Console.Clear();
                        Console.WriteLine("Feux clignotant :");
                        Console.WriteLine("------------------------------------------------------------------");
                        feuDeSignalisations[1].Clignote(5);
                        break;
                    case ConsoleKey.S:
                        Console.Clear();
                        Console.WriteLine("Changement d'état :");
                        Console.WriteLine("------------------------------------------------------------------");
                        for(int i = 0; i < 4; i++)
                        {
                            feuDeSignalisations[0].ChangerCouleur();
                            Console.WriteLine(feuDeSignalisations[0].AfficheInfo());
                        }
                        break;
                }
                Console.WriteLine("\npressez espace pour recommencer");
            } while (Console.ReadKey().Key == ConsoleKey.Spacebar);
        }
    }
}
