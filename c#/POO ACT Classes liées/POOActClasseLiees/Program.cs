namespace POOActClasseLiees
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bibliotheque biblio = new Bibliotheque();
            do
            {
                Console.Clear();
                Console.WriteLine("L: creez un livre\n" +
                        "D: degrader un livre\n" +
                        "S: suprimer les livres abimer\n" +
                        "i: les infos de la biblio\n"
                    );
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.L:
                        string titre = "";
                        string auteur = "";
                        int etat = 5;
                        bool exist = false;
                        Console.WriteLine("Titre du livre:");
                        titre = Console.ReadLine();
                        Console.WriteLine("auteur du livre:");
                        auteur = Console.ReadLine();

                        foreach (var item in biblio.Contenu)
                        {
                            if(item.Titre == titre)
                            {
                                exist = true;
                                return;
                            }
                        }
                        if (!exist)
                        {
                            biblio.Contenu.Add(new Livre(titre, auteur, etat));
                            Console.WriteLine("livre creez");
                        } else
                        {
                            Console.WriteLine("exist deja");
                        }
                        break;
                    case ConsoleKey.D:
                        biblio.Inventaire();
                        Console.WriteLine("Titre du livre:");
                        titre = Console.ReadLine();
                        Livre livre = null;
                        foreach (var item in biblio.Contenu)
                        {
                            if (item.Titre == titre)
                            {
                                livre = item;
                                return;
                            }
                        }
                        if (livre != null)
                        {
                            livre.Degrade();
                            Console.WriteLine("livre abimer");
                        }
                        else
                        { 
                            Console.WriteLine("pas de livre");
                        }

                            break;
                    case ConsoleKey.S:
                        biblio.Supprimer_livre_abimes();
                        Console.WriteLine("livre sup");
                        break;
                    case ConsoleKey.I:
                        biblio.Inventaire();
                        break;
                }
                Console.WriteLine("\npressez espace pour recommencer");
            } while (Console.ReadKey().Key == ConsoleKey.Spacebar);
        }
    }
}
