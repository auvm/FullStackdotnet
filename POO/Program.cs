namespace POO.Clases
    /*En proyectos que no usen las instrucciones de nivel superior
     *solo usan el "using namespace nombre;" sin contener todo el código
     *lo que indica en ambos casos es que forma parte del mismo contenido y
     *por lo tanto también puede accedes y hacer uso de los demás elementos
    */
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var Corona = new Beer("Corona", 2.99m, -2);
            Console.WriteLine(Corona.getInfo());
            Console.WriteLine(Corona.SAlcohol);
        }
    }
}

