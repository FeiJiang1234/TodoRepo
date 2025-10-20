namespace Todo.DTOs
{
    public record TodoReadDto(Guid id, string Title, bool isCompleted);
}
