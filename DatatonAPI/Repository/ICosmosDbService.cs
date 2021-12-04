using DatatonAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DatatonAPI.Repository
{
    public interface ICosmosDbService
    {
        Task<IEnumerable<Declaracion>> GetMultipleAsync(string query);
        Task<Declaracion> GetAsync(string id);
        Task UpdateAsync(string id, Declaracion item);
        Task DeleteAsync(string id);
    }
}
