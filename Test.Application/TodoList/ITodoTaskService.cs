using Test.Application.TodoList.Dto;

namespace Test.Application.TodoList
{
    public interface ITodoTaskService
    {
        Task<IEnumerable<TodoTaskServiceDto>> GetAllTodoTasks();

        Task CreateTodoTask(CreateTodoTaskServiceDto dto);
    }
}