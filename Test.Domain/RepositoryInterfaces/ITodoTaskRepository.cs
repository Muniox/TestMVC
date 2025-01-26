using Test.Domain.Entities;

namespace Test.Domain.RepositoryInterfaces
{
    public interface ITodoTaskRepository
    {
        Task CreateTodoTask(TodoTask todoTask);

        Task<TodoTask> GetOneTodoTask(string Id);

        Task<IEnumerable<TodoTask>> GetAllTodoTasks();
    }
}
