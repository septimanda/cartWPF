using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartWPF.Model
{
    class Sell : BaseModel
    {
        public DateTimeOffset OrderDate { get; set; }
        public bool isDelete { get; set; }
    }
}
