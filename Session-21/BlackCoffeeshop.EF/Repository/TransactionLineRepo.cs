﻿using BlackCoffeeshop.EF.Context;
using BlackCoffeeshop.EF.Repository;
using BlackCoffeeshop.Model;
using Microsoft.EntityFrameworkCore;

namespace BlackCoffeeshop.EF.Configuration {
    public class TransactionLineRepo : IEntityRepo<TransactionLine> {
        private readonly ApplicationContext context;
        public TransactionLineRepo(ApplicationContext dbCOntext) {
            context = dbCOntext;
        }
        public async Task Create(TransactionLine entity) {
            using var context = new ApplicationContext();
            context.TransactionLines.Add(entity);
            await context.SaveChangesAsync();
        }



        public async Task Delete(int id) {
            using var context = new ApplicationContext();
            var foundTransLine = context.TransactionLines.SingleOrDefault(transLine => transLine.ID == id);
            if (foundTransLine is null)
                return;

            context.TransactionLines.Remove(foundTransLine);
            await context.SaveChangesAsync();
        }


        public List<TransactionLine> GetAll() {
            using var context = new ApplicationContext();
            return context.TransactionLines.ToList();
        }



        public TransactionLine? GetById(int id) {
            using var context = new ApplicationContext();
            return context.TransactionLines.Where(transline => transline.ID == id).SingleOrDefault(); ;
        }



        public async Task Update(int id, TransactionLine entity) {
            using var context = new ApplicationContext();
            var foundTransLine = context.TransactionLines.SingleOrDefault(transLine => transLine.ID == id);
            if (foundTransLine is null)
                return;

            foundTransLine.ProductID = entity.ProductID;
            foundTransLine.TransactionID = entity.TransactionID;
            foundTransLine.Quantity = entity.Quantity;
            foundTransLine.Price = entity.Price;
            foundTransLine.Discount = entity.Discount;
            foundTransLine.TotalPrice = entity.TotalPrice;

            await context.SaveChangesAsync();
        }

        public Task UpdateAsync(int id, TransactionLine entity) {
            throw new NotImplementedException();
        }
        public Task<ProductCategory?> GetByIdAsync(int id) {
            throw new NotImplementedException();
        }
        public Task CreateAsync(TransactionLine entity) {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id) {
            throw new NotImplementedException();
        }
        public async Task<IEnumerable<TransactionLine>> GetAllAsync() {
            return await context.TransactionLines.ToListAsync();
        }

        Task<TransactionLine?> IEntityRepo<TransactionLine>.GetByIdAsync(int id) {
            throw new NotImplementedException();
        }
    }
}
