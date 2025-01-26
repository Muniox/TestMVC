using Microsoft.EntityFrameworkCore;
using Test.Domain.Entities;
using Test.Domain.RepositoryInterfaces;
using Test.Infrastructure.Persistence;

namespace Test.Infrastructure.Repositories
{
    public class TodoTaskRepository : ITodoTaskRepository
    {
        private readonly TestDbContext _dbContext;

        public TodoTaskRepository(TestDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task CreateTodoTask(TodoTask todoTask)
        {
            _dbContext.TodoTasks.Add(todoTask);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<TodoTask>> GetAllTodoTasks()
        {
            var TodoTasks = await _dbContext.TodoTasks.ToListAsync();

            return TodoTasks;
        }

        public Task<TodoTask> GetOneTodoTask(string Id)
        {
            throw new NotImplementedException();
        }
    }
}
