using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Temporal.Models
{
    public class Distancia
    {
        public int x1 { get; set; }

        public int x2 { get; set; }

        public int y1 { get; set; }

        public int y2 { get; set; }

        public double Res { get; set; }

        public double calcularDistancia(int x1, int x2, int y1, int y2)
        {

            double res = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            return res;
        }
    }
}