using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebMvc.Models
{
    public class ProductViewmodel
    {
        public int PId { get; set; }
        public string ProductName { get; set; }
        public string ProductBrand { get; set; }
        public Nullable<int> ProductCost { get; set; }
    }
}