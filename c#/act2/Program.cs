using act2.classs;
using System.Numerics;
namespace act2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool quiter = true;
            do
            {
                Console.WriteLine("Q = quiter | C = cercle | I = Imaginaire | S = sandwich | P = personne");
                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.Q:
                        quiter = false;
                        break;
                    case ConsoleKey.C:
                        Console.Clear();
                        Cercle();
                        break;
                    case ConsoleKey.I:
                        Console.Clear();
                        NComplex();
                        break;
                    case ConsoleKey.S:
                        Console.Clear();
                        Sandwich();
                        break;
                    case ConsoleKey.P:
                        Console.Clear();
                        Pers();
                        break;
                }
            } while (quiter);
        }

        static void Cercle()
        {
            lireDouble("Quelle rayon voulez-vous pour vôtre cercle ?", out double rayon);
            Cercle cercle = new Cercle(rayon);
            do
            {
                Console.WriteLine("\nA = Infos | B = Changer Rayon | C = Aire | D = Périmètre");
                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.A:
                        Console.Clear();
                        Console.WriteLine("Rayon : " + cercle.Radius);
                        break;
                    case ConsoleKey.B:
                        Console.Clear();
                        lireDouble("Quelle rayon voulez-vous pour vôtre cercle ?\nActuelle : " + cercle.Radius, out rayon);
                        cercle.Radius = rayon;
                        break;
                    case ConsoleKey.C:
                        Console.Clear();
                        Console.WriteLine("Aire : " + cercle.CalculerAire());
                        break;
                    case ConsoleKey.D:
                        Console.Clear();
                        Console.WriteLine("Périmètre : " + cercle.CalculerPerimetre());
                        break;
                }
                Console.WriteLine("space pour restart");
            } while (Console.ReadKey().Key == ConsoleKey.Spacebar);
        }

        static void NComplex()
        {
            lireDouble("Quelle reel voulez-vous pour vôtre nombre ?", out double reel);
            lireDouble("Quelle imaginaire voulez-vous pour vôtre nombre ?", out double imaginaire);
            NombreComplexe complex = new NombreComplexe(reel, imaginaire);
            do
            {
                Console.WriteLine("\nA = Infos | B = ajouter | C = calculer");
                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.A:
                        Console.Clear();
                        Console.WriteLine(complex.Afficher());
                        break;
                    case ConsoleKey.B:
                        Console.Clear();
                        lireDouble("Quelle reel voulez-vous ajouter à vôtre nombre ?", out reel);
                        lireDouble("Quelle imaginaire voulez-vous ajouter à vôtre nombre ?", out imaginaire);
                        complex.Ajouter(new NombreComplexe(reel, imaginaire));
                        break;
                    case ConsoleKey.C:
                        Console.Clear();
                        Console.WriteLine(complex.CalculModul());
                        break;
                }
                Console.WriteLine("space pour restart");
            } while (Console.ReadKey().Key == ConsoleKey.Spacebar);
        }

        static void Sandwich()
        {
            SandwichMaker make = new SandwichMaker();
            do
            {
                Console.WriteLine("\nS = sandwich");
                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.S:
                        Console.Clear();
                        Console.WriteLine(make.ComposeSandwich());
                        break;
                }
                Console.WriteLine("\nspace pour restart");
            } while (Console.ReadKey().Key == ConsoleKey.Spacebar);
        }

        static void Pers()
        {
            Perssone jack = new Perssone("jack", 10);
            Perssone elon = new Perssone("elon", 100000000000);
            do
            {
                
                Console.WriteLine("\nspace pour restart");
            } while (Console.ReadKey().Key == ConsoleKey.Spacebar);
        }

        static void lireDouble(string question, out double n)
        {
            string nUser;
            Console.WriteLine(question);
            nUser = Console.ReadLine();
            while (!double.TryParse(nUser, out n))
            {
                Console.WriteLine("La réponse envoyer n'est pas valide, vueillez réessayer la question.");
                Console.WriteLine(question);
                nUser = Console.ReadLine();
            }
        }
    }
}
