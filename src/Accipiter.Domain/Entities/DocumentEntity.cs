namespace Accipiter.Domain.Entities;

public sealed class DocumentEntity
{
    public Guid Id { get; private set; }

    public DocumentEntity(Guid id)
    {
        this.Id = id;
    }
}
