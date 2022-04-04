using BlackCoffeeshop.EF.Context;
using BlackCoffeeshop.EF.Repository;
using BlackCoffeeshop.Model;
using Microsoft.EntityFrameworkCore;

namespace BlackCoffeeshop.EF.Configuration {
    public class TransactionRepo : IEntityRepo<Transaction> {
        private readonly ApplicationContext context;
        public TransactionRepo(ApplicationContext dbCOntext) {
            context = dbCOntext;
        }
        public async Task Create(Model.Transaction entity) {
            using var context = new ApplicationContext();
            context.Transactions.Add(entity);
            await context.SaveChangesAsync();
        }

        public Task CreateAsync(Transaction entity) {
            throw new NotImplementedException();
        }

        public async Task Delete(int id) {
            using var context = new ApplicationContext();
            var foundTrans = context.Transactions.SingleOrDefault(trans => trans.ID == id);
            if (foundTrans is null)
                return;

            context.Transactions.Remove(foundTrans);
            await context.SaveChangesAsync();
        }

        public Task DeleteAsync(int id) {
            throw new NotImplementedException();
        }

        public List<Model.Transaction> GetAll() {
            using var context = new ApplicationContext();
            return context.Transactions.ToList();
        }

        public Task<IEnumerable<Transaction>> GetAllAsync() {
            throw new NotImplementedException();
        }

        public Model.Transaction? GetById(int id) {
            using var context = new ApplicationContext();
            return context.Transactions.Where(trans => trans.ID == id).SingleOrDefault(); ;
        }

        public async Task<Transaction?> GetByIdAsync(int id) {
            return await context.Transactions.SingleOrDefaultAsync(trans => trans.ID == id);
        }

        public async Task Update(int id, Transaction entity) {
            using var context = new ApplicationContext();
            var foundTrans = context.Transactions.SingleOrDefault(trans => trans.ID == id);
            if (foundTrans is null)
                return;

            foundTrans.Date = entity.Date;
            foundTrans.EmployeeID = entity.EmployeeID;
            foundTrans.CustomerID = entity.CustomerID;
            foundTrans.TransactionLines = entity.TransactionLines;
            foundTrans.PaymentMethod = entity.PaymentMethod;
            foundTrans.TotalPrice = entity.TotalPrice;
            foundTrans.TotalCost = entity.TotalCost;
            foundTrans.EmployeeName = entity.EmployeeName;
            foundTrans.Customer = entity.Customer;
            foundTrans.Employee = entity.Employee;
          /*  foundTrans.ProductCategory = entity.ProductCategory;
            foundTrans.Product = entity.Product;*/

            await context.SaveChangesAsync();
        }

        public Task UpdateAsync(int id, Transaction entity) {
            throw new NotImplementedException();
        }
    }
}
