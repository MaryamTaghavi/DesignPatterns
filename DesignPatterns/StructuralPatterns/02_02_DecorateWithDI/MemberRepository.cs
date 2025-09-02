namespace _02_02_DecorateWithDI;

public sealed class MemberRepository : IMemberRepository
{
    private readonly ApplicationDbContext _dbContext;

    public MemberRepository(ApplicationDbContext dbContext) => _dbContext = dbContext;

    public async Task<Member?> GetByIdAsync(Guid id , CancellationToken cancellationToken)
    {
        return await _dbContext.Set<Member>()
                .FirstOrDefualtAsync(member => member.Id == id , cancellationToken);
    }
}
