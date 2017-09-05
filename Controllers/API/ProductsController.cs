    using mvcCodeExercise.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace mvcCodeExercise.Controllers.API
{
    public class ProductsController : ApiController
    {
        static List<Product> products = new List<Product>()
            {
                new Product() {productID=1,productCategory="Sports",productDiscount="20", productDescription="Rider",productPrice=111},
                new Product() {productID=2,productCategory="Apparels",productDiscount="10",productDescription="Jeans",productPrice=112},
                new Product() {productID=3,productCategory="Stationary",productDiscount="4",productDescription="Pen Set",productPrice=113},
                 new Product() {productID=4,productCategory="Sports",productDiscount="20", productDescription="Dumbles",productPrice=111},
                new Product() {productID=5,productCategory="Apparels",productDiscount="10",productDescription="Trouser",productPrice=112},
                new Product() {productID=6,productCategory="Stationary",productDiscount="4",productDescription="Notebooks",productPrice=113},
                 new Product() {productID=7,productCategory="Sports",productDiscount="20", productDescription="Slider",productPrice=111},
                new Product() {productID=8,productCategory="Apparels",productDiscount="10",productDescription="Shirts",productPrice=112},
                new Product() {productID=9,productCategory="Stationary",productDiscount="4",productDescription="Geometry Compass",productPrice=113},
                 new Product() {productID=10,productCategory="Sports",productDiscount="20", productDescription="Punching Bags",productPrice=111},
                new Product() {productID=11,productCategory="Apparels",productDiscount="10",productDescription="Sarees",productPrice=112},
                new Product() {productID=12,productCategory="Stationary",productDiscount="4",productDescription="Folders",productPrice=113}

            };


        // Get /api/products
        public IEnumerable<Product> GetProducts()
        {
            return products;
        }
    }
}
