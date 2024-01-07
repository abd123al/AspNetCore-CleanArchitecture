using System.ComponentModel.DataAnnotations;

namespace CleanArchitecture.Web.Features.Todos.CreateTodo;

public class CreateTodoRequest
{
    [Required]
    public string? Title { get; set; }

    [Required]
    public string? OwnerId { get; set; }
}
