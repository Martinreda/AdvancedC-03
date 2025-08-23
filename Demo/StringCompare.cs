using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class StringCompare : IComparer<string>
    {
        public int Compare(string? x, string? y)
        {
            return y.CompareTo(x);
        }
    }
}
