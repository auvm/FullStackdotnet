var Corona = new Beer("Corona", 2.99m, -2);

Console.WriteLine(Corona.getInfo());

Console.WriteLine(Corona.SAlcohol);





public class Beer
{
    private decimal _alcohol; //<-- Campo privado
    public string Name { get; set; } //<-- Propiedades
    public decimal Price { get; set; }

    public decimal Alcohol //<-- Propiedad personalizada
    {
        get { return _alcohol; }
        set
        {
            if(value < 0)
            {
                _alcohol = 0;
            }
            else
            {
                _alcohol = value;
            }
        }
    }
    
    public string SAlcohol
    {
        get
        {
            return $"Alcohol: {Alcohol}%";
        }
    }



    /*Constructor vacío*/
    public Beer() { }

    /*Constructor con atributos*/
    public Beer(string name, decimal price, decimal alcohol)
    {
        Name = name;
        Price = price;
        Alcohol = alcohol;
    }



    public string getInfo()
    {
        return $"Nombre: {Name} Precio: ${Price}";
    }


}