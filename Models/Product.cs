using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mvcCodeExercise.Models
{
    public class Product
    {
        public int productID { get; set; }
        public string productCategory { get; set; }
        public string productDescription { get; set; }
        public string productDiscount { get; set; }
        public int productPrice { get; set; }
    }
       
}