using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Temporal.Models;

namespace Temporal.Controllers
{
    public class PruebasController : Controller
    {
        // GET: Pruebas
        public ActionResult Index()
        {
            //return Content("<h1>Index ASP.NET</h1>");
            var idgs902 = new Alumnos()
            {
                Name = "Mario",
                Email = "mar@gmail.com",
                Edad = 23
            };
            return Json(idgs902, JsonRequestBehavior.AllowGet);
            
        }
        public RedirectResult index2()
        {
            return Redirect("Index2");
        }
        public RedirectToRouteResult Index3()
        {
            return RedirectToAction("OperasBas", "Nuevo");
        }
        public ActionResult Index4()
        {
            ViewBag.Grupo = "IDSG902";
            ViewBag.Numero = 20;
            ViewBag.FechaInicio = new DateTime(2023,2,5);
            ViewData["Nombre"] = "Mario";
            return View();
        }
    }
}