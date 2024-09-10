namespace Premier_prog_poo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Chien dog = null;
            bool game = true;
            List<Chien> clubChien = new List<Chien>();

            clubChien.Add(new Chien("doggy", 4, "buldog", 15, 30, "très très con", true, false));
            for (int i = 1; i < 11; i++)
            {
                clubChien.Add(new Chien($"dog{i}", 5, $"race{i}",10+i, 10+i, "con", false, false));
            }

            while (game)
            {
                if (dog == null)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine($"que voulez vous faire?\nA) afficher les {clubChien.Count()} chiens\nC) selectionner un des {clubChien.Count()}\np)creez un nouveau chien");
                    Console.ResetColor();
                    ConsoleKey key = Console.ReadKey().Key;
                    Console.Clear();
                    switch (key)
                    {
                        case ConsoleKey.A:
                            foreach (Chien chien in clubChien) { Console.WriteLine(chien.InfosChien() + "\n"); }
                            break;
                        case ConsoleKey.C:
                            int num = lireInt("Quel chien voulez-vous selectionner.");
                            dog = clubChien[num - 1];
                            break;
                        case ConsoleKey.P:
                            Console.WriteLine("Quel nom a votre chien");
                            string nom = Console.ReadLine();
                            int age = lireInt("Quel age a le chien?");
                            Console.WriteLine("De quel race est-il?");
                            string race = Console.ReadLine();
                            double taille = lireInt("Quel taille fait-il?");
                            double poid = lireInt("Quel taille fait-il?");
                            Console.WriteLine("Dans quel etat est-il?");
                            string etat = Console.ReadLine();

                            clubChien.Add(new Chien(nom, age, race, taille, poid, etat, false, false));
                            break;
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine($"que voulez vous faire?\nM)Manger\nB)Boire\nV)Vieillir\nS)SeBlesser\nN)Besoin\nD)Mourir\nI)InfoChien\nA) afficher les {clubChien.Count()} chiens\nC) selectionner un des {clubChien.Count()}\np)creez un nouveau chien");
                    Console.ResetColor();
                    ConsoleKey key = Console.ReadKey().Key;
                    Console.Clear();
                    switch (key)
                    {
                        case ConsoleKey.M:
                            Console.WriteLine(dog.Manger());
                            break;
                        case ConsoleKey.B:
                            Console.WriteLine(dog.Boire());
                            break;
                        case ConsoleKey.V:
                            Console.WriteLine(dog.Vieillir());
                            break;
                        case ConsoleKey.S:
                            Console.WriteLine(dog.Seblesser());
                            break;
                        case ConsoleKey.N:
                            Console.WriteLine(dog.Besoin());
                            break;
                        case ConsoleKey.D:
                            Console.WriteLine(dog.Mourir());
                            break;
                        case ConsoleKey.I:
                            Console.WriteLine(dog.InfosChien());
                            break;
                        case ConsoleKey.A:
                            foreach (Chien chien in clubChien) { Console.WriteLine("1: " + chien.InfosChien() + "\n"); }
                            break;
                        case ConsoleKey.C:
                            int num = lireInt("Quel chien voulez-vous selectionner.");
                            dog = clubChien[num - 1];
                            break;
                        case ConsoleKey.P:
                            Console.WriteLine("Quel nom a votre chien");
                            string nom = Console.ReadLine();
                            int age = lireInt("Quel age a le chien?");
                            Console.WriteLine("De quel race est-il?");
                            string race = Console.ReadLine();
                            double taille = lireInt("Quel taille fait-il?");
                            double poid = lireInt("Quel poid fait-il?");
                            Console.WriteLine("Dans quel etat est-il?");
                            string etat = Console.ReadLine();

                            clubChien.Add(new Chien(nom, age, race, taille, poid, etat, false, false));
                            break;
                    }
                }
            }


            /// <summary>
            /// lire un int sur un consolRead sans crash
            /// </summary>
            /// <param name="question">la question a possez</param>
            /// <returns>la valeur int entrer</returns>
            int lireInt(string question)
            {
                int n;
                do
                {
                    Console.WriteLine(question);
                } while (!int.TryParse(Console.ReadLine(), out n));
                return n;
            }
        }
    }
}
