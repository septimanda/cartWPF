using CartWPF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartWPF.Interface
{
    interface ISupplier
    {
        List<Supplier> Get();
        Supplier Get(int id);
        bool Insert(Supplier supplier);
        bool Update(int id, Supplier supplier);
        bool Delete(int id);
    }
}
