using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodsLibrary
{
    public class Good
    {
        public double Price { get; set; }
        public string Country { get; set; }
        public string Name { get; set; }
        public DateTime DateOfPackaging { get; set; }
        public string Describing { get; set; }
    }
}
