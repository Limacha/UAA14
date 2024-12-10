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

            string[] select;
            Dictionary<string, string> set;
            do
            {
                Console.WriteLine(
                    "Q: quitter \n" +
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
                        select = new string[] { "bienId", "nom", "taille", "prix", "ville", "userId", "description", "chambres", "imageBien" };
                        fonction.SelectFromWhere(select, "biens");
                        break;
                    case ConsoleKey.D:
                        Console.Clear();
                        select = new string[] { "bienId", "nom", "taille", "prix", "ville", "userId", "description", "chambres", "imageBien" };
                        fonction.DeleteFromId(select, "biens", $"bienId = {Console.ReadLine()}");
                        break;
                    case ConsoleKey.A:
                        Console.Clear();set = new Dictionary<string, string>();
                        Console.WriteLine("nom");
                        set.Add("nom", Console.ReadLine());
                        Console.WriteLine("taille");
                        set.Add("taille", Console.ReadLine());
                        Console.WriteLine("prix");
                        set.Add("prix", Console.ReadLine());
                        Console.WriteLine("ville");
                        set.Add("ville", Console.ReadLine());
                        Console.WriteLine("user");
                        set.Add("userId", Console.ReadLine());
                        Console.WriteLine("desc");
                        set.Add("description", Console.ReadLine());
                        Console.WriteLine("chambres");
                        set.Add("chambres", Console.ReadLine());
                        Console.WriteLine("image");
                        set.Add("imageBien", Console.ReadLine());

                        fonction.AddItem("biens", set);
                        select = new string[] { "bienId", "nom", "taille", "prix", "ville", "userId", "description", "chambres", "imageBien" };
                        fonction.SelectFromWhere(select, "biens");
                        break;
                    case ConsoleKey.E:
                        Console.Clear();
                        select = new string[] { "bienId", "nom", "taille", "prix", "ville", "userId", "description", "chambres", "imageBien" };
                        fonction.SelectFromWhere(select, "biens");
                        set = new Dictionary<string, string>();
                        Console.WriteLine("nom");
                        set.Add( "nom", Console.ReadLine());
                        Console.WriteLine("taille");
                        set.Add( "taille", Console.ReadLine());
                        Console.WriteLine("prix");
                        set.Add( "prix", Console.ReadLine());
                        Console.WriteLine("ville");
                        set.Add( "ville", Console.ReadLine());
                        Console.WriteLine("user");
                        set.Add( "userId", Console.ReadLine());
                        Console.WriteLine("desc");
                        set.Add( "description", Console.ReadLine());
                        Console.WriteLine("chambres");
                        set.Add( "chambres", Console.ReadLine());
                        Console.WriteLine("image");
                        set.Add( "imageBien", Console.ReadLine());
                        Console.WriteLine("id");

                        fonction.EditItem("biens", set, $"bienId = {Console.ReadLine()}");
                        select = new string[] { "bienId", "nom", "taille", "prix", "ville", "userId", "description", "chambres", "imageBien" };
                        fonction.SelectFromWhere(select, "biens");
                        break;
                }
            } while (!quiter);
        }
    }
}
