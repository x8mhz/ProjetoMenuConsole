using System;

namespace ProjetoMenu
{
    public class Product
    {
        public Product(string brand, string model, string description, int amount, decimal price)
        {
            Code = Guid.NewGuid();
            Brand = brand;
            Model = model;
            Description = description;
            Date = DateTime.Now.Date;
            Amount = amount;
            Price = price;
            Total = amount * price;
        }
        
        public int Id { get; set; }
        public Guid Code { get; private set; }
        public string Brand { get; private set; }
        public string Model  { get; private set; }
        public string Description { get; private set; }
        public DateTime Date { get; private set; }
        public int Amount { get; private set; }
        public decimal Price { get; private set; }
        public decimal Total { get; private set; }
    }
}