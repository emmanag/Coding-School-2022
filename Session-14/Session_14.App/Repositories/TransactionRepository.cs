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
    public class TransactionRepository : IEntityRepo<Transaction>
    {
        public async Task Create(Transaction entity)
        {
            using var context = new Session_14Context();
            context.Transactions.Add(entity);
            await context.SaveChangesAsync();
        }

        public async Task Delete(Guid id)
        {
            using var context = new Session_14Context();
            var foundTransaction = context.Transactions.SingleOrDefault(transaction => transaction.ID == id);
            if (foundTransaction is null)
                return;

            context.Transactions.Remove(foundTransaction);
            await context.SaveChangesAsync();
        }

        public List<Transaction> GetAll()
        {
            using var context = new Session_14Context();
            return context.Transactions.ToList();
        }

        public Transaction? GetById(Guid id)
        {
            using var context = new Session_14Context();
            return context.Transactions.Where(transaction => transaction.ID == id).SingleOrDefault();
        }



        public async Task Update(Guid id, Transaction entity)
        {
            using var context = new Session_14Context();
            var foundTransaction = context.Transactions.SingleOrDefault(transaction => transaction.ID == id);
            if (foundTransaction is null)
                return;

            foundTransaction.Date = entity.Date;
            foundTransaction.CustomerID = entity.CustomerID;
            foundTransaction.CarID = entity.CarID;
            foundTransaction.ManagerID = entity.ManagerID;
            foundTransaction.TotalPrice = entity.TotalPrice;
            await context.SaveChangesAsync();
        }


    }
}
