using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodsLibrary
{
    public sealed class GoodsList
    {
        public GoodsList()
        {
            Goods = new HashSet<Good>();
        }
        public HashSet<Good> Goods { get; set; }
    }
}
