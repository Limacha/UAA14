namespace Premier_prog_poo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Chien doggy = new Chien("doggy", 4, "buldog", 15, 30, "tres tres con", true);

            do {
                int action = lireInt("que voulez vous faire?\n1)Manger\n2)Boire\n3)Vieillir\n4)SeBlesser\n5)Besoin\n6)Mourir\n7)InfoChien");

                switch (action) {
                    case 1:
                        Console.WriteLine(doggy.Manger());
                        break;
                    case 2:
                        Console.WriteLine(doggy.Boire());
                        break;
                    case 3:
                        Console.WriteLine(doggy.Vieillir());
                        break;
                    case 4:
                        Console.WriteLine(doggy.Seblesser());
                        break;
                    case 5:
                        Console.WriteLine(doggy.Besoin());
                        break;
                    case 6:
                        Console.WriteLine(doggy.Mourir());
                        doggy = null;
                        break;
                    case 7:
                        Console.WriteLine(doggy.InfosChien());
                        break;
                }
                Console.WriteLine("presse space");
            }while(Console.ReadKey().Key == ConsoleKey.Spacebar);


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
