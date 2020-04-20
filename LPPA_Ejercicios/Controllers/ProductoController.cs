using LPPA_Ejercicios.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LPPA_Ejercicios.Controllers
{
    public class ProductoController : Controller
    {
        // GET: Producto
        public ActionResult Index()
        {
            return View(RepProduct.GetAll());
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Producto form)
        {
            RepProduct.Add(form);
            return RedirectToAction("Index");
        }
    }
}