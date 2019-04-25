using CartWPF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartWPF.Interface
{
    interface ISell
    {
        List<Sell> Get();
        Sell Get(int id);
        bool Insert(Sell sell);
        bool Update(int id, Sell sell);
        bool Delete(int id);

    }
}
