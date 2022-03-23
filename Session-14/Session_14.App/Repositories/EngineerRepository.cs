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
    public class EngineerRepository : IEntityRepo<Engineer>
    {
        public async Task Create(Engineer entity)
        {
            using var context = new Session_14Context();
            context.Engineers.Add(entity);
            await context.SaveChangesAsync();
        }

        public async Task Delete(Guid id)
        {
            using var context = new Session_14Context();
            var foundEngineer = context.Engineers.SingleOrDefault(customer => customer.ID == id);
            if (foundEngineer is null)
                return;

            context.Engineers.Remove(foundEngineer);
            await context.SaveChangesAsync();
        }

        public List<Engineer> GetAll()
        {
            using var context = new Session_14Context();
            return context.Engineers.ToList();
        }

        public Engineer? GetById(Guid id)
        {
            using var context = new Session_14Context();
            return context.Engineers.Where(customer => customer.ID == id).SingleOrDefault();
        }



        public async Task Update(Guid id, Engineer entity)
        {
            using var context = new Session_14Context();
            var foundEngineer = context.Engineers.SingleOrDefault(customer => customer.ID == id);
            if (foundEngineer is null)
                return;

            foundEngineer.ManagerID = entity.ManagerID;
            foundEngineer.SallaryPerMonth = entity.SallaryPerMonth;
            foundEngineer.Status = entity.Status;
            await context.SaveChangesAsync();
        }


    }
}

