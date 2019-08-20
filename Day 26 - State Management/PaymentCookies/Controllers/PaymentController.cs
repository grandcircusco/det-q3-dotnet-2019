using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using PaymentCookies.Models;

namespace PaymentCookies.Controllers
{
    public class PaymentController : Controller
    {
        List<Items> availableItems = new List<Items>()
        {
            new Items{Name="Salad", Price=20.00M, Quantity=1},
            new Items{Name="Ramen", Price=0.40M, Quantity=1},
            new Items{Name="Pizza", Price=12.99M, Quantity=10},
            new Items{Name="CocaCola", Price=2.74M, Quantity=3},
            new Items{Name="Pizza Scones", Price=9.00M, Quantity=2},
            new Items{Name="Ravioli", Price=5, Quantity=1}
        };

        List<Items> shoppingCart = new List<Items>();

        public IActionResult ListItems()
        {
            return View(availableItems);
            //return View("ListItems", availableItems);
        }

        public IActionResult AddItemToCart(Items item)
        {
            string shoppingCartJson = HttpContext.Session.GetString("ShoppingCartSession");
            if ( shoppingCartJson != null)
            {
                //This if-statement is retrieving any items already added to the shopping cart.
                shoppingCart = JsonConvert.DeserializeObject<List<Items>>(shoppingCartJson);
            }

            shoppingCart.Add(item);
            HttpContext.Session.SetString("ShoppingCartSession", JsonConvert.SerializeObject(shoppingCart));
            //Set("ShoppingCart", shoppingCart);

            return View("ListItems", availableItems);
        }

        public IActionResult ShoppingCartList()
        {
            string shoppingCartJson = HttpContext.Session.GetString("ShoppingCartSession");
            if(shoppingCartJson != null)
            {
                shoppingCart = JsonConvert.DeserializeObject<List<Items>>(shoppingCartJson);
            }

            return View("ListItems", shoppingCart);
        }

        public IActionResult PaymentForm()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SavePaymentInfo(CreditCard credit, string SavePayment)
        {
            if (SavePayment == "yes")
            {
                //add a cookie to the browser save the user's payment information
                CookieOptions option = new CookieOptions();
                Response.Cookies.Append("CreditCardNumber", credit.Number, option);
                Response.Cookies.Append("CreditCardName", credit.Name, option);
            }
            return RedirectToAction("ProcessPayment", credit);
        }

        public IActionResult ProcessPayment(CreditCard credit)
        {
            //get the shopping list from a session

            //add total from the shopping list

            //use creditCard to finish up transaction

            return View("Receipt");
        }
    }
}