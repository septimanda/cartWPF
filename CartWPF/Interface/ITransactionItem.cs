using CartWPF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartWPF.Interface
{
    interface ITransactionItem
    {
        List<TransactionItem> Get();
        TransactionItem Get(int id);
        bool Insert(TransactionItem transactionItem);
        bool Update(int id, TransactionItem transactionItem);
        bool Delete(int id);
    }
}
