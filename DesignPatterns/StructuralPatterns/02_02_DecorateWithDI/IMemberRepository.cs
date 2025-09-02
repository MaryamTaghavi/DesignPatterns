namespace _02_02_DecorateWithDI;

public interface IMemberRepository
{
    Task<Member?> GetByIdAsync(Guid guid, CancellationToken cancellationToken);
}
