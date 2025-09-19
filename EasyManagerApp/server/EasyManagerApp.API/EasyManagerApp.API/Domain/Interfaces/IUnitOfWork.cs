namespace EasyManagerApp.API.Domain.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IGroupRepository GroupRepository { get; }
        Task<int> SaveChangesAsync();
    }
}
