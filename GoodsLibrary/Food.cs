using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodsLibrary
{
    public sealed class Food:Good
    {
        public DateTime ExpirationDate { get; set; }
        public int Count { get; set; }
        public string MeasureUnit { get; set; }
    }
}
