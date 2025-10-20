namespace Todo.Domain
{
    public class TodoItem
    {
        public static TodoItem Create(string title)
        {
            return new TodoItem { Title = title };
        }

        public Guid Id { get; set; }

        public string Title { get; set; }

        public bool IsCompleted {  get; set; }
    }
}
