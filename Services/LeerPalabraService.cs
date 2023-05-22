using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Security.AntiXss;

namespace Temporal.Services
{
    public class LeerPalabraService
    {
        public Array LeerIngles()
        {
            Array pIngles = null;
            var datos = HttpContext.Current.Server.MapPath("~/App_Data/palabrasIngles.txt");
            if (File.Exists(datos))
            {
                pIngles = File.ReadAllLines(datos);
            }
            return pIngles;
        }
        public Array LeerEspanol()
        {
            Array pEspanol = null;
            var datos = HttpContext.Current.Server.MapPath("~/App_Data/palabrasEspanol.txt");
            if (File.Exists(datos))
            {
                pEspanol = File.ReadAllLines(datos);
            }
            return pEspanol;
        }
        public string traducir(string buscarPalabra, string idioma)
        {
            string pMinus = buscarPalabra.ToLower();

            string[] pIngles = null;
            string[] pEspanol = null;

            if (idioma == "1") // ingles
            {
                var datosI = HttpContext.Current.Server.MapPath("~/App_Data/palabrasIngles.txt");
                var datosE = HttpContext.Current.Server.MapPath("~/App_Data/palabrasEspanol.txt");

                if (File.Exists(datosI))
                {
                    pIngles = File.ReadAllLines(datosI);
                }
                if (File.Exists(datosE))
                {
                    pEspanol = File.ReadAllLines(datosE);
                }

                var pRecortadasI = new List<string>();
                var pRecortadasE = new List<string>();

                foreach (var item in pIngles)
                {
                    pRecortadasI.AddRange(item.Split(','));
                }
                foreach (var item in pEspanol)
                {
                    pRecortadasE.AddRange(item.Split(','));
                }

                for (int i = 0; i < pRecortadasI.Count(); i++)
                {
                    if (pRecortadasI[i].ToLower() == pMinus)
                    {
                        return pRecortadasE[i];
                    }
                }

                return "No se encontro la palabra";
            }

            else if(idioma == "2")//español
            {
                var datosI = HttpContext.Current.Server.MapPath("~/App_Data/palabrasIngles.txt");
                var datosE = HttpContext.Current.Server.MapPath("~/App_Data/palabrasEspanol.txt");

                if (File.Exists(datosI))
                {
                    pIngles = File.ReadAllLines(datosI);
                }
                if (File.Exists(datosE))
                {
                    pEspanol = File.ReadAllLines(datosE);
                }

                var pRecortadasI = new List<string>();
                var pRecortadasE = new List<string>();

                foreach (var item in pIngles)
                {
                    pRecortadasI.AddRange(item.Split(','));
                }
                foreach (var item in pEspanol)
                {
                    pRecortadasE.AddRange(item.Split(','));
                }

                for (int i = 0; i < pRecortadasI.Count(); i++)
                {
                    if (pRecortadasE[i].ToLower() == pMinus)
                    {
                        return pRecortadasI[i];
                    }
                }

                return "No se encontro la palabra";
            }
            else
            {
                return "No se encontro la palabra, intente cambiar de idioma";
            }
        }
    }
}