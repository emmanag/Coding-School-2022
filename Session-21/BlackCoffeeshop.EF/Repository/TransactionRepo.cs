using BlackCoffeeshop.EF.Context;
using BlackCoffeeshop.EF.Repository;
using BlackCoffeeshop.Model;
using Microsoft.EntityFrameworkCore;

namespace BlackCoffeeshop.EF.Configuration {
    public class TransactionRepo : IEntityRepo<Transaction> {
        private readonly ApplicationContext context;
        public TransactionRepo(ApplicationContext dbContext)
        {
            context = dbContext;
        }
        public async Task Create(Model.Transaction entity) {

            context.Transactions.Add(entity);
            await context.SaveChangesAsync();
        }

        public async Task CreateAsync(Transaction entity) {
            if (entity.ID != 0)
                throw new ArgumentException("Given entity should not have Id set", nameof(entity));

            context.Transactions.Add(entity);

            await context.SaveChangesAsync();
        }

        public async Task Delete(int id) {
            var foundTrans = context.Transactions.SingleOrDefault(trans => trans.ID == id);
            if (foundTrans is null)
                return;

            context.Transactions.Remove(foundTrans);
            await context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id) {
            var dbtrans = context.Transactions.SingleOrDefault(t => t.ID == id);
            if (dbtrans is null)
                throw new KeyNotFoundException($"Given id '{id}' was not found in database");

            context.Transactions.Remove(dbtrans);

            await context.SaveChangesAsync();
        }

        public List<Model.Transaction> GetAll() {

            return context.Transactions.ToList();
        }

        public async Task<IEnumerable<Transaction>> GetAllAsync() {
            return await context.Transactions.ToListAsync();
        }

        public Model.Transaction? GetById(int id) {

            return context.Transactions.Where(trans => trans.ID == id).SingleOrDefault(); ;
        }

        public async Task<Transaction?> GetByIdAsync(int id) {
            return await context.Transactions.SingleOrDefaultAsync(t => t.ID == id);

        }

        public async Task Update(int id, Transaction entity) {
          
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

        public async Task UpdateAsync(int id, Transaction entity) {
            var foundTrans = context.Transactions.SingleOrDefault(trans => trans.ID == id);
            if (foundTrans is null)
                throw new KeyNotFoundException($"Given id '{id}' was not found in database");


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


            await context.SaveChangesAsync();

        }

        Task<Transaction?> IEntityRepo<Transaction>.GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
