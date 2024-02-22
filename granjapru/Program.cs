namespace granjapru
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the farm");
            Console.WriteLine("Choose a name for the cow");
            string nombre = Console.ReadLine();
            Vaca cow = new Vaca();
            cow.Nombrar(nombre);
            Console.WriteLine(cow.ToString());
            Console.WriteLine("I do " + cow.Sonido() + ", I am an animal " + cow.Tipo() + ", and i am very " + cow.Estado());

            Console.WriteLine("Choose a name for the hen");
            nombre = Console.ReadLine();
            Gallina hen = new Gallina();
            hen.Nombrar(nombre);
            Console.WriteLine(hen.ToString());
            Console.WriteLine("I do " + hen.Sonido() + ", I am an animal " + hen.Tipo() + ", and i am very " + hen.Estado());
            Console.WriteLine("Choose a name for the dog");
            nombre = Console.ReadLine();
            Perro dog = new Perro();
            dog.Nombrar(nombre);
            Console.WriteLine(dog.ToString());
            Console.WriteLine("I do " + dog.Sonido() + ", I am an animal " + dog.Tipo() + ", and i am very " + dog.Estado()); 
        }
    }
}