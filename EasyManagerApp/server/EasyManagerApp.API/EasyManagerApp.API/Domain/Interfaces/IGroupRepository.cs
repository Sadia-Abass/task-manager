
using EasyManagerApp.API.Domain.Models;

namespace EasyManagerApp.API.Domain.Interfaces
{
    public interface IGroupRepository : IRepository<Group>
    {
        Task<Group> GetDuplicate(Group groupModel);
    }
}
