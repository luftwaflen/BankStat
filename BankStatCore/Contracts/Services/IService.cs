namespace BankStatCore.Contracts.Services;

public interface IService<T>
{
    public IEnumerable<T> GetAll();
    public T GetById(string id);
    public void Create(T model);
    public void Update(T model);
    public void Delete(T model);
    public void DeleteById(string id);
}