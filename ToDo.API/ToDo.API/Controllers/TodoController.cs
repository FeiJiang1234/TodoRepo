using Microsoft.AspNetCore.Mvc;
using Todo.Application;
using Todo.DTOs;

namespace ToDo.API.Controllers
{
    [ApiController]
    [Route("api/[controller]s")]
    public class TodoController : ControllerBase
    {
        private readonly TodoService _todoService;

        public TodoController(TodoService todoService)
        {
            _todoService = todoService;
        }

        [HttpGet]
        public async Task<IEnumerable<TodoReadDto>> GetTodos()
        {
            return await _todoService.GetTodos();
        }
    }
}
