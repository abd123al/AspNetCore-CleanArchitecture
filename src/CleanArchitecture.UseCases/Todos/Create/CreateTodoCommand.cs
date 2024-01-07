using MediatR;

namespace CleanArchitecture.UseCases.Todos.Create;

public record CreateTodoCommand(string Title, bool IsCompleted, string OwnerId)
    : IRequest<int>;
