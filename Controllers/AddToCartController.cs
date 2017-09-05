using mvcCodeExercise.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcCodeExercise.Controllers
{
    public class AddToCartController : Controller
    {
        // GET: AddToCart
        public ActionResult Index()
        {
          
            return View((List<Product>)Session["cart"]);
        }

        public Product GetProductDetails(int productID)
        {
            var proItem = new Product();

            if (productID == 1)
            {
                proItem = new Product() { productID = 1, productCategory = "Sports", productDiscount = "20", productDescription = "Rider", productPrice = 111 };
            }
            else if (productID == 2)
            {
                proItem = new Product() { productID = 2, productCategory = "Apparels", productDiscount = "10", productDescription = "Jeans", productPrice = 112 };
            }
            else if (productID == 3)
            {
                proItem = new Product() { productID = 3, productCategory = "Stationary", productDiscount = "4", productDescription = "Pen Set", productPrice = 113 };
            }
            else if (productID == 4)
            {
                proItem = new Product() { productID = 4,productCategory = "Sports",productDiscount = "20", productDescription = "Dumbles",productPrice = 111};
            }
            else if (productID == 5)
            {
                proItem = new Product() { productID = 5, productCategory = "Apparels", productDiscount = "10", productDescription = "Trouser", productPrice = 112 };
            }
            else if (productID == 6)
            {
                proItem = new Product() { productID = 6, productCategory = "Stationary", productDiscount = "4", productDescription = "Notebooks", productPrice = 113 };
            }
            else if (productID == 7)
            {
                proItem = new Product() { productID = 7, productCategory = "Sports", productDiscount = "20", productDescription = "Slider", productPrice = 111 };
            }
            else if (productID == 8)
            {
                proItem = new Product() { productID = 8, productCategory = "Apparels", productDiscount = "10", productDescription = "Shirts", productPrice = 112 };
            }
            else if (productID == 9)
            {
                proItem = new Product() { productID = 9, productCategory = "Stationary", productDiscount = "4", productDescription = "Geometry Compass", productPrice = 113 };
            }
            else if (productID == 10)
            {
                proItem = new Product() { productID = 10, productCategory = "Sports", productDiscount = "20", productDescription = "Punching Bags", productPrice = 111 };
            }
            else if (productID == 11)
            {
                proItem = new Product() { productID = 11, productCategory = "Apparels", productDiscount = "10", productDescription = "Sarees", productPrice = 112   };
            }
            else if (productID == 12)
            {
                proItem = new Product() { productID = 12, productCategory = "Stationary", productDiscount = "4", productDescription = "Folders", productPrice = 113 };
            }
            return proItem;

        }
        // GET: AddToCart  
        public ActionResult Add(int id)
        {
            var proDetails = GetProductDetails(id);

           
            if (Session["cart"] == null)
            {
                List<Product> basketItem = new List<Product>();               

                basketItem.Add(proDetails);
                Session["cart"] = basketItem;
                ViewBag.cart = basketItem.Count();


                Session["count"] = 1;


            }
            else
            {
                List<Product> basketItem = (List<Product>)Session["cart"];
                basketItem.Add(proDetails);
                Session["cart"] = basketItem;
                ViewBag.cart = basketItem.Count();
                Session["count"] = Convert.ToInt32(Session["count"]) + 1;

            }

            proDetails = null;
            return RedirectToAction("Index", "Shop");


        }

        public ActionResult Remove(int id)
        {
            List<Product> basketItem = (List<Product>)Session["cart"];
            

            basketItem.RemoveAll(x => x.productID == id);
            Session["cart"] = basketItem;
            Session["count"] = Convert.ToInt32(Session["count"]) - 1;

            return RedirectToAction("Index", "AddToCart");

        }



    }
}