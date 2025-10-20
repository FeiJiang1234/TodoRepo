using Todo.DTOs;

namespace Todo.Application
{
    public class TodoService
    {
        public async Task<IEnumerable<TodoReadDto>> GetTodos()
        {
            return await Task.FromResult(new List<TodoReadDto>
            {
                new TodoReadDto(Guid.NewGuid(), "read book", false)
            });
        }
    }
}
