using CleanArchitecture.Core.Abstractions.Messaging;

namespace CleanArchitecture.UseCases.Todos.Create;

public record CreateTodoCommand(string Title, bool IsCompleted, string OwnerId)
    : ICommand<int>;
