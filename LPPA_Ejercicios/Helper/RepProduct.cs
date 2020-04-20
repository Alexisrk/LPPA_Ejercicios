using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LPPA_Ejercicios.Helper
{
    public static class RepProduct
    {
        private static IList<Producto> data = new List<Producto>();

        public static IList<Producto> GetAll()
        {
            return data;
        }

        public static void Add(Producto prod)
        {
            data.Add(prod);
        }

    }
}