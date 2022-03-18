using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary
{
    public class TransactionLineHandler
    {
        public TransactionLineHandler()
        {

        }

        //public T Create<T>() where T : new()
        //{
        //    return new T();
        //    //return new TransactionLine();
        //}

        public TransactionLine Create()
        {
            return new TransactionLine();
        }

        public void Delete(TransactionLine transactionLine, List<TransactionLine> transactionLines)
        {
            transactionLines.Remove(transactionLine);
        }

        public bool CheckEngineersAvail(List<Engineer> engineers)
        {
            return engineers.FindAll(e => e.Status == StatusEnum.Free).Count() > 0;
        }

        public void CalcTaskCost(TransactionLine transactionLine, ServiceTask serviceTask)
        {
            transactionLine.Price = transactionLine.PricePerHour * serviceTask.Hours;
        }
    }
}
