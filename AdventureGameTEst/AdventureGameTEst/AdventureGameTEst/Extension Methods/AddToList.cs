using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGameTEst.Extension_Methods
{
    public static class AddToList
    {
        public static void ListAdd<T>(this List<T> list, params T[] elements)
        {
            list.AddRange(elements);
        }
    }
}