using POOActClasseLiees;

namespace POOACTClasseLier2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bibliotheque biblio = new Bibliotheque();
            Livre livre = null;
            do
            {
                Console.Clear();
                Console.WriteLine("L: creez un livre\n" +
                        "D: degrader un livre\n" +
                        "S: suprimer les livres abimer\n" +
                        "E: emprunter un livre\n" +
                        "R: rendre un livre\n" +
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
                            if (item.Titre == titre)
                            {
                                exist = true;
                            }
                        }
                        if (!exist)
                        {
                            biblio.Contenu.Add(new Livre(titre, auteur, etat));
                            Console.WriteLine("livre creez");
                        }
                        else
                        {
                            Console.WriteLine("exist deja");
                        }
                        break;
                    case ConsoleKey.D:
                        biblio.Inventaire();
                        Console.WriteLine("Titre du livre:");
                        titre = Console.ReadLine();
                        livre = null;
                        foreach (var item in biblio.Contenu)
                        {
                            if (item.Titre == titre)
                            {
                                livre = item;
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
                    case ConsoleKey.E:
                        biblio.Inventaire();
                        Console.WriteLine("Titre du livre:");
                        titre = Console.ReadLine();
                        livre = null;
                        foreach (var item in biblio.Contenu)
                        {
                            if (item.Titre == titre)
                            {
                                livre = item;
                            }
                        }
                        if (livre != null)
                        {

                            Console.WriteLine("id:");
                            string id = Console.ReadLine();

                            Console.WriteLine("date:");
                            string date = Console.ReadLine();

                            biblio.Empreinter(id, livre, date);
                            Console.WriteLine("livre empreinter");
                        }
                        else
                        {
                            Console.WriteLine("pas de livre");
                        }

                        break;
                    case ConsoleKey.R:
                        biblio.Inventaire();
                        Console.WriteLine("id emprunt:");
                        string idemp = Console.ReadLine();
                        Empreint emp = null;
                        foreach (var item in biblio.Empreints)
                        {
                            if (item.Id == idemp)
                            {
                                emp = item;
                            }
                        }
                        if (emp != null)
                        {
                            biblio.Rendre(emp);
                            Console.WriteLine("livre rendu");
                        }
                        else
                        {
                            Console.WriteLine("pas de livre");
                        }

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
