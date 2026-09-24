namespace BlazorToDO.Client.Models
{
    public class TodoItems
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public required string Text { get; set; }
        public DateTime Created { get; set; } = DateTime.UtcNow;
        public bool Completed { get; set; }
    }
}
