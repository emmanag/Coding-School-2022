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
    public class CarRepository : IEntityRepo<Car>
    {
        public async Task Create(Car entity)
        {
            using var context = new Session_14Context();
            context.Cars.Add(entity);
            await context.SaveChangesAsync();
        }

        public async Task Delete(Guid id)
        {
            using var context = new Session_14Context();
            var foundCar = context.Cars.SingleOrDefault(car => car.ID == id);
            if (foundCar is null)
                return;

            context.Cars.Remove(foundCar);
            await context.SaveChangesAsync();
        }

        public List<Car> GetAll()
        {
            using var context = new Session_14Context();
            return context.Cars.ToList();
        }

        public Car? GetById(Guid id)
        {
            using var context = new Session_14Context();
            return context.Cars.Where(car => car.ID == id).SingleOrDefault();
        }



        public async Task Update(Guid id, Car entity)
        {
            using var context = new Session_14Context();
            var foundCar = context.Cars.SingleOrDefault(car => car.ID == id);
            if (foundCar is null)
                return;

            foundCar.Brand = entity.Brand;
            foundCar.Model = entity.Model;
            foundCar.CarRegNumber = entity.CarRegNumber;
            
            await context.SaveChangesAsync();
        }


    }
}
