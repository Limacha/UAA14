namespace Act12_BarCocktail
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Bar à cocktail";
            bool run = true;

            #region creation variable
            // Création des liquides
            Liquide rhum = new Liquide("Rhum", 50);
            Liquide vodka = new Liquide("Vodka", 50);
            Liquide gin = new Liquide("Gin", 50);
            Liquide tequila = new Liquide("Tequila", 50);
            Liquide citron = new Liquide("Jus de citron", 50);
            Liquide sucre = new Liquide("Sirop de sucre", 50);
            Liquide orange = new Liquide("Jus d'orange", 50);
            Liquide cola = new Liquide("Cola", 50);
            Liquide menthe = new Liquide("Menthe", 50);
            Liquide grenadine = new Liquide("Grenadine", 50);

            Cave cave = new Cave(new Liquide[] { new(rhum), new(vodka), new(gin), new(tequila), new(citron), new(sucre), new(orange), new(cola), new(menthe), new(grenadine) });

            // Création des recettes
            Recette[] recettes = new Recette[]
            {
                new Recette("Mojito", new Dictionary<Liquide, float> {{new (rhum, 0), 50}, {new(citron, 0), 30}, {new(sucre, 0), 20}}),
                new Recette("Caipirinha", new Dictionary<Liquide, float> {{ new(rhum, 0), 60}, {new(sucre, 0), 40}}),
                new Recette("Tequila Sunrise", new Dictionary<Liquide, float> {{new (tequila, 0), 50}, {new(orange, 0), 40}, {new(grenadine, 0), 10}}),
                new Recette("Cuba Libre", new Dictionary<Liquide, float> {{ new(rhum, 0), 50}, {new(cola, 0), 50}}),
                new Recette("Gin Tonic", new Dictionary<Liquide, float> {{ new(gin, 0), 50}, {new(cola, 0), 50}}),
                new Recette("Vodka Orange", new Dictionary<Liquide, float> {{new(vodka, 0), 50}, {new(orange, 0), 50}}),
                new Recette("Margarita", new Dictionary<Liquide, float> {{ new(tequila, 0), 50}, {new(citron, 0), 30}, {new(sucre, 0), 20}}),
                new Recette("Pina Colada", new Dictionary<Liquide, float> {{new(rhum, 0), 50}, {new(orange, 0), 30}, {new(sucre, 0), 20}}),
                new Recette("Gin Fizz", new Dictionary<Liquide, float> {{ new(gin, 0), 50}, {new(citron, 0), 30}, {new(sucre, 0), 20}}),
                new Recette("Bloody Mary", new Dictionary<Liquide, float> {{ new(vodka, 0), 50}, {new(citron, 0), 30}, {new(menthe, 0), 20}})
            };

            // Création du menu
            Menu menu = new Menu(recettes);

            // Création du bar
            List<Bouteille> bouteilles = new List<Bouteille>
            {
                new Bouteille(new(rhum), 75),
                new Bouteille(new(vodka), 75),
                new Bouteille(new(gin), 75),
                new Bouteille(new(tequila), 75),
                new Bouteille(new(citron), 75),
                new Bouteille(new(sucre), 75),
                new Bouteille(new(orange), 75),
                new Bouteille(new(cola), 75),
                new Bouteille(new(menthe), 75),
                new Bouteille(new(grenadine), 75)
            };

            List<Shaker> shakers = new List<Shaker>
            {
                new Shaker(50, false, true),
                new Shaker(50, false, true)
            };

            Bar bar = new Bar("bar1", bouteilles, shakers, menu);

            // Création des barmans
            BarMan barMan1 = new BarMan("Barman1", 30, 123456, bar);
            BarMan barMan2 = new BarMan("Barman2", 28, 654321, bar);

            // Création des clients
            Client client1 = new Client("Client1", 25, 111111);
            Client client2 = new Client("Client2", 27, 222222);

            #endregion

            do
            {
                Console.Clear();
                //to big
                Console.WriteLine(
                    $"--------------------------------------------------------------\n" +
                    $"{cave.ToString()}\n" +
                    $"\n{bar.ToString()}\n" +
                    $"\nbarMan:\n" +
                    $"{barMan1.ToString()}\n" +
                    $"{barMan2.ToString()}\n" +
                    $"\nclient:\n" +
                    $"{client1.ToString()}\n" +
                    $"{client2.ToString()}\n"
                );
                Console.WriteLine("qui fait une actions?\nq)quiter\nc)client\nb)barman\n");
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.Q:
                        run = false;
                        break;
                    case ConsoleKey.C:
                        Console.SetCursorPosition(0, 0);
                        Console.Clear();
                        Console.WriteLine($"client:\n" +
                            $"{client1.ToString()}\n" +
                            $"{client2.ToString()}\n");
                        Console.WriteLine("Quels Client 1/2\n");
                        switch (Console.ReadKey().Key)
                        {
                            case ConsoleKey.D1:
                                Console.SetCursorPosition(0, 0);
                                Console.Clear();
                                Console.WriteLine($"{client1.ToString()}\n");
                                Console.WriteLine("Quel actions faire?\nc)choisir\nf)commande\nr)rendre\n");
                                switch (Console.ReadKey().Key)
                                {
                                    case ConsoleKey.C:
                                        client1.Choisir(menu);
                                        break;
                                    case ConsoleKey.F:
                                        break;
                                    case ConsoleKey.R:
                                        break;
                                }
                                break;
                            case ConsoleKey.D2:
                                Console.SetCursorPosition(0, 0);
                                Console.Clear();
                                Console.WriteLine($"{client2.ToString()}\n");
                                Console.WriteLine("Quel actions faire?\nc)choisir\nf)commande\nr)rendre\n");
                                switch (Console.ReadKey().Key)
                                {
                                    case ConsoleKey.C:
                                        client2.Choisir(menu);
                                        break;
                                    case ConsoleKey.F:
                                        break;
                                    case ConsoleKey.R:
                                        break;
                                }
                                break;
                        }
                        break;
                    case ConsoleKey.B:
                        Console.SetCursorPosition(0, 0);
                        Console.Clear();
                        Console.WriteLine($"barMan:\n" +
                            $"{barMan1.ToString()}\n" +
                            $"{barMan2.ToString()}\n");
                        Console.WriteLine("Quels barMan 1/2\n");
                        switch (Console.ReadKey().Key)
                        {
                            case ConsoleKey.D1:
                                Console.SetCursorPosition(0, 0);
                                Console.Clear();
                                Console.WriteLine($"{barMan1.ToString()}\n");
                                Console.WriteLine("Quel actions faire?\ns)stop\nw)work\n");
                                switch (Console.ReadKey().Key)
                                {
                                    case ConsoleKey.S:
                                        barMan1.StopWork(cave);
                                        break;
                                    case ConsoleKey.W:
                                        barMan1.Work(cave, bar);
                                        break;
                                }
                                break;
                            case ConsoleKey.D2:
                                Console.SetCursorPosition(0, 0);
                                Console.Clear();
                                Console.WriteLine($"{barMan2.ToString()}\n");
                                Console.WriteLine("Quel actions faire?\ns)stop\nw)work\n");
                                switch (Console.ReadKey().Key)
                                {
                                    case ConsoleKey.S:
                                        barMan1.StopWork(cave);
                                        break;
                                    case ConsoleKey.W:
                                        barMan1.Work(cave, bar);
                                        break;
                                }
                                break;
                        }
                        break;
                }
                Console.Clear();
            } while (false);
        }
    }
}
