using TodoApi.Models;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace TodoApi.Services
{
    public class TodoService
    {
        private readonly IMongoCollection<TodoItem> _todoCollection;

        public TodoService(IOptions<PlannerDatabaseSettings> plannerDatabaseSettings)
        {
            var mongoClient = new MongoClient(
                plannerDatabaseSettings.Value.ConnectionString);

            var mongoDatabase = mongoClient.GetDatabase(
                plannerDatabaseSettings.Value.DatabaseName);

            _todoCollection = mongoDatabase.GetCollection<TodoItem>(
                plannerDatabaseSettings.Value.TodoCollectionName);
        }

        public async Task<List<TodoItem>> GetAsync() =>
            await _todoCollection.Find(_ => true).ToListAsync();

        public async Task<TodoItem?> GetAsync(string id) =>
            await _todoCollection.Find(x => x.Id == id).FirstOrDefaultAsync();

        public async Task CreateAsync(TodoItem newTodo) =>
            await _todoCollection.InsertOneAsync(newTodo);

        public async Task UpdateAsync(string id, TodoItem updatedBook) =>
            await _todoCollection.ReplaceOneAsync(x => x.Id == id, updatedBook);

        public async Task RemoveAsync(string id) =>
            await _todoCollection.DeleteOneAsync(x => x.Id == id);
    }
}
