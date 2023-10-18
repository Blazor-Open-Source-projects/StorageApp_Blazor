using System;
using System.ComponentModel.DataAnnotations;


namespace depooo.Shared.Model
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public double TotalPrice { get; set; }
        public string Description { get; set; }
        public double Quantity { get; set; }
    }
}
