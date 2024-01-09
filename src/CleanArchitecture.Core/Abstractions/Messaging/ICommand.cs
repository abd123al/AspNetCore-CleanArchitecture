using MediatR;

namespace CleanArchitecture.Core.Abstractions.Messaging;

public interface ICommand<out TResponse> : IRequest<TResponse>
{
}
