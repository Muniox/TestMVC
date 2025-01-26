namespace Test.Domain.Entities
{
    public class TodoTask
    {
        public Guid Id { get; set; }
        public string Title { get; set; } = default!;
        public string Description { get; set; } = default!;
        public DateTime Created { get; set; } = DateTime.Now;
        public DateTime Updated { get; set; }

    }
}
