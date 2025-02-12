using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session01.Test
{
    internal class Comparer : IEqualityComparer<Emp>
    {
        public bool Equals(Emp? x, Emp? y)
        {
            return x.Name == y.Name;
        }

        public int GetHashCode([DisallowNull] Emp obj)
        {
            return HashCode.Combine(obj.Name);
        }
    }
}
