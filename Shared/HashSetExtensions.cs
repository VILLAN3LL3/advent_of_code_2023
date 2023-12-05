using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shared
{
    public static class HashSetExtensions
    {
        public static void AddRange<T>(this HashSet<T> set, IEnumerable<T> items) => items.ToList().ForEach(item => set.Add(item));
    }
}