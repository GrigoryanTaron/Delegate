using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    public static class Extension
    {
        public static T _Last<T>(this IEnumerable<T> source, Func<T, bool> predicate)
        {
            if (source == null) throw new ArgumentNullException("source");
            if (predicate == null) throw new ArgumentNullException("predicate");
            T res = default(T);
            bool found = false;
            foreach (T element in source)
            {
                if (predicate(element))
                {
                    res = element;
                    found = true;
                }
            }
            if (found) return res;
            throw new KeyNotFoundException();
        }
    }
}
