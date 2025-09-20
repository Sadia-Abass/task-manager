using EasyManagerApp.API.Domain.Interfaces;
using EasyManagerApp.API.Infrastructure.Context;

namespace EasyManagerApp.API.Infrastructure.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _appDbContext;

        public IGroupRepository GroupRepository { get; }

        public UnitOfWork(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
            GroupRepository = new GroupRepository(_appDbContext);
        }

     

        public void Dispose()
        {
            _appDbContext.Dispose();
        }

        public Task<int> SaveChangesAsync()
        {
           return _appDbContext.SaveChangesAsync();
        }
    }
}
