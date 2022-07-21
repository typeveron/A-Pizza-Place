using System;
namespace Pizza_Place.Models
{
    public class Pizzas
    {
        public string ImageTitle { get; set; }
        public string PizzaName { get; set; }
        public float BasePrice { get; set; } = 100;
        public bool TomatoSauce { get; set; }
        public bool Cheese { get; set; }
        public bool Pepperoni { get; set; }
        public bool Mushroom { get; set; }
        public bool Bacon { get; set; }
        public bool Pineapple { get; set; }
        public bool Ham { get; set; }
        public bool Vegeterian { get; set; }
        public bool Shrimp { get; set; }
        public float FinalPrice { get; set; }

    }
}

