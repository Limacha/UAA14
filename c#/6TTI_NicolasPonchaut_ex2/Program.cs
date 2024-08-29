namespace _6TTI_NicolasPonchaut_ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
           

                func methods = new func();

                methods.colorConsole(ConsoleColor.Black, ConsoleColor.Green);


                double[] table = new double[10];
                double x;

                Console.WriteLine("Entrez 10 nombres afin d'en ressortir la moyenne:");
                for (int i = 0; i < table.Length; i++)
                {
                    methods.LireDouble(i , out x);
                    table[i] = x;

                }
                double addition = 0;
                for (int i = 0; i < table.Length; i++)
                {
                    addition += table[i];
                }
                double final = addition / table.Length;
                Console.WriteLine("\nMoyenne de tous ces nombres: " + final);

            
        }
    }
}
