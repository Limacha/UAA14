using System.Diagnostics;

namespace I5_6TTIUAA14_PonchautNicolas
{
    //comenter
    internal class Program
    {
        static void Main(string[] args)
        {
            bool leave = false; //si il veux quitte ou pas
            PaintBallGun[] armurerie = new PaintBallGun[20]; //tableau avec toute les armes

            for (int i = 0; i < 20; i++)
            {
                armurerie[i] = new PaintBallGun(16);
            }

            Console.WriteLine("pseudo?");
            Joueur joueur = new Joueur(Console.ReadLine(), 30, armurerie[12]);//le joueur
            Console.Clear();

            Console.WriteLine(
                "Bienvenu dans ce jeu de tir ... Vous démarrez avec 30 balles\n" +
                "============================================================");
            do
            {
                if (joueur.Gun.ChargeurEstVide())
                {
                    Console.WriteLine("Attention votre chargeur est vide");
                }
                Console.Write("\n" +
                    "Espace pout tirer,\n" +
                    "r pour recharger,\n" +
                    "v pour voir combient  il reste de munitions en poche et dans le chargeur,\n" +
                    "+ pour reprendre des munitions,\n" +
                    "q pour quitter,\n" +
                    "--->");
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.Spacebar:
                        Console.WriteLine();
                        if (joueur.Tirer())
                        {
                            Console.WriteLine("=> Tir effectué !");
                        }
                        else
                        {
                            Console.WriteLine("...");
                        }
                        break;
                    case ConsoleKey.R:
                        Console.WriteLine();
                        Console.WriteLine(joueur.Recharge());
                        break;
                    case ConsoleKey.V:
                        Console.WriteLine();
                        Console.WriteLine(joueur.VerifPoche());
                        break;
                    case ConsoleKey.Add:
                        Console.WriteLine();
                        joueur.NbCartoucheEnPoche += 30;
                        Console.WriteLine($"=> Reprise de 30 cartouches effectuée vous avez un total de {joueur.NbCartoucheEnPoche} cartouches en poche.");
                        break;
                    case ConsoleKey.Q:
                        leave = true;
                        break;
                }
            } while (!leave);
        }
    }
}
