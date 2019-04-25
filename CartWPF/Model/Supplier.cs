using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartWPF.Model
{
    class Supplier : BaseModel
    {
        public string Name { get; set; }
        public DateTimeOffset JoinDate { get; set; }
        public bool isDelete { get; set; }
    }
}
