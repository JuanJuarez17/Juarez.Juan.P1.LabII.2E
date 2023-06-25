using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITIES_APP
{
    public static class ListExtension
    {
        public static List<T> Filtrar<T>(this List<T> lista, Func<T, string, bool> criterioDeFiltrado, string valueFilter)
        {
            List<T> listaFiltrada = new List<T>();
            foreach (T item in lista)
            {
                if (criterioDeFiltrado(item, valueFilter))
                {
                    listaFiltrada.Add(item);
                }
            }
            return listaFiltrada;
        }
    }
}
