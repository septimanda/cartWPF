using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartWPF.Model
{
    class Item : BaseModel
    {
        public string Name { get; set; }
        public int Stock { get; set; }
        public int Price { get; set; }
        public bool isDelete { get; set; }
        public virtual Supplier Suppliers { get; set; }
    }
}
