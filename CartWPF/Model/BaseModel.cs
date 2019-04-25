using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartWPF.Model
{
    class BaseModel
    {
        [Key]
        public int Id { get; set; }
    }
}
