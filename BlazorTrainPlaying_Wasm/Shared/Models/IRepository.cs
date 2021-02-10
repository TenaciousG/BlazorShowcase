using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorTrainPlaying_Wasm.Shared.Models
{
    /// <summary>
    /// Not complete yet, check if Carl F has an updated version
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    public interface IRepository<TEntity> where TEntity : class
    {
        Task<bool> Delete(TEntity entityToDelete);
        Task<bool> Delete(object id);
        Task<IEnumerable<TEntity>> GetAll();
        Task<TEntity> GetByID(object id);
        Task<TEntity> Insert(TEntity entity);
        Task<TEntity> Update(TEntity entityToUpdate);
    }
}