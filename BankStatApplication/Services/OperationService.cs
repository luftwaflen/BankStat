using BankStatCore.Contracts.Repositories;
using BankStatCore.Contracts.Services;
using BankStatCore.Models;

namespace BankStatApplication.Services;

public class OperationService : IOperationService
{
    private readonly IOperationRepository _operationRepository;

    public OperationService(IOperationRepository operationRepository)
    {
        _operationRepository = operationRepository;
    }

    public IEnumerable<OperationModel> GetAll()
    {
        var operations = _operationRepository.GetAll();
        return operations;
    }

    public OperationModel GetById(string id)
    {
        var operation = _operationRepository.GetById(id);
        return operation;
    }

    public void Create(OperationModel model)
    {
        _operationRepository.Create(model);
    }

    public void Update(OperationModel model)
    {
        _operationRepository.Update(model);
    }

    public void Delete(OperationModel model)
    {
        _operationRepository.Delete(model);
    }

    public void DeleteById(string id)
    {
        _operationRepository.DeleteById(id);
    }
}