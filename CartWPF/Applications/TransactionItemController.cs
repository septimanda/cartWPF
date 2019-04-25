using CartWPF.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CartWPF.Model;
using System.Windows;
using System.Data.Entity;
namespace CartWPF.Applications
{
    class TransactionItemController : ITransactionItem
    {
        static MyContext myContext = new MyContext();
        
        SaveChange go = new SaveChange(myContext);

        public List<TransactionItem> Get()
        {
            var get = myContext.TransactionItems.Where(u => u.isDelete == false).ToList();
            return get;
        }

        public TransactionItem Get(int id)
        {
            var get = myContext.TransactionItems.Find(id);
            return get;
        }

        public bool Insert(TransactionItem transactionItem)
        {
            myContext.TransactionItems.Add(transactionItem);
            return true;
        }


        public bool Update(int id, TransactionItem transactionItem)
        {
            if (Get(id) != null)
            {
                Get(id).Quantity = transactionItem.Quantity;
                Get(id).Items = transactionItem.Items;
                Get(id).Sells = transactionItem.Sells;
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