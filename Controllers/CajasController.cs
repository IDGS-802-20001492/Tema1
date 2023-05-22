using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Temporal.Controllers
{
    public class CajasController : Controller
    {
        // GET: Cajas
        public ActionResult Index(string num1)
        {
            ViewBag.num1 = Convert.ToInt16(num1);
            return View();
        }
        public ActionResult Res(string[] ids)
        {
            int res = 0;
            List<string> repetidos = new List<string>();

            List<int> numeros = new List<int>();
            foreach (var id in ids)
            {
                int numero = Convert.ToInt32(id);
                numeros.Add(numero);
                res += numero;
            }

            List<int> vistos = new List<int>();
            foreach (var numero in numeros)
            {
                if (vistos.Contains(numero))
                    continue;

                int conteo = numeros.Count(n => n == numero);
                vistos.Add(numero);

                if (conteo > 1)
                    repetidos.Add($"{numero} se repitió {conteo} veces");
            }

            ViewBag.Res = res;
            ViewBag.Repetidos = repetidos;
            ViewBag.ids = ids.ToArray();
            return View();
        }

    }
}