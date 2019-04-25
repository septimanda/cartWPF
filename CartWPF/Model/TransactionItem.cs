using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartWPF.Model
{
    class TransactionItem : BaseModel
    {
        public int Quantity { get; set; }
        public bool isDelete { get; set; }
        public virtual Item Items { get; set; }
        public virtual Sell Sells { get; set; }
    }
}
