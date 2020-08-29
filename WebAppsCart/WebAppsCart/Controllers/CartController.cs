using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppsCart.Models;
using WebAppsCart.ViewModel;

namespace WebAppsCart.Controllers
{
    public class CartController : Controller
    {
        AppsDb _context;
        List<ProductViewModel> cart;

        public CartController()
		{
            _context = new AppsDb();
            cart= new List<ProductViewModel>();
        }
        // GET: Cart
        public ActionResult Index()
        {
            
            return View();
        }
        public ActionResult Buy(int id)
        {
            var singleProduct = _context.Products.SingleOrDefault(c => c.Id == id);


            if (Session["cart"] == null)
            {
                cart.Add(new ProductViewModel { Product=singleProduct,Quantity=1});
                Session["cart"] = cart;
            }
            else
            {
                List<ProductViewModel> cart = (List<ProductViewModel>)Session["cart"];
                int index = isExist(id);
                if (index != -1)
                {
                    cart[index].Quantity++;
                }
                else
                {
                    cart.Add(new ProductViewModel { Product = singleProduct, Quantity = 1 });
                }
                Session["cart"] = cart;
            }
            return RedirectToAction("Index",cart);
        }
        private int isExist(int id)
        {
            List<ProductViewModel> cart = (List<ProductViewModel>)Session["cart"];
            for (int i = 0; i < cart.Count; i++)
                if (cart[i].Product.Id.Equals(id))
                    return i;
            return -1;
        }
    }
}