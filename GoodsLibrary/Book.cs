using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodsLibrary
{
    public sealed class Book:Good
    {
        public int PagesCount { get; set; }
        public string Publishing { get; set; }
        public string Authors { get; set; }
    }
}
