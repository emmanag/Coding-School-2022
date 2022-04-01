using BlackCoffeeshop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackCoffeeshop.EF.Repository
{
    public class MockTransaction : IEntityRepo<Transaction>
    {
        private readonly List<Transaction> _transactions;
        public MockTransaction()
        {
            _transactions = new List<Transaction>

            {
                new Transaction()
                {
                    ID = 1,
                    Date = DateTime.Now,
                    CustomerID = 1,
                    EmployeeID = 1,
                    TotalPrice = 7,
                    PaymentMethod = PaymentMethod.CreditCard            }
            };
        }
        public async Task Create(Transaction entity)
        {
            _transactions.Add(entity);
        }

        public async Task Delete(int id)
        {
            _transactions.Remove(GetById(id));
        }

        public List<Transaction> GetAll()
        {
            return _transactions;
        }

        public Transaction? GetById(int id)
        {
            return _transactions.SingleOrDefault(product => product.ID == id);
        }

        public async Task Update(int id, Transaction entity)
        {
            var foundTransaction = _transactions.SingleOrDefault(product => product.ID == id);

            if (foundTransaction is null)
                throw new KeyNotFoundException($"Given id '{id}' was not found");

            foundTransaction.Date = entity.Date;
            foundTransaction.CustomerID = entity.CustomerID;
            foundTransaction.EmployeeID = entity.EmployeeID;
            foundTransaction.TotalPrice = entity.TotalPrice;
            foundTransaction.PaymentMethod = entity.PaymentMethod;
            //foundTransaction.ID = entity.ID;
        }


    }
}
}
