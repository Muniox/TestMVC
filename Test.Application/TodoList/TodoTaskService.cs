using Test.Application.TodoList.Dto;
using Test.Domain.Entities;
using Test.Domain.RepositoryInterfaces;

namespace Test.Application.TodoList
{
    public class TodoTaskService : ITodoTaskService
    {
        public readonly ITodoTaskRepository _todoTaskRepository;

        public TodoTaskService(ITodoTaskRepository todoTaskRepository)
        {
            _todoTaskRepository = todoTaskRepository;
        }

        public async Task CreateTodoTask(CreateTodoTaskServiceDto dto)
        {
            var todoTask = new TodoTask()
            {
                Title = dto.Title,
                Description = dto.Description,
            };

            await _todoTaskRepository.CreateTodoTask(todoTask);
        }

        public async Task<IEnumerable<TodoTaskServiceDto>> GetAllTodoTasks()
        {
            var todoTasks = await _todoTaskRepository.GetAllTodoTasks();

            //List<TodoTaskServiceDto> todoTasksDtoList = new List<TodoTaskServiceDto>();

            //foreach (var todoTask in todoTasks)
            //{
            //    var todoTaskServiceDto = new TodoTaskServiceDto
            //    {
            //        Id = todoTask.Id,
            //        Description = todoTask.Description,
            //        Title = todoTask.Title,
            //    };

            //    todoTasksDtoList.Add(todoTaskServiceDto);
            //}

            var todoTasksDtoList = todoTasks.Select(t => new TodoTaskServiceDto()
            {
                Id = t.Id,
                Description = t.Description,
                Title = t.Title
            });

            return todoTasksDtoList;
        }
    }
}
