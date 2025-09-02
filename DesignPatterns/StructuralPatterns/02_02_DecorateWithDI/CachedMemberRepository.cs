using Microsoft.Extensions.Caching.Memory;

namespace _02_02_DecorateWithDI;

public class CachedMemberRepository : IMemberRepository
{
    private readonly MemberRepository _decorated;
    private readonly IMemoryCache _memoryCache;

    public CachedMemberRepository(MemberRepository decorated , IMemoryCache memoryCache)
    {
        _decorated = decorated;
        _memoryCache = memoryCache;
    }

    public async Task<Member?> GetByIdAsync(Guid id, CancellationToken cancellationToken)
    {
        string key = $"member-{id}";
        return await _memoryCache.GetOrCreateAsync(key, entry =>
        {
            entry.SetAbsoluteExpiration(TimeSpan.FromMinutes(2));
            return _decorated.GetByIdAsync(id , cancellationToken);
        });
    }
}
