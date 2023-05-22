using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using Temporal.Models;

namespace Temporal.Services
{
    public class GuardarPalabraService
    {
        public void GuardarPalabra(Diccionario dic)
        {
            var palabraIngles = dic.palabraIngles;
            var palabraEspanol = dic.palabraEspanol;

            var datosIngles = palabraIngles + "," + Environment.NewLine;
            var datosEspanol = palabraEspanol + "," + Environment.NewLine;

            var archivoIngles = HttpContext.Current.Server.MapPath("~/App_Data/palabrasIngles.txt");
            var archivoEspanol = HttpContext.Current.Server.MapPath("~/App_Data/palabrasEspanol.txt");

            File.AppendAllText(archivoIngles, datosIngles);
            File.AppendAllText(archivoEspanol, datosEspanol);
        }
    }
}