namespace EasyManagerApp.API.Domain.Interfaces
{
    public interface IRepository<TModel> where TModel : class
    {
        Task<IEnumerable<TModel>> Get();
        Task<TModel> Get(int id);
        void Create(TModel model);
        void Update(TModel model);
        void Delete(int id);
        void CreateRange(IEnumerable<TModel> models);
        void UpdateRange(IEnumerable<TModel> models);
        void DeleteRange(IEnumerable<TModel> models);
    }
}
