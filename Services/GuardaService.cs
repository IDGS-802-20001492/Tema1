using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using Temporal.Models;

namespace Temporal.Services
{
    public class GuardaService
    {
        public void GuardarArchivo(Maestros maes)
        {
            var nombre = maes.Nombre;
            var apaterno = maes.Apaterno;
            var amaterno = maes.Amaterno;
            var edad = maes.Edad;
            var email = maes.Email;
            var datos = nombre + "," + apaterno + "," + amaterno + "," + edad + "," 
                + email+Environment.NewLine;
            var archivo = HttpContext.Current.Server.MapPath("~/App_Data/maestros.txt");
            File.AppendAllText(archivo, datos);
        }
    }
}