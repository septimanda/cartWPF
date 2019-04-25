using CartWPF.Interface;
using CartWPF.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CartWPF.Applications
{
    class ItemController : IItem
    {
        static MyContext myContext = new MyContext();
        
        SaveChange go = new SaveChange(myContext);

        public List<Item> Get()
        {
            var get = myContext.Items.Include("Suppliers").Where(x => x.isDelete == false).ToList();
            return get;
        }

        public Item Get(int id)
        {
            var get = myContext.Items.Find(id);
            return get;
        }

        public List<Item> GetList(int id)
        {
            var get = myContext.Items.Where(x => x.Suppliers.Id == id).ToList();
            return get;
        }

        public bool Insert(Item item)
        {
            myContext.Entry(item.Suppliers).State = EntityState.Unchanged;
            myContext.Items.Add(item);
            return go.saved();
        }


        public bool Update(int id, Item item)
        {
            var get = Get(id);

            if (get != null)
            {
                get.Name = item.Name;
                get.Stock = item.Stock;
                get.Price = item.Price;
                get.Suppliers = item.Suppliers;
                myContext.Entry(get.Suppliers).State = EntityState.Unchanged;
                myContext.Entry(get).State = EntityState.Modified;
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