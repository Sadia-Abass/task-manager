using EasyManagerApp.API.Domain.Interfaces;
using EasyManagerApp.API.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace EasyManagerApp.API.Infrastructure.Repository
{
    public class Repository<TModel> : IRepository<TModel> where TModel : class
    {
        protected readonly AppDbContext _appDbCOntext;

        public Repository(AppDbContext appDbCOntext)
        {
            _appDbCOntext = appDbCOntext;
        }

        public Task<List<TModel>> Get()
        {
            return _appDbCOntext.Set<TModel>().ToListAsync();
        }

        public Task<TModel> Get(int id)
        {
            return _appDbCOntext.Set<TModel>().FindAsync(id).AsTask();
        }

        public void Create(TModel model)
        {
            _appDbCOntext.Set<TModel>().Add(model);
        }

        public void Update(TModel model)
        {
            _appDbCOntext.Set<TModel>().Update(model);
        }

        public void Delete(TModel model)
        {
            _appDbCOntext.Set<TModel>().Remove(model);
        }

        public void CreateRange(List<TModel> models)
        {

            _appDbCOntext.Set<TModel>().AddRange(models);
        }

        public void UpdateRange(List<TModel> models)
        {
            _appDbCOntext.Set<TModel>().UpdateRange(models);
        }

        public void DeleteRange(List<TModel> models)
        {
            _appDbCOntext.Set<TModel>().RemoveRange(models);
        }

    }
}
