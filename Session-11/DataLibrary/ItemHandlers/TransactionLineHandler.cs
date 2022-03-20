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

        public TransactionLine Create()
        {
            return new TransactionLine();
        }

        public void Delete(TransactionLine transactionLine, List<TransactionLine> transactionLines, CarService carService)
        {
            if (transactionLine != null)
                carService.Engineers.FirstOrDefault(e => e.ID == transactionLine.EngineerID).Status = StatusEnum.Free;
            transactionLines.Remove(transactionLine);
        }


        public decimal CalcTaskCost(TransactionLine transactionLine, ServiceTask serviceTask)
        {
            transactionLine.Price = transactionLine.PricePerHour * serviceTask.Hours;
            return transactionLine.Price;
        }
    }
}
