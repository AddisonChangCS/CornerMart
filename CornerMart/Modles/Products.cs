using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CornerMart.Modles
{
    internal class Products
    {
        public string Name { get; set; }
        public string Size {  get; set; }
        public Products(string  name, string size)
        {
            Name = name;
            Size = size;
        }
    }
}
