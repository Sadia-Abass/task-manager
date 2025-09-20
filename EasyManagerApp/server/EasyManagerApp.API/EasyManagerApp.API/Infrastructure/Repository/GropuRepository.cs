using EasyManagerApp.API.Domain.Interfaces;
using EasyManagerApp.API.Domain.Models;
using EasyManagerApp.API.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace EasyManagerApp.API.Infrastructure.Repository
{
    public class GropuRepository : Repository<Group>, IGroupRepository
    {

        public GropuRepository(AppDbContext appDbContext) : base(appDbContext)
        {
            
        }


        public Task<Group> GetDuplicate(Group groupModel)
        {
          return _appDbCOntext.Groups.FirstOrDefaultAsync(x => x.GroupName.ToLower() == groupModel.GroupName.ToLower());
        }
    }
}
