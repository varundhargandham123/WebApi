using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebMvc.Models;
using System.Net.Http;
namespace WebMvc.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            IEnumerable<ProductViewmodel> pvmList;
            HttpResponseMessage response = GloVariable.webclient.GetAsync("https://localhost:44346/api/Products").Result;
            pvmList = response.Content.ReadAsAsync<IEnumerable<ProductViewmodel>>().Result;
            return View(pvmList);
        }

    }
}