using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Temporal.Models;
using Temporal.Services;

namespace Temporal.Controllers
{
    public class ArchivosController : Controller
    {
        // GET: Archivos
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Registrar()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Registrar(Maestros maes)
        {
            var ope1 = new GuardaService();
            ope1.GuardarArchivo(maes);
            return View(maes);
        }

        public ActionResult leerDatos()
        {
            var arch = new LeerService();
            ViewBag.Archivos = arch.LeerArchivo();
            return View();
        }
    }
}