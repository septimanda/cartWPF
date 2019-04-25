using CartWPF.Interface;
using CartWPF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Windows;

namespace CartWPF.Applications
{
    class SupplierController : ISupplier
    {
        static MyContext myContext = new MyContext();
        
        SaveChange go = new SaveChange(myContext);

        public List<Supplier> Get()
        {
            var get = myContext.Suppliers.Where(u => u.isDelete == false).ToList();
            return get;
        }

        public Supplier Get(int id)
        {
            var get = myContext.Suppliers.Find(id);
            return get;
        }

        public bool Insert(Supplier supplier)
        {
            myContext.Suppliers.Add(supplier);
            return go.saved();
        }


        public bool Update(int id, Supplier supplier)
        {
            if (Get(id) != null)
            {
                Get(id).Name = supplier.Name;
                myContext.Entry(Get(id)).State = EntityState.Modified;
            }
            else
            {
                MessageBox.Show("Cant Find The ID.");
            }
            return go.saved();
        }

        public bool Delete(int id)
        {
            Get(id).isDelete = true;
            myContext.Entry(Get(id)).State = EntityState.Modified;
            return go.saved();
        }        
    }
}

