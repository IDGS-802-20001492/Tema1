using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Temporal.Services;

namespace Temporal.Controllers
{
    public class TrianguloController : Controller
    {
        // GET: Triangulo
        public ActionResult obtenerLados()
        {
            return View();
        }
        [HttpPost]
        public ActionResult obtenerLados(string x1, string  y1, string x2, string y2, string x3, string y3)
        {
            var triangulo = new TrianguloService();
            ViewBag.tipo = triangulo.CalcularT(Convert.ToDouble(x1),
                                               Convert.ToDouble(y1),
                                               Convert.ToDouble(x2),
                                               Convert.ToDouble(y2),
                                               Convert.ToDouble(x3),
                                               Convert.ToDouble(y3));
            return View();
        }

    }
}