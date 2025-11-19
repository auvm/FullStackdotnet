namespace POO.Clases
{
    public class Beer
    {
        #region Atributos (campos) y Propiedades
        private decimal _alcohol; //<-- Campo privado
        public string Name { get; set; } //<-- Propiedades automáticas
        public decimal Price { get; set; }

        public decimal Alcohol //<-- Propiedad personalizada
        {
            get { return _alcohol; }
            set
            {
                if (value < 0)
                {
                    _alcohol = 0;
                }
                else
                {
                    _alcohol = value;
                }
            }
        }

        #endregion

        #region Constructores

        /*Constructor vacío*/
        public Beer() { }

        /*Constructor con atributos*/
        public Beer(string name, decimal price, decimal alcohol)
        {
            Name = name;
            Price = price;
            Alcohol = alcohol;
        }

        #endregion

        #region Métodos
        public virtual string getInfo()
        {
            return $"Nombre: {Name} Precio: ${Price}";
        }

        public string SAlcohol
        {
            get
            {
                return $"Alcohol: {Alcohol}%";
            }
        }
        #endregion

    }
}