using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Temporal.Models;

namespace Temporal.Services
{
    public class PulquesServices
    {
        public List<Pulques> ObtenerPulque()
        {
            var pulque1 = new Pulques()
            {
                Producto = "Pulque1",
                Litros = 20,
                Creacion = new DateTime(2023, 11, 5),
                Descripcion = "Mango Piña"
            };
            var pulque2 = new Pulques()
            {
                Producto = "Pulque2",
                Litros = 35,
                Creacion = new DateTime(2023, 5, 10),
                Descripcion = "Frutos Rojos"
            };
            return new List<Pulques> { pulque1, pulque2};
        }
    }
}