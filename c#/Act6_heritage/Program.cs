namespace Act6_heritage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicule vroom = new Vehicule("vroom Mod", "vroom Marq", "vroom Color", 15);
            Voiture vroomvroom = new Voiture("vroomvroom Mod", "vroomvroom Marq", "vroomvroom Color", 20, "vroomvroom motor", true);
            Velo cling = new Velo("cling Mod", "cling Marq", "cling Color", 25, "cling type", false);

            Console.WriteLine(vroom.Affiche());
            Console.WriteLine(vroomvroom.Affiche());
            Console.WriteLine(cling.Affiche());
        }
    }
}
