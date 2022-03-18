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

        public T Create<T>() where T : new()
        {
            return new T();
            //return new TransactionLine();
        }

        public override void Delete<TransactionLine>(TransactionLine transactionLine, List<TransactionLine> transactionLines)
        {
            transactionLines.Remove(transactionLine);
        }

        public bool CheckEngineersAvail(List<Engineer> engineers)
        {
            return engineers.FindAll(e => e.Status == StatusEnum.Free).Count() > 0;
        }
    }
}
