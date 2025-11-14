Beer erdinger = new Beer
{
    Name = "Erdinger",
    Price = 3.33m
};


System.Console.WriteLine(erdinger.Name);
var Corona = new Beer();
Corona.Name = "Corona";
Corona.Price = 2.99m;

erdinger.getInfo();
Corona.getInfo();





public class Beer
{
    public string Name { get; set; }
    public decimal Price { get; set; }


    /*Constructor vacío*/
    public Beer() { }

    /*Constructor con atributos*/
    public Beer(string name, decimal price)
    {
        Name = name;
        Price = price;
    }



    public void getInfo()
    {
        System.Console.WriteLine($"Nombre: {Name} Precio: ${Price}");
    }


}