using System;
using System.Threading.Tasks;

namespace DatatonWASM.Repositories
{
    public interface IRepository
    {
        Task<HttpResponseWrapper<T>> Get<T>(string url);
    }
}
