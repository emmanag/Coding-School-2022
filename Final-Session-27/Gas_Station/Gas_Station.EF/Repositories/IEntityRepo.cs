using Gas_Station.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gas_Station.EF.Repositories
{
    public interface IEntityRepo<TEntity>
        where TEntity : BaseEntity
    {
        //List<TEntity> GetAll();

        //TEntity? GetById(Guid id);
        //Task Create(TEntity entity);
        //Task Update(Guid id, TEntity entity);
        //Task Delete(Guid id);


        Task<IEnumerable<TEntity>> GetAllAsync();
        Task<TEntity?> GetByIdAsync(Guid id);
        Task CreateAsync(TEntity entity);
        Task UpdateAsync(Guid id, TEntity entity);
        Task DeleteAsync(Guid id);
    }
}
