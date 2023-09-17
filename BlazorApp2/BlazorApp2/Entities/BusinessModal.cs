using Microsoft.AspNetCore.Components;

namespace BlazorApp2.Entities
{
    public class BusinessModalClass
    {
        public bool modalVisible { get; set; }
        public List<Animal> Animales { get; set; }
        public decimal total { get; set; }
        public decimal totalDiscount { get; set; }
        public decimal shipping { get; set; }
        public decimal discount { get; set; }
        public decimal freightvalue { get; set; }
    }
}
