namespace CleanArchitecture.Web.Features.Todos.CreateTodo;

public class CreateTodoResponse(int id, string title, bool isCompleted, string ownerId)
{
    public int Id { get; set; } = id;

    public string Title { get; set; } = title;

    public bool IsCompleted { get; set; } = isCompleted;

    public string OwnerId { get; set; } = ownerId;
}
