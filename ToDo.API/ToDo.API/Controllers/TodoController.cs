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
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IEnumerable<TodoReadDto>> GetTodos()
        {
            return await _todoService.GetTodos();
        }

        [HttpGet("id")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<TodoReadDto> GetTodo([FromRoute] Guid id)
        {
            return null;
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public async Task<ActionResult<TodoReadDto>> CreateTodo([FromBody] TodoWriteDto writeDto)
        {
            var todo = await _todoService.CreateToto(writeDto.title);
            return CreatedAtAction(nameof(GetTodo), todo);
        }
    }
}
