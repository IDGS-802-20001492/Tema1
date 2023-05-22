using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Temporal.Models;

namespace Temporal.Controllers
{
    public class Pruebas2Controller : Controller
    {
        // GET: Pruebas2
        public ActionResult Index()
        {
            var alumno = new Alumnos()
            {
                Name = "Jimena",
                Email = "jlopez@gmail.com",
                Edad = 28,
                Activo = false,
                Inscripcion = new DateTime(2020, 4, 20)
            };
            ViewBag.Alumnos = alumno;
            return View();
        }
        public ActionResult Escuela()
        {
            var alumno = new Alumnos()
            {
                Name = "Jimena",
                Email = "jlopez@gmail.com",
                Edad = 28,
                Activo = false,
                Inscripcion = new DateTime(2020, 4, 20)
            };
            ViewBag.Alumnos = alumno;
            return View(alumno);
        }
    }
}