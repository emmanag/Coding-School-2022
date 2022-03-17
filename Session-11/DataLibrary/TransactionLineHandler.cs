using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary
{
    public class TransactionLineHandler : ActionHandler
    {
        public TransactionLineHandler()
        {

        }

        public override object Create()
        {
            return new TransactionLine();
        }

        public override void Delete<TransactionLine>(TransactionLine transactionLine, List<TransactionLine> transactionLines)
        {
            transactionLines.Remove(transactionLine);
        }
    }
}
