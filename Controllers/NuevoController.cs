using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Temporal.Models;
using Temporal.Services;

namespace Temporal.Controllers
{
    public class NuevoController : Controller
    {
        // GET: Nuevo
        public ActionResult Ventana()
        {
            return View();
        }
        public ActionResult OperasBas(string n1, string n2, string op)
        {
            if (op == "suma")
            {
                int res = Convert.ToInt16(n1) + Convert.ToInt16(n2);
                ViewBag.Res = Convert.ToString(res);
            }
            else if (op == "resta")
            {
                int res = Convert.ToInt16(n1) - Convert.ToInt16(n2);
                ViewBag.Res = Convert.ToString(res);
            }
            else if (op == "multiplicacion")
            {
                int res = Convert.ToInt16(n1) * Convert.ToInt16(n2);
                ViewBag.Res = Convert.ToString(res);
            }
            else if (op == "division")
            {
                int res = Convert.ToInt16(n1) / Convert.ToInt16(n2);
                ViewBag.Res = Convert.ToString(res);
            }

            return View();
        }

        public ActionResult OperasBas2(Calculos op)
        {
            var model = new Calculos();

            model.Res = op.num1 + op.num2;
            ViewBag.Res = model.Res;
            return View(model);
        }

        public ActionResult Distancia(Distancia op)
        {
            var model = new Distancia();


            double Res = model.calcularDistancia(op.x1, op.x2, op.y1,op.y2);
            ViewBag.Res = Res;
            return View(model);
        }

        public ActionResult MuestraPulques() 
        {
            var pulques1 = new PulquesServices();
            var model = pulques1.ObtenerPulque();
            return View(model);
        }

        public ActionResult MuestraPulques2()
        {
            var pulques1 = new PulquesServices();
            var model = pulques1.ObtenerPulque();
            return View(model);
        }
    }
}