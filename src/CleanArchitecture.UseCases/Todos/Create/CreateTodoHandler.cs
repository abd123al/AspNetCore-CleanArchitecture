using CleanArchitecture.Core.Abstractions.Messaging;
using CleanArchitecture.Core.TodoAggregate;
using CleanArchitecture.Infrastructure.Data.Repository;

namespace CleanArchitecture.UseCases.Todos.Create;

public class CreateTodoHandler(ITodoRepository _repository)
    : BaseHandler, ICommandHandler<CreateTodoCommand, int>
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
