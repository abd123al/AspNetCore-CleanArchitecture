using FluentValidation;

namespace CleanArchitecture.Web.Features.Todos.CreateTodo;

public class CreateTodoValidator : AbstractValidator<CreateTodoRequest>
{
    public CreateTodoValidator()
    {
        RuleFor(x => x.Title)
          .NotEmpty()
          .WithMessage("Title is required.")
          .MinimumLength(2);

        RuleFor(x => x.OwnerId)
          .NotEmpty()
          .WithMessage("OwnerId is required.");
    }
}
