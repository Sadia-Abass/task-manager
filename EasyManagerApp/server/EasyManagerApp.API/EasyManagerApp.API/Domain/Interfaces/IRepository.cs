namespace EasyManagerApp.API.Domain.Interfaces
{
    public interface IRepository<TModel> where TModel : class
    {
        Task<IEnumerable<TModel>> Get();
        Task<TModel> Get(int id);
        Task Create(TModel model);
        Task Update(TModel model);
        Task Delete(int id);
        Task CreateRange(IEnumerable<TModel> models);
        Task UpdateRange(IEnumerable<TModel> models);
        Task DeleteRange(IEnumerable<TModel> models);
    }
}
