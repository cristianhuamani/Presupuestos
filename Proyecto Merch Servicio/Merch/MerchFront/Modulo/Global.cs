using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MerchFront
{
    static class Global
    {
        public static string tituloPres = "Aviso Presupuesto";
        public static string tituloPer = "Aviso Operaciones";
        public static string _Usr = "";

        public static decimal ConvertirDecimal(string Texto)
        {
            return Convert.ToDecimal(Texto, new System.Globalization.CultureInfo("es-PE"));
        }

    }
}
