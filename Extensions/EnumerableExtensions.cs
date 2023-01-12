using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DroneDelivery.Extensions
{
    public static class EnumerableExtensions
    {
        public static IEnumerable<IEnumerable<T>> Combinations<T>(this IEnumerable<T> list, int y)
        {
            if (y == 0)
                return new[] { new T[0] };
            else {

                var res = list.SelectMany((e, i) =>
                          list.Skip(i + 1).Combinations(y - 1).Select(x => (new[] { e }).Concat(x)));
                return res;
            }
        }
    }
}
