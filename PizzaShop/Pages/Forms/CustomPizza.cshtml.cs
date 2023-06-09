using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PizzaShop.Models;

namespace PizzaShop.Pages.Forms
{
    public class CustomPizzaModel : PageModel
    {
        [BindProperty]
        public PizzasModel Pizza { get; set; }

        public float PizzaPrice { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            PizzaPrice = Pizza.BasePrice;
            if (Pizza.TomatoSauce) PizzaPrice += 10;
            if (Pizza.Tuna) PizzaPrice += 10;
            if (Pizza.Cheese) PizzaPrice += 10;
            if (Pizza.Mushroom) PizzaPrice += 10;
            if (Pizza.Peperoni) PizzaPrice += 10;
            if (Pizza.Pineapple) PizzaPrice += 10;

            return RedirectToPage("/Checkout/Checkout" , new { Pizza.PizzaName , PizzaPrice});
        }
    }
}
