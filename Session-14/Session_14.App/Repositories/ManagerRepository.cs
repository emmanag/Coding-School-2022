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
    public class ManagerRepository : IEntityRepo<Manager>
    {
        public async Task Create(Manager entity)
        {
            using var context = new Session_14Context();
            context.Managers.Add(entity);
            await context.SaveChangesAsync();
        }

        public async Task Delete(Guid id)
        {
            using var context = new Session_14Context();
            var foundManager = context.Managers.SingleOrDefault(manager => manager.ID == id);
            if (foundManager is null)
                return;

            context.Managers.Remove(foundManager);
            await context.SaveChangesAsync();
        }

        public List<Manager> GetAll()
        {
            using var context = new Session_14Context();
            return context.Managers.ToList();
        }

        public Manager? GetById(Guid id)
        {
            using var context = new Session_14Context();
            return context.Managers.Where(manager => manager.ID == id).SingleOrDefault();
        }



        public async Task Update(Guid id, Manager entity)
        {
            using var context = new Session_14Context();
            var foundManager = context.Managers.SingleOrDefault(manager => manager.ID == id);
            if (foundManager is null)
                return;

            foundManager.SallaryPerMonth = entity.SallaryPerMonth;
            
            await context.SaveChangesAsync();
        }


    }
}
