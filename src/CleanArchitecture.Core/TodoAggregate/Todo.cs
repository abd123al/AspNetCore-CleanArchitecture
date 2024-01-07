using CleanArchitecture.Core.Common;

namespace CleanArchitecture.Core.TodoAggregate;

public class Todo(string title) : BaseAuditableEntity
{
    public string Title { get; private set; } = title;

    public bool IsCompleted { get; private set; }

    public string OwnerId { get; private set; } = string.Empty;

    public void SetIsCompleted(bool isCompleted)
    {
        IsCompleted = isCompleted;
    }

    public void SetOwnerId(string ownerId)
    {
        OwnerId = ownerId;
    }

    public void UpdateTitle(string newTitle)
    {
        Title = newTitle;
    }
}
