using System;

namespace POO.Clases;

public class ExpiringBeer : Beer
{
    public DateTime ExpirationDate { get; set; }

    public ExpiringBeer(string name, decimal price, decimal alcohol, DateTime expirationDate)
        : base(name, price, alcohol)
    {
        ExpirationDate = expirationDate;
    }

    public override string getInfo()
    {
        return $"{base.getInfo()} Fecha de caducidad: {ExpirationDate.ToShortDateString()}";
    }
}
