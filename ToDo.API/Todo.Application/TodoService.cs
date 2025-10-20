using Todo.Domain;
using Todo.Domain.Abstractions;
using Todo.DTOs;

namespace Todo.Application
{
    public class TodoService
    {
        private readonly IUnitOfWork _uow;
        private readonly ITodoRepository _todoRepository;

        public TodoService(IUnitOfWork uow, ITodoRepository todoRepository)
        {
            _uow = uow;
            _todoRepository = todoRepository;
        }

        public async Task<IEnumerable<TodoReadDto>> GetTodos()
        {
            var todos = await _todoRepository.GetAll();

            return todos.Select(x => new TodoReadDto(x.Id, x.Title, x.IsCompleted));
        }

        public async Task<TodoReadDto> CreateToto(string title)
        {
            var todoItem = TodoItem.Create(title);
            _todoRepository.Add(todoItem);
            await _uow.SaveChangesAsync();

            return new TodoReadDto(todoItem.Id, todoItem.Title, false);
        }
    }
}
