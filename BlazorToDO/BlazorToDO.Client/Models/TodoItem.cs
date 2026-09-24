namespace BlazorToDO.Client.Models
{
    public class TodoItem
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public required string Text { get; set; }
        public DateTime Created { get; set; } = DateTime.Now;
        public bool Completed { get; set; }
    }
}
