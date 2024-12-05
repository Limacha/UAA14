namespace Act7_NicolasPonchaut_MySQL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fonction fonction = new Fonction();
            /*string[] select = new string[] { "id", "nomUser", "prenomUser", "loginUser", "passWordUser", "role" };
            fonction.SelectFromWhere(select, "utilisateurs");*/
            bool quiter = false;
            do
            {
                Console.WriteLine(
                    "Q: quitez \n" +
                    "S: affiche la liste des biens \n" +
                    "D: delete un bien depuis son id \n" +
                    "A: ajoute un bien \n" +
                    "E: edit un bien depuis son id \n"
                    );
                switch (Console.ReadKey(true).Key)
                {
                    default:
                        Console.Clear();
                        break;
                    case ConsoleKey.Q:
                        Console.Clear();
                        quiter = true;
                        break;
                    case ConsoleKey.S:
                        Console.Clear();
                        string[] select = new string[] { "bienId", "nom", "taille", "prix", "ville", "userId", "description", "chambres", "imageBien" };
                        fonction.SelectFromWhere(select, "biens");
                        break;
                    case ConsoleKey.D:
                        Console.Clear();
                        break;
                    case ConsoleKey.A:
                        Console.Clear();
                        break;
                    case ConsoleKey.E:
                        Console.Clear();
                        break;
                }
            } while (!quiter);
        }
    }
}
