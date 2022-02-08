using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using COMP2139_KRN_GENIUS.Models;

namespace COMP2139_KRN_GENIUS.Controllers
{
    public class ProductController : Controller
    {
        // GET: ProductController
        public ActionResult List()
        {
            return View();
        }

        public ActionResult Add()
        {
            return View();
        }
    } 
}
