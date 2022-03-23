using Session_14.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace TodoApp.EF.Repositories
{
    public interface IEntityRepo<TEntity>
        where TEntity : Item
    {
        List<TEntity> GetAll();
        TEntity GetById(Guid id);
        Task Create(TEntity entity);
        Task Update(Guid id, TEntity entity);
        Task Delete(Guid id);
    }
}

