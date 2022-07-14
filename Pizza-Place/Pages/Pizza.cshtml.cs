using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Pizza_Place.Models;

namespace Pizza_Place.Pages
{
    public class PizzaModel : PageModel
    {

        public List<Pizzas> PizzaDb = new List<Pizzas>()  {


        new Pizzas() { ImageTitle = "Margerita", PizzaName = "Margerita", BasePrice = 100, TomatoSauce = true, Cheese = true, FinalPrice = 1100 },
        new Pizzas() { ImageTitle = "Bolognese", PizzaName = "Bolognese", BasePrice = 100, TomatoSauce = true, Cheese = true, Bacon = true, FinalPrice = 1600 },
        new Pizzas() { ImageTitle = "Hawaiian", PizzaName = "Hawaiian", BasePrice = 100, TomatoSauce = true, Cheese = true, Ham = true, Pineapple = true, FinalPrice = 2100 },
        new Pizzas() { ImageTitle = "MeatFeast", PizzaName = "MeatFeast", BasePrice = 100, TomatoSauce = true, Cheese = true, Ham = true, Bacon = true, FinalPrice = 2100 },
        new Pizzas() { ImageTitle = "Mushroom", PizzaName = "Mushroom", BasePrice = 100, TomatoSauce = true, Cheese = true, Mushroom = true, FinalPrice = 1600 },
        new Pizzas() { ImageTitle = "Pepperoni", PizzaName = "Pepperoni", BasePrice = 100, TomatoSauce = true, Cheese = true, Peperoini = true, FinalPrice = 1600 },
        new Pizzas() { ImageTitle = "Vegetarian", PizzaName = "Vegetarian", BasePrice = 100, TomatoSauce = true, Cheese = true, Mushroom = false, Pineapple = true, FinalPrice = 1600 },
        new Pizzas() { ImageTitle = "Carbonara", PizzaName = "Carbonara", BasePrice = 100, TomatoSauce = true, Cheese = true, Ham = true, Mushroom = true, FinalPrice = 2100 },
        new Pizzas() { ImageTitle = "Seafood", PizzaName = "Seafood", BasePrice = 100, TomatoSauce = true, Cheese = true, Shrimp = true,  FinalPrice = 1600 },
     
        };

        public void OnGet()
        {

        }
    }
}




