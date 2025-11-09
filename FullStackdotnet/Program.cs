namespace FullStackdotnet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int limit = 10;
            var beers = new string[limit];
            int iBeer = 0;
            int op = 0;


            do
            {
                showMenu();
                op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        if (iBeer < limit)
                        {
                            Console.WriteLine("Escribe el nombre de la nueva cerveza: ");
                            var beer = Console.ReadLine();
                            beers[iBeer] = beer;
                            iBeer++;
                        }
                        else
                        {
                            Console.WriteLine("No se pueden agregar más cervezas...");
                            Console.ReadLine();
                        }
                        break;
                    case 2:
                        showBeers(beers);
                        break;
                    case 3:
                        Console.WriteLine("Adios");
                        break;
                    default:
                        Console.WriteLine("Opción no válida...");
                        Console.ReadLine();
                        break;
                }

            } while (op != 3);
        }

        private static void showMenu()
        {
            Console.Clear();
            Console.WriteLine("1.- Agregar nombre");
            Console.WriteLine("2.- Mostrar nombres");
            Console.WriteLine("3.- Salir");

            Console.WriteLine("Ingresa una opción: ");
        }

        public static void showBeers(string[] beers)
        {
            Console.WriteLine("Lista de cervezas: ");
            foreach (var beer in beers)
            {
                if (beer != null)
                {
                    Console.WriteLine(beer);
                }
            }
            Console.WriteLine("Presiona una tecla para continuar...");
            Console.ReadLine();
        }

    }
}
