using DataLibrary.ItemHandlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary
{
    public class TransactionHandler
    {
        public TransactionHandler()
        {

        }

        public Transaction Create()
        {
            return new Transaction();
        }

        public Transaction CreateWithDateTimeToday()
        {
            return new Transaction() { Date=DateTime.Today};
        }

        public void Delete(Transaction transaction, List<Transaction> transactions)
        {
            transactions.Remove(transaction);
        }

        public bool AddNewTransactionLine(Transaction transaction, TransactionLine transactionLine, CarServiceHandler carServiceHandler, CarService carService)
        {
            if (CheckWorkLoadAvail(carServiceHandler.GetMaxDayWorkload(carService), transactionLine, carServiceHandler.GetReservedHours(carService), CurentTransactionHours(transaction)))
            {
                transaction.TransactionLines.Add(transactionLine);
                carService.Engineers.FirstOrDefault(e => e.ID == transactionLine.EngineerID).Status = StatusEnum.InTask;
                return true;
            }
            return false;
        }

        public decimal CurentTransactionHours(Transaction transaction)
        {
            return transaction.TransactionLines.Sum(t => t.Hours);
        }

        public decimal GetTransactionPrice(Transaction transaction)
        {
            return transaction.TransactionLines.Sum(t => t.Price);
        }

        public bool CheckWorkLoadAvail(int maxDayWorkLoad, TransactionLine transactionLine, decimal reservedHours, decimal currentTransactionHours)
        {
            return maxDayWorkLoad >= reservedHours + currentTransactionHours + transactionLine.Hours;
        }
        public bool CheckEngineersAvail(List<Engineer> engineers)
        {
            return engineers.FindAll(e => e.Status == StatusEnum.Free).Count() > 0;
        }
    }
}
