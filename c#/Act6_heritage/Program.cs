using Act6_heritage.@class.ex1;
using Act6_heritage.@class.ex2;
using Act6_heritage.@class.ex3;
using Act6_heritage.@class.ex4;

namespace Act6_heritage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region ex1
            /*
            Vehicule vroom = new Vehicule("vroom Mod", "vroom Marq", "vroom Color", 15);
            Voiture vroomvroom = new Voiture("vroomvroom Mod", "vroomvroom Marq", "vroomvroom Color", 20, "vroomvroom motor", true);
            Velo cling = new Velo("cling Mod", "cling Marq", "cling Color", 25, "cling type", false);

            Console.WriteLine(vroom.Affiche());
            Console.WriteLine(vroomvroom.Affiche());
            Console.WriteLine(cling.Affiche());
            */
            #endregion
            #region ex2
            /*
            Chien chien = new Chien("chien", new DateTime(), 1, 1, false);
            Chat chat = new Chat("chat", new DateTime(), 2, 2, true);
            Lapin lapin = new Lapin("lapin", new DateTime(), 3, 3, false, 3);
            Chien chienchien = new Chien("chienchien", new DateTime(), 4, 4, true);
            Chat chatchat = new Chat("chatchat", new DateTime(), 5, 5, false);

            Animaux[] animList = new Animaux[5] {chien, chat, lapin, chienchien, chatchat};

            foreach (Animaux anim in animList)
            {
                if (anim is Chien dog)
                {
                    Console.WriteLine(dog.Manger());
                    Console.WriteLine(dog.Boire());
                    Console.WriteLine(dog.Aboyer());
                }
                else if (anim is Chat cat)
                {
                    Console.WriteLine(cat.Manger());
                    Console.WriteLine(cat.Boire());
                    Console.WriteLine(cat.Miauler());
                    Console.WriteLine(cat.Ronronner());
                }
                else if (anim is Lapin rabbit)
                {
                    Console.WriteLine(rabbit.Manger());
                    Console.WriteLine(rabbit.Boire());
                    Console.WriteLine(rabbit.FaireBond());
                }
            }
            */
            #endregion
            #region ex3
            /*
            Rectangle rectangle = new Rectangle("blanc", 10, 15);
            Carre carre = new Carre("blanc", 10);
            Console.WriteLine(rectangle.CalculerSurface());
            Console.WriteLine(rectangle.CalculerPerimetre());
            Console.WriteLine(carre.CalculerSurface());
            Console.WriteLine(carre.CalculerPerimetre());
            */
            #endregion
            #region ex4
            /*
            Employer[] employer = new Employer[] { 
                new Ouvrier("1", "esclave nom 1", "esclave prenom 1", DateTime.Now.AddYears(-30), DateTime.Now.AddYears(-1)),
                new Ouvrier("2", "esclave nom 2", "esclave prenom 2", DateTime.Now.AddYears(-30), DateTime.Now.AddYears(-2)),
                new Ouvrier("3", "esclave nom 3", "esclave prenom 3", DateTime.Now.AddYears(-30), DateTime.Now.AddYears(-3)),
                new Ouvrier("4", "esclave nom 4", "esclave prenom 4", DateTime.Now.AddYears(-30), DateTime.Now.AddYears(-4)),
                new Ouvrier("5", "esclave nom 5", "esclave prenom 5", DateTime.Now.AddYears(-30), DateTime.Now.AddYears(-5)),
                new Cadre("6", "casse couille nom 6", "casse couille prenom 6", DateTime.Now.AddYears(-30), 1),
                new Cadre("7", "casse couille nom 7", "casse couille prenom 7", DateTime.Now.AddYears(-30), 2),
                new Cadre("8", "casse couille nom 8", "casse couille prenom 8", DateTime.Now.AddYears(-30), 3),
                new Directeur("9", "evader fiscal nom 9", "evader fiscal prenom 9", DateTime.Now.AddYears(-30), 900000000, 1),
                new Directeur("0", "evader fiscal nom 0", "evader fiscal prenom 0", DateTime.Now.AddYears(-30), 900000000, 1) };
            foreach (var item in employer)
            {
                Console.Write(item.Caract());
                Console.WriteLine(item.CalculerSalaire());
                Console.WriteLine();
            }
            */
            #endregion
            #region ex5

            #endregion
        }
    }
}
