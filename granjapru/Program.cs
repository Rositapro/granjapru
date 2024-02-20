namespace granjapru
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido a la granja");
            Console.WriteLine("Te gustaria conocer a la vaca");
            Console.ReadLine();
            Vaca lola = new Vaca();
            lola.Nombrar(Console.ReadLine());
            Console.WriteLine(lola.ToString());
            
            Console.ReadKey();

            Console.WriteLine("Te gustaria conocer al perro");
            Console.ReadLine();
            Perro betoben = new Perro();
            betoben.Nombrar(Console.ReadLine());
            Console.WriteLine(betoben.ToString());
            Console.ReadKey();

            Console.WriteLine("Te gustaria conocer a la gallina");
            Console.ReadLine();
            Gallina turuleca = new Gallina();
            betoben.Nombrar(Console.ReadLine());
            Console.WriteLine(turuleca.ToString());
            Console.ReadKey();
        }
    }
}