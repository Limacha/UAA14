namespace act1_allumer_lampe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Lampe> lampeList = new List<Lampe>();
            List<Interupteur> interupList = new List<Interupteur>();

            Fonction fonction = new Fonction();
            while (true)
            {
                Console.WriteLine("l)creer une lampe\ni)creer un interrupteur\nu)utiliser un interrupteur\ns)montre l'etat d'une lampe\n");
                var key = Console.ReadKey().Key;
                if (key == ConsoleKey.L)
                {
                    var lampe = fonction.CreerLampe(SetLampeCode(), SetColor());
                    lampeList.Add(lampe);
                    Console.Clear();
                }
                else if (key == ConsoleKey.I)
                {
                    Lampe lampe = null;
                    Console.Clear();
                    var code = "";
                    if (lampeList.Count > 0)
                    {
                        Console.WriteLine("attribuer une lampe si oui pressez space.");
                        if (Console.ReadKey().Key == ConsoleKey.Spacebar)
                        {
                            do
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.DarkGray;
                                Console.WriteLine(ShowLampe());
                                Console.ResetColor();

                                Console.WriteLine("Entrez le code de la lampe ou quiter en ecrivant exit");
                                code = Console.ReadLine();
                            } while (fonction.SelectLampe(code, lampeList) == null && code != "exit");
                            lampe = fonction.SelectLampe(code, lampeList);
                        }
                    }
                    if (lampe == null)
                    {
                        lampe = fonction.CreerLampe(SetLampeCode(), SetColor());
                    }

                    lampeList.Add(lampe);
                    interupList.Add(fonction.CreerInterrupteur(SetInteruptCode(), lampe));
                    Console.Clear();
                }
                else if (key == ConsoleKey.U)
                {
                    Console.Clear();
                    var code = "";
                    Interupteur interupteur = null;
                    if (interupList.Count > 0)
                    {
                        do
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            Console.WriteLine(ShowInterupteur());
                            Console.ResetColor();

                            Console.WriteLine("Entrez le code de l'interupteur a activer ou quiter en ecrivant exit");
                            code = Console.ReadLine();
                        } while (fonction.SelectInterupteur(code, interupList) == null && code != "exit");
                        if (code != "exit")
                        {
                            interupteur = fonction.SelectInterupteur(code, interupList);
                            fonction.UtiliserInterrupteur(fonction.SelectInterupteur(code, interupList));
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            Console.WriteLine($"la lampe {interupteur.GetLampe().GetCode()} {interupteur.GetLampe().ShowState()}");
                            Console.ResetColor();
                        }
                    }
                }
                else if (key == ConsoleKey.S) 
                {
                    Lampe lampe = null;
                    Console.Clear();
                    var code = "";
                    if (lampeList.Count > 0)
                    {
                        do
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            Console.WriteLine(ShowLampe());
                            Console.ResetColor();

                            Console.WriteLine("Entrez le code de la lampe ou quiter en ecrivant exit");
                            code = Console.ReadLine();
                        } while (fonction.SelectLampe(code, lampeList) == null && code != "exit");
                        if (code != "exit")
                        {
                            lampe = fonction.SelectLampe(code, lampeList);
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            Console.WriteLine($"la lampe {lampe.GetCode()} {lampe.ShowState()}");
                            Console.ResetColor();
                        }
                    }
                }
                
            }
            string ShowLampe()
            {
                string text = "";
                foreach (var lampe in lampeList) 
                { 
                    text += $"la lampe {lampe.GetCode()} {lampe.ShowState()}\n";
                }
                return text;
            }

            string ShowInterupteur()
            {
                string text = "";
                foreach (var interupteur in interupList)
                {
                    text += $"l'interupteur {interupteur.GetCode()} est lier a la lampe {interupteur.GetLampeCode()}\n";
                }
                return text;
            }

            string SetLampeCode()
            {
                string code;
                var exist = false;
                do
                {
                    do
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine(ShowLampe());
                        Console.ResetColor();
                        Console.WriteLine("Entrez le code a utiliser pour la lampe");
                        code = Console.ReadLine();
                    } while (code == "");
                    exist = false;
                    foreach (var lampe in lampeList)
                    {
                        if (lampe.GetCode() == code)
                        {
                            exist = true;
                        }
                    }
                } while (exist && code != "exit");
                return code;
            }

            string SetInteruptCode()
            {
                string code;
                var exist = false;
                do
                {
                    do
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine(ShowInterupteur());
                        Console.ResetColor();
                        Console.WriteLine("Entrez le code a utiliser pour l'interupteur");
                        code = Console.ReadLine();
                    } while (code == "");
                    exist = false;
                    foreach (var interupteur in interupList)
                    {
                        if (interupteur.GetCode() == code)
                        {
                            exist = true;
                        }
                    }
                } while (exist && code != "exit");
                return code;
            }

            string SetColor()
            {
                string color;
                do
                {
                    Console.Clear();
                    Console.WriteLine("Entrez la couleur");
                    color = Console.ReadLine();
                    Console.WriteLine(color);
                } while (color == "");
                return color;
            }
        }
        
    }
}

