using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary
{
    public class TransactionHandler : ActionHandler
    {
        public TransactionHandler()
        {

        }

        public override object Create()
        {
            return new Transaction();
        }

        public override void Delete<Transaction>(Transaction transaction, List<Transaction> transactions)
        {
            transactions.Remove(transaction);
        }
    }
}
