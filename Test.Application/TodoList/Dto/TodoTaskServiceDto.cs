namespace Test.Application.TodoList.Dto
{
    public class TodoTaskServiceDto
    {
        public Guid Id { get; set; }
        public string Title { get; set; } = default!;
        public string Description { get; set; } = default!;
    }
}
