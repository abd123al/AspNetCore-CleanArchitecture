using CleanArchitecture.Core.TodoAggregate;
using CleanArchitecture.Infrastructure.Data.Repository;

using MediatR;

namespace CleanArchitecture.UseCases.Todos.Create;

public class CreateTodoHandler(ITodoRepository _repository)
    : IRequestHandler<CreateTodoCommand, int>
{
    public async Task<int> Handle(CreateTodoCommand request, CancellationToken cancellationToken)
    {
        var newTodo = new Todo(request.Title);
        newTodo.SetIsCompleted(false);
        if (!string.IsNullOrEmpty(request.OwnerId))
        {
            newTodo.SetOwnerId(request.OwnerId);
        }

        _repository.Add(newTodo);
        var affectedRows = await _repository.SaveChangeAsync(cancellationToken);

        return newTodo.Id;
    }
}
