using BookApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookApp.Controllers
{
    public class PurchaseController : Controller
    {
        private IPurchaseRespository repo { get; set; }
        private Basket basket { get; set; }
        public PurchaseController(IPurchaseRespository temp, Basket b)
        {
            repo = temp;
            basket = b;
        }

        [HttpGet]
        public IActionResult Checkout()
        {
            return View(new Pay());
        }
        [HttpPost]
        public IActionResult Checkout(Pay payment)
        {
            if (basket.Items.Count() == 0)
            {
                ModelState.AddModelError("", "Sorry, your cart is empty.");
            }

            if (ModelState.IsValid)
            {
                payment.Lines = basket.Items.ToArray();
                repo.SavePayment(payment);
                basket.ClearBasket();

                return RedirectToPage("/ConfirmationPage");
            }

            else
            {
                return View();
            }
        }
    }
}
