using DatatonAPI.Models;
using Microsoft.Azure.Cosmos;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatatonAPI.Repository
{
    public class CosmosDbService : ICosmosDbService
    {
        private Container _container;

        public CosmosDbService(
            CosmosClient cosmosDbClient,
            string databaseName,
            string containerName)
        {
            _container = cosmosDbClient.GetContainer(databaseName, containerName);
        }

        public async Task DeleteAsync(string id)
        {
            await _container.DeleteItemAsync<Declaracion>(id, new PartitionKey(id));
        }

        public async Task<Declaracion> GetAsync(string id)
        {
            try
            {
                var response = await _container.ReadItemAsync<Declaracion>(id, new PartitionKey(id));
                return response.Resource;
            }
            catch (CosmosException) //For handling item not found and other exceptions
            {
                return null;
            }
        }

        public async Task<IEnumerable<Declaracion>> GetMultipleAsync(string queryString)
        {
            var query = _container.GetItemQueryIterator<Declaracion>(new QueryDefinition(queryString));

            var results = new List<Declaracion>();
            while (query.HasMoreResults)
            {
                var response = await query.ReadNextAsync();
                results.AddRange(response.ToList());
            }

            return results;
        }

        public async Task UpdateAsync(string id, Declaracion item)
        {
            await _container.UpsertItemAsync(item, new PartitionKey(id));
        }

        Task<Declaracion> ICosmosDbService.GetAsync(string id)
        {
            throw new System.NotImplementedException();
        }
    }
}
