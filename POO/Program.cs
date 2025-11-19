namespace POO.Clases
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var Corona = new Beer("Corona", 2.99m, -2);
            Console.WriteLine(Corona.getInfo());
            

            var Heineken = new ExpiringBeer("Heineken", 3.49m, 5, new DateTime(2024, 11, 19));
            Console.WriteLine(Heineken.getInfo());
        }
    }
}

