using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing.Printing;
using System.Linq;
using System.Web;

namespace Temporal.Services
{
    public class TrianguloService
    {
        public string CalcularT(double x1, double y1, double x2, double y2, double x3, double y3)
        {
            string tipo = "";
            double area = 0;

            double lado1 = Math.Sqrt(Math.Pow((y2 - y1), 2) + Math.Pow((x2 - x1), 2));
            double lado2 = Math.Sqrt(Math.Pow((y1 - y3), 2) + Math.Pow((x1 - x3), 2));
            double lado3 = Math.Sqrt(Math.Pow((y3 - y2), 2) + Math.Pow((x3 - x2), 2));

            double mayor = Math.Max(Math.Max(lado1, lado2), lado3);

            if (lado1 == 0 || lado2 == 0 || lado3 == 0)
            {
                
                return "No es triangulo";
            }
            else if (!(mayor < (lado1 + lado2 + lado3 - mayor))) 
            {
                return "No es triangulo";
            }
            else
            {
                if (Math.Round(lado1, 2) == Math.Round(lado2, 2) && Math.Round(lado2, 2) == Math.Round(lado3, 2))
                {
                    tipo = "Equilatero";
                    double h = lado1 * Math.Sqrt(3) / 2;
                    area = (lado1 * h) / 2;
                }
                else if(Math.Round(lado1, 2) == Math.Round(lado2, 2) || Math.Round(lado2, 2) == Math.Round(lado3, 2) || Math.Round(lado1, 2) == Math.Round(lado3, 2))
                {
                    tipo = "Isosceles";
                    area = Math.Abs((x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2)) / 2);
                }
                else
                {
                    tipo = "Escaleno";
                    area = Math.Abs((x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2)) / 2);

                }
                
            }
            return "Triangulo: " + tipo+ "\nÁrea: "+area+" Unidades cuadradas";
        }
    }
}