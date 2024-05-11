namespace Melody.BusinessLayer.Mappings
{
    public interface ICreatorService
    {
        Task<Guid> GetCreatorIdByUid(string uid, CancellationToken cancellationToken = default);
    }
}
