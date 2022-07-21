using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Pizza_Place.Models;
using Pizza_Place.Data;

namespace Pizza_Place.Pages.Forms
{
    public class CustomPizzaModel : PageModel
    {
        [BindProperty]
        public Pizzas Pizza { get; set; }
        public float PizzaPrice { get; set; }

        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            PizzaPrice = Pizza.BasePrice;

            if (Pizza.TomatoSauce) PizzaPrice += 500;
            if (Pizza.Cheese) PizzaPrice += 500;
            if (Pizza.Pepperoni) PizzaPrice += 500;
            if (Pizza.Mushroom) PizzaPrice += 500;
            if (Pizza.Bacon) PizzaPrice += 500;
            if (Pizza.Pineapple) PizzaPrice += 500;
            if (Pizza.Ham) PizzaPrice += 500;
            if (Pizza.Shrimp) PizzaPrice += 500;
            if (Pizza.Vegeterian) PizzaPrice += 500;
            if (Pizza.Pepperoni) PizzaPrice += 500;

            //Creates an object
            return RedirectToPage("/Checkout/Checkout", new {Pizza.PizzaName, PizzaPrice});
        }
    }
}
