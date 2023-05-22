using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Temporal.Models;
using Temporal.Services;

namespace Temporal.Controllers
{
    public class DiccionarioController : Controller
    {
        // GET: Diccionario
        public ActionResult Registrar()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Registrar(Diccionario dic)
        {
            var reg = new GuardarPalabraService();
            reg.GuardarPalabra(dic);
            return View();
        }
        public ActionResult Buscar()
        {
            var leerPI = new LeerPalabraService();
            ViewBag.pIngles = leerPI.LeerIngles();
            ViewBag.pEspanol = leerPI.LeerEspanol();            
            return View();
        }
        [HttpPost]
        public ActionResult Buscar(string buscarPalabra, string selIdioma)
        {
            var leerPI = new LeerPalabraService();
            ViewBag.pIngles = leerPI.LeerIngles();
            ViewBag.pEspanol = leerPI.LeerEspanol();

            ViewBag.res = leerPI.traducir(buscarPalabra, selIdioma);

            return View();
        }
    }
    }
