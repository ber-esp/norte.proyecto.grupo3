using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace proyecto.ecommerce.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Productos()
        {
            return View();
        }
        public ActionResult Categorias()
        {
            return View();
        }
        public ActionResult Cuenta()
        {
            return View();
        }
        public ActionResult Contacto()
        {
            return View();
        }
        public ActionResult Compra()
        {
            return View();
        }
    }
}