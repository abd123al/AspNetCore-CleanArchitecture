using MediatR;

namespace CleanArchitecture.Core.Abstractions.Messaging;

public interface IQuery<out TResponse> : IRequest<TResponse>
{
}
