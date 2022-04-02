using System.Collections.Generic;

namespace CasaPopular.Utils
{
    public static class ExtensaoNumeros
    {
        public static bool EstaEntre<T>(this T item, T inicio, T fim)
        {
            return Comparer<T>.Default.Compare(item, inicio) >= 0
                && Comparer<T>.Default.Compare(item, fim) <= 0;
        }
    }
}
