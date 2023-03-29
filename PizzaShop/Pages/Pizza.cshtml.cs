using Microsoft.AspNetCore.Mvc.RazorPages;
using PizzaShop.Models;

namespace PizzaShop.Pages
{
    public class PizzaModel : PageModel
    {
        public List<PizzasModel> pizzasModels = new List<PizzasModel>
        {
            new PizzasModel(){ImageTitle = "Margerita", PizzaName = "Margerita", BasePrice = 2, TomatoSauce = true, Cheese = true, FinalPrice = 40},
            new PizzasModel(){ImageTitle = "Bolognese", PizzaName = "Bolognese", BasePrice = 30, TomatoSauce = true, Cheese = true, FinalPrice = 35},
            new PizzasModel(){ImageTitle = "Carbonara", PizzaName = "Carbonara", BasePrice = 40, Peperoni = true, Cheese = true, FinalPrice = 60},
            new PizzasModel(){ImageTitle = "Hawaiian", PizzaName = "Hawaiian", BasePrice = 30, TomatoSauce = true, Cheese = true, FinalPrice = 40},
            new PizzasModel(){ImageTitle = "MeatFeast", PizzaName = "MeatFeast", BasePrice = 25, TomatoSauce = true, Cheese = true, FinalPrice = 35},
            new PizzasModel(){ImageTitle = "Mushroom", PizzaName = "Mushroom", BasePrice = 25,TomatoSauce = true, Cheese = true, FinalPrice = 50},
            new PizzasModel(){ImageTitle = "Pepperoni", PizzaName = "Pepperoni", BasePrice = 35,TomatoSauce = true, Cheese = true, FinalPrice = 45}
        };



        public void OnGet()
        {
        }
    }
}
