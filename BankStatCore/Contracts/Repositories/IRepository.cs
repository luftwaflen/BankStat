namespace BankStatCore.Contracts.Repositories;

public interface IRepository<TModel>
{
    IEnumerable<TModel> GetAll();
    TModel GetById(string id);
    void Create(TModel model);
    void Update(TModel model);
    void Delete(TModel model);
    void DeleteById(string id);
}