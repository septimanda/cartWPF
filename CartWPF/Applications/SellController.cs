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
    class SellController : ISell
    {
        static MyContext myContext = new MyContext();
        bool status = false;

        SaveChange go = new SaveChange(myContext);

        public List<Sell> Get()
        {
            var get = myContext.Sells.Where(u => u.isDelete == false).ToList();
            return get;
        }

        public Sell Get(int id)
        {
            var get = myContext.Sells.Find(id);
            return get;
        }

        public bool Insert(Sell sell)
        {
            myContext.Sells.Add(sell);
            return go.saved();
        }


        public bool Update(int id, Sell sell)
        {
            if (Get(id) != null)
            {
                Get(id).OrderDate = sell.OrderDate;
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

