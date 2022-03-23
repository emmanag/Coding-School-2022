using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Session_14.model;
using TodoApp.EF.Repositories;


namespace Session_14.App.Repositories
{
    public class TransactionLineRepository : IEntityRepo<TransactionLine>
    {
        public async Task Create(TransactionLine entity)
        {
            using var context = new Session_14Context();
            context.TransactionLines.Add(entity);
            await context.SaveChangesAsync();
        }

        public async Task Delete(Guid id)
        {
            using var context = new Session_14Context();
            var foundTransactionLine = context.TransactionLines.SingleOrDefault(transactionLine => transactionLine.ID == id);
            if (foundTransactionLine is null)
                return;

            context.TransactionLines.Remove(foundTransactionLine);
            await context.SaveChangesAsync();
        }

        public List<TransactionLine> GetAll()
        {
            using var context = new Session_14Context();
            return context.TransactionLines.ToList();
        }

        public TransactionLine? GetById(Guid id)
        {
            using var context = new Session_14Context();
            return context.TransactionLines.Where(transactionLine => transactionLine.ID == id).SingleOrDefault();
        }



        public async Task Update(Guid id, TransactionLine entity)
        {
            using var context = new Session_14Context();
            var foundTransactionLine = context.TransactionLines.SingleOrDefault(transactionLine => transactionLine.ID == id);
            if (foundTransactionLine is null)
                return;

            foundTransactionLine.TransactionID = entity.TransactionID;
            foundTransactionLine.ServiceTaskID = entity.ServiceTaskID;
            foundTransactionLine.EngineerID = entity.EngineerID;
            foundTransactionLine.Hours = entity.Hours;
            foundTransactionLine.Price = entity.Price;
            await context.SaveChangesAsync();
        }


    }
}
