using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparision3
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Comparison Compare = new Comparison();
            Compare.lineCompare(Compare.Line1(), Compare.Line2());
        }
    }
}
