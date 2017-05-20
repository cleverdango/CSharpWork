using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library264
{
    class Product264
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }

        public override string ToString()
        {
            return String.Format("{0}\t单价：{1}\t数量：{2}",this.Name, this.Price, this.Quantity);
        }
    }
}
